using Newtonsoft.Json;
using sap_installer_fields.Core;
using sap_installer_fields.Services;
using sap_installer_fields.Models.Requests;
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

        private void btnInstalField_Click(object sender, EventArgs e)
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

        private void WriteUdfLog(string message)
        {
            txtLogUdf.AppendText(message + Environment.NewLine);
        }
    }
}
