namespace Presentation
{
    partial class Report
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
            this.flightReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // flightReport
            // 
            this.flightReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flightReport.LocalReport.ReportEmbeddedResource = "Presentation.FlightReport.rdlc";
            this.flightReport.Location = new System.Drawing.Point(0, 0);
            this.flightReport.Name = "flightReport";
            this.flightReport.ServerReport.BearerToken = null;
            this.flightReport.Size = new System.Drawing.Size(1642, 993);
            this.flightReport.TabIndex = 0;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1642, 993);
            this.Controls.Add(this.flightReport);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer flightReport;
    }
}