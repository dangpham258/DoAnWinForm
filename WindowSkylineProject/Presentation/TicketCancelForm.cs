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
    public partial class TicketCancelForm : Form
    {
        public TicketCancelForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PassengerLoginForm next = new PassengerLoginForm();
            next.Show();
            this.Hide();
        }
    }
}
