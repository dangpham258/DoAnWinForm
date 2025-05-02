using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowSkylineProject;
using DataTransferObject;

namespace Presentation
{
    public partial class BookingFlightChooseForm : Form
    {
        private SerpClient serpClient = new SerpClient();

        public BookingFlightChooseForm()
        {
            InitializeComponent();
        }


        private async void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbDiemdi.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn điểm đi.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbbDiemden.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn điểm đến.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xóa dữ liệu cũ
                dataGridViewFlightOffers.DataSource = null;

                // Lấy thông tin người dùng nhập
                string departureId = cbbDiemdi.SelectedValue?.ToString();
                string arrivalId = cbbDiemden.SelectedValue?.ToString();
                string outboundDate = flightDatePicker.Value.ToString("yyyy-MM-dd");

                // Kiểm tra không trùng điểm đi và điểm đến
                if (departureId == arrivalId)
                {
                    MessageBox.Show("Điểm đi và điểm đến không được trùng nhau.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Vô hiệu hóa nút tìm kiếm và hiển thị thông báo đang tìm kiếm
                btnLoad.Enabled = false;
                lblStatus.Text = "Đang tìm kiếm chuyến bay...";
                lblStatus.Visible = true;
                progressBarSearch.Visible = true;
                progressBarSearch.Style = ProgressBarStyle.Marquee;

                // Tạo một Task để thực hiện công việc ngầm
                await Task.Run(async () => {
                    try
                    {
                // Gọi API để lấy dữ liệu JSON
                string jsonData = await serpClient.GetGoogleFlightsAsync(
                    departureId,
                    arrivalId,
                    outboundDate,
                    "VND",    // currency
                    "en",     // hl
                    "vn"      // gl
                );

                        // Chuyển JSON thành DataTable (thực hiện trên luồng phụ)
                DataTable dt = serpClient.GetFlightOffersDataTable(jsonData);
                        DataView dv = new DataView(dt);
                        dv.RowFilter = $"DepartureAirport = '{departureId}' AND ArrivalAirport = '{arrivalId}' AND CabinClass = 'Economy'";

                        // Chuyển về UI thread để cập nhật UI
                        this.Invoke((MethodInvoker)delegate {
                            if (dv.Count > 0)
                            {
                                dataGridViewFlightOffers.DataSource = dv;
                FormatDataGridView();
            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy chuyến bay phù hợp.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        });
                    }
            catch (Exception ex)
            {
                        // Xử lý lỗi trên luồng phụ
                        this.Invoke((MethodInvoker)delegate {
                MessageBox.Show("Có lỗi xảy ra khi tìm chuyến bay: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        });
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLoad.Enabled = true;
                lblStatus.Visible = false;
                progressBarSearch.Visible = false;
            }
        }

        private void FormatDataGridView()
        {
            // Cách hiển thị các cột trong GridView
            dataGridViewFlightOffers.Columns["FlightNumber"].HeaderText = "Số hiệu";
            dataGridViewFlightOffers.Columns["Airline"].HeaderText = "Hãng bay";
            dataGridViewFlightOffers.Columns["Price"].HeaderText = "Giá vé";
            dataGridViewFlightOffers.Columns["Currency"].HeaderText = "Tiền tệ";
            dataGridViewFlightOffers.Columns["DepartureAirport"].HeaderText = "Sân bay đi";
            dataGridViewFlightOffers.Columns["ArrivalAirport"].HeaderText = "Sân bay đến";
            dataGridViewFlightOffers.Columns["DepartureTime"].HeaderText = "Giờ khởi hành";
            dataGridViewFlightOffers.Columns["ArrivalTime"].HeaderText = "Giờ đến";
            dataGridViewFlightOffers.Columns["CabinClass"].HeaderText = "Hạng ghế";

            // Định dạng giờ
            dataGridViewFlightOffers.Columns["DepartureTime"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dataGridViewFlightOffers.Columns["ArrivalTime"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

            // Định dạng giá tiền
            dataGridViewFlightOffers.Columns["Price"].DefaultCellStyle.Format = "N0";
            dataGridViewFlightOffers.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn quay về không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
            PassengerLoginForm next = new PassengerLoginForm();
            next.Show();
            this.Hide();
        }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dataGridViewFlightOffers.SelectedRows.Count == 0 && dataGridViewFlightOffers.SelectedCells.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một chuyến bay!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy dòng được chọn
            DataGridViewRow row;
            if (dataGridViewFlightOffers.SelectedRows.Count > 0)
            {
                row = dataGridViewFlightOffers.SelectedRows[0];
            }
            else
            {
                int rowIndex = dataGridViewFlightOffers.SelectedCells[0].RowIndex;
                row = dataGridViewFlightOffers.Rows[rowIndex];
            }

            try
            {
                // Lưu thông tin chuyến bay vào biến tạm
                BookingSession.CurrentTicket = new Ticket(
                    flightNumber: row.Cells["FlightNumber"].Value.ToString(),
                    airline: row.Cells["Airline"].Value.ToString(),
                    departCode: row.Cells["DepartureAirport"].Value.ToString(),
                    arriveCode: row.Cells["ArrivalAirport"].Value.ToString(),
                    departureDate: Convert.ToDateTime(row.Cells["DepartureTime"].Value),
                    arrivalDate: Convert.ToDateTime(row.Cells["ArrivalTime"].Value),
                    classType: row.Cells["CabinClass"].Value.ToString(),
                    seatNumber: null,       // chưa biết seat, null tạm
                    price: Convert.ToInt32(row.Cells["Price"].Value),
                    phoneNumber: null,       // chưa có, null tạm
                    fullName: null,       // null tạm
                    cccd: null        // null tạm
                );


                // Chuyển sang form tiếp theo
            BookingInformationForm next = new BookingInformationForm();
            next.Show();
            this.Hide();
        }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi lưu thông tin chuyến bay: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewFlightOffers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow row = dataGridViewFlightOffers.Rows[e.RowIndex];

                // Đánh dấu dòng được chọn
                dataGridViewFlightOffers.ClearSelection();
                row.Selected = true;
            }
        }

        private void BookingFlightChooseForm_Load(object sender, EventArgs e)
        {
            cbbDiemdi.DataSource = AirportData.Airports;
            cbbDiemdi.DisplayMember = "City";
            cbbDiemdi.ValueMember = "Code";
            cbbDiemdi.SelectedIndex = -1;

            cbbDiemden.BindingContext = new BindingContext();
            cbbDiemden.DataSource = AirportData.Airports;
            cbbDiemden.DisplayMember = "City";
            cbbDiemden.ValueMember = "Code";
            cbbDiemden.SelectedIndex = -1;

            // Chỉ cho chọn ngày từ hôm nay trở về sau và tối đa 1 năm
            flightDatePicker.MaxDate = DateTime.Today.AddYears(1);
            flightDatePicker.MinDate = DateTime.Today;
            flightDatePicker.Format = DateTimePickerFormat.Custom;
            flightDatePicker.CustomFormat = "dddd, dd/MM/yyyy";
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            int fromIndex = cbbDiemdi.SelectedIndex;
            int toIndex = cbbDiemden.SelectedIndex;

            // Hoán đổi
            cbbDiemdi.SelectedIndex = toIndex;
            cbbDiemden.SelectedIndex = fromIndex;
        }
    }
}
