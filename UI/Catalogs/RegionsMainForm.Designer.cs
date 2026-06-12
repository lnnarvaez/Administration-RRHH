namespace Administration_RRHH.UI.Catalogs
{
    partial class RegionsMainForm
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
            dgDepartment = new DataGridView();
            colRegionCode = new DataGridViewTextBoxColumn();
            colRegionName = new DataGridViewTextBoxColumn();
            colActive = new DataGridViewCheckBoxColumn();
            btmExit = new Button();
            pnlTitle = new Panel();
            lblTitle = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgDepartment).BeginInit();
            pnlTitle.SuspendLayout();
            SuspendLayout();
            // 
            // dgDepartment
            // 
            dgDepartment.AllowUserToDeleteRows = false;
            dgDepartment.AllowUserToResizeRows = false;
            dgDepartment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgDepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDepartment.Columns.AddRange(new DataGridViewColumn[] { colRegionCode, colRegionName, colActive });
            dgDepartment.Cursor = Cursors.Hand;
            dgDepartment.Location = new Point(110, 235);
            dgDepartment.Name = "dgDepartment";
            dgDepartment.RowHeadersWidth = 62;
            dgDepartment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDepartment.ShowEditingIcon = false;
            dgDepartment.Size = new Size(769, 423);
            dgDepartment.TabIndex = 7;
            dgDepartment.SelectionChanged += dgDepartment_SelectionChanged;
            // 
            // colRegionCode
            // 
            colRegionCode.HeaderText = "Código";
            colRegionCode.MinimumWidth = 8;
            colRegionCode.Name = "colRegionCode";
            colRegionCode.ReadOnly = true;
            colRegionCode.Resizable = DataGridViewTriState.False;
            colRegionCode.Width = 160;
            // 
            // colRegionName
            // 
            colRegionName.HeaderText = "Departamento";
            colRegionName.MinimumWidth = 8;
            colRegionName.Name = "colRegionName";
            colRegionName.ReadOnly = true;
            colRegionName.Width = 420;
            // 
            // colActive
            // 
            colActive.HeaderText = "Activo";
            colActive.MinimumWidth = 100;
            colActive.Name = "colActive";
            colActive.ReadOnly = true;
            colActive.Resizable = DataGridViewTriState.True;
            colActive.SortMode = DataGridViewColumnSortMode.Automatic;
            colActive.Width = 124;
            // 
            // btmExit
            // 
            btmExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btmExit.Cursor = Cursors.Hand;
            btmExit.FlatAppearance.BorderSize = 0;
            btmExit.Image = Properties.Resources.exit_f5f5f51;
            btmExit.Location = new Point(929, 12);
            btmExit.Name = "btmExit";
            btmExit.Size = new Size(48, 48);
            btmExit.TabIndex = 12;
            btmExit.UseVisualStyleBackColor = true;
            btmExit.Click += btmExit_Click;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(89, 93, 112);
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Controls.Add(btmExit);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(989, 71);
            pnlTitle.TabIndex = 13;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(235, 236, 238);
            lblTitle.Location = new Point(24, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(262, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Catálogo Departamentos";
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Image = Properties.Resources.edit_48;
            btnEdit.Location = new Point(731, 141);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(56, 56);
            btnEdit.TabIndex = 14;
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Image = Properties.Resources.delete_48;
            btnDelete.Location = new Point(823, 141);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(56, 56);
            btnDelete.TabIndex = 15;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(55, 60, 83);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(235, 236, 238);
            button1.Location = new Point(110, 149);
            button1.Name = "button1";
            button1.Size = new Size(156, 48);
            button1.TabIndex = 16;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            // 
            // RegionsMainForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(235, 236, 238);
            ClientSize = new Size(989, 750);
            Controls.Add(button1);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(pnlTitle);
            Controls.Add(dgDepartment);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegionsMainForm";
            Text = "RegionsMainForm";
            Load += RegionsMainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgDepartment).EndInit();
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgDepartment;
        private Button btmExit;
        private Panel pnlTitle;
        private Label lblTitle;
        private Button btnEdit;
        private Button btnDelete;
        private Button button1;
        private DataGridViewTextBoxColumn colRegionCode;
        private DataGridViewTextBoxColumn colRegionName;
        private DataGridViewCheckBoxColumn colActive;
    }
}