namespace Administration_RRHH
{
    partial class FrmEmployee
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTitle = new Panel();
            btnExit = new Button();
            label1 = new Label();
            grpGeneralData = new GroupBox();
            cmbChildren = new ComboBox();
            label12 = new Label();
            cmbMaritalStatus = new ComboBox();
            label7 = new Label();
            dpkBirthDay = new DateTimePicker();
            label6 = new Label();
            txtSurname = new TextBox();
            label5 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            mskInss = new MaskedTextBox();
            label3 = new Label();
            mskCedula = new MaskedTextBox();
            label2 = new Label();
            grpContacto = new GroupBox();
            cmbMunicipality = new ComboBox();
            label11 = new Label();
            txtAddress = new TextBox();
            label10 = new Label();
            txtEmail = new TextBox();
            label9 = new Label();
            mskPhone = new MaskedTextBox();
            label8 = new Label();
            btnRegister = new Button();
            pnlTitle.SuspendLayout();
            grpGeneralData.SuspendLayout();
            grpContacto.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(89, 93, 112);
            pnlTitle.Controls.Add(btnExit);
            pnlTitle.Controls.Add(label1);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Margin = new Padding(0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(827, 56);
            pnlTitle.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.Image = Properties.Resources.exit_f5f5f51;
            btnExit.Location = new Point(775, 8);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(40, 40);
            btnExit.TabIndex = 1;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(235, 236, 238);
            label1.Location = new Point(37, 13);
            label1.Name = "label1";
            label1.Size = new Size(263, 30);
            label1.TabIndex = 0;
            label1.Text = "Información de Empleado";
            // 
            // grpGeneralData
            // 
            grpGeneralData.Controls.Add(cmbChildren);
            grpGeneralData.Controls.Add(label12);
            grpGeneralData.Controls.Add(cmbMaritalStatus);
            grpGeneralData.Controls.Add(label7);
            grpGeneralData.Controls.Add(dpkBirthDay);
            grpGeneralData.Controls.Add(label6);
            grpGeneralData.Controls.Add(txtSurname);
            grpGeneralData.Controls.Add(label5);
            grpGeneralData.Controls.Add(txtName);
            grpGeneralData.Controls.Add(label4);
            grpGeneralData.Controls.Add(mskInss);
            grpGeneralData.Controls.Add(label3);
            grpGeneralData.Controls.Add(mskCedula);
            grpGeneralData.Controls.Add(label2);
            grpGeneralData.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpGeneralData.Location = new Point(76, 113);
            grpGeneralData.Name = "grpGeneralData";
            grpGeneralData.Size = new Size(674, 524);
            grpGeneralData.TabIndex = 3;
            grpGeneralData.TabStop = false;
            grpGeneralData.Text = "Datos Generales";
            // 
            // cmbChildren
            // 
            cmbChildren.Cursor = Cursors.Hand;
            cmbChildren.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbChildren.FormattingEnabled = true;
            cmbChildren.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cmbChildren.Location = new Point(239, 449);
            cmbChildren.Name = "cmbChildren";
            cmbChildren.Size = new Size(380, 36);
            cmbChildren.Sorted = true;
            cmbChildren.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(44, 396);
            label12.Name = "label12";
            label12.Size = new Size(113, 28);
            label12.TabIndex = 12;
            label12.Text = "Estado Cívil";
            // 
            // cmbMaritalStatus
            // 
            cmbMaritalStatus.Cursor = Cursors.Hand;
            cmbMaritalStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaritalStatus.FormattingEnabled = true;
            cmbMaritalStatus.Location = new Point(239, 382);
            cmbMaritalStatus.Name = "cmbMaritalStatus";
            cmbMaritalStatus.Size = new Size(380, 36);
            cmbMaritalStatus.Sorted = true;
            cmbMaritalStatus.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 460);
            label7.Name = "label7";
            label7.Size = new Size(56, 28);
            label7.TabIndex = 10;
            label7.Text = "Hijos";
            // 
            // dpkBirthDay
            // 
            dpkBirthDay.Cursor = Cursors.Hand;
            dpkBirthDay.Format = DateTimePickerFormat.Short;
            dpkBirthDay.Location = new Point(239, 317);
            dpkBirthDay.MaxDate = new DateTime(2030, 12, 31, 0, 0, 0, 0);
            dpkBirthDay.MinDate = new DateTime(1975, 1, 1, 0, 0, 0, 0);
            dpkBirthDay.Name = "dpkBirthDay";
            dpkBirthDay.Size = new Size(380, 34);
            dpkBirthDay.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 322);
            label6.Name = "label6";
            label6.Size = new Size(168, 28);
            label6.TabIndex = 8;
            label6.Text = "Fecha Nacimiento";
            // 
            // txtSurname
            // 
            txtSurname.CharacterCasing = CharacterCasing.Upper;
            txtSurname.Location = new Point(239, 252);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(380, 34);
            txtSurname.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 255);
            label5.Name = "label5";
            label5.Size = new Size(94, 28);
            label5.TabIndex = 6;
            label5.Text = "Apellidos";
            // 
            // txtName
            // 
            txtName.CharacterCasing = CharacterCasing.Upper;
            txtName.Location = new Point(239, 187);
            txtName.Name = "txtName";
            txtName.Size = new Size(380, 34);
            txtName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 190);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 4;
            label4.Text = "Nombres";
            // 
            // mskInss
            // 
            mskInss.Location = new Point(239, 122);
            mskInss.Mask = "999-9999-9";
            mskInss.Name = "mskInss";
            mskInss.Size = new Size(380, 34);
            mskInss.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 127);
            label3.Name = "label3";
            label3.Size = new Size(44, 28);
            label3.TabIndex = 2;
            label3.Text = "Inss";
            // 
            // mskCedula
            // 
            mskCedula.Location = new Point(239, 57);
            mskCedula.Mask = "999-999999-9999L";
            mskCedula.Name = "mskCedula";
            mskCedula.Size = new Size(380, 34);
            mskCedula.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 63);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 0;
            label2.Text = "Cédula";
            // 
            // grpContacto
            // 
            grpContacto.Controls.Add(cmbMunicipality);
            grpContacto.Controls.Add(label11);
            grpContacto.Controls.Add(txtAddress);
            grpContacto.Controls.Add(label10);
            grpContacto.Controls.Add(txtEmail);
            grpContacto.Controls.Add(label9);
            grpContacto.Controls.Add(mskPhone);
            grpContacto.Controls.Add(label8);
            grpContacto.Location = new Point(76, 682);
            grpContacto.Name = "grpContacto";
            grpContacto.Size = new Size(674, 407);
            grpContacto.TabIndex = 4;
            grpContacto.TabStop = false;
            grpContacto.Text = "Información de Contacto";
            // 
            // cmbMunicipality
            // 
            cmbMunicipality.Cursor = Cursors.Hand;
            cmbMunicipality.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMunicipality.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMunicipality.FormattingEnabled = true;
            cmbMunicipality.Location = new Point(143, 319);
            cmbMunicipality.Name = "cmbMunicipality";
            cmbMunicipality.Size = new Size(476, 36);
            cmbMunicipality.Sorted = true;
            cmbMunicipality.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(44, 327);
            label11.Name = "label11";
            label11.Size = new Size(90, 25);
            label11.TabIndex = 6;
            label11.Text = "Municipio";
            // 
            // txtAddress
            // 
            txtAddress.CharacterCasing = CharacterCasing.Upper;
            txtAddress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(143, 195);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(476, 89);
            txtAddress.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(43, 204);
            label10.Name = "label10";
            label10.Size = new Size(85, 25);
            label10.TabIndex = 4;
            label10.Text = "Dirección";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(143, 130);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(476, 34);
            txtEmail.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 139);
            label9.Name = "label9";
            label9.Size = new Size(66, 25);
            label9.TabIndex = 2;
            label9.Text = "Correo";
            // 
            // mskPhone
            // 
            mskPhone.Font = new Font("Segoe UI", 10F);
            mskPhone.Location = new Point(143, 61);
            mskPhone.Mask = "9999-9999";
            mskPhone.Name = "mskPhone";
            mskPhone.Size = new Size(476, 34);
            mskPhone.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 70);
            label8.Name = "label8";
            label8.Size = new Size(79, 25);
            label8.TabIndex = 0;
            label8.Text = "Teléfono";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(55, 60, 83);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.FromArgb(235, 236, 238);
            btnRegister.Location = new Point(307, 1126);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(212, 48);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // FrmEmployee
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.FromArgb(235, 236, 238);
            ClientSize = new Size(827, 1217);
            Controls.Add(btnRegister);
            Controls.Add(grpContacto);
            Controls.Add(grpGeneralData);
            Controls.Add(pnlTitle);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmEmployee";
            Text = "Empleado";
            Load += FrmEmployee_Load;
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            grpGeneralData.ResumeLayout(false);
            grpGeneralData.PerformLayout();
            grpContacto.ResumeLayout(false);
            grpContacto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlTitle;
        private Label label1;
        private GroupBox grpGeneralData;
        private Label label7;
        private DateTimePicker dpkBirthDay;
        private Label label6;
        private TextBox txtSurname;
        private Label label5;
        private TextBox txtName;
        private Label label4;
        private MaskedTextBox mskInss;
        private Label label3;
        private MaskedTextBox mskCedula;
        private Label label2;
        private ComboBox cmbMaritalStatus;
        private GroupBox grpContacto;
        private TextBox txtAddress;
        private Label label10;
        private TextBox txtEmail;
        private Label label9;
        private MaskedTextBox mskPhone;
        private Label label8;
        private Button btnRegister;
        private Label label11;
        private ComboBox cmbMunicipality;
        private Label label12;
        private ComboBox cmbChildren;
        private Button btnExit;
    }
}
