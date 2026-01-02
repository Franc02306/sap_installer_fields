namespace sap_installer_fields.Forms
{
    partial class InstallerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallerForm));
            this.FormUITabPanel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtLogUdf = new System.Windows.Forms.TextBox();
            this.dgvUdfList = new System.Windows.Forms.DataGridView();
            this.btnInstallField = new System.Windows.Forms.Button();
            this.btnLoadJson = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvUdtList = new System.Windows.Forms.DataGridView();
            this.txtLogUdt = new System.Windows.Forms.TextBox();
            this.btnInstallUdt = new System.Windows.Forms.Button();
            this.btnLoadUdtJson = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnLoadSp = new System.Windows.Forms.Button();
            this.btnChoosePathSp = new System.Windows.Forms.Button();
            this.txtLogSp = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.txtSpFolderPath = new System.Windows.Forms.TextBox();
            this.FormUITabPanel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUdfList)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUdtList)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormUITabPanel
            // 
            this.FormUITabPanel.Controls.Add(this.tabPage1);
            this.FormUITabPanel.Controls.Add(this.tabPage2);
            this.FormUITabPanel.Controls.Add(this.tabPage3);
            this.FormUITabPanel.Controls.Add(this.tabPage4);
            this.FormUITabPanel.Location = new System.Drawing.Point(12, 12);
            this.FormUITabPanel.Name = "FormUITabPanel";
            this.FormUITabPanel.SelectedIndex = 0;
            this.FormUITabPanel.Size = new System.Drawing.Size(771, 478);
            this.FormUITabPanel.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtLogUdf);
            this.tabPage1.Controls.Add(this.dgvUdfList);
            this.tabPage1.Controls.Add(this.btnInstallField);
            this.tabPage1.Controls.Add(this.btnLoadJson);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(763, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Campos de Usuario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtLogUdf
            // 
            this.txtLogUdf.BackColor = System.Drawing.Color.White;
            this.txtLogUdf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLogUdf.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogUdf.ForeColor = System.Drawing.Color.Black;
            this.txtLogUdf.Location = new System.Drawing.Point(3, 274);
            this.txtLogUdf.Multiline = true;
            this.txtLogUdf.Name = "txtLogUdf";
            this.txtLogUdf.ReadOnly = true;
            this.txtLogUdf.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogUdf.Size = new System.Drawing.Size(757, 175);
            this.txtLogUdf.TabIndex = 1;
            // 
            // dgvUdfList
            // 
            this.dgvUdfList.AllowUserToAddRows = false;
            this.dgvUdfList.AllowUserToDeleteRows = false;
            this.dgvUdfList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUdfList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUdfList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvUdfList.Location = new System.Drawing.Point(3, 3);
            this.dgvUdfList.Name = "dgvUdfList";
            this.dgvUdfList.ReadOnly = true;
            this.dgvUdfList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUdfList.Size = new System.Drawing.Size(757, 200);
            this.dgvUdfList.TabIndex = 3;
            // 
            // btnInstallField
            // 
            this.btnInstallField.BackColor = System.Drawing.Color.LightGreen;
            this.btnInstallField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallField.Location = new System.Drawing.Point(116, 224);
            this.btnInstallField.Name = "btnInstallField";
            this.btnInstallField.Size = new System.Drawing.Size(104, 44);
            this.btnInstallField.TabIndex = 2;
            this.btnInstallField.Text = "Instalar Campos";
            this.btnInstallField.UseVisualStyleBackColor = false;
            this.btnInstallField.Click += new System.EventHandler(this.btnInstallField_Click);
            // 
            // btnLoadJson
            // 
            this.btnLoadJson.BackColor = System.Drawing.Color.Lavender;
            this.btnLoadJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadJson.Location = new System.Drawing.Point(6, 224);
            this.btnLoadJson.Name = "btnLoadJson";
            this.btnLoadJson.Size = new System.Drawing.Size(104, 44);
            this.btnLoadJson.TabIndex = 1;
            this.btnLoadJson.Text = "Cargar JSON";
            this.btnLoadJson.UseVisualStyleBackColor = false;
            this.btnLoadJson.Click += new System.EventHandler(this.btnLoadJson_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvUdtList);
            this.tabPage2.Controls.Add(this.txtLogUdt);
            this.tabPage2.Controls.Add(this.btnInstallUdt);
            this.tabPage2.Controls.Add(this.btnLoadUdtJson);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(763, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tablas de Usuario";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvUdtList
            // 
            this.dgvUdtList.AllowUserToAddRows = false;
            this.dgvUdtList.AllowUserToDeleteRows = false;
            this.dgvUdtList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUdtList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUdtList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvUdtList.Location = new System.Drawing.Point(3, 3);
            this.dgvUdtList.Name = "dgvUdtList";
            this.dgvUdtList.ReadOnly = true;
            this.dgvUdtList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUdtList.Size = new System.Drawing.Size(757, 200);
            this.dgvUdtList.TabIndex = 5;
            // 
            // txtLogUdt
            // 
            this.txtLogUdt.BackColor = System.Drawing.Color.White;
            this.txtLogUdt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLogUdt.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogUdt.ForeColor = System.Drawing.Color.Black;
            this.txtLogUdt.Location = new System.Drawing.Point(3, 274);
            this.txtLogUdt.Multiline = true;
            this.txtLogUdt.Name = "txtLogUdt";
            this.txtLogUdt.ReadOnly = true;
            this.txtLogUdt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogUdt.Size = new System.Drawing.Size(757, 175);
            this.txtLogUdt.TabIndex = 4;
            // 
            // btnInstallUdt
            // 
            this.btnInstallUdt.BackColor = System.Drawing.Color.LightGreen;
            this.btnInstallUdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallUdt.Location = new System.Drawing.Point(116, 224);
            this.btnInstallUdt.Name = "btnInstallUdt";
            this.btnInstallUdt.Size = new System.Drawing.Size(104, 44);
            this.btnInstallUdt.TabIndex = 3;
            this.btnInstallUdt.Text = "Instalar Tablas\r\n";
            this.btnInstallUdt.UseVisualStyleBackColor = false;
            this.btnInstallUdt.Click += new System.EventHandler(this.btnInstallUdt_Click);
            // 
            // btnLoadUdtJson
            // 
            this.btnLoadUdtJson.BackColor = System.Drawing.Color.Lavender;
            this.btnLoadUdtJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadUdtJson.Location = new System.Drawing.Point(6, 224);
            this.btnLoadUdtJson.Name = "btnLoadUdtJson";
            this.btnLoadUdtJson.Size = new System.Drawing.Size(104, 44);
            this.btnLoadUdtJson.TabIndex = 2;
            this.btnLoadUdtJson.Text = "Cargar JSON";
            this.btnLoadUdtJson.UseVisualStyleBackColor = false;
            this.btnLoadUdtJson.Click += new System.EventHandler(this.btnLoadUdtJson_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(763, 452);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "UDO";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtSpFolderPath);
            this.tabPage4.Controls.Add(this.labelPath);
            this.tabPage4.Controls.Add(this.txtLogSp);
            this.tabPage4.Controls.Add(this.btnChoosePathSp);
            this.tabPage4.Controls.Add(this.btnLoadSp);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(763, 452);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Stored Procedures";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnLoadSp
            // 
            this.btnLoadSp.BackColor = System.Drawing.Color.LightGreen;
            this.btnLoadSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSp.Location = new System.Drawing.Point(179, 41);
            this.btnLoadSp.Name = "btnLoadSp";
            this.btnLoadSp.Size = new System.Drawing.Size(136, 44);
            this.btnLoadSp.TabIndex = 4;
            this.btnLoadSp.Text = "Crear Procedimientos";
            this.btnLoadSp.UseVisualStyleBackColor = false;
            this.btnLoadSp.Click += new System.EventHandler(this.btnLoadSp_Click);
            // 
            // btnChoosePathSp
            // 
            this.btnChoosePathSp.BackColor = System.Drawing.Color.Lavender;
            this.btnChoosePathSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoosePathSp.Location = new System.Drawing.Point(27, 41);
            this.btnChoosePathSp.Name = "btnChoosePathSp";
            this.btnChoosePathSp.Size = new System.Drawing.Size(136, 44);
            this.btnChoosePathSp.TabIndex = 5;
            this.btnChoosePathSp.Text = "Seleccionar Carpeta";
            this.btnChoosePathSp.UseVisualStyleBackColor = false;
            this.btnChoosePathSp.Click += new System.EventHandler(this.btnChoosePathSp_Click);
            // 
            // txtLogSp
            // 
            this.txtLogSp.BackColor = System.Drawing.Color.White;
            this.txtLogSp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLogSp.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogSp.ForeColor = System.Drawing.Color.Black;
            this.txtLogSp.Location = new System.Drawing.Point(3, 223);
            this.txtLogSp.Multiline = true;
            this.txtLogSp.Name = "txtLogSp";
            this.txtLogSp.ReadOnly = true;
            this.txtLogSp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogSp.Size = new System.Drawing.Size(757, 226);
            this.txtLogSp.TabIndex = 6;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPath.Location = new System.Drawing.Point(24, 116);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(131, 17);
            this.labelPath.TabIndex = 7;
            this.labelPath.Text = "Ruta Seleccionada:";
            // 
            // txtSpFolderPath
            // 
            this.txtSpFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpFolderPath.BackColor = System.Drawing.Color.White;
            this.txtSpFolderPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpFolderPath.ForeColor = System.Drawing.Color.Black;
            this.txtSpFolderPath.Location = new System.Drawing.Point(29, 144);
            this.txtSpFolderPath.Name = "txtSpFolderPath";
            this.txtSpFolderPath.ReadOnly = true;
            this.txtSpFolderPath.Size = new System.Drawing.Size(500, 20);
            this.txtSpFolderPath.TabIndex = 8;
            this.txtSpFolderPath.TabStop = false;
            this.txtSpFolderPath.Text = "Ruta aun no seleccionada";
            // 
            // InstallerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 502);
            this.Controls.Add(this.FormUITabPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstallerForm";
            this.Text = "Instalador Campos SAP";
            this.FormUITabPanel.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUdfList)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUdtList)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl FormUITabPanel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnLoadJson;
        private System.Windows.Forms.Button btnInstallField;
        private System.Windows.Forms.DataGridView dgvUdfList;
        private System.Windows.Forms.TextBox txtLogUdf;
        private System.Windows.Forms.DataGridView dgvUdtList;
        private System.Windows.Forms.TextBox txtLogUdt;
        private System.Windows.Forms.Button btnInstallUdt;
        private System.Windows.Forms.Button btnLoadUdtJson;
        private System.Windows.Forms.Button btnLoadSp;
        private System.Windows.Forms.TextBox txtLogSp;
        private System.Windows.Forms.Button btnChoosePathSp;
        private System.Windows.Forms.TextBox txtSpFolderPath;
        private System.Windows.Forms.Label labelPath;
    }
}