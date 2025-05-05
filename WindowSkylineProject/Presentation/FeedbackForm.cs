using BusinessLogic;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class FeedbackForm : Form
    {
        private const string Placeholder = "Ngắn gọn, không quá 512 kí tự";
        public FeedbackForm()
        {
            InitializeComponent();

            cbbType.Items.AddRange(new[]
           {
                "Lỗi đặt vé",
                "Lỗi thanh toán",
                "Góp ý tính năng",
                "Thắc mắc",
                "Khác"
            });
            cbbType.SelectedIndex = 0;

            richTxtDetail.ForeColor = Color.Gray;
            richTxtDetail.Text = Placeholder;

            this.Shown += (s, e) => txtFullName.Focus();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                FeedbackManage fbManage = new FeedbackManage();
                Feedback fb = new Feedback(txtFullName.Text, txtPhoneNumber.Text, cbbType.Text, richTxtDetail.Text);
                
                string result = fbManage.SendFeedback(fb);

                switch (result)
                {
                    case "Gửi phản hồi thành công":
                        MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        PassengerLoginForm back = new PassengerLoginForm();
                        back.Show();
                        this.Hide();

                        break;
                    case "Không thể lưu phản hồi\nVui lòng thử lại":
                        MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "Vui lòng nhập họ tên":
                        MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtFullName.Focus();
                        break;
                    case "Họ tên không được quá 100 ký tự":
                        MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtFullName.Focus();
                        break;
                    case "Vui lòng nhập số điện thoại":
                        MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPhoneNumber.Focus();
                        break;
                    case "Số điện thoại không được quá 20 ký tự":
                        MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPhoneNumber.Focus();
                        break;
                    case "Vui lòng chọn loại phản hồi":
                        MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cbbType.Focus();
                        break;
                    case "Nội dung phản hồi không được quá 255 ký tự":
                        MessageBox.Show(result, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        richTxtDetail.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                string message = "Lỗi gửi phản hồi: " + ex.Message;
                if (ex.InnerException != null)
                    message += "\nChi tiết: " + ex.InnerException.Message;

                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void richTxtDetail_Enter(object sender, EventArgs e)
        {
            if (richTxtDetail.ForeColor == Color.Gray && richTxtDetail.Text == Placeholder)
            {
                richTxtDetail.Text = "";
                richTxtDetail.ForeColor = Color.Black;
            }
        }

        private void richTxtDetail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTxtDetail.Text))
            {
                richTxtDetail.ForeColor = Color.Gray;
                richTxtDetail.Text = Placeholder;
            }
        }

        private void richTxtDetail_MouseClick(object sender, MouseEventArgs e)
        {
            richTxtDetail_Enter(sender, e);
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho nhập ký tự không hợp lệ
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PassengerLoginForm back = new PassengerLoginForm();
            back.Show();
            this.Hide();
        }
    }
}
