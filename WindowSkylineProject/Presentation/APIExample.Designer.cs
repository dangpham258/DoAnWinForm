namespace Presentation
{
    partial class APIExampleForm
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
            this.dataGridViewFlightOffers = new System.Windows.Forms.DataGridView();
            this.txtDepart = new System.Windows.Forms.TextBox();
            this.txtArrive = new System.Windows.Forms.TextBox();
            this.dateOutbound = new System.Windows.Forms.DateTimePicker();
            this.btnGetFlights = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbRoundTrip = new System.Windows.Forms.RadioButton();
            this.rdbOneWay = new System.Windows.Forms.RadioButton();
            this.dateReturn = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightOffers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewFlightOffers
            // 
            this.dataGridViewFlightOffers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlightOffers.Location = new System.Drawing.Point(72, 278);
            this.dataGridViewFlightOffers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewFlightOffers.Name = "dataGridViewFlightOffers";
            this.dataGridViewFlightOffers.RowHeadersWidth = 51;
            this.dataGridViewFlightOffers.RowTemplate.Height = 24;
            this.dataGridViewFlightOffers.Size = new System.Drawing.Size(1143, 586);
            this.dataGridViewFlightOffers.TabIndex = 0;
            // 
            // txtDepart
            // 
            this.txtDepart.Location = new System.Drawing.Point(444, 80);
            this.txtDepart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDepart.Name = "txtDepart";
            this.txtDepart.Size = new System.Drawing.Size(148, 31);
            this.txtDepart.TabIndex = 2;
            // 
            // txtArrive
            // 
            this.txtArrive.Location = new System.Drawing.Point(668, 80);
            this.txtArrive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArrive.Name = "txtArrive";
            this.txtArrive.Size = new System.Drawing.Size(148, 31);
            this.txtArrive.TabIndex = 3;
            // 
            // dateOutbound
            // 
            this.dateOutbound.Location = new System.Drawing.Point(910, 80);
            this.dateOutbound.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateOutbound.Name = "dateOutbound";
            this.dateOutbound.Size = new System.Drawing.Size(298, 31);
            this.dateOutbound.TabIndex = 4;
            // 
            // btnGetFlights
            // 
            this.btnGetFlights.Location = new System.Drawing.Point(165, 52);
            this.btnGetFlights.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGetFlights.Name = "btnGetFlights";
            this.btnGetFlights.Size = new System.Drawing.Size(162, 91);
            this.btnGetFlights.TabIndex = 5;
            this.btnGetFlights.Text = "Tìm chuyến bay";
            this.btnGetFlights.UseVisualStyleBackColor = true;
            this.btnGetFlights.Click += new System.EventHandler(this.btnGetFlights_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbRoundTrip);
            this.groupBox1.Controls.Add(this.rdbOneWay);
            this.groupBox1.Location = new System.Drawing.Point(178, 178);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(639, 66);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mặc định là Economy có thể chỉnh sau tùy nếu muốn ";
            // 
            // rdbRoundTrip
            // 
            this.rdbRoundTrip.AutoSize = true;
            this.rdbRoundTrip.Location = new System.Drawing.Point(356, 23);
            this.rdbRoundTrip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbRoundTrip.Name = "rdbRoundTrip";
            this.rdbRoundTrip.Size = new System.Drawing.Size(119, 29);
            this.rdbRoundTrip.TabIndex = 1;
            this.rdbRoundTrip.TabStop = true;
            this.rdbRoundTrip.Text = "2 chiều ";
            this.rdbRoundTrip.UseVisualStyleBackColor = true;
            // 
            // rdbOneWay
            // 
            this.rdbOneWay.AutoSize = true;
            this.rdbOneWay.Location = new System.Drawing.Point(48, 25);
            this.rdbOneWay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbOneWay.Name = "rdbOneWay";
            this.rdbOneWay.Size = new System.Drawing.Size(113, 29);
            this.rdbOneWay.TabIndex = 0;
            this.rdbOneWay.TabStop = true;
            this.rdbOneWay.Text = "1 chiều";
            this.rdbOneWay.UseVisualStyleBackColor = true;
            // 
            // dateReturn
            // 
            this.dateReturn.Location = new System.Drawing.Point(915, 197);
            this.dateReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateReturn.Name = "dateReturn";
            this.dateReturn.Size = new System.Drawing.Size(298, 31);
            this.dateReturn.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(910, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ngày đi - Outbound Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(910, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ngày về - Return Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mã đi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(663, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mã về";
            // 
            // APIExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 953);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateReturn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGetFlights);
            this.Controls.Add(this.dateOutbound);
            this.Controls.Add(this.txtArrive);
            this.Controls.Add(this.txtDepart);
            this.Controls.Add(this.dataGridViewFlightOffers);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "APIExampleForm";
            this.Text = "API Example";
            this.Load += new System.EventHandler(this.APIExampleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightOffers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFlightOffers;
        private System.Windows.Forms.TextBox txtDepart;
        private System.Windows.Forms.TextBox txtArrive;
        private System.Windows.Forms.DateTimePicker dateOutbound;
        private System.Windows.Forms.Button btnGetFlights;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbRoundTrip;
        private System.Windows.Forms.RadioButton rdbOneWay;
        private System.Windows.Forms.DateTimePicker dateReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}