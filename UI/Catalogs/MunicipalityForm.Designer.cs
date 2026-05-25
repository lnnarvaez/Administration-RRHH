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
            label1 = new Label();
            textBox1 = new TextBox();
            dgvListMunicipality = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvListMunicipality).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 55);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(105, 23);
            textBox1.TabIndex = 1;
            // 
            // dgvListMunicipality
            // 
            dgvListMunicipality.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListMunicipality.Location = new Point(47, 92);
            dgvListMunicipality.Name = "dgvListMunicipality";
            dgvListMunicipality.Size = new Size(704, 294);
            dgvListMunicipality.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(136, 137, 145);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 40);
            panel1.TabIndex = 3;
            // 
            // MunicipalityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 238, 239);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dgvListMunicipality);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MunicipalityForm";
            Text = "MunicipalityForm";
            Load += MunicipalityForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListMunicipality).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private DataGridView dgvListMunicipality;
        private Panel panel1;
    }
}