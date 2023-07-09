namespace Assignment
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
            iconButton2 = new FontAwesome.Sharp.IconButton();
            pnlColunnChart = new Panel();
            pnlPieChart = new Panel();
            panel1 = new Panel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
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
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.Location = new Point(898, 12);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(84, 36);
            iconButton2.TabIndex = 5;
            iconButton2.Text = "Tháng";
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // pnlColunnChart
            // 
            pnlColunnChart.BackColor = Color.WhiteSmoke;
            pnlColunnChart.Location = new Point(12, 212);
            pnlColunnChart.Name = "pnlColunnChart";
            pnlColunnChart.Size = new Size(599, 390);
            pnlColunnChart.TabIndex = 9;
            // 
            // pnlPieChart
            // 
            pnlPieChart.BackColor = Color.WhiteSmoke;
            pnlPieChart.Location = new Point(655, 212);
            pnlPieChart.Name = "pnlPieChart";
            pnlPieChart.Size = new Size(473, 390);
            pnlPieChart.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Controls.Add(iconButton4);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(iconButton2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1140, 64);
            panel1.TabIndex = 7;
            // 
            // iconButton4
            // 
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.Location = new Point(1019, 12);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(84, 36);
            iconButton4.TabIndex = 13;
            iconButton4.Text = "Năm";
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(774, 12);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(84, 36);
            iconButton1.TabIndex = 12;
            iconButton1.Text = "Tuần";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Location = new Point(15, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 11;
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
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(225, 0, 125);
            panel3.Location = new Point(12, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(5, 201, 204);
            panel4.Location = new Point(325, 85);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 100);
            panel4.TabIndex = 12;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(182, 205, 84);
            panel5.Location = new Point(626, 85);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 100);
            panel5.TabIndex = 13;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(154, 205, 229);
            panel6.Location = new Point(928, 85);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 100);
            panel6.TabIndex = 14;
            // 
            // dashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1140, 614);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(pnlPieChart);
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
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.DataVisualization.Charting.Chart 
          chart1;
        private Panel pnlColunnChart;
        private Panel pnlPieChart;
        private Panel panel1;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
    }
}