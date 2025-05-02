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
    public partial class ControllerFlightChooseForm : Form
    {
        public ControllerFlightChooseForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ControllerLoginForm next = new ControllerLoginForm();
            next.Show();
            this.Hide();
        }
    }
}
