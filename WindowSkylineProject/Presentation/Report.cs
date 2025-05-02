using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataTransferObject;
using Microsoft.Reporting.WinForms;

namespace Presentation
{
    public partial class Report : Form
    {
        private readonly FlightInfo _flight;
        public Report(FlightInfo flight)
        {
            InitializeComponent();

            _flight = flight;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            try
            {
                ReportManage report = new ReportManage();
                DataSet ds = report.GetReportData(_flight);

                flightReport.ProcessingMode = ProcessingMode.Local;
                flightReport.LocalReport.ReportPath = "FlightReport.rdlc";
                flightReport.LocalReport.DataSources.Clear();
                flightReport.LocalReport.DataSources.Add(
                    new ReportDataSource("FlightInfo", ds.Tables["FlightInfo"]));
                flightReport.LocalReport.DataSources.Add(
                    new ReportDataSource("CrewInfo", ds.Tables["CrewInfo"]));
                flightReport.LocalReport.DataSources.Add(
                    new ReportDataSource("PassengerInfo", ds.Tables["PassengerInfo"]));
                flightReport.RefreshReport();
            }
            catch (Exception ex)
            {
                string msg = "Lỗi khi tải báo cáo: " + ex.Message;
                if (ex.InnerException != null)
                    msg += "\nChi tiết: " + ex.InnerException.Message;
                MessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            finally
            {
                ReportFlightChooseForm back = new ReportFlightChooseForm();
                back.Show();
            }
        }
    }
}
