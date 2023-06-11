﻿namespace Assignment
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
            iconButton4 = new FontAwesome.Sharp.IconButton();
            ibtnProducts = new FontAwesome.Sharp.IconButton();
            ibtnEmp = new FontAwesome.Sharp.IconButton();
            ibtnHome = new FontAwesome.Sharp.IconButton();
            pnlLogo = new Panel();
            picLogo = new PictureBox();
            panel1 = new Panel();
            pnlMain = new Panel();
            pnlMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(35, 38, 46);
            pnlMenu.Controls.Add(iconButton4);
            pnlMenu.Controls.Add(ibtnProducts);
            pnlMenu.Controls.Add(ibtnEmp);
            pnlMenu.Controls.Add(ibtnHome);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(222, 565);
            pnlMenu.TabIndex = 0;
            // 
            // iconButton4
            // 
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton4.ForeColor = Color.Gainsboro;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.ChartArea;
            iconButton4.IconColor = Color.Gainsboro;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(-3, 459);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(222, 60);
            iconButton4.TabIndex = 4;
            iconButton4.Text = "Doanh thu";
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
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
            ibtnProducts.Location = new Point(-3, 339);
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
            ibtnEmp.Location = new Point(-3, 229);
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
            ibtnHome.Location = new Point(0, 126);
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
            pnlLogo.Size = new Size(222, 126);
            pnlLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.Location = new Point(12, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(193, 98);
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 35, 43);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(222, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(875, 51);
            panel1.TabIndex = 1;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(34, 37, 45);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(222, 51);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(875, 514);
            pnlMain.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1097, 565);
            Controls.Add(pnlMain);
            Controls.Add(panel1);
            Controls.Add(pnlMenu);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.Black;
            pnlMenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlLogo;
        private System.CodeDom.CodeTypeReference faPicker1;
        private System.CodeDom.CodeTypeReference faProvider1;
        private FontAwesome.Sharp.IconButton ibtnHome;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton ibtnProducts;
        private FontAwesome.Sharp.IconButton ibtnEmp;
        private PictureBox picLogo;
        private Panel panel1;
        private Panel pnlMain;
    }
}