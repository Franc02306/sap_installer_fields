using sap_installer_fields.Models.Requests;
using sap_installer_fields.Services;
using SAPbobsCOM;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace sap_installer_fields
{
    public partial class ConnectionForm : Form
    {
        private readonly SapConnectionService _connectionService;

        public ConnectionForm()
        {
            InitializeComponent();
            _connectionService = new SapConnectionService();
            LoadDbType();
        }

        private void LoadDbType()
        {
            cmbDbType.Items.Add("HANA");
            cmbDbType.Items.Add("MSSQL_2019");
            cmbDbType.SelectedIndex = 0;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            txtResponse.Clear();

            try
            {
                var request = new SapConnectionRequest
                {
                    Server = txtServer.Text.Trim(),
                    CompanyDB = txtCompany.Text.Trim(),
                    User = txtUser.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    DbType = cmbDbType.SelectedItem.ToString()
                };

                var company = _connectionService.Connect(request);

                // SUCCESS UI
                txtResponse.SelectionColor = Color.Green;
                txtResponse.SelectionFont = new Font(txtResponse.Font, FontStyle.Bold);
                txtResponse.AppendText("¡CONECTADO!\n\n");

                txtResponse.SelectionColor = Color.Black;
                txtResponse.SelectionFont = new Font(txtResponse.Font, FontStyle.Regular);
                txtResponse.AppendText("Conexión con SAP establecida.");
            }
            catch (Exception ex)
            {
                // ERROR UI
                txtResponse.SelectionColor = Color.Red;
                txtResponse.SelectionFont = new Font(txtResponse.Font, FontStyle.Bold);
                txtResponse.AppendText("¡ERROR!\n\n");

                txtResponse.SelectionColor = Color.Red;
                txtResponse.SelectionFont = new Font(txtResponse.Font, FontStyle.Regular);
                txtResponse.AppendText(ex.Message);
            }
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }
    }
}
