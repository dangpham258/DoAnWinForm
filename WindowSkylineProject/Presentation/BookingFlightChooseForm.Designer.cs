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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbDiemdi = new System.Windows.Forms.ComboBox();
            this.cbbDiemden = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flightDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewFlightOffers = new System.Windows.Forms.DataGridView();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightOffers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn điểm đi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn điểm đến";
            // 
            // cbbDiemdi
            // 
            this.cbbDiemdi.FormattingEnabled = true;
            this.cbbDiemdi.Location = new System.Drawing.Point(214, 21);
            this.cbbDiemdi.Name = "cbbDiemdi";
            this.cbbDiemdi.Size = new System.Drawing.Size(216, 24);
            this.cbbDiemdi.TabIndex = 2;
            // 
            // cbbDiemden
            // 
            this.cbbDiemden.FormattingEnabled = true;
            this.cbbDiemden.Location = new System.Drawing.Point(214, 79);
            this.cbbDiemden.Name = "cbbDiemden";
            this.cbbDiemden.Size = new System.Drawing.Size(216, 24);
            this.cbbDiemden.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chọn ngày bay";
            // 
            // flightDatePicker
            // 
            this.flightDatePicker.Location = new System.Drawing.Point(214, 149);
            this.flightDatePicker.Name = "flightDatePicker";
            this.flightDatePicker.Size = new System.Drawing.Size(216, 22);
            this.flightDatePicker.TabIndex = 5;
            // 
            // dataGridViewFlightOffers
            // 
            this.dataGridViewFlightOffers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFlightOffers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFlightOffers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFlightOffers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFlightOffers.Location = new System.Drawing.Point(58, 251);
            this.dataGridViewFlightOffers.Name = "dataGridViewFlightOffers";
            this.dataGridViewFlightOffers.ReadOnly = true;
            this.dataGridViewFlightOffers.RowHeadersVisible = false;
            this.dataGridViewFlightOffers.RowHeadersWidth = 51;
            this.dataGridViewFlightOffers.RowTemplate.Height = 24;
            this.dataGridViewFlightOffers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFlightOffers.Size = new System.Drawing.Size(1080, 264);
            this.dataGridViewFlightOffers.TabIndex = 6;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1049, 560);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(89, 32);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(89, 201);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(233, 32);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Tìm kiếm chuyến bay";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::Presentation.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(1141, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(29, 37);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 68;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BookingFlightChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
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
            this.Name = "BookingFlightChooseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingFlightChooseForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightOffers)).EndInit();
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
    }
}