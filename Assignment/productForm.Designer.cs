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
            panel7 = new Panel();
            pictureBox1 = new PictureBox();
            lbCRUD = new Label();
            ibtnImage = new FontAwesome.Sharp.IconButton();
            panel6 = new Panel();
            cbCategory = new ComboBox();
            label2 = new Label();
            ibtnCancel = new FontAwesome.Sharp.IconButton();
            ibtnConfirm = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            label1 = new Label();
            txtPrice = new TextBox();
            panel4 = new Panel();
            lbUsername = new Label();
            txtName = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            dataFood = new DataGridView();
            FoodName = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            lbID = new Label();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataFood).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(lbCRUD);
            panel3.Controls.Add(ibtnImage);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(ibtnCancel);
            panel3.Controls.Add(ibtnConfirm);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(12, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(335, 625);
            panel3.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.Controls.Add(pictureBox1);
            panel7.Location = new Point(19, 51);
            panel7.Name = "panel7";
            panel7.Size = new Size(284, 187);
            panel7.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(34, 37, 45);
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 181);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbCRUD
            // 
            lbCRUD.AutoSize = true;
            lbCRUD.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lbCRUD.ForeColor = Color.Black;
            lbCRUD.Location = new Point(0, 0);
            lbCRUD.Name = "lbCRUD";
            lbCRUD.Size = new Size(92, 25);
            lbCRUD.TabIndex = 9;
            lbCRUD.Text = "Thêm mới";
            // 
            // ibtnImage
            // 
            ibtnImage.BackColor = Color.FromArgb(182, 205, 84);
            ibtnImage.IconChar = FontAwesome.Sharp.IconChar.Images;
            ibtnImage.IconColor = Color.Black;
            ibtnImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnImage.IconSize = 30;
            ibtnImage.Location = new Point(285, 18);
            ibtnImage.Name = "ibtnImage";
            ibtnImage.Size = new Size(47, 30);
            ibtnImage.TabIndex = 8;
            ibtnImage.TextAlign = ContentAlignment.MiddleRight;
            ibtnImage.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnImage.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(cbCategory);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(3, 353);
            panel6.Name = "panel6";
            panel6.Size = new Size(284, 45);
            panel6.TabIndex = 6;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(123, 11);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(135, 23);
            cbCategory.TabIndex = 2;
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
            // ibtnCancel
            // 
            ibtnCancel.BackColor = Color.FromArgb(225, 0, 125);
            ibtnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ibtnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            ibtnCancel.IconColor = Color.Black;
            ibtnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnCancel.Location = new Point(231, 528);
            ibtnCancel.Name = "ibtnCancel";
            ibtnCancel.Size = new Size(103, 44);
            ibtnCancel.TabIndex = 7;
            ibtnCancel.Text = "Hủy bỏ";
            ibtnCancel.UseVisualStyleBackColor = false;
            ibtnCancel.Click += ibtnCancel_Click;
            // 
            // ibtnConfirm
            // 
            ibtnConfirm.BackColor = Color.FromArgb(5, 201, 204);
            ibtnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ibtnConfirm.IconChar = FontAwesome.Sharp.IconChar.None;
            ibtnConfirm.IconColor = Color.Black;
            ibtnConfirm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnConfirm.Location = new Point(126, 528);
            ibtnConfirm.Name = "ibtnConfirm";
            ibtnConfirm.Size = new Size(103, 44);
            ibtnConfirm.TabIndex = 6;
            ibtnConfirm.Text = "Xác nhận";
            ibtnConfirm.UseVisualStyleBackColor = false;
            ibtnConfirm.Click += ibtnConfirm_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Controls.Add(txtPrice);
            panel5.Location = new Point(3, 430);
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
            // txtPrice
            // 
            txtPrice.Location = new Point(47, 13);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(97, 23);
            txtPrice.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(lbUsername);
            panel4.Controls.Add(txtName);
            panel4.Location = new Point(1, 271);
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
            // txtName
            // 
            txtName.Location = new Point(119, 11);
            txtName.Name = "txtName";
            txtName.Size = new Size(180, 23);
            txtName.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 37, 45);
            panel1.Location = new Point(353, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 570);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataFood);
            panel2.Location = new Point(412, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(703, 593);
            panel2.TabIndex = 9;
            // 
            // dataFood
            // 
            dataFood.BackgroundColor = Color.White;
            dataFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataFood.Columns.AddRange(new DataGridViewColumn[] { FoodName, Id, Category, Price, Edit, Delete });
            dataFood.Location = new Point(0, 36);
            dataFood.Name = "dataFood";
            dataFood.RowTemplate.Height = 25;
            dataFood.Size = new Size(703, 521);
            dataFood.TabIndex = 1;
            dataFood.CellContentClick += dataFood_CellContentClick;
            // 
            // FoodName
            // 
            FoodName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FoodName.HeaderText = "Tên sản phẩm";
            FoodName.Name = "FoodName";
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Category
            // 
            Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Category.HeaderText = "Loại sản phẩm";
            Category.Name = "Category";
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.HeaderText = "Giá";
            Price.Name = "Price";
            // 
            // Edit
            // 
            Edit.HeaderText = "Chỉnh sửa";
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            // 
            // Delete
            // 
            Delete.HeaderText = "Xóa";
            Delete.Name = "Delete";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(31, 10);
            lbID.Name = "lbID";
            lbID.Size = new Size(0, 15);
            lbID.TabIndex = 10;
            lbID.Visible = false;
            // 
            // productForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1125, 667);
            Controls.Add(lbID);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "productForm";
            Text = "productForm";
            Load += productForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private FontAwesome.Sharp.IconButton ibtnCancel;
        private FontAwesome.Sharp.IconButton ibtnConfirm;
        private Panel panel5;
        private Label label1;
        private TextBox txtPrice;
        private Panel panel4;
        private Label lbUsername;
        private TextBox txtName;
        private Panel panel1;
        private Panel panel2;
        private Panel panel6;
        private ComboBox cbCategory;
        private Label label2;
        private FontAwesome.Sharp.IconButton ibtnImage;
        private Label lbCRUD;
        private DataGridView dataFood;
        private Panel panel7;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn FoodName;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Label lbID;
    }
}