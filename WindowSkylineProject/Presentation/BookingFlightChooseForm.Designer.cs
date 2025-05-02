namespace Presentation
{
    partial class BookingFlightChooseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbDiemdi = new System.Windows.Forms.ComboBox();
            this.cbbDiemden = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flightDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewFlightOffers = new System.Windows.Forms.DataGridView();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.progressBarSearch = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSwap = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightOffers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSwap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn điểm đi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn điểm đến";
            // 
            // cbbDiemdi
            // 
            this.cbbDiemdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDiemdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDiemdi.FormattingEnabled = true;
            this.cbbDiemdi.Location = new System.Drawing.Point(200, 21);
            this.cbbDiemdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbDiemdi.Name = "cbbDiemdi";
            this.cbbDiemdi.Size = new System.Drawing.Size(241, 29);
            this.cbbDiemdi.TabIndex = 2;
            // 
            // cbbDiemden
            // 
            this.cbbDiemden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDiemden.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDiemden.FormattingEnabled = true;
            this.cbbDiemden.Location = new System.Drawing.Point(200, 70);
            this.cbbDiemden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbDiemden.Name = "cbbDiemden";
            this.cbbDiemden.Size = new System.Drawing.Size(241, 29);
            this.cbbDiemden.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chọn ngày bay";
            // 
            // flightDatePicker
            // 
            this.flightDatePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.flightDatePicker.Location = new System.Drawing.Point(200, 124);
            this.flightDatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flightDatePicker.Name = "flightDatePicker";
            this.flightDatePicker.Size = new System.Drawing.Size(241, 29);
            this.flightDatePicker.TabIndex = 5;
            // 
            // dataGridViewFlightOffers
            // 
            this.dataGridViewFlightOffers.AllowUserToAddRows = false;
            this.dataGridViewFlightOffers.AllowUserToDeleteRows = false;
            this.dataGridViewFlightOffers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFlightOffers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFlightOffers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFlightOffers.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewFlightOffers.Location = new System.Drawing.Point(9, 267);
            this.dataGridViewFlightOffers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewFlightOffers.Name = "dataGridViewFlightOffers";
            this.dataGridViewFlightOffers.ReadOnly = true;
            this.dataGridViewFlightOffers.RowHeadersVisible = false;
            this.dataGridViewFlightOffers.RowHeadersWidth = 51;
            this.dataGridViewFlightOffers.RowTemplate.Height = 24;
            this.dataGridViewFlightOffers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFlightOffers.Size = new System.Drawing.Size(868, 279);
            this.dataGridViewFlightOffers.TabIndex = 6;
            this.dataGridViewFlightOffers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFlightOffers_CellClick);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(9, 551);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(868, 51);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Tiếp tục";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(200, 170);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(240, 40);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Tìm kiếm chuyến bay";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // progressBarSearch
            // 
            this.progressBarSearch.Location = new System.Drawing.Point(9, 244);
            this.progressBarSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBarSearch.Name = "progressBarSearch";
            this.progressBarSearch.Size = new System.Drawing.Size(868, 19);
            this.progressBarSearch.TabIndex = 69;
            this.progressBarSearch.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(9, 219);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(113, 21);
            this.lblStatus.TabIndex = 70;
            this.lblStatus.Text = "Process tìm cb";
            this.lblStatus.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Presentation.Properties.Resources.iconDiemDen;
            this.pictureBox3.Location = new System.Drawing.Point(13, 73);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 74;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentation.Properties.Resources.iconDiemDi;
            this.pictureBox2.Location = new System.Drawing.Point(13, 24);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 73;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation.Properties.Resources.windowairline;
            this.pictureBox1.Location = new System.Drawing.Point(549, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // btnSwap
            // 
            this.btnSwap.Image = global::Presentation.Properties.Resources.swap2;
            this.btnSwap.Location = new System.Drawing.Point(459, 44);
            this.btnSwap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(29, 34);
            this.btnSwap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSwap.TabIndex = 71;
            this.btnSwap.TabStop = false;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnBack
            // 
            this.btnBack.ErrorImage = global::Presentation.Properties.Resources.back;
            this.btnBack.Image = global::Presentation.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(856, 6);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(22, 30);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 68;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(548, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 32);
            this.label4.TabIndex = 75;
            this.label4.Text = "CHỌN CHUYẾN BAY";
            // 
            // BookingFlightChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 612);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBarSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cbbDiemdi);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dataGridViewFlightOffers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbDiemden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flightDatePicker);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BookingFlightChooseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingFlightChooseForm";
            this.Load += new System.EventHandler(this.BookingFlightChooseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightOffers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSwap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbDiemdi;
        private System.Windows.Forms.ComboBox cbbDiemden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker flightDatePicker;
        private System.Windows.Forms.DataGridView dataGridViewFlightOffers;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.ProgressBar progressBarSearch;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox btnSwap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
    }
}