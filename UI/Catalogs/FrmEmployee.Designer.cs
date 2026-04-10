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
            gprGeneralInfo = new GroupBox();
            tblLayoutGeneral = new TableLayoutPanel();
            label2 = new Label();
            txtName = new TextBox();
            txtApellido = new TextBox();
            mskCedula = new MaskedTextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            datTimeBirthDate = new DateTimePicker();
            cmbMaritalStatus = new ComboBox();
            cmbChildren = new ComboBox();
            groupBox1 = new GroupBox();
            tblLayoutContact = new TableLayoutPanel();
            label7 = new Label();
            txtEmail = new TextBox();
            label8 = new Label();
            txtPhone = new TextBox();
            label9 = new Label();
            txtAddress = new TextBox();
            panel1 = new Panel();
            btnRegister = new Button();
            gprGeneralInfo.SuspendLayout();
            tblLayoutGeneral.SuspendLayout();
            groupBox1.SuspendLayout();
            tblLayoutContact.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gprGeneralInfo
            // 
            gprGeneralInfo.Controls.Add(tblLayoutGeneral);
            gprGeneralInfo.Dock = DockStyle.Top;
            gprGeneralInfo.Location = new Point(37, 43);
            gprGeneralInfo.Margin = new Padding(18, 21, 18, 21);
            gprGeneralInfo.Name = "gprGeneralInfo";
            gprGeneralInfo.Padding = new Padding(18, 21, 18, 21);
            gprGeneralInfo.Size = new Size(701, 429);
            gprGeneralInfo.TabIndex = 0;
            gprGeneralInfo.TabStop = false;
            gprGeneralInfo.Text = "Datos Generales";
            // 
            // tblLayoutGeneral
            // 
            tblLayoutGeneral.ColumnCount = 2;
            tblLayoutGeneral.ColumnStyles.Add(new ColumnStyle());
            tblLayoutGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayoutGeneral.Controls.Add(label2, 0, 1);
            tblLayoutGeneral.Controls.Add(txtName, 1, 1);
            tblLayoutGeneral.Controls.Add(txtApellido, 1, 2);
            tblLayoutGeneral.Controls.Add(mskCedula, 1, 0);
            tblLayoutGeneral.Controls.Add(label1, 0, 0);
            tblLayoutGeneral.Controls.Add(label3, 0, 2);
            tblLayoutGeneral.Controls.Add(label4, 0, 4);
            tblLayoutGeneral.Controls.Add(label5, 0, 5);
            tblLayoutGeneral.Controls.Add(label6, 0, 6);
            tblLayoutGeneral.Controls.Add(datTimeBirthDate, 1, 4);
            tblLayoutGeneral.Controls.Add(cmbMaritalStatus, 1, 5);
            tblLayoutGeneral.Controls.Add(cmbChildren, 1, 6);
            tblLayoutGeneral.Cursor = Cursors.Hand;
            tblLayoutGeneral.Dock = DockStyle.Fill;
            tblLayoutGeneral.Location = new Point(18, 41);
            tblLayoutGeneral.Margin = new Padding(5, 5, 5, 5);
            tblLayoutGeneral.Name = "tblLayoutGeneral";
            tblLayoutGeneral.Padding = new Padding(18, 21, 18, 21);
            tblLayoutGeneral.RowCount = 8;
            tblLayoutGeneral.RowStyles.Add(new RowStyle());
            tblLayoutGeneral.RowStyles.Add(new RowStyle());
            tblLayoutGeneral.RowStyles.Add(new RowStyle());
            tblLayoutGeneral.RowStyles.Add(new RowStyle());
            tblLayoutGeneral.RowStyles.Add(new RowStyle());
            tblLayoutGeneral.RowStyles.Add(new RowStyle());
            tblLayoutGeneral.RowStyles.Add(new RowStyle());
            tblLayoutGeneral.RowStyles.Add(new RowStyle());
            tblLayoutGeneral.Size = new Size(665, 367);
            tblLayoutGeneral.TabIndex = 0;
            tblLayoutGeneral.Paint += tableLayoutPanel1_Paint;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(21, 81);
            label2.Margin = new Padding(3, 8, 3, 8);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(157, 81);
            txtName.Margin = new Padding(5, 11, 5, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(485, 27);
            txtName.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Dock = DockStyle.Fill;
            txtApellido.Location = new Point(155, 117);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(489, 27);
            txtApellido.TabIndex = 5;
            // 
            // mskCedula
            // 
            mskCedula.Dock = DockStyle.Fill;
            mskCedula.Location = new Point(157, 32);
            mskCedula.Margin = new Padding(5, 11, 5, 11);
            mskCedula.Mask = "000-000000-0000L";
            mskCedula.Name = "mskCedula";
            mskCedula.Size = new Size(485, 27);
            mskCedula.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(21, 35);
            label1.Margin = new Padding(3, 8, 3, 8);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 0;
            label1.Text = "Cédula";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(21, 120);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 4;
            label3.Text = "Apellidos";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(21, 155);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 6;
            label4.Text = "Fecha Nacimiento";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(21, 191);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 7;
            label5.Text = "Estado Cívil";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(21, 227);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 8;
            label6.Text = "Hijos";
            // 
            // datTimeBirthDate
            // 
            datTimeBirthDate.CustomFormat = "dd/mm/yyyy";
            datTimeBirthDate.Dock = DockStyle.Fill;
            datTimeBirthDate.Format = DateTimePickerFormat.Short;
            datTimeBirthDate.Location = new Point(155, 152);
            datTimeBirthDate.Margin = new Padding(3, 4, 3, 4);
            datTimeBirthDate.MaxDate = new DateTime(2040, 12, 30, 0, 0, 0, 0);
            datTimeBirthDate.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            datTimeBirthDate.Name = "datTimeBirthDate";
            datTimeBirthDate.Size = new Size(489, 27);
            datTimeBirthDate.TabIndex = 9;
            // 
            // cmbMaritalStatus
            // 
            cmbMaritalStatus.Dock = DockStyle.Fill;
            cmbMaritalStatus.FormattingEnabled = true;
            cmbMaritalStatus.Location = new Point(155, 187);
            cmbMaritalStatus.Margin = new Padding(3, 4, 3, 4);
            cmbMaritalStatus.Name = "cmbMaritalStatus";
            cmbMaritalStatus.Size = new Size(489, 28);
            cmbMaritalStatus.TabIndex = 10;
            // 
            // cmbChildren
            // 
            cmbChildren.Dock = DockStyle.Fill;
            cmbChildren.FormattingEnabled = true;
            cmbChildren.Location = new Point(155, 223);
            cmbChildren.Margin = new Padding(3, 4, 3, 4);
            cmbChildren.Name = "cmbChildren";
            cmbChildren.Size = new Size(489, 28);
            cmbChildren.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tblLayoutContact);
            groupBox1.Location = new Point(37, 497);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(18, 21, 18, 21);
            groupBox1.Size = new Size(702, 233);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de Contacto";
            // 
            // tblLayoutContact
            // 
            tblLayoutContact.ColumnCount = 2;
            tblLayoutContact.ColumnStyles.Add(new ColumnStyle());
            tblLayoutContact.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayoutContact.Controls.Add(label7, 0, 0);
            tblLayoutContact.Controls.Add(txtEmail, 1, 0);
            tblLayoutContact.Controls.Add(label8, 0, 1);
            tblLayoutContact.Controls.Add(txtPhone, 1, 1);
            tblLayoutContact.Controls.Add(label9, 0, 2);
            tblLayoutContact.Controls.Add(txtAddress, 1, 2);
            tblLayoutContact.Dock = DockStyle.Fill;
            tblLayoutContact.Location = new Point(18, 41);
            tblLayoutContact.Margin = new Padding(3, 4, 3, 4);
            tblLayoutContact.Name = "tblLayoutContact";
            tblLayoutContact.Padding = new Padding(18, 21, 18, 21);
            tblLayoutContact.RowCount = 3;
            tblLayoutContact.RowStyles.Add(new RowStyle());
            tblLayoutContact.RowStyles.Add(new RowStyle());
            tblLayoutContact.RowStyles.Add(new RowStyle());
            tblLayoutContact.Size = new Size(666, 171);
            tblLayoutContact.TabIndex = 0;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(21, 28);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 0;
            label7.Text = "Correo";
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(101, 25);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(544, 27);
            txtEmail.TabIndex = 1;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(21, 63);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 2;
            label8.Text = "Teléfono";
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(101, 60);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(544, 27);
            txtPhone.TabIndex = 3;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(21, 110);
            label9.Name = "label9";
            label9.Size = new Size(74, 20);
            label9.TabIndex = 4;
            label9.Text = "Domicilio";
            // 
            // txtAddress
            // 
            txtAddress.Dock = DockStyle.Fill;
            txtAddress.Location = new Point(101, 95);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(544, 27);
            txtAddress.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRegister);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(37, 763);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(9, 11, 9, 11);
            panel1.Size = new Size(701, 69);
            panel1.TabIndex = 2;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRegister.Location = new Point(585, 15);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(103, 43);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // FrmEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 875);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(gprGeneralInfo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmEmployee";
            Padding = new Padding(37, 43, 37, 43);
            Text = "Empleado";
            gprGeneralInfo.ResumeLayout(false);
            tblLayoutGeneral.ResumeLayout(false);
            tblLayoutGeneral.PerformLayout();
            groupBox1.ResumeLayout(false);
            tblLayoutContact.ResumeLayout(false);
            tblLayoutContact.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gprGeneralInfo;
        private TableLayoutPanel tblLayoutGeneral;
        private MaskedTextBox mskCedula;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtApellido;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker datTimeBirthDate;
        private ComboBox cmbMaritalStatus;
        private ComboBox cmbChildren;
        private GroupBox groupBox1;
        private TableLayoutPanel tblLayoutContact;
        private Label label7;
        private TextBox txtEmail;
        private Label label8;
        private TextBox txtPhone;
        private Label label9;
        private TextBox txtAddress;
        private Panel panel1;
        private Button btnRegister;
    }
}
