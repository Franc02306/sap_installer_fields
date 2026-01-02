using sap_installer_fields.Models.Requests;
using SAPbobsCOM;
using System;
using System.Data.Odbc;
using System.IO;
using System.Runtime.InteropServices;

namespace sap_installer_fields.Services
{
    public class SpInstallerService
    {
        private readonly Company _company;

        public SpInstallerService(Company company)
        {
            _company = company;
        }

        /// <summary>
        /// Ejecuta scripts SQL / HANA usando ODBC
        /// </summary>
        public string ExecuteScript(SpScriptRequest req)
        {
            try
            {
                string connStr = BuildConnectionString();
                string sql = req.ScriptContent.Trim();

                if (string.IsNullOrWhiteSpace(sql))
                    return $"[SKIP] {Path.GetFileName(req.FilePath)} vacío.";

                using (var conn = new OdbcConnection(connStr))
                {
                    conn.Open();

                    using (var cmd = new OdbcCommand(sql, conn))
                    {
                        cmd.CommandTimeout = 0;

                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception exStmt)
                        {
                            return $"[ERROR] {Path.GetFileName(req.FilePath)}: {exStmt.Message}";
                        }
                    }
                }

                return $"[OK] Ejecutado: {Path.GetFileName(req.FilePath)}";
            }
            catch (Exception ex)
            {
                return $"[ERROR] {Path.GetFileName(req.FilePath)}: {ex.Message}";
            }
        }

        /// <summary>
        /// Construye la cadena de conexión ODBC según el motor (SQL o HANA)
        /// </summary>
        private string BuildConnectionString()
        {
            return "Driver={HDBODBC};ServerNode=imphdb:30015;UID=SYSTEM;PWD=3X2FtBKU7j7eC;CURRENTSCHEMA=IQMEDIC_20200116;";
            //string server = _company.Server;
            //string db = _company.CompanyDB;
            //string user = _company.UserName;
            //string pass = _company.Password;

            //// HANA
            //if (_company.DbServerType == BoDataServerTypes.dst_HANADB)
            //{
            //    return $"DRIVER=HDBODBC;ServerNode={server};UID={user};PWD={pass};";
            //}

            //// SQL SERVER
            //return $"Driver={{ODBC Driver 17 for SQL Server}};Server={server};Database={db};Uid={user};Pwd={pass};";
        }
    }
}
