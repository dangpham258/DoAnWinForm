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
    public partial class SeatBookForm : Form
    {
        public SeatBookForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BookingInformationForm next = new BookingInformationForm();
            next.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            BookingConfirmForm next = new BookingConfirmForm();
            next.Show();
            this.Hide();
        }
    }
}
