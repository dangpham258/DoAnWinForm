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
    public partial class QRDisplayForm : Form
    {
        private Bitmap qrImage;

        public QRDisplayForm(Bitmap qrImage)
        {
            InitializeComponent();
            this.qrImage = qrImage; // Lưu trữ ảnh QR được truyền vào
            if (qrImage != null)
            {
                pictureBoxQR.Image = qrImage; // Gán ảnh QR vào PictureBox
            }
            else
            {
                MessageBox.Show("Lỗi: Mã QR không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void QRDisplayForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "PNG Image|*.png";
                saveDialog.Title = "Lưu mã QR";
                saveDialog.FileName = "VeMayBay_QR.png";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    qrImage.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    MessageBox.Show("Ảnh mã QR đã được lưu!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
