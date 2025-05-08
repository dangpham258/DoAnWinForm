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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.DGVFlight = new System.Windows.Forms.DataGridView();
            this.DGVMainPilot = new System.Windows.Forms.DataGridView();
            this.DGVCoPilot = new System.Windows.Forms.DataGridView();
            this.DGVAttendant = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.btnRemoveCrew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMainPilot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCoPilot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAttendant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnXacNhan.Location = new System.Drawing.Point(623, 725);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(1265, 62);
            this.btnXacNhan.TabIndex = 15;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // DGVFlight
            // 
            this.DGVFlight.AllowUserToAddRows = false;
            this.DGVFlight.AllowUserToDeleteRows = false;
            this.DGVFlight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVFlight.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVFlight.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGVFlight.Location = new System.Drawing.Point(12, 69);
            this.DGVFlight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVFlight.Name = "DGVFlight";
            this.DGVFlight.ReadOnly = true;
            this.DGVFlight.RowHeadersVisible = false;
            this.DGVFlight.RowHeadersWidth = 51;
            this.DGVFlight.RowTemplate.Height = 24;
            this.DGVFlight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVFlight.Size = new System.Drawing.Size(1876, 234);
            this.DGVFlight.TabIndex = 71;
            // 
            // DGVMainPilot
            // 
            this.DGVMainPilot.AllowUserToAddRows = false;
            this.DGVMainPilot.AllowUserToDeleteRows = false;
            this.DGVMainPilot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMainPilot.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVMainPilot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVMainPilot.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGVMainPilot.Location = new System.Drawing.Point(12, 348);
            this.DGVMainPilot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVMainPilot.Name = "DGVMainPilot";
            this.DGVMainPilot.ReadOnly = true;
            this.DGVMainPilot.RowHeadersVisible = false;
            this.DGVMainPilot.RowHeadersWidth = 51;
            this.DGVMainPilot.RowTemplate.Height = 24;
            this.DGVMainPilot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVMainPilot.Size = new System.Drawing.Size(605, 371);
            this.DGVMainPilot.TabIndex = 72;
            // 
            // DGVCoPilot
            // 
            this.DGVCoPilot.AllowUserToAddRows = false;
            this.DGVCoPilot.AllowUserToDeleteRows = false;
            this.DGVCoPilot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCoPilot.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVCoPilot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCoPilot.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVCoPilot.Location = new System.Drawing.Point(623, 348);
            this.DGVCoPilot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVCoPilot.Name = "DGVCoPilot";
            this.DGVCoPilot.ReadOnly = true;
            this.DGVCoPilot.RowHeadersVisible = false;
            this.DGVCoPilot.RowHeadersWidth = 51;
            this.DGVCoPilot.RowTemplate.Height = 24;
            this.DGVCoPilot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCoPilot.Size = new System.Drawing.Size(621, 371);
            this.DGVCoPilot.TabIndex = 73;
            // 
            // DGVAttendant
            // 
            this.DGVAttendant.AllowUserToAddRows = false;
            this.DGVAttendant.AllowUserToDeleteRows = false;
            this.DGVAttendant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVAttendant.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVAttendant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVAttendant.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGVAttendant.Location = new System.Drawing.Point(1250, 348);
            this.DGVAttendant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVAttendant.Name = "DGVAttendant";
            this.DGVAttendant.ReadOnly = true;
            this.DGVAttendant.RowHeadersVisible = false;
            this.DGVAttendant.RowHeadersWidth = 51;
            this.DGVAttendant.RowTemplate.Height = 24;
            this.DGVAttendant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVAttendant.Size = new System.Drawing.Size(638, 371);
            this.DGVAttendant.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(742, 9);
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
            this.label6.Location = new System.Drawing.Point(218, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 28);
            this.label6.TabIndex = 77;
            this.label6.Text = "Chọn cơ trưởng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(875, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 78;
            this.label1.Text = "Chọn cơ phó";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1492, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 28);
            this.label2.TabIndex = 79;
            this.label2.Text = "Chọn tiếp viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation.Properties.Resources.flyicon;
            this.pictureBox1.Location = new System.Drawing.Point(1116, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Image = global::Presentation.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(1859, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(29, 37);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 70;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRemoveCrew
            // 
            this.btnRemoveCrew.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnRemoveCrew.Location = new System.Drawing.Point(12, 725);
            this.btnRemoveCrew.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveCrew.Name = "btnRemoveCrew";
            this.btnRemoveCrew.Size = new System.Drawing.Size(605, 62);
            this.btnRemoveCrew.TabIndex = 81;
            this.btnRemoveCrew.Text = "Gỡ thông tin";
            this.btnRemoveCrew.Click += new System.EventHandler(this.btnRemoveCrew_Click);
            // 
            // ControllerFlightChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1900, 800);
            this.Controls.Add(this.btnRemoveCrew);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.DGVFlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMainPilot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCoPilot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAttendant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRemoveCrew;
    }
}