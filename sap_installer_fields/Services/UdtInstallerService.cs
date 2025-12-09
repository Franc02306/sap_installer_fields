using sap_installer_fields.Models;
using sap_installer_fields.Models.Requests;
using SAPbobsCOM;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace sap_installer_fields.Services
{
    public class UdtInstallerService
    {
        private readonly Company _company;

        public UdtInstallerService(Company company)
        {
            _company = company;
        }

        /// <summary>
        /// Crear tablas de usuario (TabPanel: UDT)
        /// </summary>
        public string CreateUdt(UdtRequest req)
        {
            UserTablesMD table = null;
            Recordset rs = null;

            try
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();

                // 1. Validar si la tabla existe
                rs = (Recordset)_company.GetBusinessObject(BoObjectTypes.BoRecordset);

                string query = _company.DbServerType == BoDataServerTypes.dst_HANADB
                    ? $@"SELECT ""TableName"" FROM ""OUTB"" WHERE ""TableName"" = '{req.TableName}'"
                    : $@"SELECT TableName FROM OUTB WHERE TableName = '{req.TableName}'";

                rs.DoQuery(query);

                if (rs.RecordCount > 0)
                {
                    Marshal.ReleaseComObject(rs);
                    rs = null;
                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    return $"[SKIP] El UDT {req.TableName} ya existe.";
                }

                // 2. Crear UDT
                table = (UserTablesMD)_company.GetBusinessObject(BoObjectTypes.oUserTables);

                table.TableName = req.TableName;
                table.TableDescription = req.TableDescription;

                // 3. Mapear tipo
                switch (req.TableType.ToLower())
                {
                    case "noobject":
                        table.TableType = BoUTBTableType.bott_NoObject;
                        break;

                    case "masterdata":
                        table.TableType = BoUTBTableType.bott_MasterData;
                        break;

                    case "masterdatalines":
                        table.TableType = BoUTBTableType.bott_MasterDataLines;
                        break;

                    case "document":
                        table.TableType = BoUTBTableType.bott_Document;
                        break;

                    case "documentlines":
                        table.TableType = BoUTBTableType.bott_DocumentLines;
                        break;

                    default:
                        return $"[ERROR] Tipo de tabla inválido: {req.TableType}";
                }

                Marshal.ReleaseComObject(rs);
                rs = null;

                GC.Collect();
                GC.WaitForPendingFinalizers();

                // 4. Ejecutar creación
                int response = table.Add();

                if (response != 0)
                {
                    _company.GetLastError(out int code, out string errorMsg);
                    return $"[ERROR] {req.TableName}: {errorMsg}";
                }

                return $"[OK] UDT {req.TableName} creado correctamente.";
            }
            catch (Exception ex)
            {
                return $"[EXCEPTION] {req.TableName}: {ex.Message}";
            }
            finally
            {
                if (table != null)
                {
                    Marshal.ReleaseComObject(table);
                    table = null;
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
