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
    public partial class shopForm : Form
    {


        private readonly IMapper _mapper;
        private TableCoffeeBUS coffeeTableBUS;
        private CategoryFoodBUS cateBUS;
        private FoodBUS foodBUS;
        private Panel selectedPanel;
        private BillBUS billBUS;
        private FoodDTO foodDTO;
        public shopForm(IMapper mapper)
        {
            InitializeComponent();
            this._mapper = mapper;
            coffeeTableBUS = new TableCoffeeBUS(_mapper);
            this.cateBUS = new CategoryFoodBUS(_mapper);
            this.foodBUS = new FoodBUS(_mapper);
            this.billBUS = new BillBUS(_mapper);
            this.loadListFood();
            this.CreatePanels();

        }

        private void CreatePanels()
        {
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Padding = new Padding(10);
            pnlHome.Controls.Add(flowLayoutPanel);
            var listTable = this.Tables();
            foreach (TableCoffeeDTO item in listTable)
            {
                Panel tablePanel = CreateTablePanel(item);
                flowLayoutPanel.Controls.Add(tablePanel);
            }
        }

        private List<TableCoffeeDTO> Tables()
        {
            return coffeeTableBUS.getAll().ToList();
        }

        private void loadListFood()
        {
            var listCate = cateBUS.getAll();
            var allCategory = new CategoryFoodDTO { Id = "all", Name = "All" };

            // Thêm lựa chọn "All" vào danh sách danh mục
            listCate.Insert(0, allCategory);

            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
            cbCategory.DataSource = listCate;


            var foods = foodBUS.getAll().Where(p => p.Status == true).Select(p => new
            {
                p.Id,
                p.Name,
                p.Price,
                Category = p.Category.Name,
            }).ToList();
            dataFood.Columns["Id"].DataPropertyName = "Id";
            dataFood.Columns["Id"].Visible = false;
            dataFood.Columns["FoodName"].DataPropertyName = "Name";
            dataFood.Columns["Category"].DataPropertyName = "Category";
            dataFood.Columns["Price"].DataPropertyName = "Price";
            dataFood.DataSource = foods;

        }

        private void TablePictureBox_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                PictureBox clickedPictureBox = (PictureBox)sender;
                string tableId = clickedPictureBox.Tag.ToString();
                Panel tablePanel = (Panel)clickedPictureBox.Parent;

                if (selectedPanel != null)
                {
                    selectedPanel.BackColor = Color.White;
                }

                tablePanel.BackColor = Color.LightSkyBlue;
                selectedPanel = tablePanel;

                label2.Text = clickedPictureBox.Name;
                lbId.Text = tableId;
            }
        }


        private Panel CreateTablePanel(TableCoffeeDTO table)
        {
            Panel tablePanel = new Panel();
            tablePanel.Name = "panelTable" + table.Id;
            tablePanel.BorderStyle = BorderStyle.FixedSingle;
            if (!table.Status)
            {
                tablePanel.BackColor = Color.LightSkyBlue;
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
            tablePictureBox.Name = table.Name;
            tablePictureBox.Tag = table.Id;
            tablePictureBox.ImageLocation = "C:\\Users\\duyba\\OneDrive\\Desktop\\video\\7113274.png";
            tablePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            tablePictureBox.Click += TablePictureBox_Click;
            tableLayoutPanel.Controls.Add(tablePictureBox, 0, 0);

            TextBox textBox = new TextBox();
            textBox.Name = "txtTable" + table.Id;
            textBox.Text = table.Name;
            textBox.Enabled = false;
            textBox.Dock = DockStyle.Fill;
            tableLayoutPanel.Controls.Add(textBox, 0, 1);
            tablePanel.Controls.Add(tableLayoutPanel);

            return tablePanel;
        }


        private void dataFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataFood.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            var food = foodBUS.getFood(id);
            foodDTO = food;
            lbFood.Text = foodDTO.Name;
            lbFoodPrice.Text = foodDTO.Price.ToString() + " VND";
        }

        private void ibtnAdd_Click(object sender, EventArgs e)
        {
            if(foodDTO == null)
            {
                MessageBox.Show("Vui lòng chọn đồ uống trước");
                return;
            }

        }
    }

}
