namespace Presentation
{
    partial class ControllerLoginForm
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
            this.btnXepLich = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnXepLich
            // 
            this.btnXepLich.Location = new System.Drawing.Point(69, 89);
            this.btnXepLich.Name = "btnXepLich";
            this.btnXepLich.Size = new System.Drawing.Size(168, 63);
            this.btnXepLich.TabIndex = 1;
            this.btnXepLich.Text = "Xếp lịch chuyến bay";
            this.btnXepLich.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tạo báo cáo chuyến bay";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ControllerLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnXepLich);
            this.Name = "ControllerLoginForm";
            this.Text = "ControllerLoginForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXepLich;
        private System.Windows.Forms.Button button1;
    }
}