namespace Presentation
{
    partial class ReportFlightChooseForm
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnMakeReport = new System.Windows.Forms.Button();
            this.flightDGV = new System.Windows.Forms.DataGridView();
            this.flightDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.flightIDLb = new System.Windows.Forms.Label();
            this.txtFlightID = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.flightDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(61, 311);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(350, 50);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Tìm kiếm chuyến bay";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnMakeReport
            // 
            this.btnMakeReport.Location = new System.Drawing.Point(1404, 909);
            this.btnMakeReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMakeReport.Name = "btnMakeReport";
            this.btnMakeReport.Size = new System.Drawing.Size(202, 50);
            this.btnMakeReport.TabIndex = 12;
            this.btnMakeReport.Text = "Tạo báo cáo";
            this.btnMakeReport.UseVisualStyleBackColor = true;
            this.btnMakeReport.Click += new System.EventHandler(this.btnMakeReport_Click);
            // 
            // flightDGV
            // 
            this.flightDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.flightDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.flightDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.flightDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.flightDGV.Location = new System.Drawing.Point(25, 461);
            this.flightDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flightDGV.Name = "flightDGV";
            this.flightDGV.ReadOnly = true;
            this.flightDGV.RowHeadersVisible = false;
            this.flightDGV.RowHeadersWidth = 51;
            this.flightDGV.RowTemplate.Height = 24;
            this.flightDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.flightDGV.Size = new System.Drawing.Size(1620, 412);
            this.flightDGV.TabIndex = 11;
            this.flightDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.flightDGV_CellContentClick);
            // 
            // flightDatePicker
            // 
            this.flightDatePicker.Location = new System.Drawing.Point(237, 219);
            this.flightDatePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flightDatePicker.Name = "flightDatePicker";
            this.flightDatePicker.Size = new System.Drawing.Size(399, 31);
            this.flightDatePicker.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chọn ngày bay";
            // 
            // flightIDLb
            // 
            this.flightIDLb.AutoSize = true;
            this.flightIDLb.Location = new System.Drawing.Point(31, 113);
            this.flightIDLb.Name = "flightIDLb";
            this.flightIDLb.Size = new System.Drawing.Size(91, 25);
            this.flightIDLb.TabIndex = 14;
            this.flightIDLb.Text = "Flight ID";
            // 
            // txtFlightID
            // 
            this.txtFlightID.Location = new System.Drawing.Point(237, 110);
            this.txtFlightID.Name = "txtFlightID";
            this.txtFlightID.Size = new System.Drawing.Size(142, 31);
            this.txtFlightID.TabIndex = 15;
            // 
            // btnBack
            // 
            this.btnBack.Image = global::Presentation.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(1562, 25);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(44, 58);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 71;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ReportFlightChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1675, 1003);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtFlightID);
            this.Controls.Add(this.flightIDLb);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnMakeReport);
            this.Controls.Add(this.flightDGV);
            this.Controls.Add(this.flightDatePicker);
            this.Controls.Add(this.label3);
            this.Name = "ReportFlightChooseForm";
            this.Text = "ReportFlightChooseForm";
            ((System.ComponentModel.ISupportInitialize)(this.flightDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnMakeReport;
        private System.Windows.Forms.DataGridView flightDGV;
        private System.Windows.Forms.DateTimePicker flightDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label flightIDLb;
        private System.Windows.Forms.TextBox txtFlightID;
        private System.Windows.Forms.PictureBox btnBack;
    }
}