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

namespace Presentation
{
    public partial class ControllerFlightChooseForm : Form
    {
        public ControllerFlightChooseForm()
        {
            InitializeComponent();

            LoadToFlightGridView();
            LoadToPilotGridView();
            LoadToCoPilotGridView();
            LoadToAttendantGridView();
        }

        private void LoadToFlightGridView()
        {
            try
            {
                CheckForLoadToDGV ctrlChoose = new CheckForLoadToDGV();
                DataTable dt = ctrlChoose.ForChoosingFlight();
                DGVFlight.DataSource = dt;
            }
            catch (Exception ex)
            {
                string message = "Lỗi tải chuyến bay: " + ex.Message;
                if (ex.InnerException != null)
                    message += "\nChi tiết: " + ex.InnerException.Message;

                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadToPilotGridView()
        {
            try
            {
                CheckForLoadToDGV ctrlChoose = new CheckForLoadToDGV();
                DataTable dt = ctrlChoose.ForChoosingPilot();
                DGVMainPilot.DataSource = dt;
            }
            catch (Exception ex)
            {
                string message = "Lỗi tải phi công: " + ex.Message;
                if (ex.InnerException != null)
                    message += "\nChi tiết: " + ex.InnerException.Message;
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadToCoPilotGridView()
        {
            try
            {
                CheckForLoadToDGV ctrlChoose = new CheckForLoadToDGV();
                DataTable dt = ctrlChoose.ForChoosingCoPilot();
                DGVCoPilot.DataSource = dt;
            }
            catch (Exception ex)
            {
                string message = "Lỗi tải phi công phụ: " + ex.Message;
                if (ex.InnerException != null)
                    message += "\nChi tiết: " + ex.InnerException.Message;
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadToAttendantGridView()
        {
            try
            {
                CheckForLoadToDGV ctrlChoose = new CheckForLoadToDGV();
                DataTable dt = ctrlChoose.ForChoosingAttendant();
                DGVAttendant.DataSource = dt;
            }
            catch (Exception ex)
            {
                string message = "Lỗi tải tiếp viên: " + ex.Message;
                if (ex.InnerException != null)
                    message += "\nChi tiết: " + ex.InnerException.Message;
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ControllerLoginForm next = new ControllerLoginForm();
            next.Show();
            this.Hide();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVFlight.SelectedRows.Count == 0 || DGVMainPilot.SelectedRows.Count == 0 ||
                    DGVCoPilot.SelectedRows.Count == 0 || DGVAttendant.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn đầy đủ thông tin chuyến bay và phi hành đoàn!",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                

                // Lấy dòng chuyến bay (để kiểm tra trạng thái xếp lịch)
                var flightRow = DGVFlight.SelectedRows[0];
                int flightID = Convert.ToInt32(flightRow.Cells["FlightID"].Value);
                string flightNumber = flightRow.Cells["FlightNumber"].Value.ToString();      

                DateTime departureDate = Convert.ToDateTime(flightRow.Cells["DepartureDate"].Value);
                DateTime arrivalDate = Convert.ToDateTime(flightRow.Cells["ArrivalDate"].Value);

                // Biến lưu các id của phi hành đoàn cũ
                int oldPilotID = flightRow.Cells["PilotID"].Value != DBNull.Value ? Convert.ToInt32(flightRow.Cells["PilotID"].Value) : -1;
                int oldCoPilotID = flightRow.Cells["CoPilotID"].Value != DBNull.Value ? Convert.ToInt32(flightRow.Cells["CoPilotID"].Value) : -1;
                int oldAttendantID = flightRow.Cells["AttendantID"].Value != DBNull.Value ? Convert.ToInt32(flightRow.Cells["AttendantID"].Value) : -1;

                if (oldPilotID != -1 || oldCoPilotID != -1 || oldAttendantID != -1)
                {
                    var ans = MessageBox.Show(
                        $"Chuyến bay {flightNumber} ngày {departureDate:dd/MM/yyyy} đã có phi hành đoàn.\n" +
                        "Bạn có muốn sửa đổi phân công không?",
                        "Xác nhận sửa đổi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ans != DialogResult.Yes)
                        return;
                }

                FlightInfo flight = ReadFullFlightInfoFromDGV();

                string message = $"Bạn có chắc chắn gán phi hành đoàn cho chuyến bay {flightNumber} ngày {departureDate:dd/MM/yyyy}?\n\n" +
                                 $"✈️ Phi công chính: {flight.PilotName}\n✈️ Cơ phó: {flight.CoPilotName}\n✈️ Tiếp viên: {flight.AttendantName}";

                AddCrewMember update = new AddCrewMember();

                var result = MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool success = update.AssignCrewToFlight(flight);
                    if (success)
                    {
                        // Cập nhật trạng thái phi hành đoàn
                        if (oldPilotID != -1)
                        {
                            update.UpdatePilotStatus(oldPilotID);
                        }
                        if (oldCoPilotID != -1)
                        {
                            update.UpdateCoPilotStatus(oldCoPilotID);
                        }
                        if (oldAttendantID != -1)
                        {
                            update.UpdateAttendantStatus(oldAttendantID);
                        }

                        MessageBox.Show("Xếp lịch bay cho phi hành đoàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }  
                    else
                        MessageBox.Show("Có lỗi xảy ra khi gán phi hành đoàn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);  
                }
            }
            catch (Exception ex)
            {
                string msg = "Lỗi xử lý: " + ex.Message;
                if (ex.InnerException != null)
                    msg += "\nChi tiết: " + ex.InnerException.Message;

                MessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadToFlightGridView();
                LoadToPilotGridView();
                LoadToCoPilotGridView();
                LoadToAttendantGridView();
                DGVFlight.ClearSelection();
                DGVMainPilot.ClearSelection();
                DGVCoPilot.ClearSelection();
                DGVAttendant.ClearSelection();
            }
        }

        private void ControllerFlightChooseForm_Load(object sender, EventArgs e)
        {
            FormatDataGridViewFlight();
            FormatDataGridViewMainPilot();
            FormatDataGridViewCoPilot();
            FormatDataGridViewAttendant();
        }

        private void FormatDataGridViewFlight()
        {
            DGVFlight.ClearSelection();
            DGVFlight.Columns["FlightID"].Visible = false;
            DGVFlight.Columns["FlightNumber"].HeaderText = "Mã chuyến bay";
            DGVFlight.Columns["Airline"].HeaderText = "Hãng bay";
            DGVFlight.Columns["DepartCode"].HeaderText = "Sân bay đi";
            DGVFlight.Columns["ArriveCode"].HeaderText = "Sân bay đến";
            DGVFlight.Columns["DepartureDate"].HeaderText = "Thời gian khởi hành";
            DGVFlight.Columns["ArrivalDate"].HeaderText = "Thời gian đến";
            DGVFlight.Columns["PilotID"].HeaderText = "Mã phi công";
            DGVFlight.Columns["PilotName"].HeaderText = "Tên phi công";
            DGVFlight.Columns["CoPilotID"].HeaderText = "Mã cơ phó";
            DGVFlight.Columns["CoPilotName"].HeaderText = "Tên cơ phó";
            DGVFlight.Columns["AttendantID"].HeaderText = "Mã tiếp viên";
            DGVFlight.Columns["AttendantName"].HeaderText = "Tên tiếp viên";
            DGVFlight.Columns["PassengerCount"].HeaderText = "Số lượng hành khách";

            for (int i = 1; i <= 10; i++)
            {
                string columnName = "G" + i;
                if (DGVFlight.Columns.Contains(columnName))
                {
                    DGVFlight.Columns[columnName].Visible = false;
                }
            }

            DGVFlight.Columns["DepartureDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            DGVFlight.Columns["ArrivalDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

            DGVFlight.AutoResizeColumns();
        }

        private void FormatDataGridViewMainPilot()
        {
            DGVMainPilot.ClearSelection();

            // Ẩn hoặc đổi tên các cột
            DGVMainPilot.Columns["PersonID"].HeaderText = "Mã phi công";
            DGVMainPilot.Columns["UserName"].Visible = false;
            DGVMainPilot.Columns["Password"].Visible = false;
            DGVMainPilot.Columns["JobType"].HeaderText = "Chức vụ";
            DGVMainPilot.Columns["YearsOfExperience"].HeaderText = "Kinh nghiệm (năm)";
            DGVMainPilot.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
            DGVMainPilot.Columns["FullName"].HeaderText = "Họ và tên";
            DGVMainPilot.Columns["CCCD"].HeaderText = "CCCD";

            // Ẩn cột Status vì database đã lọc người có status = 1
            if (DGVMainPilot.Columns.Contains("Status"))
                DGVMainPilot.Columns["Status"].Visible = false;

            DGVMainPilot.AutoResizeColumns();
        }

        private void FormatDataGridViewCoPilot()
        {
            DGVCoPilot.ClearSelection();

            // Ẩn hoặc đổi tên các cột
            DGVCoPilot.Columns["PersonID"].HeaderText = "Mã cơ phó";
            DGVCoPilot.Columns["UserName"].Visible = false;
            DGVCoPilot.Columns["Password"].Visible = false;
            DGVCoPilot.Columns["JobType"].HeaderText = "Chức vụ";
            DGVCoPilot.Columns["YearsOfExperience"].HeaderText = "Kinh nghiệm (năm)";
            DGVCoPilot.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
            DGVCoPilot.Columns["FullName"].HeaderText = "Họ và tên";
            DGVCoPilot.Columns["CCCD"].HeaderText = "CCCD";

            // Ẩn cột Status vì database đã lọc người có status = 1
            if (DGVCoPilot.Columns.Contains("Status"))
                DGVCoPilot.Columns["Status"].Visible = false;

            DGVCoPilot.AutoResizeColumns();
        }

        private void FormatDataGridViewAttendant()
        {
            DGVAttendant.ClearSelection();

            // Ẩn hoặc đổi tên các cột
            DGVAttendant.Columns["PersonID"].HeaderText = "Mã tiếp viên";
            DGVAttendant.Columns["UserName"].Visible = false;
            DGVAttendant.Columns["Password"].Visible = false;
            DGVAttendant.Columns["JobType"].HeaderText = "Chức vụ";
            DGVAttendant.Columns["YearsOfExperience"].HeaderText = "Kinh nghiệm (năm)";
            DGVAttendant.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
            DGVAttendant.Columns["FullName"].HeaderText = "Họ và tên";
            DGVAttendant.Columns["CCCD"].HeaderText = "CCCD";

            // Ẩn cột Status vì database đã lọc người có status = 1
            if (DGVAttendant.Columns.Contains("Status"))
                DGVAttendant.Columns["Status"].Visible = false;

            DGVAttendant.AutoResizeColumns();
        }
    }
}
