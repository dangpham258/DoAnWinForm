namespace Presentation
{
    partial class ControllerLoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnXepLich = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.btnCheckFeedback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXepLich
            // 
            this.btnXepLich.Location = new System.Drawing.Point(104, 139);
            this.btnXepLich.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXepLich.Name = "btnXepLich";
            this.btnXepLich.Size = new System.Drawing.Size(252, 98);
            this.btnXepLich.TabIndex = 1;
            this.btnXepLich.Text = "Xếp lịch chuyến bay";
            this.btnXepLich.UseVisualStyleBackColor = true;
            this.btnXepLich.Click += new System.EventHandler(this.btnXepLich_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(104, 400);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(252, 98);
            this.btnBaoCao.TabIndex = 3;
            this.btnBaoCao.Text = "Tạo báo cáo chuyến bay";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1381, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(54, 58);
            this.btnClose.TabIndex = 73;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::Presentation.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(1310, 14);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(44, 58);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 72;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCheckFeedback
            // 
            this.btnCheckFeedback.Location = new System.Drawing.Point(104, 667);
            this.btnCheckFeedback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckFeedback.Name = "btnCheckFeedback";
            this.btnCheckFeedback.Size = new System.Drawing.Size(252, 98);
            this.btnCheckFeedback.TabIndex = 74;
            this.btnCheckFeedback.Text = "Xem phản hồi khách hàng";
            this.btnCheckFeedback.UseVisualStyleBackColor = true;
            this.btnCheckFeedback.Click += new System.EventHandler(this.btnCheckFeedback_Click);
            // 
            // ControllerLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1773, 1177);
            this.Controls.Add(this.btnCheckFeedback);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.btnXepLich);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ControllerLoginForm";
            this.Text = "ControllerLoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXepLich;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCheckFeedback;
    }
}