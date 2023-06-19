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
            cbType = new ComboBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            dataGridView2 = new DataGridView();
            panel2 = new Panel();
            foodDgv = new DataGridView();
            colName1 = new DataGridViewTextBoxColumn();
            colType1 = new DataGridViewTextBoxColumn();
            colPrice1 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)foodDgv).BeginInit();
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
            pnlHome.Location = new Point(12, 240);
            pnlHome.Name = "pnlHome";
            pnlHome.Size = new Size(659, 347);
            pnlHome.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(cbType);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Location = new Point(23, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 76);
            panel1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 23);
            textBox1.TabIndex = 1;
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(185, 32);
            cbType.Name = "cbType";
            cbType.Size = new Size(91, 23);
            cbType.TabIndex = 2;
            cbType.SelectedIndexChanged += cbType_SelectedIndexChanged;
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
            dataGridView2.Location = new Point(12, 57);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(659, 101);
            dataGridView2.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(foodDgv);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(725, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(329, 543);
            panel2.TabIndex = 5;
            // 
            // foodDgv
            // 
            foodDgv.BackgroundColor = Color.White;
            foodDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            foodDgv.Columns.AddRange(new DataGridViewColumn[] { colName1, colType1, colPrice1 });
            foodDgv.Location = new Point(23, 97);
            foodDgv.Name = "foodDgv";
            foodDgv.RowTemplate.Height = 25;
            foodDgv.Size = new Size(292, 433);
            foodDgv.TabIndex = 0;
            // 
            // colName1
            // 
            colName1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colName1.HeaderText = "Tên đồ uống";
            colName1.Name = "colName1";
            colName1.Width = 98;
            // 
            // colType1
            // 
            colType1.HeaderText = "Phân loại";
            colType1.Name = "colType1";
            // 
            // colPrice1
            // 
            colPrice1.HeaderText = "Giá";
            colPrice1.Name = "colPrice1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 197);
            label2.Name = "label2";
            label2.Size = new Size(44, 28);
            label2.TabIndex = 6;
            label2.Text = "Bàn";
            // 
            // shopForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 52, 60);
            ClientSize = new Size(1056, 612);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(pnlHome);
            Controls.Add(label1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "shopForm";
            Text = "shopForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)foodDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel pnlHome;
        private PictureBox picTable;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private ComboBox cbType;
        private TextBox textBox1;
        private DataGridView dataGridView2;
        private Panel panel2;
        private Label label2;
        private DataGridView foodDgv;
        private DataGridViewTextBoxColumn colName1;
        private DataGridViewTextBoxColumn colType1;
        private DataGridViewTextBoxColumn colPrice1;
    }
}