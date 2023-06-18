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
        public accountForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountTypeBus bus = new AccountTypeBus();
            string id = Guid.NewGuid().ToString();
            string typeName = "Quản lí";

            AccountTypeDTO accountType = new AccountTypeDTO();
            accountType.Id = id;
            accountType.TypeName = typeName;

            bus.addNewAccountType(accountType);
        }
    }
}
