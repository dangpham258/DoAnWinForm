namespace Presentation
{
    partial class StatisticForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblTotalPassengers = new System.Windows.Forms.Label();
            this.chartAirlineRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAirlinePassengers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFlightsPerDay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartAirlineRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAirlinePassengers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFlightsPerDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(312, 62);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(77, 28);
            this.lblTotalRevenue.TabIndex = 0;
            this.lblTotalRevenue.Text = "Money";
            // 
            // lblTotalPassengers
            // 
            this.lblTotalPassengers.AutoSize = true;
            this.lblTotalPassengers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPassengers.Location = new System.Drawing.Point(1058, 62);
            this.lblTotalPassengers.Name = "lblTotalPassengers";
            this.lblTotalPassengers.Size = new System.Drawing.Size(102, 28);
            this.lblTotalPassengers.TabIndex = 1;
            this.lblTotalPassengers.Text = "Customer";
            // 
            // chartAirlineRevenue
            // 
            chartArea10.Name = "ChartArea1";
            this.chartAirlineRevenue.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chartAirlineRevenue.Legends.Add(legend10);
            this.chartAirlineRevenue.Location = new System.Drawing.Point(12, 110);
            this.chartAirlineRevenue.Name = "chartAirlineRevenue";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chartAirlineRevenue.Series.Add(series10);
            this.chartAirlineRevenue.Size = new System.Drawing.Size(663, 377);
            this.chartAirlineRevenue.TabIndex = 2;
            this.chartAirlineRevenue.Text = "chart1";
            // 
            // chartAirlinePassengers
            // 
            chartArea11.Name = "ChartArea1";
            this.chartAirlinePassengers.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chartAirlinePassengers.Legends.Add(legend11);
            this.chartAirlinePassengers.Location = new System.Drawing.Point(681, 110);
            this.chartAirlinePassengers.Name = "chartAirlinePassengers";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.chartAirlinePassengers.Series.Add(series11);
            this.chartAirlinePassengers.Size = new System.Drawing.Size(688, 377);
            this.chartAirlinePassengers.TabIndex = 3;
            this.chartAirlinePassengers.Text = "chart2";
            // 
            // chartFlightsPerDay
            // 
            chartArea12.Name = "ChartArea1";
            this.chartFlightsPerDay.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chartFlightsPerDay.Legends.Add(legend12);
            this.chartFlightsPerDay.Location = new System.Drawing.Point(12, 493);
            this.chartFlightsPerDay.Name = "chartFlightsPerDay";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.chartFlightsPerDay.Series.Add(series12);
            this.chartFlightsPerDay.Size = new System.Drawing.Size(1357, 348);
            this.chartFlightsPerDay.TabIndex = 4;
            this.chartFlightsPerDay.Text = "chart3";
            // 
            // btnBack
            // 
            this.btnBack.Image = global::Presentation.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(1340, 7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(29, 37);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 73;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(523, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 41);
            this.label4.TabIndex = 79;
            this.label4.Text = "SỐ LIỆU THỐNG KÊ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 28);
            this.label1.TabIndex = 80;
            this.label1.Text = "Tổng doanh thu vé đã dùng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(676, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 28);
            this.label2.TabIndex = 81;
            this.label2.Text = "Tổng số lượng khách đã sử dụng vé:";
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 853);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chartFlightsPerDay);
            this.Controls.Add(this.chartAirlinePassengers);
            this.Controls.Add(this.chartAirlineRevenue);
            this.Controls.Add(this.lblTotalPassengers);
            this.Controls.Add(this.lblTotalRevenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticForm";
            this.Load += new System.EventHandler(this.StatisticForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartAirlineRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAirlinePassengers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFlightsPerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblTotalPassengers;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAirlineRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAirlinePassengers;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFlightsPerDay;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}