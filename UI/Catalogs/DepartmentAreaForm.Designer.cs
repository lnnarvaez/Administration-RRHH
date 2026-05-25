namespace Administration_RRHH.UI.Catalogs
{
    partial class DepartmentAreaForm
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
            label1 = new Label();
            dgv_DepartmentList = new DataGridView();
            cmbFilter = new ComboBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_DepartmentList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 79);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // dgv_DepartmentList
            // 
            dgv_DepartmentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DepartmentList.Location = new Point(44, 117);
            dgv_DepartmentList.Name = "dgv_DepartmentList";
            dgv_DepartmentList.Size = new Size(566, 169);
            dgv_DepartmentList.TabIndex = 2;
            // 
            // cmbFilter
            // 
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "001", "401", "441", "501" });
            cmbFilter.Location = new Point(98, 71);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(114, 23);
            cmbFilter.TabIndex = 3;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(136, 137, 145);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 40);
            panel1.TabIndex = 4;
            // 
            // DepartmentAreaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 238, 239);
            ClientSize = new Size(653, 326);
            Controls.Add(panel1);
            Controls.Add(cmbFilter);
            Controls.Add(dgv_DepartmentList);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "DepartmentAreaForm";
            Text = "DepartmentAreaForm";
            Load += DepartmentAreaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_DepartmentList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_DepartmentList;
        private ComboBox cmbFilter;
        private Panel panel1;
    }
}