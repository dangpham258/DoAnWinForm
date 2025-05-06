namespace Presentation
{
    partial class CheckFeedbackForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.radioBtnYes = new System.Windows.Forms.RadioButton();
            this.radioBtnNo = new System.Windows.Forms.RadioButton();
            this.richTxtDetail = new System.Windows.Forms.RichTextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.DGVFeedback = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.radioBtnNotSeen = new System.Windows.Forms.CheckBox();
            this.groupBoxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFeedback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.radioBtnYes);
            this.groupBoxStatus.Controls.Add(this.radioBtnNo);
            this.groupBoxStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStatus.Location = new System.Drawing.Point(1000, 196);
            this.groupBoxStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxStatus.Size = new System.Drawing.Size(172, 123);
            this.groupBoxStatus.TabIndex = 2;
            this.groupBoxStatus.TabStop = false;
            // 
            // radioBtnYes
            // 
            this.radioBtnYes.AutoSize = true;
            this.radioBtnYes.Location = new System.Drawing.Point(11, 76);
            this.radioBtnYes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtnYes.Name = "radioBtnYes";
            this.radioBtnYes.Size = new System.Drawing.Size(96, 32);
            this.radioBtnYes.TabIndex = 1;
            this.radioBtnYes.TabStop = true;
            this.radioBtnYes.Text = "Đã đọc";
            this.radioBtnYes.UseVisualStyleBackColor = true;
            // 
            // radioBtnNo
            // 
            this.radioBtnNo.AutoSize = true;
            this.radioBtnNo.Location = new System.Drawing.Point(11, 28);
            this.radioBtnNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioBtnNo.Name = "radioBtnNo";
            this.radioBtnNo.Size = new System.Drawing.Size(118, 32);
            this.radioBtnNo.TabIndex = 0;
            this.radioBtnNo.TabStop = true;
            this.radioBtnNo.Text = "Chưa đọc";
            this.radioBtnNo.UseVisualStyleBackColor = true;
            // 
            // richTxtDetail
            // 
            this.richTxtDetail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtDetail.Location = new System.Drawing.Point(11, 66);
            this.richTxtDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTxtDetail.Name = "richTxtDetail";
            this.richTxtDetail.Size = new System.Drawing.Size(657, 272);
            this.richTxtDetail.TabIndex = 71;
            this.richTxtDetail.Text = "";
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(682, 323);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(489, 51);
            this.btnFilter.TabIndex = 73;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(777, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 41);
            this.label5.TabIndex = 77;
            this.label5.Text = "Ý KIẾN PHẢN HỒI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 28);
            this.label2.TabIndex = 78;
            this.label2.Text = "Nội dung ý kiến:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(677, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 28);
            this.label1.TabIndex = 79;
            this.label1.Text = "Loại ý kiến:";
            // 
            // cbbType
            // 
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(682, 258);
            this.cbbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(282, 36);
            this.cbbType.TabIndex = 80;
            // 
            // DGVFeedback
            // 
            this.DGVFeedback.AllowUserToAddRows = false;
            this.DGVFeedback.AllowUserToDeleteRows = false;
            this.DGVFeedback.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVFeedback.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVFeedback.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGVFeedback.Location = new System.Drawing.Point(11, 388);
            this.DGVFeedback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVFeedback.Name = "DGVFeedback";
            this.DGVFeedback.ReadOnly = true;
            this.DGVFeedback.RowHeadersVisible = false;
            this.DGVFeedback.RowHeadersWidth = 51;
            this.DGVFeedback.RowTemplate.Height = 24;
            this.DGVFeedback.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVFeedback.Size = new System.Drawing.Size(1157, 354);
            this.DGVFeedback.TabIndex = 81;
            this.DGVFeedback.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVFeedback_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Presentation.Properties.Resources.back;
            this.pictureBox1.Image = global::Presentation.Properties.Resources.iconFeedBack;
            this.pictureBox1.Location = new System.Drawing.Point(740, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.ErrorImage = global::Presentation.Properties.Resources.back;
            this.btnBack.Image = global::Presentation.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(1141, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(29, 37);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 70;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // radioBtnNotSeen
            // 
            this.radioBtnNotSeen.AutoSize = true;
            this.radioBtnNotSeen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnNotSeen.Location = new System.Drawing.Point(11, 348);
            this.radioBtnNotSeen.Name = "radioBtnNotSeen";
            this.radioBtnNotSeen.Size = new System.Drawing.Size(445, 32);
            this.radioBtnNotSeen.TabIndex = 83;
            this.radioBtnNotSeen.Text = "Chọn để đánh dấu là chưa đọc các tin nhắn";
            this.radioBtnNotSeen.UseVisualStyleBackColor = true;
            // 
            // CheckFeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.radioBtnNotSeen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DGVFeedback);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.richTxtDetail);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBoxStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CheckFeedbackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckFeedbackForm";
            this.Load += new System.EventHandler(this.CheckFeedbackForm_Load);
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFeedback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.RadioButton radioBtnYes;
        private System.Windows.Forms.RadioButton radioBtnNo;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.RichTextBox richTxtDetail;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.DataGridView DGVFeedback;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox radioBtnNotSeen;
    }
}