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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment
{
    public partial class productForm : Form
    {
        private readonly IMapper _mapper;
        private CategoryFoodBUS cateBUS;
        private FoodBUS foodBUS;
        public productForm(IMapper mapper)
        {
            InitializeComponent();
            this._mapper = mapper;
            this.cateBUS = new CategoryFoodBUS(_mapper);
            this.foodBUS = new FoodBUS(_mapper);
            this.loadListFood();
            pictureBox1.ImageLocation =
                "C:\\Users\\duyba\\OneDrive\\Desktop\\video\\ca-phe-nguyen-chat-bao-nhieu-tien-1kg-2.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void productForm_Load(object sender, EventArgs e)
        {


        }

        private void loadListFood()
        {
            var listCate = cateBUS.getAll();
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "Id";
            cbCategory.DataSource = listCate;

            var foods = foodBUS.getAll().Where(p => p.Status == true).Select(p => new
            {
                p.Id,
                p.Name,
                p.Price,
                Category = p.Category.Name,
                Edit = "Chỉnh sửa",
                Delete = "Xóa",
            }).ToList();
            dataFood.Columns["Id"].DataPropertyName = "Id";
            dataFood.Columns["Id"].Visible = false;
            dataFood.Columns["FoodName"].DataPropertyName = "Name";
            dataFood.Columns["Category"].DataPropertyName = "Category";
            dataFood.Columns["Price"].DataPropertyName = "Price";
            dataFood.Columns["Edit"].DataPropertyName = "Edit";
            dataFood.Columns["Delete"].DataPropertyName = "Delete";
            dataFood.DataSource = foods;

        }

        private FoodDTO CreateFood()
        {
            FoodDTO foodDTO = new FoodDTO();
            foodDTO.Id = Guid.NewGuid().ToString();
            foodDTO.Name = txtName.Text != "" ? txtName.Text : throw new
                Exception("Tên sản phẩm không được trống");
            foodDTO.Price = txtPrice.Text != "" ? int.Parse(txtPrice.Text) :
                throw new Exception("Giá phẩm không được trống");
            if (foodDTO.Price < 5000)
            {
                throw new Exception("Giá phẩm không hợp lệ");
            }
            foodDTO.Status = true;
            foodDTO.CategoryId = cbCategory.SelectedValue.ToString();
            return foodDTO;
        }


        private FoodDTO UpdateFood()
        {
            string id = lbID.Text != "" ? lbID.Text : throw new Exception("Lỗi không tìm thấy sản phẩm");
            FoodDTO foodDTO;
            foodDTO = foodBUS.getFood(id);
            if (foodDTO != null)
            {
                foodDTO.Name = txtName.Text != "" ? txtName.Text : throw new
                        Exception("Tên sản phẩm không được trống");
                foodDTO.Price = txtPrice.Text != "" ? int.Parse(txtPrice.Text) :
                    throw new Exception("Giá phẩm không được trống");
                if (foodDTO.Price < 5000)
                {
                    throw new Exception("Giá phẩm không hợp lệ");
                }
                foodDTO.CategoryId = cbCategory.SelectedValue.ToString();
            }
            return foodDTO;
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
                            var foodDTO = CreateFood();
                            foodBUS.create(foodDTO);
                            MessageBox.Show("Thêm mới thành công");
                            this.loadListFood();
                        }
                        catch (Exception ex)
                        {
                            if (ex.Message.Contains("format"))
                            {
                                MessageBox.Show("Nhập không đúng định dạng");
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
                            var foodDTO = UpdateFood();
                            foodBUS.update(foodDTO);
                            MessageBox.Show("Sửa đổi thành công");
                            this.loadListFood();
                        }
                        catch (Exception ex)
                        {
                            if (ex.Message.Contains("format"))
                            {
                                MessageBox.Show("Nhập không đúng định dạng");
                            }
                            else
                            {
                                MessageBox.Show(ex.Message);
                            }
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

        private void dataFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = dataFood.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                if (e.ColumnIndex == dataFood.Columns["Edit"].Index)
                {
                    lbCRUD.Text = "Chỉnh sửa";
                    FoodDTO foodDTO = foodBUS.getFood(id);
                    if (foodDTO != null)
                    {
                        txtName.Text = foodDTO.Name;
                        txtPrice.Text = foodDTO.Price.ToString();
                        cbCategory.SelectedValue = foodDTO.CategoryId;
                        lbID.Text = id;
                    }
                    else
                    {
                        MessageBox.Show("Yêu cầu không hợp lệ");
                    }
                }
                if (e.ColumnIndex == dataFood.Columns["Delete"].Index)
                {
                    this.reset();
                    FoodDTO foodDTO = foodBUS.getFood(id);
                    if (foodDTO != null)
                    {

                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa " + foodDTO.Name
                            + " ?", "Xác nhận xóa", MessageBoxButtons.YesNo);


                        if (result == DialogResult.Yes)
                        {
                            foodDTO.Status = false;
                            try
                            {
                                foodBUS.update(foodDTO);
                                MessageBox.Show("Xóa thành công");
                                this.loadListFood();
                            }
                            catch
                            {
                                MessageBox.Show("Xóa thất bại");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Yêu cầu không hợp lệ");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Sản phẩm không tồn tại");
            }
        }

        private void ibtnCancel_Click(object sender, EventArgs e)
        {
            this.reset();
            lbCRUD.Text = "Thêm mới";
        }

        private void reset()
        {
            txtName.Text = "";
            txtPrice.Text = "";
            lbID.Text = "";
        }
    }
}
