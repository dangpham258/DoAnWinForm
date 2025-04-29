namespace Presentation
{
    partial class TicketHistoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtHang = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.DVGHistoryTicket = new System.Windows.Forms.DataGridView();
            this.cbbDiemdi = new System.Windows.Forms.ComboBox();
            this.cbbDiemden = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DVGHistoryTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điểm đi ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày bay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên hành khách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hãng";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(573, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 22);
            this.txtName.TabIndex = 7;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(168, 167);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 8;
            // 
            // txtHang
            // 
            this.txtHang.Location = new System.Drawing.Point(573, 106);
            this.txtHang.Name = "txtHang";
            this.txtHang.Size = new System.Drawing.Size(181, 22);
            this.txtHang.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(594, 181);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // DVGHistoryTicket
            // 
            this.DVGHistoryTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVGHistoryTicket.Location = new System.Drawing.Point(69, 268);
            this.DVGHistoryTicket.Name = "DVGHistoryTicket";
            this.DVGHistoryTicket.RowHeadersWidth = 51;
            this.DVGHistoryTicket.RowTemplate.Height = 24;
            this.DVGHistoryTicket.Size = new System.Drawing.Size(661, 150);
            this.DVGHistoryTicket.TabIndex = 11;
            // 
            // cbbDiemdi
            // 
            this.cbbDiemdi.FormattingEnabled = true;
            this.cbbDiemdi.Location = new System.Drawing.Point(168, 50);
            this.cbbDiemdi.Name = "cbbDiemdi";
            this.cbbDiemdi.Size = new System.Drawing.Size(216, 24);
            this.cbbDiemdi.TabIndex = 12;
            // 
            // cbbDiemden
            // 
            this.cbbDiemden.FormattingEnabled = true;
            this.cbbDiemden.Location = new System.Drawing.Point(168, 108);
            this.cbbDiemden.Name = "cbbDiemden";
            this.cbbDiemden.Size = new System.Drawing.Size(216, 24);
            this.cbbDiemden.TabIndex = 13;
            // 
            // btnBack
            // 
            this.btnBack.Image = global::Presentation.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(1127, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(29, 37);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 72;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TicketHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbbDiemdi);
            this.Controls.Add(this.cbbDiemden);
            this.Controls.Add(this.DVGHistoryTicket);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtHang);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketHistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.DVGHistoryTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtHang;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView DVGHistoryTicket;
        private System.Windows.Forms.ComboBox cbbDiemdi;
        private System.Windows.Forms.ComboBox cbbDiemden;
        private System.Windows.Forms.PictureBox btnBack;
    }
}