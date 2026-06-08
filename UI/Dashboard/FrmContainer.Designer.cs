namespace Administration_RRHH.UI.Dashboard
{
    partial class FrmContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContainer));
            pnlHeaderTopMain = new Panel();
            btnSideBarMenu = new Button();
            lblUserLogIn = new Label();
            pc_UserLogin = new PictureBox();
            lblTitleSystem = new Label();
            pcLogo = new PictureBox();
            pnlBreadcrumbs = new Panel();
            btnExit = new Button();
            lblItems = new Label();
            lblSubMenu = new Label();
            lblHome = new Label();
            pnlSideBar = new Panel();
            pnlSubMenuAdmin = new Panel();
            btnAdmin2 = new Button();
            btnAdmin1 = new Button();
            BtnUser = new Button();
            btnAdmin = new Button();
            pnlSubMenuReport = new Panel();
            btnReport3 = new Button();
            btnReport2 = new Button();
            btnReport1 = new Button();
            btnReport = new Button();
            pnlSubMenuPayroll = new Panel();
            btnPayStubs = new Button();
            btnProcessPayroll = new Button();
            btnPayroll = new Button();
            pnlSubMenuContract = new Panel();
            btnPromoter = new Button();
            btnActiveContracts = new Button();
            btnContract = new Button();
            pnlSubMenuEmployee = new Panel();
            btnTrainingManagement = new Button();
            btnEmployeeFile = new Button();
            btnEmployees = new Button();
            pnlCatalogSubMenu = new Panel();
            btnMunicipality = new Button();
            btnDepartment = new Button();
            btnJobCategory = new Button();
            btnCatalog = new Button();
            pnlHeaderNav = new Panel();
            btnHome = new Button();
            pnlContainer = new Panel();
            pnlHeaderTopMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pc_UserLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcLogo).BeginInit();
            pnlBreadcrumbs.SuspendLayout();
            pnlSideBar.SuspendLayout();
            pnlSubMenuAdmin.SuspendLayout();
            pnlSubMenuReport.SuspendLayout();
            pnlSubMenuPayroll.SuspendLayout();
            pnlSubMenuContract.SuspendLayout();
            pnlSubMenuEmployee.SuspendLayout();
            pnlCatalogSubMenu.SuspendLayout();
            pnlHeaderNav.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeaderTopMain
            // 
            pnlHeaderTopMain.BackColor = Color.FromArgb(39, 42, 58);
            pnlHeaderTopMain.BorderStyle = BorderStyle.FixedSingle;
            pnlHeaderTopMain.Controls.Add(btnSideBarMenu);
            pnlHeaderTopMain.Controls.Add(lblUserLogIn);
            pnlHeaderTopMain.Controls.Add(pc_UserLogin);
            pnlHeaderTopMain.Controls.Add(lblTitleSystem);
            pnlHeaderTopMain.Controls.Add(pcLogo);
            pnlHeaderTopMain.Dock = DockStyle.Top;
            pnlHeaderTopMain.Location = new Point(0, 0);
            pnlHeaderTopMain.Name = "pnlHeaderTopMain";
            pnlHeaderTopMain.Size = new Size(1767, 95);
            pnlHeaderTopMain.TabIndex = 0;
            // 
            // btnSideBarMenu
            // 
            btnSideBarMenu.Cursor = Cursors.Hand;
            btnSideBarMenu.FlatAppearance.BorderSize = 0;
            btnSideBarMenu.FlatStyle = FlatStyle.Flat;
            btnSideBarMenu.Image = Properties.Resources.menu_icons1;
            btnSideBarMenu.Location = new Point(15, 15);
            btnSideBarMenu.Name = "btnSideBarMenu";
            btnSideBarMenu.Size = new Size(57, 57);
            btnSideBarMenu.TabIndex = 4;
            btnSideBarMenu.UseVisualStyleBackColor = true;
            btnSideBarMenu.Click += btnSideBarMenu_Click;
            // 
            // lblUserLogIn
            // 
            lblUserLogIn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUserLogIn.AutoSize = true;
            lblUserLogIn.ForeColor = Color.FromArgb(251, 251, 251);
            lblUserLogIn.Location = new Point(1576, 39);
            lblUserLogIn.Margin = new Padding(10, 14, 45, 14);
            lblUserLogIn.Name = "lblUserLogIn";
            lblUserLogIn.Size = new Size(163, 25);
            lblUserLogIn.TabIndex = 3;
            lblUserLogIn.Text = "Usuario Conectado";
            // 
            // pc_UserLogin
            // 
            pc_UserLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pc_UserLogin.Cursor = Cursors.Hand;
            pc_UserLogin.Image = Properties.Resources.admin_user_32;
            pc_UserLogin.Location = new Point(1495, 14);
            pc_UserLogin.Margin = new Padding(3, 4, 3, 4);
            pc_UserLogin.Name = "pc_UserLogin";
            pc_UserLogin.Size = new Size(66, 76);
            pc_UserLogin.TabIndex = 2;
            pc_UserLogin.TabStop = false;
            // 
            // lblTitleSystem
            // 
            lblTitleSystem.AutoSize = true;
            lblTitleSystem.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleSystem.ForeColor = Color.FromArgb(251, 251, 251);
            lblTitleSystem.Location = new Point(327, 27);
            lblTitleSystem.Name = "lblTitleSystem";
            lblTitleSystem.Size = new Size(537, 38);
            lblTitleSystem.TabIndex = 1;
            lblTitleSystem.Text = "Sistema de Gestión de Recursos Humanos";
            // 
            // pcLogo
            // 
            pcLogo.Image = (Image)resources.GetObject("pcLogo.Image");
            pcLogo.Location = new Point(213, 10);
            pcLogo.Name = "pcLogo";
            pcLogo.Size = new Size(106, 74);
            pcLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pcLogo.TabIndex = 0;
            pcLogo.TabStop = false;
            // 
            // pnlBreadcrumbs
            // 
            pnlBreadcrumbs.BackColor = Color.FromArgb(237, 238, 239);
            pnlBreadcrumbs.Controls.Add(btnExit);
            pnlBreadcrumbs.Controls.Add(lblItems);
            pnlBreadcrumbs.Controls.Add(lblSubMenu);
            pnlBreadcrumbs.Controls.Add(lblHome);
            pnlBreadcrumbs.Cursor = Cursors.Hand;
            pnlBreadcrumbs.Dock = DockStyle.Top;
            pnlBreadcrumbs.Location = new Point(359, 95);
            pnlBreadcrumbs.Margin = new Padding(6, 4, 6, 4);
            pnlBreadcrumbs.Name = "pnlBreadcrumbs";
            pnlBreadcrumbs.Padding = new Padding(6);
            pnlBreadcrumbs.Size = new Size(1408, 72);
            pnlBreadcrumbs.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(34, 37, 51);
            btnExit.Image = Properties.Resources.exit_f5f5f51;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(1203, 14);
            btnExit.Margin = new Padding(0, 6, 84, 6);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(6);
            btnExit.Size = new Size(132, 48);
            btnExit.TabIndex = 3;
            btnExit.Text = "Salir";
            btnExit.TextAlign = ContentAlignment.MiddleRight;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblItems
            // 
            lblItems.AutoSize = true;
            lblItems.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItems.ForeColor = Color.FromArgb(34, 37, 51);
            lblItems.Location = new Point(188, 20);
            lblItems.Margin = new Padding(6, 0, 6, 0);
            lblItems.Name = "lblItems";
            lblItems.Size = new Size(98, 32);
            lblItems.TabIndex = 2;
            lblItems.Text = "/ Items ";
            // 
            // lblSubMenu
            // 
            lblSubMenu.AutoSize = true;
            lblSubMenu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubMenu.ForeColor = Color.FromArgb(34, 37, 51);
            lblSubMenu.Location = new Point(112, 20);
            lblSubMenu.Margin = new Padding(6, 0, 0, 0);
            lblSubMenu.Name = "lblSubMenu";
            lblSubMenu.Size = new Size(77, 32);
            lblSubMenu.TabIndex = 1;
            lblSubMenu.Text = "Menu";
            // 
            // lblHome
            // 
            lblHome.AutoSize = true;
            lblHome.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHome.ForeColor = Color.FromArgb(34, 37, 51);
            lblHome.Location = new Point(32, 21);
            lblHome.Margin = new Padding(12, 0, 0, 0);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(87, 31);
            lblHome.TabIndex = 0;
            lblHome.Text = "Inicio /";
            // 
            // pnlSideBar
            // 
            pnlSideBar.BackColor = Color.FromArgb(34, 37, 51);
            pnlSideBar.BorderStyle = BorderStyle.FixedSingle;
            pnlSideBar.Controls.Add(pnlSubMenuAdmin);
            pnlSideBar.Controls.Add(btnAdmin);
            pnlSideBar.Controls.Add(pnlSubMenuReport);
            pnlSideBar.Controls.Add(btnReport);
            pnlSideBar.Controls.Add(pnlSubMenuPayroll);
            pnlSideBar.Controls.Add(btnPayroll);
            pnlSideBar.Controls.Add(pnlSubMenuContract);
            pnlSideBar.Controls.Add(btnContract);
            pnlSideBar.Controls.Add(pnlSubMenuEmployee);
            pnlSideBar.Controls.Add(btnEmployees);
            pnlSideBar.Controls.Add(pnlCatalogSubMenu);
            pnlSideBar.Controls.Add(btnCatalog);
            pnlSideBar.Controls.Add(pnlHeaderNav);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Location = new Point(0, 95);
            pnlSideBar.Margin = new Padding(0);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(359, 1179);
            pnlSideBar.TabIndex = 4;
            // 
            // pnlSubMenuAdmin
            // 
            pnlSubMenuAdmin.BackColor = Color.FromArgb(89, 93, 112);
            pnlSubMenuAdmin.Controls.Add(btnAdmin2);
            pnlSubMenuAdmin.Controls.Add(btnAdmin1);
            pnlSubMenuAdmin.Controls.Add(BtnUser);
            pnlSubMenuAdmin.Dock = DockStyle.Top;
            pnlSubMenuAdmin.Location = new Point(0, 1204);
            pnlSubMenuAdmin.Margin = new Padding(0);
            pnlSubMenuAdmin.Name = "pnlSubMenuAdmin";
            pnlSubMenuAdmin.Size = new Size(357, 177);
            pnlSubMenuAdmin.TabIndex = 12;
            // 
            // btnAdmin2
            // 
            btnAdmin2.Cursor = Cursors.Hand;
            btnAdmin2.Dock = DockStyle.Top;
            btnAdmin2.FlatAppearance.BorderSize = 0;
            btnAdmin2.FlatStyle = FlatStyle.Flat;
            btnAdmin2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdmin2.ForeColor = Color.FromArgb(246, 246, 247);
            btnAdmin2.Location = new Point(0, 96);
            btnAdmin2.MaximumSize = new Size(288, 48);
            btnAdmin2.MinimumSize = new Size(285, 48);
            btnAdmin2.Name = "btnAdmin2";
            btnAdmin2.Padding = new Padding(48, 0, 0, 0);
            btnAdmin2.Size = new Size(288, 48);
            btnAdmin2.TabIndex = 2;
            btnAdmin2.Text = "Admin 2";
            btnAdmin2.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmin2.UseVisualStyleBackColor = true;
            // 
            // btnAdmin1
            // 
            btnAdmin1.Cursor = Cursors.Hand;
            btnAdmin1.Dock = DockStyle.Top;
            btnAdmin1.FlatAppearance.BorderSize = 0;
            btnAdmin1.FlatStyle = FlatStyle.Flat;
            btnAdmin1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdmin1.ForeColor = Color.FromArgb(246, 246, 247);
            btnAdmin1.Location = new Point(0, 48);
            btnAdmin1.MaximumSize = new Size(288, 48);
            btnAdmin1.MinimumSize = new Size(285, 48);
            btnAdmin1.Name = "btnAdmin1";
            btnAdmin1.Padding = new Padding(48, 0, 0, 0);
            btnAdmin1.Size = new Size(288, 48);
            btnAdmin1.TabIndex = 1;
            btnAdmin1.Text = "Admin 1";
            btnAdmin1.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmin1.UseVisualStyleBackColor = true;
            // 
            // BtnUser
            // 
            BtnUser.Cursor = Cursors.Hand;
            BtnUser.Dock = DockStyle.Top;
            BtnUser.FlatAppearance.BorderSize = 0;
            BtnUser.FlatStyle = FlatStyle.Flat;
            BtnUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnUser.ForeColor = Color.FromArgb(246, 246, 247);
            BtnUser.Location = new Point(0, 0);
            BtnUser.MaximumSize = new Size(288, 48);
            BtnUser.MinimumSize = new Size(285, 48);
            BtnUser.Name = "BtnUser";
            BtnUser.Padding = new Padding(48, 0, 0, 0);
            BtnUser.Size = new Size(288, 48);
            BtnUser.TabIndex = 0;
            BtnUser.Text = "Usuarios";
            BtnUser.TextAlign = ContentAlignment.MiddleLeft;
            BtnUser.UseVisualStyleBackColor = true;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.FromArgb(55, 60, 83);
            btnAdmin.Cursor = Cursors.Hand;
            btnAdmin.Dock = DockStyle.Top;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = Color.FromArgb(235, 236, 238);
            btnAdmin.Location = new Point(0, 1141);
            btnAdmin.Margin = new Padding(0);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Padding = new Padding(42, 0, 0, 0);
            btnAdmin.Size = new Size(357, 63);
            btnAdmin.TabIndex = 11;
            btnAdmin.Text = "Administrar";
            btnAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // pnlSubMenuReport
            // 
            pnlSubMenuReport.BackColor = Color.FromArgb(89, 93, 112);
            pnlSubMenuReport.Controls.Add(btnReport3);
            pnlSubMenuReport.Controls.Add(btnReport2);
            pnlSubMenuReport.Controls.Add(btnReport1);
            pnlSubMenuReport.Dock = DockStyle.Top;
            pnlSubMenuReport.Location = new Point(0, 963);
            pnlSubMenuReport.Margin = new Padding(0);
            pnlSubMenuReport.Name = "pnlSubMenuReport";
            pnlSubMenuReport.Size = new Size(357, 178);
            pnlSubMenuReport.TabIndex = 10;
            // 
            // btnReport3
            // 
            btnReport3.Cursor = Cursors.Hand;
            btnReport3.Dock = DockStyle.Top;
            btnReport3.FlatAppearance.BorderSize = 0;
            btnReport3.FlatStyle = FlatStyle.Flat;
            btnReport3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReport3.ForeColor = Color.FromArgb(246, 246, 247);
            btnReport3.Location = new Point(0, 96);
            btnReport3.MaximumSize = new Size(288, 48);
            btnReport3.MinimumSize = new Size(288, 48);
            btnReport3.Name = "btnReport3";
            btnReport3.Padding = new Padding(48, 0, 0, 0);
            btnReport3.Size = new Size(288, 48);
            btnReport3.TabIndex = 2;
            btnReport3.Text = "Reporte 3";
            btnReport3.TextAlign = ContentAlignment.MiddleLeft;
            btnReport3.UseVisualStyleBackColor = true;
            // 
            // btnReport2
            // 
            btnReport2.Cursor = Cursors.Hand;
            btnReport2.Dock = DockStyle.Top;
            btnReport2.FlatAppearance.BorderSize = 0;
            btnReport2.FlatStyle = FlatStyle.Flat;
            btnReport2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReport2.ForeColor = Color.FromArgb(246, 246, 247);
            btnReport2.Location = new Point(0, 48);
            btnReport2.MaximumSize = new Size(288, 48);
            btnReport2.MinimumSize = new Size(288, 48);
            btnReport2.Name = "btnReport2";
            btnReport2.Padding = new Padding(48, 0, 0, 0);
            btnReport2.Size = new Size(288, 48);
            btnReport2.TabIndex = 1;
            btnReport2.Text = "Reporte 2";
            btnReport2.TextAlign = ContentAlignment.MiddleLeft;
            btnReport2.UseVisualStyleBackColor = true;
            // 
            // btnReport1
            // 
            btnReport1.Cursor = Cursors.Hand;
            btnReport1.Dock = DockStyle.Top;
            btnReport1.FlatAppearance.BorderSize = 0;
            btnReport1.FlatStyle = FlatStyle.Flat;
            btnReport1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReport1.ForeColor = Color.FromArgb(246, 246, 247);
            btnReport1.Location = new Point(0, 0);
            btnReport1.MaximumSize = new Size(288, 48);
            btnReport1.MinimumSize = new Size(288, 48);
            btnReport1.Name = "btnReport1";
            btnReport1.Padding = new Padding(48, 0, 0, 0);
            btnReport1.Size = new Size(288, 48);
            btnReport1.TabIndex = 0;
            btnReport1.Text = "Reporte 1";
            btnReport1.TextAlign = ContentAlignment.MiddleLeft;
            btnReport1.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.FromArgb(55, 60, 83);
            btnReport.Cursor = Cursors.Hand;
            btnReport.Dock = DockStyle.Top;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReport.ForeColor = Color.FromArgb(235, 236, 238);
            btnReport.Location = new Point(0, 900);
            btnReport.Margin = new Padding(0);
            btnReport.Name = "btnReport";
            btnReport.Padding = new Padding(42, 0, 0, 0);
            btnReport.Size = new Size(357, 63);
            btnReport.TabIndex = 9;
            btnReport.Text = "Reportes";
            btnReport.TextAlign = ContentAlignment.MiddleLeft;
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // pnlSubMenuPayroll
            // 
            pnlSubMenuPayroll.BackColor = Color.FromArgb(89, 93, 112);
            pnlSubMenuPayroll.Controls.Add(btnPayStubs);
            pnlSubMenuPayroll.Controls.Add(btnProcessPayroll);
            pnlSubMenuPayroll.Dock = DockStyle.Top;
            pnlSubMenuPayroll.Location = new Point(0, 771);
            pnlSubMenuPayroll.Margin = new Padding(0);
            pnlSubMenuPayroll.Name = "pnlSubMenuPayroll";
            pnlSubMenuPayroll.Size = new Size(357, 129);
            pnlSubMenuPayroll.TabIndex = 8;
            // 
            // btnPayStubs
            // 
            btnPayStubs.Cursor = Cursors.Hand;
            btnPayStubs.Dock = DockStyle.Top;
            btnPayStubs.FlatAppearance.BorderSize = 0;
            btnPayStubs.FlatStyle = FlatStyle.Flat;
            btnPayStubs.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPayStubs.ForeColor = Color.FromArgb(246, 246, 247);
            btnPayStubs.Location = new Point(0, 57);
            btnPayStubs.MinimumSize = new Size(285, 48);
            btnPayStubs.Name = "btnPayStubs";
            btnPayStubs.Padding = new Padding(56, 0, 0, 0);
            btnPayStubs.Size = new Size(357, 48);
            btnPayStubs.TabIndex = 1;
            btnPayStubs.Text = "Colillas de Pago";
            btnPayStubs.TextAlign = ContentAlignment.MiddleLeft;
            btnPayStubs.UseVisualStyleBackColor = true;
            // 
            // btnProcessPayroll
            // 
            btnProcessPayroll.Cursor = Cursors.Hand;
            btnProcessPayroll.Dock = DockStyle.Top;
            btnProcessPayroll.FlatAppearance.BorderSize = 0;
            btnProcessPayroll.FlatStyle = FlatStyle.Flat;
            btnProcessPayroll.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProcessPayroll.ForeColor = Color.FromArgb(246, 246, 247);
            btnProcessPayroll.Location = new Point(0, 0);
            btnProcessPayroll.MinimumSize = new Size(285, 48);
            btnProcessPayroll.Name = "btnProcessPayroll";
            btnProcessPayroll.Padding = new Padding(56, 0, 0, 0);
            btnProcessPayroll.Size = new Size(357, 57);
            btnProcessPayroll.TabIndex = 0;
            btnProcessPayroll.Text = "Procesar Nominas";
            btnProcessPayroll.TextAlign = ContentAlignment.MiddleLeft;
            btnProcessPayroll.UseVisualStyleBackColor = true;
            // 
            // btnPayroll
            // 
            btnPayroll.BackColor = Color.FromArgb(55, 60, 83);
            btnPayroll.Cursor = Cursors.Hand;
            btnPayroll.Dock = DockStyle.Top;
            btnPayroll.FlatAppearance.BorderSize = 0;
            btnPayroll.FlatStyle = FlatStyle.Flat;
            btnPayroll.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPayroll.ForeColor = Color.FromArgb(235, 236, 238);
            btnPayroll.Location = new Point(0, 708);
            btnPayroll.Margin = new Padding(3, 4, 3, 4);
            btnPayroll.Name = "btnPayroll";
            btnPayroll.Padding = new Padding(42, 0, 0, 0);
            btnPayroll.Size = new Size(357, 63);
            btnPayroll.TabIndex = 7;
            btnPayroll.Text = "Nominas";
            btnPayroll.TextAlign = ContentAlignment.MiddleLeft;
            btnPayroll.UseVisualStyleBackColor = false;
            btnPayroll.Click += btnPayroll_Click;
            // 
            // pnlSubMenuContract
            // 
            pnlSubMenuContract.BackColor = Color.FromArgb(89, 93, 112);
            pnlSubMenuContract.Controls.Add(btnPromoter);
            pnlSubMenuContract.Controls.Add(btnActiveContracts);
            pnlSubMenuContract.Dock = DockStyle.Top;
            pnlSubMenuContract.Location = new Point(0, 588);
            pnlSubMenuContract.Margin = new Padding(0);
            pnlSubMenuContract.Name = "pnlSubMenuContract";
            pnlSubMenuContract.Size = new Size(357, 120);
            pnlSubMenuContract.TabIndex = 6;
            // 
            // btnPromoter
            // 
            btnPromoter.Cursor = Cursors.Hand;
            btnPromoter.Dock = DockStyle.Top;
            btnPromoter.FlatAppearance.BorderSize = 0;
            btnPromoter.FlatStyle = FlatStyle.Flat;
            btnPromoter.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPromoter.ForeColor = Color.FromArgb(246, 246, 247);
            btnPromoter.Location = new Point(0, 48);
            btnPromoter.MaximumSize = new Size(288, 48);
            btnPromoter.MinimumSize = new Size(285, 48);
            btnPromoter.Name = "btnPromoter";
            btnPromoter.Padding = new Padding(48, 0, 0, 0);
            btnPromoter.Size = new Size(288, 48);
            btnPromoter.TabIndex = 1;
            btnPromoter.Text = "Promotoria";
            btnPromoter.TextAlign = ContentAlignment.MiddleLeft;
            btnPromoter.UseVisualStyleBackColor = true;
            // 
            // btnActiveContracts
            // 
            btnActiveContracts.Cursor = Cursors.Hand;
            btnActiveContracts.Dock = DockStyle.Top;
            btnActiveContracts.FlatAppearance.BorderSize = 0;
            btnActiveContracts.FlatStyle = FlatStyle.Flat;
            btnActiveContracts.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActiveContracts.ForeColor = Color.FromArgb(246, 246, 247);
            btnActiveContracts.Location = new Point(0, 0);
            btnActiveContracts.MaximumSize = new Size(288, 48);
            btnActiveContracts.MinimumSize = new Size(285, 48);
            btnActiveContracts.Name = "btnActiveContracts";
            btnActiveContracts.Padding = new Padding(48, 0, 0, 0);
            btnActiveContracts.Size = new Size(288, 48);
            btnActiveContracts.TabIndex = 0;
            btnActiveContracts.Text = "Contratación";
            btnActiveContracts.TextAlign = ContentAlignment.MiddleLeft;
            btnActiveContracts.UseVisualStyleBackColor = true;
            // 
            // btnContract
            // 
            btnContract.BackColor = Color.FromArgb(55, 60, 83);
            btnContract.Cursor = Cursors.Hand;
            btnContract.Dock = DockStyle.Top;
            btnContract.FlatAppearance.BorderSize = 0;
            btnContract.FlatStyle = FlatStyle.Flat;
            btnContract.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnContract.ForeColor = Color.FromArgb(235, 236, 238);
            btnContract.Location = new Point(0, 525);
            btnContract.Name = "btnContract";
            btnContract.Padding = new Padding(42, 0, 0, 0);
            btnContract.Size = new Size(357, 63);
            btnContract.TabIndex = 5;
            btnContract.Text = "Contrataciones";
            btnContract.TextAlign = ContentAlignment.MiddleLeft;
            btnContract.UseVisualStyleBackColor = false;
            btnContract.Click += btnContract_Click;
            // 
            // pnlSubMenuEmployee
            // 
            pnlSubMenuEmployee.BackColor = Color.FromArgb(89, 93, 112);
            pnlSubMenuEmployee.Controls.Add(btnTrainingManagement);
            pnlSubMenuEmployee.Controls.Add(btnEmployeeFile);
            pnlSubMenuEmployee.Dock = DockStyle.Top;
            pnlSubMenuEmployee.Location = new Point(0, 399);
            pnlSubMenuEmployee.Margin = new Padding(0);
            pnlSubMenuEmployee.Name = "pnlSubMenuEmployee";
            pnlSubMenuEmployee.Size = new Size(357, 126);
            pnlSubMenuEmployee.TabIndex = 4;
            // 
            // btnTrainingManagement
            // 
            btnTrainingManagement.Cursor = Cursors.Hand;
            btnTrainingManagement.Dock = DockStyle.Top;
            btnTrainingManagement.FlatAppearance.BorderSize = 0;
            btnTrainingManagement.FlatStyle = FlatStyle.Flat;
            btnTrainingManagement.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTrainingManagement.ForeColor = Color.FromArgb(246, 246, 247);
            btnTrainingManagement.Location = new Point(0, 48);
            btnTrainingManagement.MaximumSize = new Size(288, 48);
            btnTrainingManagement.MinimumSize = new Size(285, 48);
            btnTrainingManagement.Name = "btnTrainingManagement";
            btnTrainingManagement.Padding = new Padding(48, 0, 0, 0);
            btnTrainingManagement.Size = new Size(288, 48);
            btnTrainingManagement.TabIndex = 1;
            btnTrainingManagement.Text = "Expedientes de Empleados";
            btnTrainingManagement.TextAlign = ContentAlignment.MiddleLeft;
            btnTrainingManagement.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeFile
            // 
            btnEmployeeFile.Cursor = Cursors.Hand;
            btnEmployeeFile.Dock = DockStyle.Top;
            btnEmployeeFile.FlatAppearance.BorderSize = 0;
            btnEmployeeFile.FlatStyle = FlatStyle.Flat;
            btnEmployeeFile.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmployeeFile.ForeColor = Color.FromArgb(246, 246, 247);
            btnEmployeeFile.Location = new Point(0, 0);
            btnEmployeeFile.MaximumSize = new Size(288, 48);
            btnEmployeeFile.MinimumSize = new Size(285, 48);
            btnEmployeeFile.Name = "btnEmployeeFile";
            btnEmployeeFile.Padding = new Padding(48, 0, 0, 0);
            btnEmployeeFile.Size = new Size(288, 48);
            btnEmployeeFile.TabIndex = 0;
            btnEmployeeFile.Text = "Registro Empleado";
            btnEmployeeFile.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployeeFile.UseVisualStyleBackColor = true;
            // 
            // btnEmployees
            // 
            btnEmployees.BackColor = Color.FromArgb(55, 60, 83);
            btnEmployees.Cursor = Cursors.Hand;
            btnEmployees.Dock = DockStyle.Top;
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmployees.ForeColor = Color.FromArgb(235, 236, 238);
            btnEmployees.Location = new Point(0, 336);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Padding = new Padding(42, 0, 0, 0);
            btnEmployees.Size = new Size(357, 63);
            btnEmployees.TabIndex = 3;
            btnEmployees.Text = "Empleados";
            btnEmployees.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployees.UseVisualStyleBackColor = false;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // pnlCatalogSubMenu
            // 
            pnlCatalogSubMenu.BackColor = Color.FromArgb(89, 93, 112);
            pnlCatalogSubMenu.Controls.Add(btnMunicipality);
            pnlCatalogSubMenu.Controls.Add(btnDepartment);
            pnlCatalogSubMenu.Controls.Add(btnJobCategory);
            pnlCatalogSubMenu.Dock = DockStyle.Top;
            pnlCatalogSubMenu.Location = new Point(0, 153);
            pnlCatalogSubMenu.Margin = new Padding(0);
            pnlCatalogSubMenu.Name = "pnlCatalogSubMenu";
            pnlCatalogSubMenu.Size = new Size(357, 183);
            pnlCatalogSubMenu.TabIndex = 2;
            // 
            // btnMunicipality
            // 
            btnMunicipality.Cursor = Cursors.Hand;
            btnMunicipality.Dock = DockStyle.Top;
            btnMunicipality.FlatAppearance.BorderSize = 0;
            btnMunicipality.FlatStyle = FlatStyle.Flat;
            btnMunicipality.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMunicipality.ForeColor = Color.FromArgb(246, 246, 247);
            btnMunicipality.Location = new Point(0, 126);
            btnMunicipality.Name = "btnMunicipality";
            btnMunicipality.Padding = new Padding(48, 0, 0, 0);
            btnMunicipality.Size = new Size(357, 63);
            btnMunicipality.TabIndex = 2;
            btnMunicipality.Text = "Municipios";
            btnMunicipality.TextAlign = ContentAlignment.MiddleLeft;
            btnMunicipality.UseVisualStyleBackColor = true;
            btnMunicipality.Click += btnMunicipality_Click;
            // 
            // btnDepartment
            // 
            btnDepartment.Cursor = Cursors.Hand;
            btnDepartment.Dock = DockStyle.Top;
            btnDepartment.FlatAppearance.BorderSize = 0;
            btnDepartment.FlatStyle = FlatStyle.Flat;
            btnDepartment.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDepartment.ForeColor = Color.FromArgb(246, 246, 248);
            btnDepartment.Location = new Point(0, 63);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Padding = new Padding(48, 0, 0, 0);
            btnDepartment.Size = new Size(357, 63);
            btnDepartment.TabIndex = 1;
            btnDepartment.Text = "Geo - Departamentos ";
            btnDepartment.TextAlign = ContentAlignment.MiddleLeft;
            btnDepartment.UseVisualStyleBackColor = true;
            btnDepartment.Click += btnDepartment_Click;
            // 
            // btnJobCategory
            // 
            btnJobCategory.Cursor = Cursors.Hand;
            btnJobCategory.Dock = DockStyle.Top;
            btnJobCategory.FlatAppearance.BorderSize = 0;
            btnJobCategory.FlatStyle = FlatStyle.Flat;
            btnJobCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnJobCategory.ForeColor = Color.FromArgb(246, 247, 248);
            btnJobCategory.Location = new Point(0, 0);
            btnJobCategory.Margin = new Padding(0);
            btnJobCategory.Name = "btnJobCategory";
            btnJobCategory.Padding = new Padding(48, 0, 0, 0);
            btnJobCategory.Size = new Size(357, 63);
            btnJobCategory.TabIndex = 0;
            btnJobCategory.Text = "Categoría Laboral";
            btnJobCategory.TextAlign = ContentAlignment.MiddleLeft;
            btnJobCategory.UseVisualStyleBackColor = true;
            // 
            // btnCatalog
            // 
            btnCatalog.AutoSize = true;
            btnCatalog.BackColor = Color.FromArgb(55, 60, 83);
            btnCatalog.Cursor = Cursors.Hand;
            btnCatalog.Dock = DockStyle.Top;
            btnCatalog.FlatAppearance.BorderSize = 0;
            btnCatalog.FlatStyle = FlatStyle.Flat;
            btnCatalog.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCatalog.ForeColor = Color.FromArgb(235, 236, 238);
            btnCatalog.Location = new Point(0, 90);
            btnCatalog.Margin = new Padding(0);
            btnCatalog.Name = "btnCatalog";
            btnCatalog.Padding = new Padding(33, 0, 0, 0);
            btnCatalog.Size = new Size(357, 63);
            btnCatalog.TabIndex = 1;
            btnCatalog.Text = "Catálogos";
            btnCatalog.TextAlign = ContentAlignment.MiddleLeft;
            btnCatalog.UseVisualStyleBackColor = false;
            btnCatalog.Click += btnCatalog_Click;
            // 
            // pnlHeaderNav
            // 
            pnlHeaderNav.BackColor = Color.FromArgb(34, 37, 51);
            pnlHeaderNav.Controls.Add(btnHome);
            pnlHeaderNav.Dock = DockStyle.Top;
            pnlHeaderNav.Location = new Point(0, 0);
            pnlHeaderNav.Margin = new Padding(0);
            pnlHeaderNav.Name = "pnlHeaderNav";
            pnlHeaderNav.Size = new Size(357, 90);
            pnlHeaderNav.TabIndex = 1;
            // 
            // btnHome
            // 
            btnHome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 37, 51);
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 37, 51);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.FromArgb(246, 246, 247);
            btnHome.Image = Properties.Resources.home_1;
            btnHome.ImageAlign = ContentAlignment.MiddleRight;
            btnHome.Location = new Point(14, 15);
            btnHome.Margin = new Padding(0);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(21, 0, 0, 0);
            btnHome.Size = new Size(336, 63);
            btnHome.TabIndex = 2;
            btnHome.Text = "Inicio";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = true;
            // 
            // pnlContainer
            // 
            pnlContainer.AutoScroll = true;
            pnlContainer.BackColor = Color.FromArgb(246, 246, 247);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(359, 167);
            pnlContainer.Margin = new Padding(6, 4, 6, 4);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1408, 1107);
            pnlContainer.TabIndex = 5;
            // 
            // FrmContainer
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1767, 1274);
            Controls.Add(pnlContainer);
            Controls.Add(pnlBreadcrumbs);
            Controls.Add(pnlSideBar);
            Controls.Add(pnlHeaderTopMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(268, 56);
            Name = "FrmContainer";
            ShowIcon = false;
            Text = "TALENTHQ";
            WindowState = FormWindowState.Maximized;
            Load += FrmContainer_Load;
            pnlHeaderTopMain.ResumeLayout(false);
            pnlHeaderTopMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pc_UserLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcLogo).EndInit();
            pnlBreadcrumbs.ResumeLayout(false);
            pnlBreadcrumbs.PerformLayout();
            pnlSideBar.ResumeLayout(false);
            pnlSideBar.PerformLayout();
            pnlSubMenuAdmin.ResumeLayout(false);
            pnlSubMenuReport.ResumeLayout(false);
            pnlSubMenuPayroll.ResumeLayout(false);
            pnlSubMenuContract.ResumeLayout(false);
            pnlSubMenuEmployee.ResumeLayout(false);
            pnlCatalogSubMenu.ResumeLayout(false);
            pnlHeaderNav.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeaderTopMain;
        private Label lblTitleSystem;
        private PictureBox pcLogo;
        private Label lblUserLogIn;
        private PictureBox pc_UserLogin;
        private Panel pnlBreadcrumbs;
        private Label lblHome;
        private Label lblSubMenu;
        private Label lblItems;
        private Button btnSideBarMenu;
        private Panel pnlSideBar;
        private Panel pnlSubMenuAdmin;
        private Button btnAdmin2;
        private Button btnAdmin1;
        private Button BtnUser;
        private Button btnAdmin;
        private Panel pnlSubMenuReport;
        private Button btnReport3;
        private Button btnReport2;
        private Button btnReport1;
        private Button btnReport;
        private Panel pnlSubMenuPayroll;
        private Button btnPayStubs;
        private Button btnProcessPayroll;
        private Button btnPayroll;
        private Panel pnlSubMenuContract;
        private Button btnPromoter;
        private Button btnActiveContracts;
        private Button btnContract;
        private Panel pnlSubMenuEmployee;
        private Button btnTrainingManagement;
        private Button btnEmployeeFile;
        private Button btnEmployees;
        private Panel pnlCatalogSubMenu;
        private Button btnMunicipality;
        private Button btnDepartment;
        private Button btnJobCategory;
        private Button btnCatalog;
        private Panel pnlHeaderNav;
        private Button btnHome;
        private Panel pnlContainer;
        private Button btnExit;
    }
}