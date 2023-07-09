using AutoMapper;
using BUS;
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
    public partial class LoginForm : Form
    {
        private readonly IMapper _mapper;
        private AccountBUS bus;
        public bool isLogin = false;
        public string DisplayName;
        public LoginForm(IMapper mapper)
        {
            this._mapper = mapper;
            this.bus = new AccountBUS(_mapper);
            InitializeComponent();
        }

        private List<AccountDTO> getAllAccount()
        {
            var list = bus.GetAll();
            return list;
        }

        private async void ibtnLogin_Click(object sender, EventArgs e)
        {
            var list = getAllAccount();
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            progressBarForm progressBarForm = new progressBarForm();
            progressBarForm.StartPosition = FormStartPosition.CenterScreen;
            progressBarForm.Show();
            await Task.Delay(1500);

            foreach (var item in list)
            {
                if (item.UserName == userName && item.Password == password)
                {
                    isLogin = true;
                    DisplayName = item.DisplayName;
                    MessageBox.Show("Đăng nhập thành công");
                    progressBarForm.Close();
                    this.Close();
                    return;
                }
            }
            progressBarForm.Close();
            MessageBox.Show("Đăng nhập không thành công");
        }


    }
}
