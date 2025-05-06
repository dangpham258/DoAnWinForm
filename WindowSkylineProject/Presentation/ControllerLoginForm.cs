using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Presentation
{
    public partial class ControllerLoginForm : Form
    {
        public ControllerLoginForm()
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

        private void btnXepLich_Click(object sender, EventArgs e)
        {
            ControllerFlightChooseForm next = new ControllerFlightChooseForm();
            next.Show();
            this.Hide();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            ReportFlightChooseForm next = new ReportFlightChooseForm();
            next.Show();
            this.Hide();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            CheckFeedbackForm next = new CheckFeedbackForm();
            next.Show();
            this.Hide();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            StatisticForm next = new StatisticForm();
            next.Show();
            this.Hide();
        }
    }
}
