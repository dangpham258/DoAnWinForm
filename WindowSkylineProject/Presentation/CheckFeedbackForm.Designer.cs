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
            this.DGVFeedback = new System.Windows.Forms.DataGridView();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.radioBtnYes = new System.Windows.Forms.RadioButton();
            this.radioBtnNo = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.richTxtDetail = new System.Windows.Forms.RichTextBox();
            this.radioBtnNotSeen = new System.Windows.Forms.RadioButton();
            this.btnFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFeedback)).BeginInit();
            this.groupBoxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVFeedback
            // 
            this.DGVFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFeedback.Location = new System.Drawing.Point(66, 564);
            this.DGVFeedback.Name = "DGVFeedback";
            this.DGVFeedback.RowHeadersWidth = 82;
            this.DGVFeedback.RowTemplate.Height = 33;
            this.DGVFeedback.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVFeedback.Size = new System.Drawing.Size(1491, 378);
            this.DGVFeedback.TabIndex = 0;
            this.DGVFeedback.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVFeedback_CellClick);
            // 
            // cbbType
            // 
            this.cbbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(1111, 80);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(380, 39);
            this.cbbType.TabIndex = 1;
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Controls.Add(this.radioBtnYes);
            this.groupBoxStatus.Controls.Add(this.radioBtnNo);
            this.groupBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStatus.Location = new System.Drawing.Point(1111, 325);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(258, 152);
            this.groupBoxStatus.TabIndex = 2;
            this.groupBoxStatus.TabStop = false;
            // 
            // radioBtnYes
            // 
            this.radioBtnYes.AutoSize = true;
            this.radioBtnYes.Location = new System.Drawing.Point(16, 102);
            this.radioBtnYes.Name = "radioBtnYes";
            this.radioBtnYes.Size = new System.Drawing.Size(131, 35);
            this.radioBtnYes.TabIndex = 1;
            this.radioBtnYes.TabStop = true;
            this.radioBtnYes.Text = "Đã đọc";
            this.radioBtnYes.UseVisualStyleBackColor = true;
            // 
            // radioBtnNo
            // 
            this.radioBtnNo.AutoSize = true;
            this.radioBtnNo.Location = new System.Drawing.Point(16, 37);
            this.radioBtnNo.Name = "radioBtnNo";
            this.radioBtnNo.Size = new System.Drawing.Size(161, 35);
            this.radioBtnNo.TabIndex = 0;
            this.radioBtnNo.TabStop = true;
            this.radioBtnNo.Text = "Chưa đọc";
            this.radioBtnNo.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.ErrorImage = global::Presentation.Properties.Resources.back;
            this.btnBack.Image = global::Presentation.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(1526, 32);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(44, 58);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 70;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // richTxtDetail
            // 
            this.richTxtDetail.Location = new System.Drawing.Point(66, 80);
            this.richTxtDetail.Name = "richTxtDetail";
            this.richTxtDetail.Size = new System.Drawing.Size(984, 397);
            this.richTxtDetail.TabIndex = 71;
            this.richTxtDetail.Text = "";
            // 
            // radioBtnNotSeen
            // 
            this.radioBtnNotSeen.AutoSize = true;
            this.radioBtnNotSeen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnNotSeen.Location = new System.Drawing.Point(66, 520);
            this.radioBtnNotSeen.Name = "radioBtnNotSeen";
            this.radioBtnNotSeen.Size = new System.Drawing.Size(279, 35);
            this.radioBtnNotSeen.TabIndex = 72;
            this.radioBtnNotSeen.TabStop = true;
            this.radioBtnNotSeen.Text = "Đánh dấu chưa đọc";
            this.radioBtnNotSeen.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(1414, 341);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(143, 136);
            this.btnFilter.TabIndex = 73;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // CheckFeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1619, 964);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.radioBtnNotSeen);
            this.Controls.Add(this.richTxtDetail);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.DGVFeedback);
            this.Name = "CheckFeedbackForm";
            this.Text = "CheckFeedbackForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGVFeedback)).EndInit();
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVFeedback;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.RadioButton radioBtnYes;
        private System.Windows.Forms.RadioButton radioBtnNo;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.RichTextBox richTxtDetail;
        private System.Windows.Forms.RadioButton radioBtnNotSeen;
        private System.Windows.Forms.Button btnFilter;
    }
}