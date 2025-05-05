namespace Presentation
{
    partial class FeedbackForm
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
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.phoneNumLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.detailLabel = new System.Windows.Forms.Label();
            this.richTxtDetail = new System.Windows.Forms.RichTextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameLabel.Location = new System.Drawing.Point(88, 88);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(94, 31);
            this.fullNameLabel.TabIndex = 0;
            this.fullNameLabel.Text = "Họ tên";
            // 
            // phoneNumLabel
            // 
            this.phoneNumLabel.AutoSize = true;
            this.phoneNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumLabel.Location = new System.Drawing.Point(88, 187);
            this.phoneNumLabel.Name = "phoneNumLabel";
            this.phoneNumLabel.Size = new System.Drawing.Size(171, 31);
            this.phoneNumLabel.TabIndex = 1;
            this.phoneNumLabel.Text = "Số điện thoại";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(88, 293);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(120, 31);
            this.typeLabel.TabIndex = 2;
            this.typeLabel.Text = "Phản hồi";
            // 
            // detailLabel
            // 
            this.detailLabel.AutoSize = true;
            this.detailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailLabel.Location = new System.Drawing.Point(88, 405);
            this.detailLabel.Name = "detailLabel";
            this.detailLabel.Size = new System.Drawing.Size(99, 31);
            this.detailLabel.TabIndex = 3;
            this.detailLabel.Text = "Chi tiết";
            // 
            // richTxtDetail
            // 
            this.richTxtDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtDetail.Location = new System.Drawing.Point(94, 474);
            this.richTxtDetail.MaxLength = 255;
            this.richTxtDetail.Name = "richTxtDetail";
            this.richTxtDetail.Size = new System.Drawing.Size(821, 304);
            this.richTxtDetail.TabIndex = 4;
            this.richTxtDetail.Text = "Ngắn gọn, không quá 255 kí tự";
            this.richTxtDetail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTxtDetail_MouseClick);
            this.richTxtDetail.Enter += new System.EventHandler(this.richTxtDetail_Enter);
            this.richTxtDetail.Leave += new System.EventHandler(this.richTxtDetail_Leave);
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(296, 85);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(399, 38);
            this.txtFullName.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(296, 184);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(399, 38);
            this.txtPhoneNumber.TabIndex = 5;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // cbbType
            // 
            this.cbbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(296, 290);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(399, 39);
            this.cbbType.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(814, 839);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(145, 57);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnBack
            // 
            this.btnBack.ErrorImage = global::Presentation.Properties.Resources.back;
            this.btnBack.Image = global::Presentation.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(915, 28);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(44, 58);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 69;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1031, 963);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.richTxtDetail);
            this.Controls.Add(this.detailLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.phoneNumLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Name = "FeedbackForm";
            this.Text = "FeedbackForm";
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label phoneNumLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label detailLabel;
        private System.Windows.Forms.RichTextBox richTxtDetail;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.PictureBox btnBack;
    }
}