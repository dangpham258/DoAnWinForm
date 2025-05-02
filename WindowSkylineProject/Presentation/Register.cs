using BusinessLogic;
using DataTransferObject;
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
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
            fullnameTxt.Text = "Ex: Nguyen Van A";
            usernameTxt.Text = "Ex: username";
            passwordTxt.Text = "Ex: password";
            confirmPasswordTxt.Text = "Ex: password";

            passwordTxt.PasswordChar = '\0';
            confirmPasswordTxt.PasswordChar = '\0';

            this.AcceptButton = registerBtn;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Passenger passenger = new Passenger(usernameTxt.Text, passwordTxt.Text, fullnameTxt.Text);
                string confirmPassword = confirmPasswordTxt.Text;

                CheckLogin_Register checkPassengerRegister = new CheckLogin_Register();
                string verifyStr = checkPassengerRegister.Register(passenger, confirmPassword);

                switch (verifyStr)
                {
                    case "Đăng ký thành công":
                        MessageBox.Show(verifyStr, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        loginForm login = new loginForm();
                        login.Show();
                        break;
                    case "Tên user không được chứa khoảng trắng":
                        MessageBox.Show(verifyStr, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "Người dùng đã tồn tại":
                        MessageBox.Show(verifyStr, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "Mật khẩu không khớp":
                        MessageBox.Show(verifyStr, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "Họ tên không được để trống":
                        MessageBox.Show(verifyStr, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "Tên người dùng không được để trống":
                        MessageBox.Show(verifyStr, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "Mật khẩu không được để trống":
                        MessageBox.Show(verifyStr, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "Vui lòng nhập xác minh mật khẩu":
                        MessageBox.Show(verifyStr, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case "Mật khẩu phải có ít nhất 6 ký tự":
                        MessageBox.Show(verifyStr, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            catch (Exception ex)
            {
                string message = "Lỗi đăng ký: " + ex.Message;
                if (ex.InnerException != null)
                    message += "\nChi tiết: " + ex.InnerException.Message;

                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fullnameTxt_MouseDown(object sender, MouseEventArgs e)
        {
            fullnameTxt.ForeColor = Color.Black;
            if (fullnameTxt.Text.Equals("Ex: Nguyen Van A"))
            {
                fullnameTxt.Text = "";
            }
        }

        private void fullnameTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fullnameTxt.Text))
            {
                fullnameTxt.ForeColor = Color.Gray;
                fullnameTxt.Text = "Ex: Nguyen Van A";
            }
        }

        private void usernameTxt_MouseDown(object sender, MouseEventArgs e)
        {
            usernameTxt.ForeColor = Color.Black;
            if (usernameTxt.Text.Equals("Ex: username"))
            {
                usernameTxt.Text = "";
            }
        }

        private void usernameTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTxt.Text))
            {
                usernameTxt.ForeColor = Color.Gray;
                usernameTxt.Text = "Ex: username";
            }
        }

        private void passwordTxt_MouseDown(object sender, MouseEventArgs e)
        {
            passwordTxt.ForeColor = Color.Black;
            if (passwordTxt.Text.Equals("Ex: password"))
            {
                passwordTxt.Text = "";
                passwordTxt.PasswordChar = '*';
            }
        }

        private void passwordTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTxt.Text))
            {
                passwordTxt.ForeColor = Color.Gray;
                passwordTxt.Text = "Ex: password";
                passwordTxt.PasswordChar = '\0'; // Hiện lại mật khẩu
            }
        }

        private void confirmPasswordTxt_MouseDown(object sender, MouseEventArgs e)
        {
            confirmPasswordTxt.ForeColor = Color.Black;
            if (confirmPasswordTxt.Text.Equals("Ex: password"))
            {
                confirmPasswordTxt.Text = "";
                confirmPasswordTxt.PasswordChar = '*';
            }
        }

        private void confirmPasswordTxt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(confirmPasswordTxt.Text))
            {
                confirmPasswordTxt.ForeColor = Color.Gray;
                confirmPasswordTxt.Text = "Ex: password";
                confirmPasswordTxt.PasswordChar = '\0'; // Hiện lại mật khẩu
            }
        }

        private void registerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát ứng dụng?", "Thoát ứng dụng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            loginForm next = new loginForm();
            next.Show();
            this.Hide();
        }
    }
}
