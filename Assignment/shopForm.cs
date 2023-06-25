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
        private BillInfoBUS billInfoBUS;
        private FoodDTO foodDTO;
        public shopForm(IMapper mapper)
        {
            InitializeComponent();
            this._mapper = mapper;
            coffeeTableBUS = new TableCoffeeBUS(_mapper);
            this.cateBUS = new CategoryFoodBUS(_mapper);
            this.foodBUS = new FoodBUS(_mapper);
            this.billBUS = new BillBUS(_mapper);
            this.billInfoBUS = new BillInfoBUS(_mapper);
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

            PictureBox clickedPictureBox = (PictureBox)sender;
            string tableId = clickedPictureBox.Tag.ToString();
            Panel tablePanel = (Panel)clickedPictureBox.Parent;

            if (selectedPanel != null && selectedPanel.BackColor != Color.DarkGray)
            {
                selectedPanel.BackColor = Color.White;
            }

            if (tablePanel.BackColor != Color.DarkGray)
            {
                tablePanel.BackColor = Color.LightSkyBlue;
                selectedPanel = tablePanel;
                dataBillInfo.Columns["BillInfoFoodName"].DataPropertyName = "";
                dataBillInfo.Columns["BillInfoQuantity"].DataPropertyName = "";
                dataBillInfo.Columns["BillInfoPrice"].DataPropertyName = "";
                dataBillInfo.Columns["BillInfoId"].DataPropertyName = "";
                dataBillInfo.Columns["BillInfoDelete"].DataPropertyName = "";
            }

            if (tablePanel.BackColor == Color.DarkGray)
            {
                this.getListBillInfo(clickedPictureBox.Tag.ToString());

            }

            label2.Text = clickedPictureBox.Name;
            lbId.Text = tableId;

        }

        private void getListBillInfo(string TableId)
        {
            var billDTO = billBUS.getBillDTO(TableId);
            if (billDTO != null)
            {
                var billInfoDTOs = billInfoBUS.getAllByBillId(billDTO.Id).
                    Select(p => new
                    {
                        p.Id,
                        FoodName = p.Food.Name,
                        FoodPrice = p.Food.Price,
                        p.Amount,
                        Delete = "Xóa",
                    }).ToList();
                dataBillInfo.Columns["BillInfoFoodName"].DataPropertyName = "FoodName";
                dataBillInfo.Columns["BillInfoQuantity"].DataPropertyName = "Amount";
                dataBillInfo.Columns["BillInfoPrice"].DataPropertyName = "FoodPrice";
                dataBillInfo.Columns["BillInfoId"].DataPropertyName = "Id";
                dataBillInfo.Columns["BillInfoDelete"].DataPropertyName = "Delete";
                dataBillInfo.DataSource = billInfoDTOs;
            }
            else
            {
                MessageBox.Show("Yêu cầu không hợp lệ");
            }
        }


        private Panel CreateTablePanel(TableCoffeeDTO table)
        {
            Panel tablePanel = new Panel();
            tablePanel.Name = "panelTable" + table.Id;
            tablePanel.BorderStyle = BorderStyle.FixedSingle;
            if (!table.Status)
            {
                tablePanel.BackColor = Color.DarkGray;
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
            try
            {
                string id = dataFood.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                var food = foodBUS.getFood(id);
                foodDTO = food;
                lbFood.Text = foodDTO.Name;
                lbFoodPrice.Text = foodDTO.Price.ToString() + " VND";
                lbFoodID.Text = food.Id;
            }
            catch
            {
                MessageBox.Show("Vui lòng click chuột vào trong bảng");
            }
        }

        private void ibtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (foodDTO == null) throw new Exception("Vui lòng chọn món trước");
                if (selectedPanel == null) throw new Exception("Vui lòng chọn bàn trước");
                TableCoffeeDTO table = coffeeTableBUS.getTable(lbId.Text);
                if (table != null)
                {
                    selectedPanel.BackColor = Color.DarkGray;
                }

                if (table.Status == true)
                {
                    BillDTO billDTO = this.creatBillDTO(table.Id);
                    BillInfoDTO billInfoDTO = this.createBillInfoDTO(billDTO.Id, lbFoodID.Text, 1);
                    billBUS.create(billDTO, billInfoDTO);
                    table.Status = false;
                    coffeeTableBUS.updateStatus(table);
                    MessageBox.Show("Thêm món thành công");
                }
                if (table.Status == false)
                {
                    var billDTO = billBUS.getBillDTO(table.Id);
                    MessageBox.Show(billDTO.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private BillDTO creatBillDTO(string tableId)
        {
            BillDTO billDTO = new BillDTO();
            billDTO.Id = Guid.NewGuid().ToString();
            billDTO.TableId = tableId;
            billDTO.CheckIn = DateTime.Now;
            billDTO.Discount = 1;
            billDTO.Status = 0;
            return billDTO;
        }

        private BillInfoDTO createBillInfoDTO(string billId, string foodID, int amount)
        {
            BillInfoDTO billInfoDTO = new BillInfoDTO();
            billInfoDTO.Id = Guid.NewGuid().ToString();
            billInfoDTO.FoodId = foodID;
            billInfoDTO.BillId = billId;
            billInfoDTO.Amount = amount;
            return billInfoDTO;
        }

    }

}
