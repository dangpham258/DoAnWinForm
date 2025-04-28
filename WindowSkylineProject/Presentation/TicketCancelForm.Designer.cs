namespace Presentation
{
    partial class TicketCancelForm
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
            this.DVGTicket = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DVGTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // DVGTicket
            // 
            this.DVGTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVGTicket.Location = new System.Drawing.Point(51, 107);
            this.DVGTicket.Name = "DVGTicket";
            this.DVGTicket.RowHeadersWidth = 51;
            this.DVGTicket.RowTemplate.Height = 24;
            this.DVGTicket.Size = new System.Drawing.Size(1056, 242);
            this.DVGTicket.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Ticket";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(51, 391);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(1056, 66);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Gửi yêu cầu hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // TicketCancelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DVGTicket);
            this.Name = "TicketCancelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketCancelForm";
            ((System.ComponentModel.ISupportInitialize)(this.DVGTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DVGTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuy;
    }
}