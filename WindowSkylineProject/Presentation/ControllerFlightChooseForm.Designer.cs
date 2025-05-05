namespace Presentation
{
    partial class ControllerFlightChooseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.DGVFlight = new System.Windows.Forms.DataGridView();
            this.DGVMainPilot = new System.Windows.Forms.DataGridView();
            this.DGVCoPilot = new System.Windows.Forms.DataGridView();
            this.DGVAttendant = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMainPilot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCoPilot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAttendant)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.Location = new System.Drawing.Point(12, 725);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(1776, 62);
            this.btnXacNhan.TabIndex = 15;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::Presentation.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(1760, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(29, 37);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 70;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // DGVFlight
            // 
            this.DGVFlight.AllowUserToAddRows = false;
            this.DGVFlight.AllowUserToDeleteRows = false;
            this.DGVFlight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVFlight.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVFlight.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGVFlight.Location = new System.Drawing.Point(12, 69);
            this.DGVFlight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVFlight.Name = "DGVFlight";
            this.DGVFlight.ReadOnly = true;
            this.DGVFlight.RowHeadersVisible = false;
            this.DGVFlight.RowHeadersWidth = 51;
            this.DGVFlight.RowTemplate.Height = 24;
            this.DGVFlight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVFlight.Size = new System.Drawing.Size(1776, 234);
            this.DGVFlight.TabIndex = 71;
            // 
            // DGVMainPilot
            // 
            this.DGVMainPilot.AllowUserToAddRows = false;
            this.DGVMainPilot.AllowUserToDeleteRows = false;
            this.DGVMainPilot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMainPilot.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVMainPilot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVMainPilot.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVMainPilot.Location = new System.Drawing.Point(12, 348);
            this.DGVMainPilot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVMainPilot.Name = "DGVMainPilot";
            this.DGVMainPilot.ReadOnly = true;
            this.DGVMainPilot.RowHeadersVisible = false;
            this.DGVMainPilot.RowHeadersWidth = 51;
            this.DGVMainPilot.RowTemplate.Height = 24;
            this.DGVMainPilot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVMainPilot.Size = new System.Drawing.Size(564, 371);
            this.DGVMainPilot.TabIndex = 72;
            // 
            // DGVCoPilot
            // 
            this.DGVCoPilot.AllowUserToAddRows = false;
            this.DGVCoPilot.AllowUserToDeleteRows = false;
            this.DGVCoPilot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCoPilot.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVCoPilot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCoPilot.DefaultCellStyle = dataGridViewCellStyle7;
            this.DGVCoPilot.Location = new System.Drawing.Point(582, 348);
            this.DGVCoPilot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVCoPilot.Name = "DGVCoPilot";
            this.DGVCoPilot.ReadOnly = true;
            this.DGVCoPilot.RowHeadersVisible = false;
            this.DGVCoPilot.RowHeadersWidth = 51;
            this.DGVCoPilot.RowTemplate.Height = 24;
            this.DGVCoPilot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCoPilot.Size = new System.Drawing.Size(611, 371);
            this.DGVCoPilot.TabIndex = 73;
            // 
            // DGVAttendant
            // 
            this.DGVAttendant.AllowUserToAddRows = false;
            this.DGVAttendant.AllowUserToDeleteRows = false;
            this.DGVAttendant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVAttendant.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVAttendant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVAttendant.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGVAttendant.Location = new System.Drawing.Point(1199, 348);
            this.DGVAttendant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVAttendant.Name = "DGVAttendant";
            this.DGVAttendant.ReadOnly = true;
            this.DGVAttendant.RowHeadersVisible = false;
            this.DGVAttendant.RowHeadersWidth = 51;
            this.DGVAttendant.RowTemplate.Height = 24;
            this.DGVAttendant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVAttendant.Size = new System.Drawing.Size(589, 371);
            this.DGVAttendant.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(722, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(357, 41);
            this.label5.TabIndex = 75;
            this.label5.Text = "XẾP LỊCH CHUYẾN BAY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 28);
            this.label3.TabIndex = 76;
            this.label3.Text = "Chọn chuyến bay";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(207, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 28);
            this.label6.TabIndex = 77;
            this.label6.Text = "Chọn cơ trưởng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(829, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 78;
            this.label1.Text = "Chọn cơ phó";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1423, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 28);
            this.label2.TabIndex = 79;
            this.label2.Text = "Chọn tiếp viên";
            // 
            // ControllerFlightChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1800, 800);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DGVAttendant);
            this.Controls.Add(this.DGVCoPilot);
            this.Controls.Add(this.DGVMainPilot);
            this.Controls.Add(this.DGVFlight);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnXacNhan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControllerFlightChooseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControllerFlightChooseForm";
            this.Load += new System.EventHandler(this.ControllerFlightChooseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMainPilot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCoPilot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAttendant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.DataGridView DGVFlight;
        private System.Windows.Forms.DataGridView DGVMainPilot;
        private System.Windows.Forms.DataGridView DGVCoPilot;
        private System.Windows.Forms.DataGridView DGVAttendant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}