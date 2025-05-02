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
    public partial class PassengerLoginForm : Form
    {
        public PassengerLoginForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            loginForm next = new loginForm();
            next.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
            "Bạn có muốn thoát ứng dụng?",
            "Thoát ứng dụng",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
                Environment.Exit(0);
        }

        private void btnDat_Click(object sender, EventArgs e)
        {
            BookingFlightChooseForm next = new BookingFlightChooseForm();
            next.Show();
            this.Hide();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            TicketHistoryForm next = new TicketHistoryForm();
            next.Show();
            this.Hide();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TicketCancelForm next = new TicketCancelForm();
            next.Show();
            this.Hide();
        }
    }
}
