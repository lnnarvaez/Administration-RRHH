namespace Administration_RRHH.UI
{
    partial class AuthenticationForm
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
            pcLogo = new PictureBox();
            pnlTitle = new Panel();
            lblTitle = new Label();
            lblWelcome = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btnLogOn = new Button();
            btnRecoverAccess = new Button();
            pcIconUser = new PictureBox();
            pcIconsPass = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcLogo).BeginInit();
            pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcIconUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcIconsPass).BeginInit();
            SuspendLayout();
            // 
            // pcLogo
            // 
            pcLogo.Image = Properties.Resources.logo_syst;
            pcLogo.Location = new Point(156, 70);
            pcLogo.Name = "pcLogo";
            pcLogo.Size = new Size(108, 66);
            pcLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcLogo.TabIndex = 0;
            pcLogo.TabStop = false;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(34, 37, 51);
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(420, 40);
            pnlTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(246, 246, 247);
            lblTitle.Location = new Point(15, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(90, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TALENTHQ";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(39, 42, 58);
            lblWelcome.Location = new Point(143, 162);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(135, 32);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Bienvenido";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(96, 229);
            txtUser.Margin = new Padding(4);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Ingresar Usuario";
            txtUser.Size = new Size(268, 27);
            txtUser.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(96, 286);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '.';
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(268, 27);
            txtPassword.TabIndex = 4;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogOn
            // 
            btnLogOn.BackColor = Color.FromArgb(34, 37, 51);
            btnLogOn.Cursor = Cursors.Hand;
            btnLogOn.FlatStyle = FlatStyle.Flat;
            btnLogOn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogOn.ForeColor = Color.FromArgb(246, 246, 247);
            btnLogOn.Location = new Point(57, 354);
            btnLogOn.Name = "btnLogOn";
            btnLogOn.Size = new Size(307, 41);
            btnLogOn.TabIndex = 5;
            btnLogOn.Text = "Ingresar";
            btnLogOn.UseVisualStyleBackColor = false;
            btnLogOn.Click += btnLogOn_Click;
            // 
            // btnRecoverAccess
            // 
            btnRecoverAccess.Cursor = Cursors.Hand;
            btnRecoverAccess.FlatAppearance.BorderSize = 0;
            btnRecoverAccess.FlatStyle = FlatStyle.Flat;
            btnRecoverAccess.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRecoverAccess.ForeColor = Color.FromArgb(34, 37, 51);
            btnRecoverAccess.Location = new Point(57, 420);
            btnRecoverAccess.Name = "btnRecoverAccess";
            btnRecoverAccess.Size = new Size(296, 40);
            btnRecoverAccess.TabIndex = 6;
            btnRecoverAccess.Text = "¿No puede ingresar?";
            btnRecoverAccess.UseVisualStyleBackColor = true;
            // 
            // pcIconUser
            // 
            pcIconUser.Image = Properties.Resources.user_circle;
            pcIconUser.Location = new Point(57, 224);
            pcIconUser.Name = "pcIconUser";
            pcIconUser.Size = new Size(32, 32);
            pcIconUser.SizeMode = PictureBoxSizeMode.CenterImage;
            pcIconUser.TabIndex = 7;
            pcIconUser.TabStop = false;
            // 
            // pcIconsPass
            // 
            pcIconsPass.Image = Properties.Resources.llave;
            pcIconsPass.Location = new Point(57, 281);
            pcIconsPass.Name = "pcIconsPass";
            pcIconsPass.Size = new Size(32, 32);
            pcIconsPass.SizeMode = PictureBoxSizeMode.CenterImage;
            pcIconsPass.TabIndex = 8;
            pcIconsPass.TabStop = false;
            // 
            // AuthenticationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 238, 239);
            ClientSize = new Size(420, 494);
            Controls.Add(pcIconsPass);
            Controls.Add(pcIconUser);
            Controls.Add(btnRecoverAccess);
            Controls.Add(btnLogOn);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(lblWelcome);
            Controls.Add(pnlTitle);
            Controls.Add(pcLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AuthenticationForm";
            ShowIcon = false;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pcLogo).EndInit();
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcIconUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcIconsPass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcLogo;
        private Panel pnlTitle;
        private Label lblTitle;
        private Label lblWelcome;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnLogOn;
        private Button btnRecoverAccess;
        private PictureBox pcIconUser;
        private PictureBox pcIconsPass;
    }
}