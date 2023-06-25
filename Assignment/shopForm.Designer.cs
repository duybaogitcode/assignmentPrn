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
            pnlHome = new Panel();
            panel1 = new Panel();
            textBox1 = new TextBox();
            cbCategory = new ComboBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            ibtnCancel = new FontAwesome.Sharp.IconButton();
            ibtnConfirm = new FontAwesome.Sharp.IconButton();
            dataFood = new DataGridView();
            FoodName = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel3 = new Panel();
            lbDetailTable = new Label();
            lbTotal = new Label();
            lbBill = new Label();
            dataGridView2 = new DataGridView();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            lbId = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataFood).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHome
            // 
            pnlHome.BackColor = Color.White;
            pnlHome.BorderStyle = BorderStyle.FixedSingle;
            pnlHome.Location = new Point(3, 3);
            pnlHome.Name = "pnlHome";
            pnlHome.Size = new Size(683, 334);
            pnlHome.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(cbCategory);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Location = new Point(17, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 76);
            panel1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 23);
            textBox1.TabIndex = 1;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(242, 32);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(115, 23);
            cbCategory.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.WhiteSmoke;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(3, 32);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(ibtnCancel);
            panel2.Controls.Add(ibtnConfirm);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(dataFood);
            panel2.Location = new Point(732, -5);
            panel2.Name = "panel2";
            panel2.Size = new Size(380, 647);
            panel2.TabIndex = 5;
            // 
            // ibtnCancel
            // 
            ibtnCancel.BackColor = Color.FromArgb(225, 0, 125);
            ibtnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ibtnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            ibtnCancel.IconColor = Color.Black;
            ibtnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnCancel.Location = new Point(274, 588);
            ibtnCancel.Name = "ibtnCancel";
            ibtnCancel.Size = new Size(103, 44);
            ibtnCancel.TabIndex = 9;
            ibtnCancel.Text = "Hủy bỏ";
            ibtnCancel.UseVisualStyleBackColor = false;
            // 
            // ibtnConfirm
            // 
            ibtnConfirm.BackColor = Color.FromArgb(5, 201, 204);
            ibtnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ibtnConfirm.IconChar = FontAwesome.Sharp.IconChar.None;
            ibtnConfirm.IconColor = Color.Black;
            ibtnConfirm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnConfirm.Location = new Point(165, 588);
            ibtnConfirm.Name = "ibtnConfirm";
            ibtnConfirm.Size = new Size(103, 44);
            ibtnConfirm.TabIndex = 8;
            ibtnConfirm.Text = "Thêm món";
            ibtnConfirm.UseVisualStyleBackColor = false;
            // 
            // dataFood
            // 
            dataFood.BackgroundColor = Color.White;
            dataFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataFood.Columns.AddRange(new DataGridViewColumn[] { FoodName, Category, Price, Id });
            dataFood.Location = new Point(17, 85);
            dataFood.Name = "dataFood";
            dataFood.RowTemplate.Height = 25;
            dataFood.Size = new Size(360, 495);
            dataFood.TabIndex = 2;
            // 
            // FoodName
            // 
            FoodName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FoodName.HeaderText = "Tên đồ uống";
            FoodName.MinimumWidth = 10;
            FoodName.Name = "FoodName";
            // 
            // Category
            // 
            Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Category.HeaderText = "Phân loại";
            Category.Name = "Category";
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.HeaderText = "Giá";
            Price.Name = "Price";
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(-2, -5);
            label2.Name = "label2";
            label2.Size = new Size(48, 28);
            label2.TabIndex = 6;
            label2.Text = "Bàn";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lbDetailTable);
            panel3.Controls.Add(lbTotal);
            panel3.Controls.Add(lbBill);
            panel3.Controls.Add(dataGridView2);
            panel3.Controls.Add(iconButton2);
            panel3.Location = new Point(12, 380);
            panel3.Name = "panel3";
            panel3.Size = new Size(689, 262);
            panel3.TabIndex = 7;
            // 
            // lbDetailTable
            // 
            lbDetailTable.AutoSize = true;
            lbDetailTable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDetailTable.Location = new Point(3, 16);
            lbDetailTable.Name = "lbDetailTable";
            lbDetailTable.Size = new Size(59, 21);
            lbDetailTable.TabIndex = 15;
            lbDetailTable.Text = "Chi tiết";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTotal.Location = new Point(474, 159);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(82, 21);
            lbTotal.TabIndex = 14;
            lbTotal.Text = "Tổng tiền: ";
            // 
            // lbBill
            // 
            lbBill.AutoSize = true;
            lbBill.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbBill.ForeColor = Color.Black;
            lbBill.Location = new Point(474, 40);
            lbBill.Name = "lbBill";
            lbBill.Size = new Size(70, 21);
            lbBill.TabIndex = 13;
            lbBill.Text = "Hóa đơn";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 40);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(448, 207);
            dataGridView2.TabIndex = 12;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(182, 205, 84);
            iconButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(574, 203);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(103, 44);
            iconButton2.TabIndex = 10;
            iconButton2.Text = "Thanh toán";
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(pnlHome);
            panel4.Location = new Point(12, 30);
            panel4.Name = "panel4";
            panel4.Size = new Size(689, 344);
            panel4.TabIndex = 8;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(96, 5);
            lbId.Name = "lbId";
            lbId.Size = new Size(0, 15);
            lbId.TabIndex = 9;
            // 
            // shopForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1135, 702);
            Controls.Add(lbId);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(panel4);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "shopForm";
            Text = "shopForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataFood).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlHome;
        private PictureBox picTable;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private ComboBox cbCategory;
        private TextBox textBox1;
        private Panel panel2;
        private DataGridView dataFood;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton ibtnCancel;
        private FontAwesome.Sharp.IconButton ibtnConfirm;
        private FontAwesome.Sharp.IconButton iconButton2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn FoodName;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Id;
        private Label lbId;
        private Label lbDetailTable;
        private Label lbTotal;
        private Label lbBill;
    }
}