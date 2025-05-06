using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BusinessLogic;

namespace Presentation
{
    public partial class StatisticForm : Form
    {
        private CheckStatistic statisticBLL;

        public StatisticForm()
        {
            InitializeComponent();
            statisticBLL = new CheckStatistic();
        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTotalRevenue();
                LoadAirlineRevenueChart();
                LoadTotalPassengersCount();
                LoadAirlinePassengersChart();
                LoadFlightsPerDayChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu thống kê: " + ex.Message,
                               "Lỗi",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        private void LoadTotalRevenue()
        {
            decimal totalRevenue = statisticBLL.GetTotalRevenue(true); // Chỉ tính vé đã sử dụng
            lblTotalRevenue.Text = string.Format(new CultureInfo("vi-VN"), "{0:N0} đồng", totalRevenue);
        }

        private void LoadAirlineRevenueChart()
        {
            Dictionary<string, decimal> airlineRevenue = statisticBLL.GetRevenueByAirline();

            // Cấu hình biểu đồ tròn
            chartAirlineRevenue.Series.Clear();
            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Pie;
            foreach (var item in airlineRevenue)
            {
                series.Points.AddXY(item.Key, item.Value);
            }
            series.Label = "#PERCENT{P0}";
            series.LegendText = "#VALX: #VALY{N0} đồng";
            series["PieLabelStyle"] = "Outside";
            series["PieLineColor"] = "Black";

            chartAirlineRevenue.Series.Add(series);
            chartAirlineRevenue.Titles.Add(new Title("DOANH THU THEO HÃNG BAY (VÉ ĐÃ DÙNG)", Docking.Top,
                new Font("Microsoft Sans Serif", 12f, FontStyle.Bold), Color.Black));
        }

        private void LoadTotalPassengersCount()
        {
            int totalPassengers = statisticBLL.GetTotalPassengers(true );
            lblTotalPassengers.Text = totalPassengers.ToString("N0");
        }

        private void LoadAirlinePassengersChart()
        {
            // Lấy dữ liệu số lượng khách theo từng hãng bay
            Dictionary<string, int> airlinePassengers = statisticBLL.GetPassengersByAirline(true); // Chỉ tính vé đã sử dụng

            // Cấu hình biểu đồ cột
            chartAirlinePassengers.Series.Clear();
            Series series = new Series("Số khách");
            series.ChartType = SeriesChartType.Column;
            foreach (var item in airlinePassengers)
            {
                series.Points.AddXY(item.Key, item.Value);
            }

            series.IsValueShownAsLabel = true;
            series.LabelFormat = "{0:N0}";
            series["PointWidth"] = "0.8";
            series.Color = Color.FromArgb(65, 140, 240);

            chartAirlinePassengers.Series.Add(series);
            chartAirlinePassengers.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chartAirlinePassengers.ChartAreas[0].AxisX.Interval = 1;
            chartAirlinePassengers.ChartAreas[0].AxisY.Title = "Số lượng khách";
            chartAirlinePassengers.ChartAreas[0].AxisX.Title = "Hãng bay";
            chartAirlinePassengers.Titles.Add(new Title("SỐ LƯỢNG KHÁCH THEO HÃNG BAY (ĐÃ BAY)", Docking.Top,
                new Font("Microsoft Sans Serif", 12f, FontStyle.Bold), Color.Black));
        }

        private void LoadFlightsPerDayChart()
        {
            // Lấy dữ liệu số lượng chuyến bay mỗi ngày trong tháng hiện tại
            Dictionary<int, int> flightsPerDay = statisticBLL.GetFlightsPerDayInCurrentMonth();

            // Cấu hình biểu đồ đường
            chartFlightsPerDay.Series.Clear();
            Series series = new Series("Số chuyến bay");
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 3;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 8;

            int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            for (int day = 1; day <= daysInMonth; day++)
            {
                int flightCount = flightsPerDay.ContainsKey(day) ? flightsPerDay[day] : 0;
                series.Points.AddXY(day, flightCount);
            }
            series.IsValueShownAsLabel = true;
            series.LabelFormat = "{0:N0}";

            chartFlightsPerDay.Series.Add(series);
            chartFlightsPerDay.ChartAreas[0].AxisX.Minimum = 1;
            chartFlightsPerDay.ChartAreas[0].AxisX.Maximum = daysInMonth;
            chartFlightsPerDay.ChartAreas[0].AxisX.Interval = 1;
            chartFlightsPerDay.ChartAreas[0].AxisY.Title = "Số lượng chuyến bay";
            chartFlightsPerDay.ChartAreas[0].AxisX.Title = "Các ngày trong tháng";
            chartFlightsPerDay.Titles.Add(new Title("SỐ LƯỢNG CHUYẾN BAY MỖI NGÀY TRONG THÁNG HIỆN TẠI", Docking.Top,
                new Font("Microsoft Sans Serif", 12f, FontStyle.Bold), Color.Black));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ControllerLoginForm next = new ControllerLoginForm();
            next.Show();
            this.Hide();
        }
    }
}