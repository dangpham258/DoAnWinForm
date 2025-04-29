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
            bookingPanel.BackColor = Color.White;
            usernamePassengerTxt.Text = "Ex: username";
            passwordPassengerTxt.Text = "Ex: password";

            passwordPassengerTxt.PasswordChar = '\0';
            passwordFlightCrewTxt.PasswordChar = '\0';
        }

        // đồng nhất màu button và panel tương ứng, loại bỏ viền để tạo sự liên tục
        private void ChangeActivePanel(Button activeButton, Panel activePanel)
        {
            // Reset màu của tất cả button và panel
            scheduleBtn.BackColor = Color.LightGray;
            bookingBtn.BackColor = Color.LightGray;
            scheduleFlightPanel.BackColor = Color.LightGray;
            bookingPanel.BackColor = Color.LightGray;

            // Đặt màu cho button và panel được chọn
            activeButton.BackColor = Color.White;
            activePanel.BackColor = Color.White;

            // Loại bỏ viền nổi (FlatStyle)
            scheduleBtn.FlatStyle = FlatStyle.Flat;
            scheduleBtn.FlatAppearance.BorderSize = 0;
            bookingBtn.FlatStyle = FlatStyle.Flat;
            bookingBtn.FlatAppearance.BorderSize = 0;
        }

        private void bookingBtn_Click(object sender, EventArgs e)
        {
            bookingPanel.Visible = true;
            scheduleFlightPanel.Visible = false;
            ChangeActivePanel(bookingBtn, bookingPanel);

            usernamePassengerTxt.Text = "Ex: username";
            passwordPassengerTxt.Text = "Ex: password";
        }

        private void scheduleBtn_Click(object sender, EventArgs e)
        {
            scheduleFlightPanel.Visible = true;
            bookingPanel.Visible = false;
            ChangeActivePanel(scheduleBtn, scheduleFlightPanel);

            usernameFlightCrewTxt.Text = "Ex: username";
            passwordFlightCrewTxt.Text = "Ex: password";
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerForm reg = new registerForm();
            reg.Show();
        }

        private void usernamePassengerTxt_MouseDown(object sender, MouseEventArgs e)
        {
            usernamePassengerTxt.ForeColor = Color.Black;
            if (usernamePassengerTxt.Text.Equals("Ex: username"))
            {
                usernamePassengerTxt.Text = "";
            }
        }

        private void usernamePassengerTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernamePassengerTxt.Text))
            {
                usernamePassengerTxt.ForeColor = Color.Gray;
                usernamePassengerTxt.Text = "Ex: username";
            }
        }

        private void passwordPassengerTxt_MouseDown(object sender, MouseEventArgs e)
        {
            passwordPassengerTxt.ForeColor = Color.Black;
            passwordPassengerTxt.PasswordChar = '*';
            if (passwordPassengerTxt.Text.Equals("Ex: password"))
            {
                passwordPassengerTxt.Text = "";
            }
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

        private void usernameFlightCrewTxt_MouseDown(object sender, MouseEventArgs e)
        {
            usernameFlightCrewTxt.ForeColor = Color.Black;
            if (usernameFlightCrewTxt.Text.Equals("Ex: username"))
            {
                usernameFlightCrewTxt.Text = "";
            }
        }

        private void usernameFlightCrewTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameFlightCrewTxt.Text))
            {
                usernameFlightCrewTxt.ForeColor = Color.Gray;
                usernameFlightCrewTxt.Text = "Ex: username";
            }
        }

        private void passwordFlightCrewTxt_MouseDown(object sender, MouseEventArgs e)
        {
            passwordFlightCrewTxt.ForeColor = Color.Black;
            if (passwordFlightCrewTxt.Text.Equals("Ex: password"))
            {
                passwordFlightCrewTxt.Text = "";
                passwordFlightCrewTxt.PasswordChar = '*';
            }
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
                CheckPassengerLogin_Register checkPassengerLogin = new CheckPassengerLogin_Register();
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
    }
}
