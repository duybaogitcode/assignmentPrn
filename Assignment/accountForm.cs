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
    public partial class accountForm : Form
    {
        private readonly IMapper _mapper;
        public accountForm(IMapper mapper)
        {
            InitializeComponent();
            _mapper = mapper;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountTypeBus bus = new AccountTypeBus(_mapper);
            string id = Guid.NewGuid().ToString();
            string typeName = "Nhân viên";

            AccountTypeDTO accountType = new AccountTypeDTO();
            accountType.Id = id;
            accountType.TypeName = typeName;

            try
            {
                bus.addNewAccountType(accountType);
                MessageBox.Show("Thêm mới thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm mới thất bại");
            }
        }
    }
}
