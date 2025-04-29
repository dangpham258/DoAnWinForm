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
    public partial class BookingInformationForm : Form
    {
        public BookingInformationForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BookingFlightChooseForm next = new BookingFlightChooseForm();
            next.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SeatBookForm next = new SeatBookForm();
            next.Show();
            this.Hide();
        }
    }
}
