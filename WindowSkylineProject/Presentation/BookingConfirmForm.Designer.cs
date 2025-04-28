namespace Presentation
{
    partial class BookingConfirmForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblHanhTrinh;
        private System.Windows.Forms.Label lblChuyenBay;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblHangBay;
        private System.Windows.Forms.Label lblSoGhe;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnXacNhan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblHanhTrinh = new System.Windows.Forms.Label();
            this.lblChuyenBay = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.lblHangBay = new System.Windows.Forms.Label();
            this.lblSoGhe = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblHoTen, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSDT, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCCCD, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblHanhTrinh, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblChuyenBay, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblThoiGian, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblHangBay, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblSoGhe, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblGia, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1182, 753);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblHoTen
            // 
            this.lblHoTen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHoTen.Location = new System.Drawing.Point(11, 20);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(11, 4, 5, 4);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(89, 28);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Ông/Bà:";
            // 
            // lblSDT
            // 
            this.lblSDT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSDT.Location = new System.Drawing.Point(11, 86);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(11, 4, 5, 4);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(55, 28);
            this.lblSDT.TabIndex = 1;
            this.lblSDT.Text = "SĐT:";
            // 
            // lblCCCD
            // 
            this.lblCCCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCCCD.Location = new System.Drawing.Point(11, 146);
            this.lblCCCD.Margin = new System.Windows.Forms.Padding(11, 4, 5, 4);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(65, 25);
            this.lblCCCD.TabIndex = 2;
            this.lblCCCD.Text = "CCCD:";
            // 
            // lblHanhTrinh
            // 
            this.lblHanhTrinh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHanhTrinh.AutoSize = true;
            this.lblHanhTrinh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHanhTrinh.Location = new System.Drawing.Point(11, 206);
            this.lblHanhTrinh.Margin = new System.Windows.Forms.Padding(11, 4, 5, 4);
            this.lblHanhTrinh.Name = "lblHanhTrinh";
            this.lblHanhTrinh.Size = new System.Drawing.Size(126, 25);
            this.lblHanhTrinh.TabIndex = 3;
            this.lblHanhTrinh.Text = "Bay từ / đến:";
            // 
            // lblChuyenBay
            // 
            this.lblChuyenBay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblChuyenBay.AutoSize = true;
            this.lblChuyenBay.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblChuyenBay.Location = new System.Drawing.Point(11, 280);
            this.lblChuyenBay.Margin = new System.Windows.Forms.Padding(11, 4, 5, 4);
            this.lblChuyenBay.Name = "lblChuyenBay";
            this.lblChuyenBay.Size = new System.Drawing.Size(151, 25);
            this.lblChuyenBay.TabIndex = 4;
            this.lblChuyenBay.Text = "Mã chuyến bay:";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblThoiGian.Location = new System.Drawing.Point(11, 355);
            this.lblThoiGian.Margin = new System.Windows.Forms.Padding(11, 4, 5, 4);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(171, 25);
            this.lblThoiGian.TabIndex = 5;
            this.lblThoiGian.Text = "Giờ bay / hạ cánh:";
            // 
            // lblHangBay
            // 
            this.lblHangBay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHangBay.AutoSize = true;
            this.lblHangBay.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHangBay.Location = new System.Drawing.Point(11, 432);
            this.lblHangBay.Margin = new System.Windows.Forms.Padding(11, 4, 5, 4);
            this.lblHangBay.Name = "lblHangBay";
            this.lblHangBay.Size = new System.Drawing.Size(103, 25);
            this.lblHangBay.TabIndex = 6;
            this.lblHangBay.Text = "Hạng bay:";
            // 
            // lblSoGhe
            // 
            this.lblSoGhe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSoGhe.AutoSize = true;
            this.lblSoGhe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSoGhe.Location = new System.Drawing.Point(11, 513);
            this.lblSoGhe.Margin = new System.Windows.Forms.Padding(11, 4, 5, 4);
            this.lblSoGhe.Name = "lblSoGhe";
            this.lblSoGhe.Size = new System.Drawing.Size(78, 25);
            this.lblSoGhe.TabIndex = 7;
            this.lblSoGhe.Text = "Số ghế:";
            // 
            // lblGia
            // 
            this.lblGia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGia.Location = new System.Drawing.Point(11, 586);
            this.lblGia.Margin = new System.Windows.Forms.Padding(11, 4, 5, 4);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(46, 25);
            this.lblGia.TabIndex = 8;
            this.lblGia.Text = "Giá:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnXacNhan);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 635);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1176, 116);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.Location = new System.Drawing.Point(-3, 4);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(1175, 113);
            this.btnXacNhan.TabIndex = 0;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // BookingConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BookingConfirmForm";
            this.Text = "Xác nhận thông tin đặt vé";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}