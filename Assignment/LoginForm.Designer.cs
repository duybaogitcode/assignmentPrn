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
            ibtnLogin = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            txtPassword = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            txtUserName = new TextBox();
            label1 = new Label();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ibtnLogin
            // 
            ibtnLogin.BackColor = Color.FromArgb(5, 201, 204);
            ibtnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ibtnLogin.IconChar = FontAwesome.Sharp.IconChar.None;
            ibtnLogin.IconColor = Color.Black;
            ibtnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnLogin.Location = new Point(568, 365);
            ibtnLogin.Name = "ibtnLogin";
            ibtnLogin.Size = new Size(100, 39);
            ibtnLogin.TabIndex = 6;
            ibtnLogin.Text = "Đăng nhập";
            ibtnLogin.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(403, 293);
            panel3.Name = "panel3";
            panel3.Size = new Size(348, 54);
            panel3.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(104, 16);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(234, 23);
            txtPassword.TabIndex = 1;
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
            // panel2
            // 
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(403, 248);
            panel2.Name = "panel2";
            panel2.Size = new Size(348, 54);
            panel2.TabIndex = 4;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(104, 16);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(234, 23);
            txtUserName.TabIndex = 1;
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
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 37, 45);
            ClientSize = new Size(1233, 665);
            Controls.Add(ibtnLogin);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton ibtnLogin;
        private Panel panel3;
        private TextBox txtPassword;
        private Label label2;
        private Panel panel2;
        private TextBox txtUserName;
        private Label label1;
    }
}