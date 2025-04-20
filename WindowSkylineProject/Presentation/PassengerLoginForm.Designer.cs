namespace Presentation
{
    partial class PassengerLoginForm
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
            this.btnDat = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDat
            // 
            this.btnDat.Location = new System.Drawing.Point(77, 62);
            this.btnDat.Name = "btnDat";
            this.btnDat.Size = new System.Drawing.Size(168, 63);
            this.btnDat.TabIndex = 0;
            this.btnDat.Text = "Đặt vé";
            this.btnDat.UseVisualStyleBackColor = true;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(77, 213);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(168, 63);
            this.btnXem.TabIndex = 1;
            this.btnXem.Text = "Lịch sử mua vé";
            this.btnXem.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(77, 362);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(168, 63);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy vé";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // PassengerLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnDat);
            this.Name = "PassengerLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassengerLoginForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDat;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnHuy;
    }
}