namespace Administration_RRHH.UI.Catalogs
{
    partial class MunicipalityForm
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
            pnlTitle = new Panel();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            txtCode = new TextBox();
            label3 = new Label();
            txtMunicipality = new TextBox();
            label4 = new Label();
            cmbDepartament = new ComboBox();
            chkEnable = new CheckBox();
            btnResgister = new Button();
            btnCancel = new Button();
            pnlTitle.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(89, 93, 112);
            pnlTitle.Controls.Add(btnExit);
            pnlTitle.Controls.Add(label1);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Padding = new Padding(2);
            pnlTitle.Size = new Size(699, 56);
            pnlTitle.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.Image = Properties.Resources.exit_f5f5f51;
            btnExit.Location = new Point(643, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(48, 48);
            btnExit.TabIndex = 11;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(235, 236, 238);
            label1.Location = new Point(2, 14);
            label1.Margin = new Padding(2);
            label1.Name = "label1";
            label1.Padding = new Padding(32, 0, 0, 0);
            label1.Size = new Size(154, 30);
            label1.TabIndex = 0;
            label1.Text = "Municipios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 136);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 2;
            label2.Text = "Código";
            // 
            // txtCode
            // 
            txtCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCode.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCode.Location = new Point(242, 127);
            txtCode.MaxLength = 3;
            txtCode.Name = "txtCode";
            txtCode.PlaceholderText = "000";
            txtCode.Size = new Size(356, 34);
            txtCode.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 196);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 4;
            label3.Text = "Municipio";
            // 
            // txtMunicipality
            // 
            txtMunicipality.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMunicipality.CharacterCasing = CharacterCasing.Upper;
            txtMunicipality.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMunicipality.Location = new Point(242, 187);
            txtMunicipality.Name = "txtMunicipality";
            txtMunicipality.PlaceholderText = "Nombre del Municipio";
            txtMunicipality.Size = new Size(356, 34);
            txtMunicipality.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 263);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 6;
            label4.Text = "Departamento";
            // 
            // cmbDepartament
            // 
            cmbDepartament.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbDepartament.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartament.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbDepartament.FormattingEnabled = true;
            cmbDepartament.Location = new Point(242, 252);
            cmbDepartament.Name = "cmbDepartament";
            cmbDepartament.Size = new Size(356, 36);
            cmbDepartament.Sorted = true;
            cmbDepartament.TabIndex = 7;
            // 
            // chkEnable
            // 
            chkEnable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkEnable.AutoSize = true;
            chkEnable.Checked = true;
            chkEnable.CheckState = CheckState.Checked;
            chkEnable.Enabled = false;
            chkEnable.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkEnable.Location = new Point(504, 325);
            chkEnable.Name = "chkEnable";
            chkEnable.Size = new Size(94, 32);
            chkEnable.TabIndex = 8;
            chkEnable.Text = "Activo";
            chkEnable.UseVisualStyleBackColor = true;
            // 
            // btnResgister
            // 
            btnResgister.BackColor = Color.FromArgb(55, 60, 83);
            btnResgister.Cursor = Cursors.Hand;
            btnResgister.FlatAppearance.BorderSize = 0;
            btnResgister.FlatStyle = FlatStyle.Flat;
            btnResgister.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResgister.ForeColor = Color.FromArgb(235, 236, 238);
            btnResgister.Location = new Point(99, 410);
            btnResgister.Name = "btnResgister";
            btnResgister.Size = new Size(208, 48);
            btnResgister.TabIndex = 9;
            btnResgister.Text = "Registrar";
            btnResgister.UseVisualStyleBackColor = false;
            btnResgister.Click += btnResgister_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(89, 93, 112);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(235, 236, 238);
            btnCancel.Location = new Point(390, 410);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(208, 48);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // MunicipalityForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(235, 236, 238);
            ClientSize = new Size(699, 540);
            Controls.Add(btnCancel);
            Controls.Add(btnResgister);
            Controls.Add(chkEnable);
            Controls.Add(cmbDepartament);
            Controls.Add(label4);
            Controls.Add(txtMunicipality);
            Controls.Add(label3);
            Controls.Add(txtCode);
            Controls.Add(label2);
            Controls.Add(pnlTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MunicipalityForm";
            Text = "MunicipalityForm";
            Load += MunicipalityForm_Load;
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTitle;
        private Label label1;
        private Label label2;
        private TextBox txtCode;
        private Label label3;
        private TextBox txtMunicipality;
        private Label label4;
        private ComboBox cmbDepartament;
        private CheckBox chkEnable;
        private Button btnResgister;
        private Button btnCancel;
        private Button btnExit;
    }
}