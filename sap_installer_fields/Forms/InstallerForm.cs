using Newtonsoft.Json;
using sap_installer_fields.Core;
using sap_installer_fields.Models.Requests;
using sap_installer_fields.Services;
using SAPbobsCOM;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace sap_installer_fields.Forms
{
    public partial class InstallerForm : Form
    {
        private readonly Company _company;
        private List<UdfRequest> _udfList = new List<UdfRequest>();
        private List<UdtRequest> _udtList = new List<UdtRequest>();
        private string _spFolderPath = string.Empty;

        public InstallerForm()
        {
            InitializeComponent();

            _company = SapSession.Company;

            if (_company == null || !_company.Connected)
            {
                MessageBox.Show("No existe una conexión activa con SAP.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        #region UDF - User Defined Field

        /// <summary>
        /// Botón para cargar los UDF en formato JSON
        /// </summary>
        private void btnLoadJson_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Filter = "JSON Files (*.json)|*.json",
                    Title = "Seleccionar archivo JSON de UDF"
                };

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                string json = File.ReadAllText(dialog.FileName);

                // Deserializar lista
                _udfList = JsonConvert.DeserializeObject<List<UdfRequest>>(json);

                if (_udfList == null || _udfList.Count == 0)
                {
                    MessageBox.Show("El archivo JSON no contiene UDF válidos.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Mostrar en el DataGridView
                dgvUdfList.DataSource = _udfList;

                WriteUdfLog($"[INFO] Archivo JSON cargado correctamente. UDF encontrados: {_udfList.Count}");
            }
            catch (Exception ex)
            {
                WriteUdfLog($"[ERROR] Error al cargar JSON: {ex.Message}");
            }
        }

        /// <summary>
        /// Botón para instalar los UDF
        /// </summary>
        private void btnInstallField_Click(object sender, EventArgs e)
        {
            try
            {
                if (_udfList == null || _udfList.Count == 0)
                {
                    MessageBox.Show("Primero cargue un archivo JSON.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear instancia del servicio
                var udfService = new UdfInstallerService(_company);

                WriteUdfLog("=== INICIO INSTALACIÓN UDF ===");

                foreach (var udf in _udfList)
                {
                    string result = udfService.CreateUdf(udf);
                    WriteUdfLog(result);
                }

                WriteUdfLog("=== FIN INSTALACIÓN UDF ===");
            }
            catch (Exception ex)
            {
                WriteUdfLog($"[ERROR] Instalación fallida: {ex.Message}");
            }
        }

        /// <summary>
        /// Mostrar el log en pantalla del resultado de la instalación de los UDF
        /// </summary>
        private void WriteUdfLog(string message)
        {
            txtLogUdf.AppendText(message + Environment.NewLine);
        }

        #endregion

        #region UDT - User Defined Table

        /// <summary>
        /// Botón para cargar los UDT en formato JSON
        /// </summary>
        private void btnLoadUdtJson_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog
                {
                    Filter = "JSON Files (*.json)|*.json",
                    Title = "Seleccionar archivo JSON de UDT"
                };

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                string json = File.ReadAllText(dialog.FileName);

                // Deserializar lista
                _udtList = JsonConvert.DeserializeObject<List<UdtRequest>>(json);

                if (_udtList == null || _udtList.Count == 0)
                {
                    MessageBox.Show("El archivo JSON no contiene UDT válidos.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Mostrar en el DataGridView
                dgvUdtList.DataSource = _udtList;

                WriteUdtLog($"[INFO] Archivo JSON cargado correctamente. UDT encontrados: {_udtList.Count}");
            }
            catch (Exception ex)
            {
                WriteUdtLog($"[ERROR] Error al cargar JSON: {ex.Message}");
            }
        }

        /// <summary>
        /// Botón para instalar los UDT
        /// </summary>
        private void btnInstallUdt_Click(object sender, EventArgs e)
        {
            try
            {
                if (_udtList == null || _udtList.Count == 0)
                {
                    MessageBox.Show("Primero cargue un archivo JSON.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var udtService = new UdtInstallerService(_company);

                WriteUdtLog("=== INICIO INSTALACIÓN UDT ===");

                foreach (var udt in _udtList)
                {
                    string result = udtService.CreateUdt(udt);
                    WriteUdtLog(result);
                }

                WriteUdtLog("=== FIN INSTALACIÓN UDT ===");
            }
            catch (Exception ex)
            {
                WriteUdtLog($"[ERROR] Instalación fallida: {ex.Message}");
            }
        }

        /// <summary>
        /// Mostrar el log en pantalla del resultado de la instalación de los UDT
        /// </summary>
        private void WriteUdtLog(string message)
        {
            txtLogUdt.AppendText(message + Environment.NewLine);
        }

        #endregion

        #region SP - Stored Procedures

        /// <summary>
        /// Botón para escoger la ruta de los scripts SQL / HANA
        /// </summary>
        private void btnChoosePathSp_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dialog = new FolderBrowserDialog())
                {
                    if (dialog.ShowDialog() != DialogResult.OK)
                        return;

                    _spFolderPath = dialog.SelectedPath;
                    txtSpFolderPath.Text = _spFolderPath;

                    WriteSpLog($"[INFO] Carpeta seleccionada: {_spFolderPath}");
                }
            }
            catch (Exception ex)
            {
                WriteSpLog($"[ERROR] No se pudo seleccionar carpeta: {ex.Message}");
            }
        }

        /// <summary>
        /// Botón para ejecutar los scripts SQL / HANA
        /// </summary>
        private void btnLoadSp_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_spFolderPath))
                {
                    MessageBox.Show("Primero seleccione una carpeta.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 1. Detectar tipo de BD
                string dbTypeFolder = _company.DbServerType == BoDataServerTypes.dst_HANADB
                    ? "HANA"
                    : "SQL";

                string finalPath = Path.Combine(_spFolderPath, dbTypeFolder);

                if (!Directory.Exists(finalPath))
                {
                    WriteSpLog($"[ERROR] La carpeta '{dbTypeFolder}' no existe dentro de la ruta seleccionada.");
                    return;
                }

                // 2. Obtener archivos .sql
                var sqlFiles = Directory.GetFiles(finalPath, "*.sql", SearchOption.TopDirectoryOnly);

                if (sqlFiles.Length == 0)
                {
                    WriteSpLog("[ERROR] No se encontraron archivos .sql.");
                    return;
                }

                var spService = new SpInstallerService(_company);

                WriteSpLog($"=== INICIO INSTALACIÓN SP ({dbTypeFolder}) ===");

                foreach (var file in sqlFiles)
                {
                    var req = new SpScriptRequest
                    {
                        FilePath = file,
                        ScriptContent = File.ReadAllText(file)
                    };

                    string result = spService.ExecuteScript(req);
                    WriteSpLog(result);
                }

                WriteSpLog("=== FIN INSTALACIÓN SP ===");
            }
            catch (Exception ex)
            {
                WriteSpLog($"[ERROR] Instalación fallida: {ex.Message}");
            }
        }

        /// <summary>
        /// Mostrar el log en pantalla del resultado de la ejecución de scripts SQL / HANA
        /// </summary>
        private void WriteSpLog(string message)
        {
            txtLogSp.AppendText(message + Environment.NewLine);
        }

        #endregion
    }
}
