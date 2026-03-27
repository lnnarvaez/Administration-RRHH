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
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            mskCedula = new MaskedTextBox();
            txtName = new TextBox();
            txtSurname = new TextBox();
            datTimeBirth = new DateTimePicker();
            cmbMarital = new ComboBox();
            cmbChildren = new ComboBox();
            panel1 = new Panel();
            btnRegister = new Button();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(35, 30);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(21, 18, 21, 18);
            groupBox1.Size = new Size(514, 212);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Generales";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(mskCedula, 1, 0);
            tableLayoutPanel1.Controls.Add(txtName, 1, 1);
            tableLayoutPanel1.Controls.Add(txtSurname, 1, 2);
            tableLayoutPanel1.Controls.Add(datTimeBirth, 1, 3);
            tableLayoutPanel1.Controls.Add(cmbMarital, 1, 4);
            tableLayoutPanel1.Controls.Add(cmbChildren, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(21, 34);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(7, 6, 7, 6);
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(472, 160);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(10, 12);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Cédula";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(10, 39);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(10, 66);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(10, 93);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha Nacimiento";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(10, 120);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 4;
            label5.Text = "Estado Cívil";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(10, 147);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 5;
            label6.Text = "Hijos";
            // 
            // mskCedula
            // 
            mskCedula.Dock = DockStyle.Fill;
            mskCedula.Location = new Point(119, 8);
            mskCedula.Margin = new Padding(3, 2, 3, 2);
            mskCedula.Name = "mskCedula";
            mskCedula.Size = new Size(343, 23);
            mskCedula.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(119, 35);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(343, 23);
            txtName.TabIndex = 7;
            // 
            // txtSurname
            // 
            txtSurname.Dock = DockStyle.Fill;
            txtSurname.Location = new Point(119, 62);
            txtSurname.Margin = new Padding(3, 2, 3, 2);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(343, 23);
            txtSurname.TabIndex = 8;
            // 
            // datTimeBirth
            // 
            datTimeBirth.Dock = DockStyle.Fill;
            datTimeBirth.Location = new Point(119, 89);
            datTimeBirth.Margin = new Padding(3, 2, 3, 2);
            datTimeBirth.Name = "datTimeBirth";
            datTimeBirth.Size = new Size(343, 23);
            datTimeBirth.TabIndex = 9;
            // 
            // cmbMarital
            // 
            cmbMarital.Dock = DockStyle.Fill;
            cmbMarital.FormattingEnabled = true;
            cmbMarital.Location = new Point(119, 116);
            cmbMarital.Margin = new Padding(3, 2, 3, 2);
            cmbMarital.Name = "cmbMarital";
            cmbMarital.Size = new Size(343, 23);
            cmbMarital.TabIndex = 10;
            // 
            // cmbChildren
            // 
            cmbChildren.Dock = DockStyle.Fill;
            cmbChildren.FormattingEnabled = true;
            cmbChildren.Location = new Point(119, 143);
            cmbChildren.Margin = new Padding(3, 2, 3, 2);
            cmbChildren.Name = "cmbChildren";
            cmbChildren.Size = new Size(343, 23);
            cmbChildren.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRegister);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(35, 306);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 51);
            panel1.TabIndex = 1;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(418, 10);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(82, 32);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // FrmEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 387);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmEmployee";
            Padding = new Padding(35, 30, 35, 30);
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaskedTextBox mskCedula;
        private TextBox txtName;
        private TextBox txtSurname;
        private DateTimePicker datTimeBirth;
        private ComboBox cmbMarital;
        private ComboBox cmbChildren;
        private Panel panel1;
        private Button btnRegister;
    }
}
