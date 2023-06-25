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
            accountDataG = new DataGridView();
            UserName = new DataGridViewTextBoxColumn();
            DisplayName = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ibtnImage = new FontAwesome.Sharp.IconButton();
            panel7 = new Panel();
            pictureBox1 = new PictureBox();
            lbCRUD = new Label();
            ibtnCancel = new FontAwesome.Sharp.IconButton();
            ibtnConfirm = new FontAwesome.Sharp.IconButton();
            panel6 = new Panel();
            label2 = new Label();
            txtDisplayname = new TextBox();
            panel5 = new Panel();
            label1 = new Label();
            txtPassword = new TextBox();
            panel4 = new Panel();
            lbUsername = new Label();
            txtUsername = new TextBox();
            ((System.ComponentModel.ISupportInitialize)accountDataG).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // accountDataG
            // 
            accountDataG.BackgroundColor = Color.White;
            accountDataG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            accountDataG.Columns.AddRange(new DataGridViewColumn[] { UserName, DisplayName, Type, Edit, Delete });
            accountDataG.Location = new Point(39, 57);
            accountDataG.Name = "accountDataG";
            accountDataG.RowTemplate.Height = 25;
            accountDataG.Size = new Size(703, 521);
            accountDataG.TabIndex = 0;
            accountDataG.CellContentClick += accountDataG_CellContentClick;
            // 
            // UserName
            // 
            UserName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UserName.HeaderText = "Tài khoản";
            UserName.Name = "UserName";
            // 
            // DisplayName
            // 
            DisplayName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DisplayName.HeaderText = "Tên hiển thị";
            DisplayName.Name = "DisplayName";
            // 
            // Type
            // 
            Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Type.HeaderText = "Chức vụ";
            Type.Name = "Type";
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 37, 45);
            panel1.Location = new Point(323, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 567);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(accountDataG);
            panel2.Location = new Point(350, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(771, 593);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(ibtnImage);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(lbCRUD);
            panel3.Controls.Add(ibtnCancel);
            panel3.Controls.Add(ibtnConfirm);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(12, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(294, 625);
            panel3.TabIndex = 3;
            // 
            // ibtnImage
            // 
            ibtnImage.BackColor = Color.FromArgb(182, 205, 84);
            ibtnImage.IconChar = FontAwesome.Sharp.IconChar.Images;
            ibtnImage.IconColor = Color.Black;
            ibtnImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnImage.IconSize = 30;
            ibtnImage.Location = new Point(247, 17);
            ibtnImage.Name = "ibtnImage";
            ibtnImage.Size = new Size(47, 30);
            ibtnImage.TabIndex = 9;
            ibtnImage.TextAlign = ContentAlignment.MiddleRight;
            ibtnImage.TextImageRelation = TextImageRelation.ImageBeforeText;
            ibtnImage.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(pictureBox1);
            panel7.Location = new Point(13, 44);
            panel7.Name = "panel7";
            panel7.Size = new Size(267, 191);
            panel7.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(34, 37, 45);
            pictureBox1.Location = new Point(6, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 171);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbCRUD
            // 
            lbCRUD.AutoSize = true;
            lbCRUD.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lbCRUD.ForeColor = Color.Black;
            lbCRUD.Location = new Point(0, 3);
            lbCRUD.Name = "lbCRUD";
            lbCRUD.Size = new Size(92, 25);
            lbCRUD.TabIndex = 8;
            lbCRUD.Text = "Thêm mới";
            // 
            // ibtnCancel
            // 
            ibtnCancel.BackColor = Color.FromArgb(225, 0, 125);
            ibtnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ibtnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            ibtnCancel.IconColor = Color.Black;
            ibtnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnCancel.Location = new Point(188, 545);
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
            ibtnConfirm.Location = new Point(79, 545);
            ibtnConfirm.Name = "ibtnConfirm";
            ibtnConfirm.Size = new Size(103, 44);
            ibtnConfirm.TabIndex = 6;
            ibtnConfirm.Text = "Xác nhận";
            ibtnConfirm.UseVisualStyleBackColor = false;
            ibtnConfirm.Click += ibtnConfirm_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(label2);
            panel6.Controls.Add(txtDisplayname);
            panel6.Location = new Point(8, 356);
            panel6.Name = "panel6";
            panel6.Size = new Size(272, 45);
            panel6.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(0, 11);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 1;
            label2.Text = "Tên hiển thị";
            // 
            // txtDisplayname
            // 
            txtDisplayname.BackColor = Color.White;
            txtDisplayname.Location = new Point(89, 9);
            txtDisplayname.Name = "txtDisplayname";
            txtDisplayname.Size = new Size(180, 23);
            txtDisplayname.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Controls.Add(txtPassword);
            panel5.Location = new Point(4, 450);
            panel5.Name = "panel5";
            panel5.Size = new Size(272, 45);
            panel5.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(8, 11);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 1;
            label1.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.InactiveCaption;
            txtPassword.Location = new Point(89, 9);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(180, 23);
            txtPassword.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(lbUsername);
            panel4.Controls.Add(txtUsername);
            panel4.Location = new Point(7, 259);
            panel4.Name = "panel4";
            panel4.Size = new Size(272, 45);
            panel4.TabIndex = 4;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbUsername.ForeColor = Color.Black;
            lbUsername.Location = new Point(8, 11);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(75, 21);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Tài khoản";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Location = new Point(89, 9);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(180, 23);
            txtUsername.TabIndex = 0;
            // 
            // accountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1144, 623);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "accountForm";
            Text = "accountForm";
            Load += accountForm_Load;
            ((System.ComponentModel.ISupportInitialize)accountDataG).EndInit();
            panel2.ResumeLayout(false);
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
            ResumeLayout(false);
        }

        #endregion

        private DataGridView accountDataG;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtUsername;
        private FontAwesome.Sharp.IconButton ibtnConfirm;
        private Panel panel6;
        private Label label2;
        private TextBox txtDisplayname;
        private Panel panel5;
        private Label label1;
        private TextBox txtPassword;
        private Panel panel4;
        private Label lbUsername;
        private FontAwesome.Sharp.IconButton ibtnCancel;
        private Label lbCRUD;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn DisplayName;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Panel panel7;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton ibtnImage;
    }
}