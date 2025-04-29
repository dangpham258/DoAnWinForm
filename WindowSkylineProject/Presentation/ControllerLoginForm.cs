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
    }
}
