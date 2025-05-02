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
    }
}
