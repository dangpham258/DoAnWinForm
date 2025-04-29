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
    public partial class BookingConfirmForm : Form
    {
        public BookingConfirmForm()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            PassengerLoginForm next = new PassengerLoginForm();
            next.Show();
            this.Hide();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            SeatBookForm next = new SeatBookForm();
            next.Show();
            this.Hide();
        }
    }
}
