namespace Administration_RRHH.UI.Catalogs
{
    partial class MunicipalityMainForm
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
            pnlTitle.Size = new Size(1174, 56);
            pnlTitle.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Image = Properties.Resources.exit_f5f5f51;
            btnExit.Location = new Point(1119, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(48, 48);
            btnExit.TabIndex = 11;
            btnExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(235, 236, 238);
            label1.Location = new Point(45, 13);
            label1.Margin = new Padding(4);
            label1.Name = "label1";
            label1.Size = new Size(217, 30);
            label1.TabIndex = 0;
            label1.Text = "Catálogo Municipios";
            // 
            // MunicipalityMainForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1174, 681);
            Controls.Add(pnlTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MunicipalityMainForm";
            Text = "MunicipalityMainForm";
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Button btnExit;
        private Label label1;
    }
}