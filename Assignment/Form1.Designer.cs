namespace Assignment
{
    partial class Form1
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
            pnlMenu = new Panel();
            ibtnSetting = new FontAwesome.Sharp.IconButton();
            ibtnDashboard = new FontAwesome.Sharp.IconButton();
            ibtnProducts = new FontAwesome.Sharp.IconButton();
            ibtnEmp = new FontAwesome.Sharp.IconButton();
            ibtnHome = new FontAwesome.Sharp.IconButton();
            pnlLogo = new Panel();
            picLogo = new PictureBox();
            panelTitleBar = new Panel();
            panel1 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            pnlMain = new Panel();
            pnlMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelTitleBar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(35, 38, 46);
            pnlMenu.Controls.Add(ibtnSetting);
            pnlMenu.Controls.Add(ibtnDashboard);
            pnlMenu.Controls.Add(ibtnProducts);
            pnlMenu.Controls.Add(ibtnEmp);
            pnlMenu.Controls.Add(ibtnHome);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(222, 742);
            pnlMenu.TabIndex = 0;
            // 
            // ibtnSetting
            // 
            ibtnSetting.FlatAppearance.BorderSize = 0;
            ibtnSetting.FlatStyle = FlatStyle.Flat;
            ibtnSetting.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ibtnSetting.ForeColor = Color.Gainsboro;
            ibtnSetting.IconChar = FontAwesome.Sharp.IconChar.Gear;
            ibtnSetting.IconColor = Color.Gainsboro;
            ibtnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnSetting.Location = new Point(0, 612);
            ibtnSetting.Name = "ibtnSetting";
            ibtnSetting.Size = new Size(222, 60);
            ibtnSetting.TabIndex = 5;
            ibtnSetting.Text = "Cài đặt";
            ibtnSetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnSetting.UseVisualStyleBackColor = true;
            ibtnSetting.Click += ibtnSetting_Click;
            // 
            // ibtnDashboard
            // 
            ibtnDashboard.FlatAppearance.BorderSize = 0;
            ibtnDashboard.FlatStyle = FlatStyle.Flat;
            ibtnDashboard.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ibtnDashboard.ForeColor = Color.Gainsboro;
            ibtnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            ibtnDashboard.IconColor = Color.Gainsboro;
            ibtnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnDashboard.Location = new Point(-3, 504);
            ibtnDashboard.Name = "ibtnDashboard";
            ibtnDashboard.Size = new Size(222, 60);
            ibtnDashboard.TabIndex = 4;
            ibtnDashboard.Text = "Doanh thu";
            ibtnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnDashboard.UseVisualStyleBackColor = true;
            ibtnDashboard.Click += ibtnDashboard_Click;
            // 
            // ibtnProducts
            // 
            ibtnProducts.FlatAppearance.BorderSize = 0;
            ibtnProducts.FlatStyle = FlatStyle.Flat;
            ibtnProducts.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ibtnProducts.ForeColor = Color.Gainsboro;
            ibtnProducts.IconChar = FontAwesome.Sharp.IconChar.BusinessTime;
            ibtnProducts.IconColor = Color.GhostWhite;
            ibtnProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnProducts.Location = new Point(3, 389);
            ibtnProducts.Name = "ibtnProducts";
            ibtnProducts.Size = new Size(222, 60);
            ibtnProducts.TabIndex = 3;
            ibtnProducts.Text = "Sản phẩm";
            ibtnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnProducts.UseVisualStyleBackColor = true;
            ibtnProducts.Click += ibtnProducts_Click;
            // 
            // ibtnEmp
            // 
            ibtnEmp.FlatAppearance.BorderSize = 0;
            ibtnEmp.FlatStyle = FlatStyle.Flat;
            ibtnEmp.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ibtnEmp.ForeColor = Color.Gainsboro;
            ibtnEmp.IconChar = FontAwesome.Sharp.IconChar.UsersRays;
            ibtnEmp.IconColor = Color.Gainsboro;
            ibtnEmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnEmp.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnEmp.Location = new Point(-3, 282);
            ibtnEmp.Name = "ibtnEmp";
            ibtnEmp.Size = new Size(222, 60);
            ibtnEmp.TabIndex = 2;
            ibtnEmp.Text = "Nhân viên";
            ibtnEmp.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnEmp.UseVisualStyleBackColor = true;
            ibtnEmp.Click += ibtnEmp_Click;
            // 
            // ibtnHome
            // 
            ibtnHome.Dock = DockStyle.Top;
            ibtnHome.FlatAppearance.BorderSize = 0;
            ibtnHome.FlatStyle = FlatStyle.Flat;
            ibtnHome.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            ibtnHome.ForeColor = Color.Gainsboro;
            ibtnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            ibtnHome.IconColor = Color.Gainsboro;
            ibtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnHome.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnHome.Location = new Point(0, 186);
            ibtnHome.Name = "ibtnHome";
            ibtnHome.Size = new Size(222, 60);
            ibtnHome.TabIndex = 1;
            ibtnHome.Text = "Cửa hàng";
            ibtnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnHome.UseVisualStyleBackColor = true;
            ibtnHome.Click += ibtnHome_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(35, 38, 46);
            pnlLogo.Controls.Add(picLogo);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(222, 186);
            pnlLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Location = new Point(12, 30);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(193, 102);
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(32, 35, 43);
            panelTitleBar.Controls.Add(panel1);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(222, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1140, 79);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 37, 45);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(iconButton2);
            panel1.Location = new Point(1017, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(120, 26);
            panel1.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(34, 37, 45);
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(64, 2);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(56, 21);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "X";
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.UseWaitCursor = true;
            iconButton1.Click += btnExit_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(34, 37, 45);
            iconButton2.Cursor = Cursors.Hand;
            iconButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Minus;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 20;
            iconButton2.Location = new Point(3, 2);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(56, 21);
            iconButton2.TabIndex = 2;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.UseWaitCursor = true;
            iconButton2.Click += btnMinimize_Click;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(34, 37, 45);
            pnlMain.BorderStyle = BorderStyle.FixedSingle;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(222, 79);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1140, 663);
            pnlMain.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1362, 742);
            Controls.Add(pnlMain);
            Controls.Add(panelTitleBar);
            Controls.Add(pnlMenu);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.Black;
            pnlMenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelTitleBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlLogo;
        private System.CodeDom.CodeTypeReference faPicker1;
        private System.CodeDom.CodeTypeReference faProvider1;
        private FontAwesome.Sharp.IconButton ibtnHome;
        private FontAwesome.Sharp.IconButton ibtnDashboard;
        private FontAwesome.Sharp.IconButton ibtnProducts;
        private FontAwesome.Sharp.IconButton ibtnEmp;
        private Panel panelTitleBar;
        private Panel pnlMain;
        private FontAwesome.Sharp.IconButton ibtnSetting;
        private PictureBox picLogo;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}