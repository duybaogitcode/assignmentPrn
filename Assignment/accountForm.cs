using AutoMapper;
using BUS;
using DAO.Services;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class accountForm : Form
    {
        private readonly IMapper _mapper;
        private AccountBUS bus;
        private const string TypeID = "c1391b5d-5d7d-4881-a1ac-0567c172c65b";
        public accountForm(IMapper mapper)
        {
            InitializeComponent();
            _mapper = mapper;
            this.bus = new AccountBUS(_mapper);
            this.loadListAccount();
            pictureBox1.ImageLocation =
                "C:\\Users\\duyba\\OneDrive\\Desktop\\video\\" +
                "pngtree-businessman-user-avatar-free-vector-png-image_1538405.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }



        private void loadListAccount()
        {
            var accounts = bus.GetAll().Select(p => new
            {
                p.UserName,
                p.DisplayName,
                Type = p.Type.TypeName,
                Edit = "Chỉnh sửa",
                Delete = "Xóa",
            }).ToList();


            accountDataG.Columns["UserName"].DataPropertyName = "UserName";
            accountDataG.Columns["DisplayName"].DataPropertyName = "DisplayName";
            accountDataG.Columns["Type"].DataPropertyName = "Type";
            accountDataG.Columns["Edit"].DataPropertyName = "Edit";
            accountDataG.Columns["Delete"].DataPropertyName = "Delete";

            accountDataG.DataSource = accounts;
        }

        private AccountDTO CreateAccount()
        {
            AccountDTO accountDTO = new AccountDTO();
            accountDTO.UserName = txtUsername.Text != "" ?
                txtUsername.Text : throw new Exception("Tài khoản không được bỏ trống");
            accountDTO.Password = txtPassword.Text != "" ?
                txtPassword.Text : throw new Exception("Mật khẩu không được bỏ trống");
            accountDTO.DisplayName = txtDisplayname.Text != "" ?
                txtDisplayname.Text : throw new Exception("Tên hiển thị không được bỏ trống");
            accountDTO.TypeId = TypeID;
            return accountDTO;
        }

        private AccountDTO UpdateAccount()
        {
            AccountDTO accountDTO = new AccountDTO();
            accountDTO = bus.getAccount(txtUsername.Text);
            accountDTO.Password = txtPassword.Text != "" ?
                txtPassword.Text : accountDTO.Password;
            accountDTO.DisplayName = txtDisplayname.Text != "" ?
                txtDisplayname.Text : accountDTO.DisplayName;
            accountDTO.TypeId = TypeID;
            return accountDTO;
        }


        private void ibtnConfirm_Click(object sender, EventArgs e)
        {
            string crud = lbCRUD.Text;
            switch (crud)
            {
                case "Thêm mới":
                    {
                        try
                        {
                            var accountDTO = CreateAccount();
                            bus.createAccount(accountDTO);
                            this.loadListAccount();
                            MessageBox.Show("Thêm mới thành công");
                        }
                        catch (Exception ex)
                        {
                            if (ex.Message.Contains("existing"))
                            {
                                MessageBox.Show("Tên tài khoản bị trùng");
                            }
                            else
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                        break;
                    }

                case "Chỉnh sửa":
                    {

                        try
                        {
                            var accountDTO = UpdateAccount();
                            bus.updateAccount(accountDTO); this.loadListAccount();
                            MessageBox.Show("Cập nhập thành công");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            MessageBox.Show("Cập nhập thất bại");
                        }
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Yêu cầu không hợp lệ");
                        break;

                    }

            }
        }

        private void ibtnCancel_Click(object sender, EventArgs e)
        {
            this.reset();
            lbCRUD.Text = "Thêm mới";
            txtUsername.Enabled = true;

        }

        private void reset()
        {
            txtUsername.Text = "";
            txtDisplayname.Text = "";
            txtPassword.Text = "";
        }

        private void accountForm_Load(object sender, EventArgs e)
        {

        }

        private void accountDataG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                string userName = accountDataG.Rows[e.RowIndex].Cells["UserName"].Value.ToString();

                var accountDTO = bus.getAccount(userName);
                if (e.ColumnIndex == accountDataG.Columns["Edit"].Index)
                {

                    txtUsername.Text = accountDTO.UserName;
                    txtUsername.Enabled = false;
                    txtDisplayname.Text = accountDTO.DisplayName;
                    txtPassword.Text = accountDTO.Password;
                    lbCRUD.Text = "Chỉnh sửa";
                }
                if (e.ColumnIndex == accountDataG.Columns["Delete"].Index)
                {
                    this.reset();
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa " + userName + " ?", "Xác nhận xóa", MessageBoxButtons.YesNo);


                    if (result == DialogResult.Yes)
                    {
                        bool isDelete = bus.deleteAccount(accountDTO);
                        if (isDelete)
                        {
                            MessageBox.Show("Xóa thành công");
                            this.loadListAccount();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã hủy lựa chọn");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Tài khoản không tồn tại");
            }
        }

    }
}
