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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnMakeReport = new System.Windows.Forms.Button();
            this.flightDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.flightIDLb = new System.Windows.Forms.Label();
            this.txtFlightID = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.flightDGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(12, 190);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(542, 49);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Tìm kiếm chuyến bay";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnMakeReport
            // 
            this.btnMakeReport.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeReport.Location = new System.Drawing.Point(13, 688);
            this.btnMakeReport.Name = "btnMakeReport";
            this.btnMakeReport.Size = new System.Drawing.Size(1357, 53);
            this.btnMakeReport.TabIndex = 12;
            this.btnMakeReport.Text = "Tạo báo cáo chuyến bay";
            this.btnMakeReport.UseVisualStyleBackColor = true;
            this.btnMakeReport.Click += new System.EventHandler(this.btnMakeReport_Click);
            // 
            // flightDatePicker
            // 
            this.flightDatePicker.Enabled = false;
            this.flightDatePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightDatePicker.Location = new System.Drawing.Point(198, 135);
            this.flightDatePicker.Name = "flightDatePicker";
            this.flightDatePicker.Size = new System.Drawing.Size(356, 34);
            this.flightDatePicker.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chọn ngày bay";
            // 
            // flightIDLb
            // 
            this.flightIDLb.AutoSize = true;
            this.flightIDLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightIDLb.Location = new System.Drawing.Point(12, 72);
            this.flightIDLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.flightIDLb.Name = "flightIDLb";
            this.flightIDLb.Size = new System.Drawing.Size(93, 28);
            this.flightIDLb.TabIndex = 14;
            this.flightIDLb.Text = "Flight ID";
            // 
            // txtFlightID
            // 
            this.txtFlightID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightID.Location = new System.Drawing.Point(198, 72);
            this.txtFlightID.Margin = new System.Windows.Forms.Padding(2);
            this.txtFlightID.Name = "txtFlightID";
            this.txtFlightID.Size = new System.Drawing.Size(96, 34);
            this.txtFlightID.TabIndex = 15;
            this.txtFlightID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFlightID_KeyPress);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::Presentation.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(1341, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(29, 37);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 71;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // flightDGV
            // 
            this.flightDGV.AllowUserToAddRows = false;
            this.flightDGV.AllowUserToDeleteRows = false;
            this.flightDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.flightDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.flightDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.flightDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.flightDGV.Location = new System.Drawing.Point(13, 244);
            this.flightDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flightDGV.Name = "flightDGV";
            this.flightDGV.ReadOnly = true;
            this.flightDGV.RowHeadersVisible = false;
            this.flightDGV.RowHeadersWidth = 51;
            this.flightDGV.RowTemplate.Height = 24;
            this.flightDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.flightDGV.Size = new System.Drawing.Size(1357, 439);
            this.flightDGV.TabIndex = 72;
            this.flightDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.flightDGV_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(589, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 41);
            this.label4.TabIndex = 77;
            this.label4.Text = "TẠO BÁO CÁO";
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDate.Location = new System.Drawing.Point(582, 143);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(18, 17);
            this.checkBoxDate.TabIndex = 78;
            this.checkBoxDate.UseVisualStyleBackColor = true;
            this.checkBoxDate.CheckedChanged += new System.EventHandler(this.checkBoxDate_CheckedChanged);
            // 
            // ReportFlightChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.checkBoxDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flightDGV);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtFlightID);
            this.Controls.Add(this.flightIDLb);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnMakeReport);
            this.Controls.Add(this.flightDatePicker);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReportFlightChooseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportFlightChooseForm";
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnMakeReport;
        private System.Windows.Forms.DateTimePicker flightDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label flightIDLb;
        private System.Windows.Forms.TextBox txtFlightID;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.DataGridView flightDGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxDate;
    }
}