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
                Panel tablePanel = CreateTablePanel(item.Id);
                flowLayoutPanel.Controls.Add(tablePanel);
            }

        }

        private List<TableCoffeeDTO> Tables()
        {
            return coffeeTableBUS.getAll().ToList();
        }


        private Panel CreateTablePanel(string tableId)
        {
            Panel tablePanel = new Panel();
            tablePanel.Name = "panelTable" + tableId;
            tablePanel.BorderStyle = BorderStyle.FixedSingle;
            //tablePanel.BackColor = Color.LimeGreen;
            tablePanel.Size = new Size(120, 100);

            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 80));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));

            PictureBox tablePictureBox = new PictureBox();
            tablePictureBox.Name = "picTable" + tableId;
            tablePictureBox.ImageLocation = "C:\\Users\\duyba\\OneDrive\\Desktop\\video\\7113274.png";
            tablePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            tableLayoutPanel.Controls.Add(tablePictureBox, 0, 0);

            TextBox textBox = new TextBox();
            textBox.Name = "txtTable" + tableId;
            textBox.Text = "Bàn " + tableId;
            textBox.Enabled = false;
            textBox.Dock = DockStyle.Fill;
            tableLayoutPanel.Controls.Add(textBox, 0, 1);

            tablePanel.Controls.Add(tableLayoutPanel);

            return tablePanel;
        }

    }

}
