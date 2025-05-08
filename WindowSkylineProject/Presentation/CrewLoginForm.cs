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
using BusinessLogic;

namespace Presentation
{
    public partial class CrewLoginForm : Form
    {
        // Thêm biến cờ để kiểm soát việc hiển thị hộp thoại xác nhận
        private bool isInitializing = true;

        public CrewLoginForm()
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

        private void CrewLoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                isInitializing = true;

                string currentUser = PersonLoginSession.CurrentPerson.UserName;

                CrewMemberLogic crewBLL = new CrewMemberLogic();

                // Lấy thông tin từ bảng Table_CrewDatabase
                DataTable crewInfo = crewBLL.GetCrewMemberInfo(currentUser);

                if (crewInfo != null && crewInfo.Rows.Count > 0)
                {
                    DataRow row = crewInfo.Rows[0];

                    PersonLoginSession.CurrentPerson.PersonID = Convert.ToInt32(row["PersonID"]);
                    lblName.Text = row["FullName"].ToString();
                    lblJob.Text = row["JobType"].ToString();

                    CrewMemberLogic crewMemberLogic = new CrewMemberLogic();
                    if (crewMemberLogic.IsBusyInFuture(PersonLoginSession.CurrentPerson.PersonID))
                    {
                        groupBox1.Enabled = false;
                        lblNotification.Visible = true;
                        lblNotification.Text = "Bạn có ít nhất một chuyến bay trong tương lai tới, không thể thay đổi trạng thái.";
                    }
                    else
                    {
                        groupBox1.Enabled = true;
                        lblNotification.Visible = false;
                    }

                    // Cập nhật trạng thái cho RadioButton
                    int status = Convert.ToInt32(row["Status"]);

                    // Nếu status = 0 thì bận, 1 là rảnh
                    if (status == 0)
                    {
                        radioButtonBusy.Checked = true;
                        radioButtonFree.Checked = false;
                    }
                    else
                    {
                        radioButtonFree.Checked = true;
                        radioButtonBusy.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin phi hành đoàn!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                isInitializing = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thông tin: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                isInitializing = false;
            }
        }

        private void radioButtonFree_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonFree.Checked && !isInitializing)
                {
                    var result = MessageBox.Show(
                        "Bạn có muốn đổi trạng thái thành 'Rảnh rỗi' không?",
                        "Xác nhận thay đổi trạng thái",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        string currentUser = PersonLoginSession.CurrentPerson.UserName;
                        CrewMemberLogic crewBLL = new CrewMemberLogic();
                        crewBLL.UpdateCrewMemberStatus(currentUser, 1); // 1 = rảnh
                    }
                    else
                    {
                        isInitializing = true;
                        radioButtonFree.Checked = false;
                        radioButtonBusy.Checked = true;
                        isInitializing = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật trạng thái: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButtonBusy_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonBusy.Checked && !isInitializing)
                {
                    var result = MessageBox.Show(
                        "Bạn có muốn đổi trạng thái thành 'Bận' không?",
                        "Xác nhận thay đổi trạng thái",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        string currentUser = PersonLoginSession.CurrentPerson.UserName;
                        CrewMemberLogic crewBLL = new CrewMemberLogic();
                        crewBLL.UpdateCrewMemberStatus(currentUser, 0); // 0 = bận
                    }
                    else
                    {
                        isInitializing = true;
                        radioButtonBusy.Checked = false;
                        radioButtonFree.Checked = true;
                        isInitializing = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật trạng thái: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            CrewCheckForm next = new CrewCheckForm();
            next.Show();
            this.Hide();
        }
    }
}