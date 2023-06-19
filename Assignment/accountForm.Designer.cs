namespace Assignment
{
    partial class accountForm
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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel6 = new Panel();
            label2 = new Label();
            textBox3 = new TextBox();
            panel5 = new Panel();
            label1 = new Label();
            textBox2 = new TextBox();
            panel4 = new Panel();
            lbUsername = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(703, 521);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(323, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 550);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(348, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(771, 593);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(iconButton2);
            panel3.Controls.Add(iconButton1);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(12, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(279, 625);
            panel3.TabIndex = 3;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(225, 0, 125);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(169, 417);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(103, 44);
            iconButton2.TabIndex = 7;
            iconButton2.Text = "Hủy bỏ";
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(5, 201, 204);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(60, 417);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(103, 44);
            iconButton1.TabIndex = 6;
            iconButton1.Text = "Xác nhận";
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(label2);
            panel6.Controls.Add(textBox3);
            panel6.Location = new Point(3, 259);
            panel6.Name = "panel6";
            panel6.Size = new Size(272, 45);
            panel6.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 11);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 1;
            label2.Text = "Tên hiển thị";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(89, 9);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 23);
            textBox3.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Controls.Add(textBox2);
            panel5.Location = new Point(3, 153);
            panel5.Name = "panel5";
            panel5.Size = new Size(272, 45);
            panel5.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 11);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 1;
            label1.Text = "Mật khẩu";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(89, 9);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 23);
            textBox2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(lbUsername);
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(3, 54);
            panel4.Name = "panel4";
            panel4.Size = new Size(272, 45);
            panel4.TabIndex = 4;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbUsername.ForeColor = Color.White;
            lbUsername.Location = new Point(8, 11);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(75, 21);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Tài khoản";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(89, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 0;
            // 
            // accountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 52, 60);
            ClientSize = new Size(1144, 623);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "accountForm";
            Text = "accountForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel6;
        private Label label2;
        private TextBox textBox3;
        private Panel panel5;
        private Label label1;
        private TextBox textBox2;
        private Panel panel4;
        private Label lbUsername;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}