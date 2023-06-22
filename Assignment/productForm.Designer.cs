namespace Assignment
{
    partial class productForm
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
            panel3 = new Panel();
            lbCRUD = new Label();
            ibtnReload = new FontAwesome.Sharp.IconButton();
            panel6 = new Panel();
            comboBox1 = new ComboBox();
            label2 = new Label();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            label1 = new Label();
            textBox2 = new TextBox();
            panel4 = new Panel();
            lbUsername = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(lbCRUD);
            panel3.Controls.Add(ibtnReload);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(iconButton2);
            panel3.Controls.Add(iconButton1);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(12, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(306, 625);
            panel3.TabIndex = 4;
            // 
            // lbCRUD
            // 
            lbCRUD.AutoSize = true;
            lbCRUD.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lbCRUD.ForeColor = Color.Black;
            lbCRUD.Location = new Point(0, 7);
            lbCRUD.Name = "lbCRUD";
            lbCRUD.Size = new Size(92, 25);
            lbCRUD.TabIndex = 9;
            lbCRUD.Text = "Thêm mới";
            // 
            // ibtnReload
            // 
            ibtnReload.BackColor = Color.FromArgb(182, 205, 84);
            ibtnReload.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            ibtnReload.IconColor = Color.Black;
            ibtnReload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnReload.IconSize = 30;
            ibtnReload.ImageAlign = ContentAlignment.MiddleLeft;
            ibtnReload.Location = new Point(249, 3);
            ibtnReload.Name = "ibtnReload";
            ibtnReload.Size = new Size(38, 34);
            ibtnReload.TabIndex = 8;
            ibtnReload.TextAlign = ContentAlignment.MiddleRight;
            ibtnReload.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnReload.UseVisualStyleBackColor = false;
            ibtnReload.Click += ibtnReload_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(comboBox1);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(3, 134);
            panel6.Name = "panel6";
            panel6.Size = new Size(284, 45);
            panel6.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(123, 11);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(135, 23);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(8, 11);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 1;
            label2.Text = "Loại sản phẩm";
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(225, 0, 125);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(199, 349);
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
            iconButton1.Location = new Point(94, 349);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(103, 44);
            iconButton1.TabIndex = 6;
            iconButton1.Text = "Xác nhận";
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Controls.Add(textBox2);
            panel5.Location = new Point(3, 222);
            panel5.Name = "panel5";
            panel5.Size = new Size(172, 45);
            panel5.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(33, 21);
            label1.TabIndex = 1;
            label1.Text = "Giá";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(47, 13);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(97, 23);
            textBox2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(lbUsername);
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(3, 54);
            panel4.Name = "panel4";
            panel4.Size = new Size(302, 45);
            panel4.TabIndex = 4;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbUsername.ForeColor = Color.Black;
            lbUsername.Location = new Point(8, 11);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(105, 21);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Tên sản phẩm";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(119, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 35, 43);
            panel1.Location = new Point(353, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 591);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(412, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(703, 593);
            panel2.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(659, 521);
            dataGridView1.TabIndex = 0;
            // 
            // productForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1125, 667);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "productForm";
            Text = "productForm";
            Load += productForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel5;
        private Label label1;
        private TextBox textBox2;
        private Panel panel4;
        private Label lbUsername;
        private TextBox textBox1;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel6;
        private ComboBox comboBox1;
        private Label label2;
        private FontAwesome.Sharp.IconButton ibtnReload;
        private Label lbCRUD;
    }
}