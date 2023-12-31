﻿namespace Assignment
{
    partial class dashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dateTimePickerFrom = new DateTimePicker();
            dateTimePickerTo = new DateTimePicker();
            label2 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            pnlColunnChart = new Panel();
            pnlPieChart = new Panel();
            panel1 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 0;
            label1.Text = "Doanh Thu";
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Location = new Point(140, 14);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(128, 23);
            dateTimePickerFrom.TabIndex = 1;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Location = new Point(325, 14);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(128, 23);
            dateTimePickerTo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(287, 20);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 3;
            label2.Text = "---";
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(693, 16);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(75, 23);
            iconButton1.TabIndex = 4;
            iconButton1.Text = "iconButton1";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(815, 14);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(75, 23);
            iconButton2.TabIndex = 5;
            iconButton2.Text = "iconButton2";
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.Location = new Point(949, 16);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(75, 23);
            iconButton3.TabIndex = 6;
            iconButton3.Text = "iconButton3";
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // pnlColunnChart
            // 
            pnlColunnChart.BackColor = Color.WhiteSmoke;
            pnlColunnChart.Location = new Point(12, 152);
            pnlColunnChart.Name = "pnlColunnChart";
            pnlColunnChart.Size = new Size(599, 450);
            pnlColunnChart.TabIndex = 9;
            // 
            // pnlPieChart
            // 
            pnlPieChart.BackColor = Color.WhiteSmoke;
            pnlPieChart.Location = new Point(669, 283);
            pnlPieChart.Name = "pnlPieChart";
            pnlPieChart.Size = new Size(446, 319);
            pnlPieChart.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1140, 64);
            panel1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 0;
            label3.Text = "Doanh thu";
            // 
            // dashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1140, 614);
            Controls.Add(pnlPieChart);
            Controls.Add(iconButton3);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(label2);
            Controls.Add(dateTimePickerTo);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(pnlColunnChart);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dashboardForm";
            Text = "dashboardForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Panel pnlColunnChart;
        private Panel pnlPieChart;
        private Panel panel1;
        private Label label3;
    }
}