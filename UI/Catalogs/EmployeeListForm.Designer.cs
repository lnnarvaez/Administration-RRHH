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
            btnCreateEmployee = new Button();
            dgListEmployee = new DataGridView();
            colIdNumber = new DataGridViewTextBoxColumn();
            colInss = new DataGridViewTextBoxColumn();
            colNames = new DataGridViewTextBoxColumn();
            colSurname = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            pnlTitle = new Panel();
            btnExit = new Button();
            lbltitle = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgListEmployee).BeginInit();
            pnlTitle.SuspendLayout();
            SuspendLayout();
            // 
            // mskIdNumber
            // 
            mskIdNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskIdNumber.Location = new Point(88, 106);
            mskIdNumber.Margin = new Padding(4, 5, 4, 5);
            mskIdNumber.Mask = "000-000000-0000L";
            mskIdNumber.Name = "mskIdNumber";
            mskIdNumber.Size = new Size(243, 34);
            mskIdNumber.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = Properties.Resources.search_1;
            btnSearch.Location = new Point(350, 102);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(48, 48);
            btnSearch.TabIndex = 3;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnCreateEmployee
            // 
            btnCreateEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreateEmployee.BackColor = Color.FromArgb(55, 60, 83);
            btnCreateEmployee.Cursor = Cursors.Hand;
            btnCreateEmployee.FlatAppearance.BorderSize = 0;
            btnCreateEmployee.FlatStyle = FlatStyle.Flat;
            btnCreateEmployee.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateEmployee.ForeColor = Color.FromArgb(235, 236, 238);
            btnCreateEmployee.Location = new Point(88, 190);
            btnCreateEmployee.Margin = new Padding(4, 5, 4, 5);
            btnCreateEmployee.Name = "btnCreateEmployee";
            btnCreateEmployee.Size = new Size(192, 56);
            btnCreateEmployee.TabIndex = 4;
            btnCreateEmployee.Text = "Crear Empleado";
            btnCreateEmployee.UseVisualStyleBackColor = false;
            btnCreateEmployee.Click += btnCreateEmployee_Click;
            // 
            // dgListEmployee
            // 
            dgListEmployee.AllowUserToDeleteRows = false;
            dgListEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgListEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgListEmployee.Columns.AddRange(new DataGridViewColumn[] { colIdNumber, colInss, colNames, colSurname, colPhone, colEmail });
            dgListEmployee.Location = new Point(88, 296);
            dgListEmployee.Margin = new Padding(4, 5, 4, 5);
            dgListEmployee.Name = "dgListEmployee";
            dgListEmployee.ReadOnly = true;
            dgListEmployee.RowHeadersWidth = 62;
            dgListEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgListEmployee.Size = new Size(1416, 607);
            dgListEmployee.TabIndex = 5;
            dgListEmployee.SelectionChanged += dgListEmployee_SelectionChanged;
            // 
            // colIdNumber
            // 
            colIdNumber.HeaderText = "Cédula";
            colIdNumber.MinimumWidth = 108;
            colIdNumber.Name = "colIdNumber";
            colIdNumber.ReadOnly = true;
            colIdNumber.Resizable = DataGridViewTriState.False;
            colIdNumber.Width = 200;
            // 
            // colInss
            // 
            colInss.HeaderText = "Inss";
            colInss.MinimumWidth = 108;
            colInss.Name = "colInss";
            colInss.ReadOnly = true;
            colInss.Resizable = DataGridViewTriState.False;
            colInss.Width = 160;
            // 
            // colNames
            // 
            colNames.HeaderText = "Nombre";
            colNames.MinimumWidth = 208;
            colNames.Name = "colNames";
            colNames.ReadOnly = true;
            colNames.Resizable = DataGridViewTriState.False;
            colNames.Width = 280;
            // 
            // colSurname
            // 
            colSurname.HeaderText = "Apellidos";
            colSurname.MinimumWidth = 208;
            colSurname.Name = "colSurname";
            colSurname.ReadOnly = true;
            colSurname.Resizable = DataGridViewTriState.False;
            colSurname.Width = 280;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "Teléfono";
            colPhone.MinimumWidth = 208;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            colPhone.Resizable = DataGridViewTriState.False;
            colPhone.Width = 208;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Correo";
            colEmail.MinimumWidth = 208;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.Width = 320;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(89, 93, 112);
            pnlTitle.Controls.Add(btnExit);
            pnlTitle.Controls.Add(lbltitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(1591, 56);
            pnlTitle.TabIndex = 6;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.Image = Properties.Resources.exit_f5f5f51;
            btnExit.Location = new Point(1539, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(48, 48);
            btnExit.TabIndex = 1;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitle.ForeColor = Color.FromArgb(235, 236, 238);
            lbltitle.Location = new Point(32, 13);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(215, 28);
            lbltitle.TabIndex = 0;
            lbltitle.Text = "Empleados Registrados";
            // 
            // btnEdit
            // 
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Image = Properties.Resources.edit_48;
            btnEdit.Location = new Point(1356, 190);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(56, 56);
            btnEdit.TabIndex = 7;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Image = Properties.Resources.delete_48;
            btnDelete.Location = new Point(1448, 190);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(56, 56);
            btnDelete.TabIndex = 8;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // EmployeeListForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(235, 236, 238);
            ClientSize = new Size(1591, 990);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(pnlTitle);
            Controls.Add(dgListEmployee);
            Controls.Add(btnCreateEmployee);
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
        private Button btnCreateEmployee;
        private DataGridView dgListEmployee;
        private Panel pnlTitle;
        private Label lbltitle;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridViewTextBoxColumn colIdNumber;
        private DataGridViewTextBoxColumn colInss;
        private DataGridViewTextBoxColumn colNames;
        private DataGridViewTextBoxColumn colSurname;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private Button btnExit;
    }
}