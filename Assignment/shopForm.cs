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
        private CoffeeTableBUS coffeeTableBUS;
        public shopForm(IMapper mapper)
        {
            InitializeComponent();
            this._mapper = mapper;
            coffeeTableBUS = new CoffeeTableBUS(_mapper);
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Padding = new Padding(10);

            pnlHome.Controls.Add(flowLayoutPanel);
            var listTable = this.Tables();
            foreach (TableCoffeeDTO item in listTable )
            {
                Panel tablePanel = CreateTablePanel(item.Name, item.Id , item.Status);
                flowLayoutPanel.Controls.Add(tablePanel);
            }

        }

        private List<TableCoffeeDTO> Tables()
        {
            return coffeeTableBUS.getAll().ToList();
        }

        private void TablePictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = (PictureBox)sender;
            string tableId = clickedPictureBox.Name;
            MessageBox.Show(tableId);
        }


        private Panel CreateTablePanel(string tableName, string tableId, bool status)
        {
            Panel tablePanel = new Panel();
            tablePanel.Name = "panelTable" + tableId;
            tablePanel.BorderStyle = BorderStyle.FixedSingle;
            if(!status)
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
            tablePictureBox.Name = tableId;
            tablePictureBox.ImageLocation = "C:\\Users\\duyba\\OneDrive\\Desktop\\video\\7113274.png";
            tablePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            tablePictureBox.Click += TablePictureBox_Click;
            tableLayoutPanel.Controls.Add(tablePictureBox, 0, 0);

            TextBox textBox = new TextBox();
            textBox.Name = "txtTable" + tableId;
            textBox.Text = tableName;
            textBox.Enabled = false;
            textBox.Dock = DockStyle.Fill;
            tableLayoutPanel.Controls.Add(textBox, 0, 1);
            tablePanel.Controls.Add(tableLayoutPanel);

            return tablePanel;
        }

    }

}
