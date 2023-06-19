using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Assignment
{
    public partial class dashboardForm : Form
    {
        public dashboardForm()
        {
            InitializeComponent();

            // Tạo biểu đồ dạng cột
            CreateColumnChart();

            // Tạo biểu đồ dạng hình tròn
            CreatePieChart();
        }

        private void CreateColumnChart()
        {
            // Tạo một Chart control mới
            Chart columnChart = new Chart();
            columnChart.Size = new System.Drawing.Size(400, 300);
            columnChart.Location = new System.Drawing.Point(50, 50);
            columnChart.Dock = DockStyle.Fill;

            // Tạo một ChartArea mới cho biểu đồ dạng cột
            ChartArea chartArea = new ChartArea("ColumnChartArea");
            columnChart.ChartAreas.Add(chartArea);

            // Tạo một Series mới cho biểu đồ dạng cột
            Series series = new Series("ColumnSeries");
            series.ChartType = SeriesChartType.Column;

            // Thêm các điểm dữ liệu cho biểu đồ dạng cột
            series.Points.AddXY("Category1", 10);
            series.Points.AddXY("Category2", 20);
            series.Points.AddXY("Category3", 15);
            series.Points.AddXY("Category4", 30);

            // Thêm Series vào Chart
            columnChart.Series.Add(series);

            // Gán khu vực biểu đồ cho Series
            series.ChartArea = "ColumnChartArea";

            // Hiển thị biểu đồ dạng cột trong panel pnlColunnChart
            pnlColunnChart.Controls.Add(columnChart);
            pnlColunnChart.BorderStyle = BorderStyle.FixedSingle;
        }
        private void CreatePieChart()
        {
            // Tạo một Chart control mới
            Chart pieChart = new Chart();
            pieChart.Size = new System.Drawing.Size(400, 300);
            pieChart.Location = new System.Drawing.Point(500, 50);
            pieChart.Dock = DockStyle.Fill;

            // Tạo một ChartArea mới cho biểu đồ hình tròn
            ChartArea chartArea = new ChartArea("PieChartArea");
            pieChart.ChartAreas.Add(chartArea);

            // Tạo một Series mới cho biểu đồ hình tròn
            Series series = new Series("PieSeries");
            series.ChartType = SeriesChartType.Pie;

            // Thêm các điểm dữ liệu cho biểu đồ hình tròn
            series.Points.AddXY("Category1", 10);
            series.Points.AddXY("Category2", 20);
            series.Points.AddXY("Category3", 15);
            series.Points.AddXY("Category4", 30);

            // Thêm Series vào Chart
            pieChart.Series.Add(series);

            // Gán khu vực biểu đồ cho Series
            series.ChartArea = "PieChartArea";

            // Hiển thị biểu đồ hình tròn trên form
            pnlPieChart.Controls.Add(pieChart);
            pnlPieChart.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
