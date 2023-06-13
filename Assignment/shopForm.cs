﻿using System;
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


        int tableCount = 12;

        public shopForm()
        {
            InitializeComponent();
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Padding = new Padding(10);

            pnlHome.Controls.Add(flowLayoutPanel);

            for (int i = 1; i <= tableCount; i++)
            {
                Panel tablePanel = CreateTablePanel(i);
                flowLayoutPanel.Controls.Add(tablePanel);
            }

        }

        private Panel CreateTablePanel(int tableNumber)
        {
            Panel tablePanel = new Panel();
            tablePanel.Name = "panelTable" + tableNumber;
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
            tablePictureBox.Name = "picTable" + tableNumber;
            tablePictureBox.ImageLocation = "https://firebasestorage.googleapis.com/v0/b/fxchangesapmle.appspot.com/o/c%23%2F7113274.png?alt=media&token=f293568b-19f3-4907-88a6-c9083c0b27cf";
            tablePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            tableLayoutPanel.Controls.Add(tablePictureBox, 0, 0);

            TextBox textBox = new TextBox();
            textBox.Name = "txtTable" + tableNumber;
            textBox.Text = "Bàn " + tableNumber;
            textBox.Enabled = false;
            textBox.Dock = DockStyle.Fill;
            tableLayoutPanel.Controls.Add(textBox, 0, 1);

            tablePanel.Controls.Add(tableLayoutPanel);

            return tablePanel;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
