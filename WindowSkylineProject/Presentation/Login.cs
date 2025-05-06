using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTransferObject;
using BusinessLogic;

namespace Presentation
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            scheduleFlightPanel.Visible = false;
            bookingPanel.Visible = true;
            usernamePassengerTxt.Text = "Ex: username";
            passwordPassengerTxt.Text = "Ex: password";

            passwordPassengerTxt.PasswordChar = '\0';
            passwordFlightCrewTxt.PasswordChar = '\0';

            controllerRadioBtn.Checked = true;
            this.AcceptButton = loginAsPassengerBtn;

        }

        private void ChangeActivePanel(Button activeButton, Panel activePanel)
        {
            // Reset màu của tất cả button và panel
            scheduleBtn.BackColor = Color.LightGray;
            bookingBtn.BackColor = Color.LightGray;
            
            passwordPassengerTxt.PasswordChar = '\0';
            passwordFlightCrewTxt.PasswordChar = '\0';

            // Xử lý Enter
            if (activePanel == bookingPanel)
                this.AcceptButton = loginAsPassengerBtn;
            else
                this.AcceptButton = loginAsFlightCrewBtn;

            scheduleBtn.FlatStyle = FlatStyle.Flat;
            scheduleBtn.FlatAppearance.BorderSize = 0;
            bookingBtn.FlatStyle = FlatStyle.Flat;
            bookingBtn.FlatAppearance.BorderSize = 0;

            scheduleFlightPanel.Visible = false;
            bookingPanel.Visible = false;

            activePanel.Visible = true;
            activePanel.BringToFront();
            activeButton.BackColor = Color.White;
        }

        private void bookingBtn_Click(object sender, EventArgs e)
        {
            ChangeActivePanel(bookingBtn, bookingPanel);

            usernamePassengerTxt.ForeColor = Color.Gray;
            passwordPassengerTxt.ForeColor = Color.Gray;
            usernamePassengerTxt.Text = "Ex: username";
            passwordPassengerTxt.Text = "Ex: password";
        }

        private void scheduleBtn_Click(object sender, EventArgs e)
        {
            ChangeActivePanel(scheduleBtn, scheduleFlightPanel);

            usernameFlightCrewTxt.ForeColor = Color.Gray;
            passwordFlightCrewTxt.ForeColor = Color.Gray;
            usernameFlightCrewTxt.Text = "Ex: username";
            passwordFlightCrewTxt.Text = "Ex: password";
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerForm reg = new registerForm();
            reg.Show();
        }

        private void usernamePassengerTxt_Enter(object sender, EventArgs e)
        {
            usernamePassengerTxt.ForeColor = Color.Black;
            if (usernamePassengerTxt.Text.Equals("Ex: username"))
            {
                usernamePassengerTxt.Text = "";
            }
        }

        private void usernamePassengerTxt_MouseClick(object sender, MouseEventArgs e)
        {
            usernamePassengerTxt_Enter(sender, e);
        }

        private void usernamePassengerTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernamePassengerTxt.Text))
            {
                usernamePassengerTxt.ForeColor = Color.Gray;
                usernamePassengerTxt.Text = "Ex: username";
            }
        }

        private void passwordPassengerTxt_Enter(object sender, EventArgs e)
        {
            passwordPassengerTxt.ForeColor = Color.Black;
            passwordPassengerTxt.PasswordChar = '*';
            if (passwordPassengerTxt.Text.Equals("Ex: password"))
            {
                passwordPassengerTxt.Text = "";
            }
        }

        private void passwordPassengerTxt_MouseClick(object sender, MouseEventArgs e)
        {
            passwordPassengerTxt_Enter(sender, e);
        }

        private void passwordPassengerTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordPassengerTxt.Text))
            {
                passwordPassengerTxt.ForeColor = Color.Gray;
                passwordPassengerTxt.Text = "Ex: password";
                passwordPassengerTxt.PasswordChar = '\0'; // Hiện lại mật khẩu
            }
        }

        private void usernameFlightCrewTxt_Enter(object sender, EventArgs e)
        {
            usernameFlightCrewTxt.ForeColor = Color.Black;
            if (usernameFlightCrewTxt.Text.Equals("Ex: username"))
            {
                usernameFlightCrewTxt.Text = "";
            }
        }

        private void usernameFlightCrewTxt_MouseClick(object sender, MouseEventArgs e)
        {
            usernamePassengerTxt_Enter(sender, e);
        }

        private void usernameFlightCrewTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameFlightCrewTxt.Text))
            {
                usernameFlightCrewTxt.ForeColor = Color.Gray;
                usernameFlightCrewTxt.Text = "Ex: username";
            }
        }

        private void passwordFlightCrewTxt_Enter(object sender, EventArgs e)
        {
            passwordFlightCrewTxt.ForeColor = Color.Black;
            if (passwordFlightCrewTxt.Text.Equals("Ex: password"))
            {
                passwordFlightCrewTxt.Text = "";
                passwordFlightCrewTxt.PasswordChar = '*';
            }
        }

        private void passwordFlightCrewTxt_MouseClick(object sender, MouseEventArgs e)
        {
            passwordFlightCrewTxt_Enter(sender, e);
        }

        private void passwordFlightCrewTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordFlightCrewTxt.Text))
            {
                passwordFlightCrewTxt.ForeColor = Color.Gray;
                passwordFlightCrewTxt.Text = "Ex: password";
                passwordFlightCrewTxt.PasswordChar = '\0'; // Hiện lại mật khẩu
            }
        }

        private void loginAsPassengerBtn_Click(object sender, EventArgs e)
        {
            Passenger passenger = new Passenger(usernamePassengerTxt.Text, passwordPassengerTxt.Text);
            try
            {
                CheckLogin_Register checkPassengerLogin = new CheckLogin_Register();
                string verifyStr = checkPassengerLogin.CheckLogin(passenger);

                switch (verifyStr)
                {
                    case "Tên người dùng không được để trống":
                        MessageBox.Show(verifyStr, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "Mật khẩu không được để trống":
                        MessageBox.Show(verifyStr, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "Tên người dùng hoặc mật khẩu không đúng":
                        MessageBox.Show(verifyStr, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "Đăng nhập thành công":
                        MessageBox.Show(verifyStr, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        PersonLoginSession.CurrentPerson = new Person
                        (
                            userName: usernamePassengerTxt.Text,
                            password: passwordPassengerTxt.Text
                        );

                        this.Hide();
                        PassengerLoginForm mainForm = new PassengerLoginForm();
                        mainForm.Show();
                        break;
                }
            }
            catch (Exception ex)
            {
                string message = "Lỗi đăng nhập: " + ex.Message;
                if (ex.InnerException != null)
                    message += "\nChi tiết: " + ex.InnerException.Message;

                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginAsFlightCrewBtn_Click(object sender, EventArgs e)
        {
            try
            {
                CheckLogin_Register checkLogin = new CheckLogin_Register();
                string verifyStr = "";

                Form mainForm = null;

                if (controllerRadioBtn.Checked)
                {
                    Controller controller = new Controller(usernameFlightCrewTxt.Text, passwordFlightCrewTxt.Text);
                    verifyStr = checkLogin.CheckLogin(controller);
                    mainForm = new ControllerLoginForm();
                }
                else
                {
                    CrewMember flightCrew = new CrewMember(usernameFlightCrewTxt.Text, passwordFlightCrewTxt.Text);
                    verifyStr = checkLogin.CheckLogin(flightCrew);
                    mainForm = new CrewLoginForm();
                }
                switch (verifyStr)
                {
                    case "Tên người dùng không được để trống":
                        MessageBox.Show(verifyStr, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "Mật khẩu không được để trống":
                        MessageBox.Show(verifyStr, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "Tên người dùng hoặc mật khẩu không đúng":
                        MessageBox.Show(verifyStr, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "Đăng nhập thành công":
                        MessageBox.Show(verifyStr, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        PersonLoginSession.CurrentPerson = new Person
                        (
                            userName: usernameFlightCrewTxt.Text,
                            password: passwordFlightCrewTxt.Text
                        );

                        this.Hide();
                        mainForm.Show();
                        break;
                }
            }
            catch (Exception ex)
            {
                string message = "Lỗi đăng nhập: " + ex.Message;
                if (ex.InnerException != null)
                    message += "\nChi tiết: " + ex.InnerException.Message;

                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát ứng dụng?", "Thoát ứng dụng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Cập nhật trạng thái vé quá hạn khi form được tải
                CheckTicketInformation checkTicket = new CheckTicketInformation();
                checkTicket.UpdateExpiredTickets();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Lỗi cập nhật vé quá hạn: " + ex.Message);
            }
        }

        private void usernameFlightCrewTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void passwordFlightCrewTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void usernamePassengerTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void passwordPassengerTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
