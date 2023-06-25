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
            lbFoodID = new Label();
            textBox1 = new TextBox();
            cbCategory = new ComboBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            lbFoodPrice = new Label();
            lbFood = new Label();
            ibtnCancel = new FontAwesome.Sharp.IconButton();
            ibtnAdd = new FontAwesome.Sharp.IconButton();
            dataFood = new DataGridView();
            FoodName = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel3 = new Panel();
            ibtnUpdate = new FontAwesome.Sharp.IconButton();
            lbTotal = new Label();
            lbBill = new Label();
            dataBillInfo = new DataGridView();
            IbtnCheckout = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            lbId = new Label();
            BillInfoFoodName = new DataGridViewTextBoxColumn();
            BillInfoQuantity = new DataGridViewTextBoxColumn();
            BillInfoPrice = new DataGridViewTextBoxColumn();
            BillInfoId = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataFood).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataBillInfo).BeginInit();
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
            panel1.Controls.Add(lbFoodID);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(cbCategory);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Location = new Point(17, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 76);
            panel1.TabIndex = 3;
            // 
            // lbFoodID
            // 
            lbFoodID.AutoSize = true;
            lbFoodID.Location = new Point(18, 7);
            lbFoodID.Name = "lbFoodID";
            lbFoodID.Size = new Size(38, 15);
            lbFoodID.TabIndex = 3;
            lbFoodID.Text = "label1";
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
            panel2.Controls.Add(lbFoodPrice);
            panel2.Controls.Add(lbFood);
            panel2.Controls.Add(ibtnCancel);
            panel2.Controls.Add(ibtnAdd);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(dataFood);
            panel2.Location = new Point(732, -5);
            panel2.Name = "panel2";
            panel2.Size = new Size(380, 647);
            panel2.TabIndex = 5;
            // 
            // lbFoodPrice
            // 
            lbFoodPrice.AutoSize = true;
            lbFoodPrice.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbFoodPrice.Location = new Point(20, 615);
            lbFoodPrice.Name = "lbFoodPrice";
            lbFoodPrice.Size = new Size(13, 19);
            lbFoodPrice.TabIndex = 11;
            lbFoodPrice.Text = ".";
            // 
            // lbFood
            // 
            lbFood.AutoSize = true;
            lbFood.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbFood.Location = new Point(20, 583);
            lbFood.Name = "lbFood";
            lbFood.Size = new Size(13, 19);
            lbFood.TabIndex = 10;
            lbFood.Text = ".";
            // 
            // ibtnCancel
            // 
            ibtnCancel.BackColor = Color.FromArgb(225, 0, 125);
            ibtnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ibtnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            ibtnCancel.IconColor = Color.Black;
            ibtnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnCancel.Location = new Point(277, 600);
            ibtnCancel.Name = "ibtnCancel";
            ibtnCancel.Size = new Size(103, 44);
            ibtnCancel.TabIndex = 9;
            ibtnCancel.Text = "Hủy bỏ";
            ibtnCancel.UseVisualStyleBackColor = false;
            // 
            // ibtnAdd
            // 
            ibtnAdd.BackColor = Color.FromArgb(5, 201, 204);
            ibtnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ibtnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            ibtnAdd.IconColor = Color.Black;
            ibtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnAdd.Location = new Point(168, 600);
            ibtnAdd.Name = "ibtnAdd";
            ibtnAdd.Size = new Size(103, 44);
            ibtnAdd.TabIndex = 8;
            ibtnAdd.Text = "Thêm món";
            ibtnAdd.UseVisualStyleBackColor = false;
            ibtnAdd.Click += ibtnAdd_Click;
            // 
            // dataFood
            // 
            dataFood.BackgroundColor = Color.White;
            dataFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataFood.Columns.AddRange(new DataGridViewColumn[] { FoodName, Category, Price, Id });
            dataFood.Location = new Point(17, 85);
            dataFood.MultiSelect = false;
            dataFood.Name = "dataFood";
            dataFood.RowTemplate.Height = 25;
            dataFood.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataFood.Size = new Size(360, 495);
            dataFood.TabIndex = 2;
            dataFood.CellContentClick += dataFood_CellContentClick;
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
            panel3.Controls.Add(ibtnUpdate);
            panel3.Controls.Add(lbTotal);
            panel3.Controls.Add(lbBill);
            panel3.Controls.Add(dataBillInfo);
            panel3.Controls.Add(IbtnCheckout);
            panel3.Location = new Point(12, 380);
            panel3.Name = "panel3";
            panel3.Size = new Size(689, 262);
            panel3.TabIndex = 7;
            // 
            // ibtnUpdate
            // 
            ibtnUpdate.BackColor = Color.FromArgb(5, 201, 204);
            ibtnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ibtnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            ibtnUpdate.IconColor = Color.Black;
            ibtnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnUpdate.Location = new Point(371, 215);
            ibtnUpdate.Name = "ibtnUpdate";
            ibtnUpdate.Size = new Size(77, 25);
            ibtnUpdate.TabIndex = 10;
            ibtnUpdate.Text = "Cập nhập";
            ibtnUpdate.UseVisualStyleBackColor = false;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotal.Location = new Point(454, 189);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(91, 21);
            lbTotal.TabIndex = 14;
            lbTotal.Text = "Tổng tiền: ";
            // 
            // lbBill
            // 
            lbBill.AutoSize = true;
            lbBill.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbBill.ForeColor = Color.Black;
            lbBill.Location = new Point(454, 3);
            lbBill.Name = "lbBill";
            lbBill.Size = new Size(75, 21);
            lbBill.TabIndex = 13;
            lbBill.Text = "Hóa đơn";
            // 
            // dataBillInfo
            // 
            dataBillInfo.BackgroundColor = Color.White;
            dataBillInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataBillInfo.Columns.AddRange(new DataGridViewColumn[] { BillInfoFoodName, BillInfoQuantity, BillInfoPrice, BillInfoId });
            dataBillInfo.Location = new Point(0, 3);
            dataBillInfo.Name = "dataBillInfo";
            dataBillInfo.RowTemplate.Height = 25;
            dataBillInfo.Size = new Size(448, 207);
            dataBillInfo.TabIndex = 12;
            // 
            // IbtnCheckout
            // 
            IbtnCheckout.BackColor = Color.FromArgb(182, 205, 84);
            IbtnCheckout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            IbtnCheckout.IconChar = FontAwesome.Sharp.IconChar.None;
            IbtnCheckout.IconColor = Color.Black;
            IbtnCheckout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IbtnCheckout.Location = new Point(583, 219);
            IbtnCheckout.Name = "IbtnCheckout";
            IbtnCheckout.Size = new Size(103, 40);
            IbtnCheckout.TabIndex = 10;
            IbtnCheckout.Text = "Thanh toán";
            IbtnCheckout.UseVisualStyleBackColor = false;
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
            // BillInfoFoodName
            // 
            BillInfoFoodName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BillInfoFoodName.HeaderText = "Tên đồ uống";
            BillInfoFoodName.Name = "BillInfoFoodName";
            // 
            // BillInfoQuantity
            // 
            BillInfoQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BillInfoQuantity.HeaderText = "Số lượng";
            BillInfoQuantity.Name = "BillInfoQuantity";
            // 
            // BillInfoPrice
            // 
            BillInfoPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BillInfoPrice.HeaderText = "Giá";
            BillInfoPrice.Name = "BillInfoPrice";
            // 
            // BillInfoId
            // 
            BillInfoId.HeaderText = "Id";
            BillInfoId.Name = "BillInfoId";
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
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataFood).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataBillInfo).EndInit();
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
        private FontAwesome.Sharp.IconButton ibtnAdd;
        private FontAwesome.Sharp.IconButton IbtnCheckout;
        private DataGridView dataBillInfo;
        private DataGridViewTextBoxColumn FoodName;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Id;
        private Label lbId;
        private Label lbTotal;
        private Label lbBill;
        private FontAwesome.Sharp.IconButton ibtnUpdate;
        private Label lbFood;
        private Label lbFoodPrice;
        private Label lbFoodID;
        private DataGridViewTextBoxColumn BillInfoFoodName;
        private DataGridViewTextBoxColumn BillInfoQuantity;
        private DataGridViewTextBoxColumn BillInfoPrice;
        private DataGridViewTextBoxColumn BillInfoId;
    }
}