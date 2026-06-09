namespace Administration_RRHH.UI.Catalogs
{
    partial class EmployeeListForm
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
            mskIdNumber = new MaskedTextBox();
            btnSearch = new Button();
            btnCreate = new Button();
            dgListEmployee = new DataGridView();
            pnlTitle = new Panel();
            lbltitle = new Label();
            colIdNumber = new DataGridViewTextBoxColumn();
            colInss = new DataGridViewTextBoxColumn();
            colNames = new DataGridViewTextBoxColumn();
            colSurname = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgListEmployee).BeginInit();
            pnlTitle.SuspendLayout();
            SuspendLayout();
            // 
            // mskIdNumber
            // 
            mskIdNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskIdNumber.Location = new Point(88, 117);
            mskIdNumber.Margin = new Padding(4, 5, 4, 5);
            mskIdNumber.Mask = "000-000000-0000L";
            mskIdNumber.Name = "mskIdNumber";
            mskIdNumber.Size = new Size(243, 34);
            mskIdNumber.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = Properties.Resources.search_1;
            btnSearch.Location = new Point(350, 103);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(48, 48);
            btnSearch.TabIndex = 3;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreate.BackColor = Color.FromArgb(55, 60, 83);
            btnCreate.Cursor = Cursors.Hand;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.FromArgb(235, 236, 238);
            btnCreate.Location = new Point(1312, 108);
            btnCreate.Margin = new Padding(4, 5, 4, 5);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(192, 53);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Crear Empleado";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // dgListEmployee
            // 
            dgListEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgListEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListEmployee.Columns.AddRange(new DataGridViewColumn[] { colIdNumber, colInss, colNames, colSurname, colPhone, colEmail });
            dgListEmployee.Location = new Point(88, 231);
            dgListEmployee.Margin = new Padding(4, 5, 4, 5);
            dgListEmployee.Name = "dgListEmployee";
            dgListEmployee.RowHeadersWidth = 62;
            dgListEmployee.Size = new Size(1416, 755);
            dgListEmployee.TabIndex = 5;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(89, 93, 112);
            pnlTitle.Controls.Add(lbltitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1591, 56);
            pnlTitle.TabIndex = 6;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitle.ForeColor = Color.FromArgb(235, 236, 238);
            lbltitle.Location = new Point(44, 14);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(215, 28);
            lbltitle.TabIndex = 0;
            lbltitle.Text = "Empleados Registrados";
            // 
            // colIdNumber
            // 
            colIdNumber.HeaderText = "Cédula";
            colIdNumber.MinimumWidth = 8;
            colIdNumber.Name = "colIdNumber";
            colIdNumber.Width = 150;
            // 
            // colInss
            // 
            colInss.HeaderText = "Inss";
            colInss.MinimumWidth = 8;
            colInss.Name = "colInss";
            colInss.Width = 150;
            // 
            // colNames
            // 
            colNames.HeaderText = "Nombre";
            colNames.MinimumWidth = 8;
            colNames.Name = "colNames";
            colNames.Width = 150;
            // 
            // colSurname
            // 
            colSurname.HeaderText = "Apellidos";
            colSurname.MinimumWidth = 8;
            colSurname.Name = "colSurname";
            colSurname.Width = 150;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "Teléfono";
            colPhone.MinimumWidth = 8;
            colPhone.Name = "colPhone";
            colPhone.Width = 150;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Correo";
            colEmail.MinimumWidth = 8;
            colEmail.Name = "colEmail";
            colEmail.Width = 150;
            // 
            // EmployeeListForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(235, 236, 238);
            ClientSize = new Size(1591, 1078);
            Controls.Add(pnlTitle);
            Controls.Add(dgListEmployee);
            Controls.Add(btnCreate);
            Controls.Add(btnSearch);
            Controls.Add(mskIdNumber);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "EmployeeListForm";
            Text = "Registros de Empleados";
            Load += FrmListEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)dgListEmployee).EndInit();
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaskedTextBox mskIdNumber;
        private Button btnSearch;
        private Button btnCreate;
        private DataGridView dgListEmployee;
        private Panel pnlTitle;
        private Label lbltitle;
        private DataGridViewTextBoxColumn colIdNumber;
        private DataGridViewTextBoxColumn colInss;
        private DataGridViewTextBoxColumn colNames;
        private DataGridViewTextBoxColumn colSurname;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
    }
}