using DAO;
using DAO.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class shopForm : Form
    {
        TableCoffeeService TableCoffeeSer;
        FoodService FoodSer;
        CategoryFoodService CategoryFoodSer;

        public shopForm()
        {
            InitializeComponent();
            //get list table
            TableCoffeeSer = new TableCoffeeService();
            FoodSer = new FoodService();
            CategoryFoodSer = new CategoryFoodService();
            var listCategory = CategoryFoodSer.GetAll().Select(p => new
            {
                p.Id,
                p.Name
            }).ToList();
            var obj = new
            {
                Id = "ALL",
                Name = "All"
            };
            listCategory.Insert(0, obj);
            cbType.DisplayMember = "Name";
            cbType.ValueMember = "Id";
            cbType.DataSource = listCategory;
            cbType.SelectedIndex = 0;

            var listTable = TableCoffeeSer.GetAll().Select(p => new { p.Id, p.Name, p.Status }).ToList();

            int tableCount = listTable.Count;

            

            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Padding = new Padding(10);

            pnlHome.Controls.Add(flowLayoutPanel);

            foreach (var item in listTable)
            {
                Panel tablePanel = CreateTablePanel(item.Name, item.Status);
                flowLayoutPanel.Controls.Add(tablePanel);
            }

        }

        private Panel CreateTablePanel(string name, bool status)
        {
            Panel tablePanel = new Panel();
            tablePanel.Name = "panelTable" + name;
            tablePanel.BorderStyle = BorderStyle.FixedSingle;
            if (status)
            {
                tablePanel.BackColor = Color.LimeGreen;
            }

            tablePanel.Size = new Size(120, 100);

            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 80));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));

            PictureBox tablePictureBox = new PictureBox();
            tablePictureBox.Name = "picTable" + name;
            tablePictureBox.ImageLocation = "https://firebasestorage.googleapis.com/v0/b/fxchangesapmle.appspot.com/o/c%23%2F7113274.png?alt=media&token=f293568b-19f3-4907-88a6-c9083c0b27cf";
            tablePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            tableLayoutPanel.Controls.Add(tablePictureBox, 0, 0);

            TextBox textBox = new TextBox();
            textBox.Name = "txtTable" + name;
            textBox.Text = "Bàn " + name;
            textBox.Enabled = false;
            textBox.Dock = DockStyle.Fill;
            tableLayoutPanel.Controls.Add(textBox, 0, 1);

            tablePanel.Controls.Add(tableLayoutPanel);

            return tablePanel;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var listFood1 = FoodSer.GetAll().Include(p => p.Category).Select(p => new
            {
                p.Id,
                p.Name,
                p.CategoryId,
                CategoryName = p.Category.Name,
                p.Price

            }).ToList();
            string selectedValue = cbType.SelectedValue.ToString();
            
            if(selectedValue.Equals("ALL"))
            {
                foodDgv.Rows.Clear();
                foreach (var item in listFood1)
                {
                    foodDgv.Rows.Add(item.Name, item.CategoryName, item.Price);
                }
            }
            else {
                var filteredData = listFood1.Where(item => item.CategoryId == selectedValue).ToList();
                foodDgv.Rows.Clear();
                foreach (var item in filteredData)
                {
                    foodDgv.Rows.Add(item.Name, item.CategoryName, item.Price);
                }
            }
            
        }
    }

}
