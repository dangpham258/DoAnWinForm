using BusinessLogic;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class CrewCheckForm : Form
    {
        public CrewCheckForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CrewLoginForm next = new CrewLoginForm();
            next.Show();
            this.Hide();
        }

        private void CrewCheckForm_Load(object sender, EventArgs e)
        {
            try
            {
                int currentID = PersonLoginSession.CurrentPerson.PersonID;
                DGVFlightInFuture.DataSource = new CrewMemberLogic().GetCurrentFlightInfo(currentID);
                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridView()
        {
            DGVFlightInFuture.ClearSelection();

            DGVFlightInFuture.Columns["FlightID"].Visible = false;
            DGVFlightInFuture.Columns["FlightNumber"].HeaderText = "Mã chuyến bay";
            DGVFlightInFuture.Columns["Airline"].HeaderText = "Hãng bay";
            DGVFlightInFuture.Columns["DepartCode"].HeaderText = "Sân bay đi";
            DGVFlightInFuture.Columns["ArriveCode"].HeaderText = "Sân bay đến";
            DGVFlightInFuture.Columns["DepartureDate"].HeaderText = "Thời gian khởi hành";
            DGVFlightInFuture.Columns["ArrivalDate"].HeaderText = "Thời gian đến";
            DGVFlightInFuture.Columns["PilotID"].HeaderText = "Mã phi công";
            DGVFlightInFuture.Columns["PilotName"].HeaderText = "Tên phi công";
            DGVFlightInFuture.Columns["CoPilotID"].HeaderText = "Mã cơ phó";
            DGVFlightInFuture.Columns["CoPilotName"].HeaderText = "Tên cơ phó";
            DGVFlightInFuture.Columns["AttendantID"].HeaderText = "Mã tiếp viên";
            DGVFlightInFuture.Columns["AttendantName"].HeaderText = "Tên tiếp viên";
            DGVFlightInFuture.Columns["PassengerCount"].HeaderText = "Số lượng hành khách";

            for (int i = 1; i <= 10; i++)
            {
                string columnName = "G" + i;
                if (DGVFlightInFuture.Columns.Contains(columnName))
                {
                    DGVFlightInFuture.Columns[columnName].Visible = false;
                }
            }

            DGVFlightInFuture.Columns["DepartureDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            DGVFlightInFuture.Columns["ArrivalDate"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            DGVFlightInFuture.AutoResizeColumns();
        }
    }
}
