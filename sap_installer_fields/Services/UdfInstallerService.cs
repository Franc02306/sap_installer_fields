using sap_installer_fields.Models.Requests;
using SAPbobsCOM;
using System;
using System.Runtime.InteropServices;

namespace sap_installer_fields.Services
{
    public class UdfInstallerService
    {
        private readonly Company _company;

        public UdfInstallerService(Company company)
        {
            _company = company;
        }

        /// <summary>
        /// Crear campos de usuario (TabPanel: UDF)
        /// </summary>
        public string CreateUdf(UdfRequest req)
        {
            Recordset rs = null;
            UserFieldsMD field = null;

            try
            {
                // 1. Validar si el campo ya existe o no
                GC.Collect();
                GC.WaitForPendingFinalizers();

                // 1. Validar si ya existe
                rs = (Recordset)_company.GetBusinessObject(BoObjectTypes.BoRecordset);
                string query = _company.DbServerType == BoDataServerTypes.dst_HANADB
                    ? $@"SELECT ""FieldID"" FROM ""CUFD"" WHERE ""TableID"" = '{req.TableName}' AND ""AliasID"" = '{req.FieldName}'"
                    : $@"SELECT FieldID FROM CUFD WHERE TableID = '{req.TableName}' AND AliasID = '{req.FieldName}'";

                rs.DoQuery(query);

                if (rs.RecordCount > 0)
                {
                    // liberar COM antes de retornar
                    Marshal.ReleaseComObject(rs);
                    rs = null;
                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    return $"[SKIP] El UDF {req.FieldName} ya existe en {req.TableName}.";
                }

                // 2. Crear nuevo UDF
                field = (UserFieldsMD)_company.GetBusinessObject(BoObjectTypes.oUserFields);

                field.TableName = req.TableName;
                field.Name = req.FieldName;
                field.Description = req.Description;

                // 3. Tipo
                switch (req.FieldType.ToLower())
                {
                    case "alpha":
                        field.Type = BoFieldTypes.db_Alpha;
                        field.Size = req.Size;
                        break;

                    case "numeric":
                        field.Type = BoFieldTypes.db_Numeric;
                        field.EditSize = req.Size;
                        break;

                    case "float":
                        field.Type = BoFieldTypes.db_Float;
                        field.SubType = BoFldSubTypes.st_Quantity;
                        break;

                    case "date":
                        field.Type = BoFieldTypes.db_Date;
                        break;

                    default:
                        return $"[ERROR] Tipo de campo inválido: {req.FieldType}";
                }

                // 4. Mandatorio o no
                field.Mandatory = req.Mandatory ? BoYesNoEnum.tYES : BoYesNoEnum.tNO;

                // 5. Default Value
                if (!string.IsNullOrWhiteSpace(req.DefaultValue))
                {
                    field.DefaultValue = req.DefaultValue;
                }

                // 6. Lista de valores válidos
                if (req.ValidValues != null)
                {
                    foreach (var item in req.ValidValues)
                    {
                        field.ValidValues.Value = item.Value;
                        field.ValidValues.Description = item.Description;
                        field.ValidValues.Add();
                    }
                }

                Marshal.ReleaseComObject(rs);
                rs = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();

                // 7. Ejecutar la creación
                int response = field.Add();

                if (response != 0)
                {
                    _company.GetLastError(out int code, out string errorMsg);
                    return $"[ERROR] {req.FieldName}: {errorMsg}";
                }

                return $"[OK] UDF {req.FieldName} creado en {req.TableName}.";
            }
            catch (System.Exception ex)
            {
                return $"[EXCEPTION] {req.FieldName}: {ex.Message}";
            }
            finally
            {
                if (field != null)
                {
                    Marshal.ReleaseComObject(field);
                    field = null;
                }
                if (rs != null)
                {
                    Marshal.ReleaseComObject(rs);
                    rs = null;
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
    }
}
