namespace Assignment
{
    partial class LoginForm
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
            panel2 = new Panel();
            label1 = new Label();
            txtUserName = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            txtPassword = new TextBox();
            ibtnLogin = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(20, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(348, 54);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(104, 16);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(234, 23);
            txtUserName.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(20, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(348, 54);
            panel3.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 16);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(104, 16);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(234, 23);
            txtPassword.TabIndex = 1;
            // 
            // ibtnLogin
            // 
            ibtnLogin.BackColor = Color.FromArgb(5, 201, 204);
            ibtnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ibtnLogin.IconChar = FontAwesome.Sharp.IconChar.None;
            ibtnLogin.IconColor = Color.Black;
            ibtnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnLogin.Location = new Point(185, 134);
            ibtnLogin.Name = "ibtnLogin";
            ibtnLogin.Size = new Size(100, 39);
            ibtnLogin.TabIndex = 6;
            ibtnLogin.Text = "Đăng nhập";
            ibtnLogin.UseVisualStyleBackColor = false;
            ibtnLogin.Click += ibtnLogin_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(ibtnLogin);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(383, 231);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 184);
            panel1.TabIndex = 7;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 37, 45);
            ClientSize = new Size(1233, 665);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txtUserName;
        private Label label1;
        private Panel panel3;
        private TextBox txtPassword;
        private Label label2;
        private FontAwesome.Sharp.IconButton ibtnLogin;
        private Panel panel1;
    }
}