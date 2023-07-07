using AutoMapper;
using AutoMapper.Configuration.Conventions;
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

            try
            {
                PictureBox clickedPictureBox = (PictureBox)sender;
                string tableId = clickedPictureBox.Tag.ToString();
                Panel tablePanel = (Panel)clickedPictureBox.Parent;

                if (selectedPanel != null && selectedPanel.BackColor != Color.DarkGray)
                {
                    selectedPanel.BackColor = Color.White;
                    lbTotal.Text = "Tổng tiền";
                }

                if (tablePanel.BackColor != Color.DarkGray)
                {
                    tablePanel.BackColor = Color.LightSkyBlue;
                    selectedPanel = tablePanel;
                    activeColumns(false);
                    lbTotal.Text = "Tổng tiền";
                }

                if (tablePanel.BackColor == Color.DarkGray)
                {
                    getListBillInfo(tableId);
                    selectedPanel = tablePanel;
                    var billDTO = billBUS.getBillDTO(tableId);
                    if (billDTO != null)
                    {
                        int total = billInfoBUS.totalPrice(billDTO.Id);
                        lbTotal.Text = "Tổng tiền: " + total.ToString();
                    }
                }

                label2.Text = clickedPictureBox.Name;
                lbId.Text = tableId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yêu cầu không hợp lệ");
            }

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
                        Up = "▲",
                        Down = "▼",
                        Delete = "Xóa",
                    }).ToList();
                dataBillInfo.Columns["BillInfoId"].DataPropertyName = "Id";
                dataBillInfo.Columns["BillInfoFoodName"].DataPropertyName = "FoodName";
                dataBillInfo.Columns["BillInfoUp"].DataPropertyName = "Up";
                dataBillInfo.Columns["BillInfoQuantity"].DataPropertyName = "Amount";
                dataBillInfo.Columns["BillInfoDown"].DataPropertyName = "Down";
                dataBillInfo.Columns["BillInfoPrice"].DataPropertyName = "FoodPrice";
                dataBillInfo.Columns["BillInfoDelete"].DataPropertyName = "Delete";
                activeColumns(true);
                dataBillInfo.DataSource = billInfoDTOs;

            }
        }

        public void activeColumns(bool boolean)
        {
            dataBillInfo.Columns["BillInfoFoodName"].Visible = boolean;
            dataBillInfo.Columns["BillInfoQuantity"].Visible = boolean;
            dataBillInfo.Columns["BillInfoUp"].Visible = boolean;
            dataBillInfo.Columns["BillInfoPrice"].Visible = boolean;
            dataBillInfo.Columns["BillInfoId"].Visible = false;
            dataBillInfo.Columns["BillInfoDown"].Visible = boolean;
            dataBillInfo.Columns["BillInfoDelete"].Visible = boolean;
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
                this.CreateAndUpdateBill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CreateAndUpdateBill()
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
                table.Status = false;
                billBUS.create(billDTO, billInfoDTO, table);
                MessageBox.Show("Thêm món thành công");
                lbTotal.Text = "Tổng tiền: " + billInfoBUS.totalPrice(billDTO.Id).ToString();
                getListBillInfo(table.Id);
                return;
            }
            if (table.Status == false)
            {
                var billDTO = billBUS.getBillDTO(table.Id);
                if (billDTO == null) throw new Exception("Yêu cầu không hợp lệ");
                var billInfoDTO = billInfoBUS.getByBillIdAndFoodId(billDTO.Id, lbFoodID.Text);
                if (billInfoDTO == null)
                {
                    billInfoDTO = this.createBillInfoDTO(billDTO.Id, lbFoodID.Text, 1);
                    billInfoBUS.create(billInfoDTO);
                    MessageBox.Show("Thêm món thành công");
                    getListBillInfo(table.Id);
                    lbTotal.Text = "Tổng tiền: " + billInfoBUS.totalPrice(billDTO.Id).ToString();
                    return;
                }
                if (billInfoDTO != null)
                {
                    billInfoDTO.Amount = 1 + billInfoDTO.Amount;
                    billInfoBUS.update(billInfoDTO);
                    MessageBox.Show("Cập nhập số lượng món thành công");
                    getListBillInfo(table.Id);
                    lbTotal.Text = "Tổng tiền: " + billInfoBUS.totalPrice(billDTO.Id).ToString();
                    return;
                }
            }
        }

        private BillDTO creatBillDTO(string tableId)
        {
            BillDTO billDTO = new BillDTO();
            billDTO.Id = Guid.NewGuid().ToString();
            billDTO.TableId = tableId;
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

        private void IbtnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedPanel == null) throw new Exception("Vui lòng chọn bàn trước");
                TableCoffeeDTO table = coffeeTableBUS.getTable(lbId.Text);
                if (table != null)
                {
                    selectedPanel.BackColor = Color.White;
                }
                table.Status = true;
                var billDTO = billBUS.getBillDTO(table.Id);
                if (billDTO == null) throw new Exception("Yêu cầu không hợp lệ");
                billDTO.CheckOut = DateTime.Now;
                billDTO.TotalPrice = billInfoBUS.totalPrice(billDTO.Id);
                billBUS.update(billDTO, table);
                this.activeColumns(false);
                lbTotal.Text = "Tổng tiền";
                MessageBox.Show("Thanh toán thành công");
            }
            catch (Exception ex)
            {
                if(selectedPanel != null)
                {
                    selectedPanel.BackColor = Color.DarkGray;
                }
                MessageBox.Show(ex.Message);
            }
        }

        private void dataBillInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataBillInfo.Rows[e.RowIndex].Cells["BillInfoQuantity"].Value == null)
                {
                    throw new Exception("Yêu cầu không hợp lệ");
                }
                if (e.ColumnIndex == dataBillInfo.Columns["BillInfoUp"].Index)
                {
                    int quantity = int.Parse(
                        dataBillInfo.Rows[e.RowIndex].Cells["BillInfoQuantity"].Value.ToString());
                    int newQuantity = quantity + 1;
                    string id = dataBillInfo.Rows[e.RowIndex].Cells["BillInfoId"].Value.ToString();
                    var billInfoDTO = billInfoBUS.getById(id);
                    if (billInfoDTO == null) throw new Exception("Không thể cập nhập số lượng trong lúc này");
                    billInfoDTO.Amount = newQuantity;
                    billInfoBUS.update(billInfoDTO);
                    int newTotal = billInfoBUS.totalPrice(billInfoDTO.BillId);
                    lbTotal.Text = "Tổng tiền: " + newTotal.ToString();
                    this.getListBillInfo(lbId.Text);
                }
                if (e.ColumnIndex == dataBillInfo.Columns["BillInfoDown"].Index)
                {
                    int quantity = int.Parse(
                        dataBillInfo.Rows[e.RowIndex].Cells["BillInfoQuantity"].Value.ToString());
                    if (quantity > 1)
                    {
                        int newQuantity = quantity - 1;
                        string id = dataBillInfo.Rows[e.RowIndex].Cells["BillInfoId"].Value.ToString();
                        var billInfoDTO = billInfoBUS.getById(id);
                        if (billInfoDTO == null) throw new Exception("Không thể cập nhập số lượng trong lúc này");
                        billInfoDTO.Amount = newQuantity;
                        billInfoBUS.update(billInfoDTO);
                        int newTotal = billInfoBUS.totalPrice(billInfoDTO.BillId);
                        lbTotal.Text = "Tổng tiền: " + newTotal.ToString();
                        this.getListBillInfo(lbId.Text);
                        return;
                    }
                    if (quantity == 1)
                    {


                        string id = dataBillInfo.Rows[e.RowIndex].Cells["BillInfoId"].Value.ToString();
                        var billInfoDTO = billInfoBUS.getById(id);

                        if (!checkBillIsDeleteAll(billInfoDTO.BillId))
                        {

                            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa toàn bộ món " +
                                 " ?", "Xác nhận xóa", MessageBoxButtons.YesNo);

                            if (result == DialogResult.Yes)
                            {
                                try
                                {
                                    this.deleteBill(billInfoDTO.BillId, lbId.Text, billInfoDTO);
                                    this.activeColumns(false);
                                    lbTotal.Text = "Tổng tiền";
                                    selectedPanel.BackColor = Color.White;
                                }
                                catch
                                {
                                    MessageBox.Show("Xóa thất bại");
                                }
                            }
                            return;
                        }
                        bool isDelete = billInfoBUS.delete(billInfoDTO);
                        if (!isDelete)
                        {
                            throw new Exception("Không thể cập nhập số lượng trong lúc này");
                        }
                        int newTotal = billInfoBUS.totalPrice(billInfoDTO.BillId);
                        lbTotal.Text = "Tổng tiền: " + newTotal.ToString();
                        
                        this.getListBillInfo(lbId.Text);
                    }
                  

                    }
                if (e.ColumnIndex == dataBillInfo.Columns["BillInfoDelete"].Index)
                {
                    string id = dataBillInfo.Rows[e.RowIndex].Cells["BillInfoId"].Value.ToString();
                    var billInfoDTO = billInfoBUS.getById(id);
                    var table = coffeeTableBUS.getTable(lbId.Text);
                    if (!checkBillIsDeleteAll(billInfoDTO.BillId))
                    {

                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa toàn bộ món " +
                             " ?", "Xác nhận xóa", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                this.deleteBill(billInfoDTO.BillId, table.Id, billInfoDTO);
                                this.activeColumns(false);
                                lbTotal.Text = "Tổng tiền";
                                selectedPanel.BackColor = Color.White;
                            }
                            catch
                            {
                                MessageBox.Show("Xóa thất bại");
                            }
                        }
                        return;
                    }
                    else
                    {

                        bool isDelete = billInfoBUS.delete(billInfoDTO);
                        if (!isDelete)
                        {
                            throw new Exception("Không thể cập nhập số lượng trong lúc này");
                        }
                        int newTotal = billInfoBUS.totalPrice(billInfoDTO.BillId);
                        this.getListBillInfo(lbId.Text);
                        lbTotal.Text = "Tổng tiền: " + newTotal.ToString();

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteBill(string billId, string tableId, BillInfoDTO billInfoDTO)
        {          
                var table = coffeeTableBUS.getTable(tableId);
                if (table == null) throw new Exception("Bàn không hợp lệ");
                table.Status = true;
                var billDTO = billBUS.getById(billId);
                if (billDTO == null) throw new Exception("Hóa đơn khônghợp lệ");
                billBUS.delete(billDTO, billInfoDTO, table);
            
        }

        public bool checkBillIsDeleteAll(string billId)
        {
            var listCheck = billInfoBUS.getAllByBillId(billId).ToList();
            if(listCheck.Count == 1)
            {
                return false;
            }
            return true;
        }
    }

}
