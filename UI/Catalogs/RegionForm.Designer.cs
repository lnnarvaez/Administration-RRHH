namespace Administration_RRHH.UI.Catalogs
{
    partial class RegionForm
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
            panel1 = new Panel();
            btnClosed = new Button();
            label1 = new Label();
            label2 = new Label();
            mskRegionCode = new MaskedTextBox();
            label3 = new Label();
            txtRegionName = new TextBox();
            chkEnable = new CheckBox();
            btnRegister = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(89, 93, 112);
            panel1.Controls.Add(btnClosed);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(671, 56);
            panel1.TabIndex = 0;
            // 
            // btnClosed
            // 
            btnClosed.Image = Properties.Resources.exit_f5f5f51;
            btnClosed.Location = new Point(616, 5);
            btnClosed.Name = "btnClosed";
            btnClosed.Size = new Size(48, 48);
            btnClosed.TabIndex = 1;
            btnClosed.UseVisualStyleBackColor = true;
            btnClosed.Click += btnClosed_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(235, 236, 238);
            label1.Location = new Point(31, 16);
            label1.Name = "label1";
            label1.Size = new Size(246, 25);
            label1.TabIndex = 0;
            label1.Text = "Departamentos Geográficos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(76, 131);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 1;
            label2.Text = "Código";
            // 
            // mskRegionCode
            // 
            mskRegionCode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mskRegionCode.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskRegionCode.Location = new Point(230, 125);
            mskRegionCode.Mask = "###";
            mskRegionCode.Name = "mskRegionCode";
            mskRegionCode.Size = new Size(361, 34);
            mskRegionCode.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 198);
            label3.Name = "label3";
            label3.Size = new Size(139, 28);
            label3.TabIndex = 3;
            label3.Text = "Departamento";
            // 
            // txtRegionName
            // 
            txtRegionName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRegionName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegionName.Location = new Point(230, 192);
            txtRegionName.Name = "txtRegionName";
            txtRegionName.Size = new Size(361, 34);
            txtRegionName.TabIndex = 4;
            // 
            // chkEnable
            // 
            chkEnable.AutoSize = true;
            chkEnable.Checked = true;
            chkEnable.CheckState = CheckState.Checked;
            chkEnable.Enabled = false;
            chkEnable.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkEnable.Location = new Point(497, 259);
            chkEnable.Name = "chkEnable";
            chkEnable.Size = new Size(94, 32);
            chkEnable.TabIndex = 5;
            chkEnable.Text = "Activo";
            chkEnable.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(96, 325);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(216, 48);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(375, 325);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(216, 48);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // RegionForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(235, 236, 238);
            ClientSize = new Size(671, 434);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(chkEnable);
            Controls.Add(txtRegionName);
            Controls.Add(label3);
            Controls.Add(mskRegionCode);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegionForm";
            Text = "RegionForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private MaskedTextBox mskRegionCode;
        private Label label3;
        private TextBox txtRegionName;
        private CheckBox chkEnable;
        private Button btnRegister;
        private Button btnCancel;
        private Button btnClosed;
    }
}