namespace Assignment
{
    partial class shopForm
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
            label1 = new Label();
            pnlHome = new Panel();
            panel1 = new Panel();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            dataGridView2 = new DataGridView();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 28);
            label1.TabIndex = 0;
            label1.Text = "Cửa hàng";
            // 
            // pnlHome
            // 
            pnlHome.BackColor = Color.White;
            pnlHome.BorderStyle = BorderStyle.FixedSingle;
            pnlHome.Location = new Point(12, 277);
            pnlHome.Name = "pnlHome";
            pnlHome.Size = new Size(659, 347);
            pnlHome.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Location = new Point(23, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 76);
            panel1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 23);
            textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(242, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(70, 23);
            comboBox1.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(46, 52, 60);
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(3, 32);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(9, 17);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(659, 156);
            dataGridView2.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(744, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(369, 543);
            panel2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colName, colType, colPrice });
            dataGridView1.Location = new Point(30, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(323, 455);
            dataGridView1.TabIndex = 2;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colName.HeaderText = "Tên đồ uống";
            colName.MinimumWidth = 10;
            colName.Name = "colName";
            colName.Width = 98;
            // 
            // colType
            // 
            colType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colType.HeaderText = "Phân loại";
            colType.Name = "colType";
            colType.Width = 81;
            // 
            // colPrice
            // 
            colPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colPrice.HeaderText = "Giá";
            colPrice.Name = "colPrice";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 230);
            label2.Name = "label2";
            label2.Size = new Size(44, 28);
            label2.TabIndex = 6;
            label2.Text = "Bàn";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView2);
            panel3.Location = new Point(3, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(684, 170);
            panel3.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Location = new Point(6, 257);
            panel4.Name = "panel4";
            panel4.Size = new Size(706, 392);
            panel4.TabIndex = 8;
            // 
            // shopForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 52, 60);
            ClientSize = new Size(1135, 652);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(pnlHome);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "shopForm";
            Text = "shopForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel pnlHome;
        private PictureBox picTable;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private DataGridView dataGridView2;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label2;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colPrice;
        private Panel panel3;
        private Panel panel4;
    }
}