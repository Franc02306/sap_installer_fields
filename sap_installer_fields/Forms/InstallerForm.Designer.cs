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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnLoadJson = new System.Windows.Forms.Button();
            this.btnInstalField = new System.Windows.Forms.Button();
            this.dgvUdfList = new System.Windows.Forms.DataGridView();
            this.txtLogUdf = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUdfList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(771, 478);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtLogUdf);
            this.tabPage1.Controls.Add(this.dgvUdfList);
            this.tabPage1.Controls.Add(this.btnInstalField);
            this.tabPage1.Controls.Add(this.btnLoadJson);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(763, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "UDF";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(674, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "UDT";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(674, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "UDO";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(674, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "SP";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            // btnInstalField
            // 
            this.btnInstalField.BackColor = System.Drawing.Color.LightGreen;
            this.btnInstalField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstalField.Location = new System.Drawing.Point(116, 224);
            this.btnInstalField.Name = "btnInstalField";
            this.btnInstalField.Size = new System.Drawing.Size(104, 44);
            this.btnInstalField.TabIndex = 2;
            this.btnInstalField.Text = "Instalar Campos";
            this.btnInstalField.UseVisualStyleBackColor = false;
            this.btnInstalField.Click += new System.EventHandler(this.btnInstalField_Click);
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
            // InstallerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 502);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstallerForm";
            this.Text = "Instalador Campos SAP";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUdfList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnLoadJson;
        private System.Windows.Forms.Button btnInstalField;
        private System.Windows.Forms.DataGridView dgvUdfList;
        private System.Windows.Forms.TextBox txtLogUdf;
    }
}