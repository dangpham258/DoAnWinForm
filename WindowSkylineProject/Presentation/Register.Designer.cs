namespace Presentation
{
    partial class registerForm
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
            this.welcomeNewUserLabel = new System.Windows.Forms.Label();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.fullnameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordPassengerLabel = new System.Windows.Forms.Label();
            this.usernamePassengerLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTxt = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeNewUserLabel
            // 
            this.welcomeNewUserLabel.AutoSize = true;
            this.welcomeNewUserLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeNewUserLabel.Location = new System.Drawing.Point(83, 49);
            this.welcomeNewUserLabel.Name = "welcomeNewUserLabel";
            this.welcomeNewUserLabel.Size = new System.Drawing.Size(295, 28);
            this.welcomeNewUserLabel.TabIndex = 16;
            this.welcomeNewUserLabel.Text = "Chào mừng đến với Skyline 360";
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameLabel.Location = new System.Drawing.Point(16, 228);
            this.fullnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(75, 25);
            this.fullnameLabel.TabIndex = 17;
            this.fullnameLabel.Text = "Họ tên:";
            // 
            // registerBtn
            // 
            this.registerBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(11, 478);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(457, 54);
            this.registerBtn.TabIndex = 18;
            this.registerBtn.Text = "Đăng ký tài khoản";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // fullnameTxt
            // 
            this.fullnameTxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.fullnameTxt.Location = new System.Drawing.Point(206, 223);
            this.fullnameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.fullnameTxt.Name = "fullnameTxt";
            this.fullnameTxt.Size = new System.Drawing.Size(251, 30);
            this.fullnameTxt.TabIndex = 19;
            this.fullnameTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fullnameTxt_MouseClick);
            this.fullnameTxt.Enter += new System.EventHandler(this.fullnameTxt_Enter);
            this.fullnameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fullnameTxt_KeyPress);
            this.fullnameTxt.Leave += new System.EventHandler(this.fullnameTxt_Leave);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordTxt.Location = new System.Drawing.Point(205, 359);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(251, 30);
            this.passwordTxt.TabIndex = 22;
            this.passwordTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passwordTxt_MouseClick);
            this.passwordTxt.Enter += new System.EventHandler(this.passwordTxt_Enter);
            this.passwordTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTxt_KeyPress);
            this.passwordTxt.Leave += new System.EventHandler(this.passwordTxt_Leave);
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.usernameTxt.Location = new System.Drawing.Point(205, 293);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(251, 30);
            this.usernameTxt.TabIndex = 23;
            this.usernameTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.usernameTxt_MouseClick);
            this.usernameTxt.Enter += new System.EventHandler(this.usernameTxt_Enter);
            this.usernameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameTxt_KeyPress);
            this.usernameTxt.Leave += new System.EventHandler(this.usernameTxt_Leave);
            // 
            // passwordPassengerLabel
            // 
            this.passwordPassengerLabel.AutoSize = true;
            this.passwordPassengerLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordPassengerLabel.Location = new System.Drawing.Point(16, 362);
            this.passwordPassengerLabel.Name = "passwordPassengerLabel";
            this.passwordPassengerLabel.Size = new System.Drawing.Size(98, 25);
            this.passwordPassengerLabel.TabIndex = 20;
            this.passwordPassengerLabel.Text = "Mật khẩu:";
            // 
            // usernamePassengerLabel
            // 
            this.usernamePassengerLabel.AutoSize = true;
            this.usernamePassengerLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamePassengerLabel.Location = new System.Drawing.Point(15, 295);
            this.usernamePassengerLabel.Name = "usernamePassengerLabel";
            this.usernamePassengerLabel.Size = new System.Drawing.Size(143, 25);
            this.usernamePassengerLabel.TabIndex = 21;
            this.usernamePassengerLabel.Text = "Tên đăng nhập:";
            // 
            // confirmPasswordTxt
            // 
            this.confirmPasswordTxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.confirmPasswordTxt.Location = new System.Drawing.Point(205, 422);
            this.confirmPasswordTxt.Name = "confirmPasswordTxt";
            this.confirmPasswordTxt.Size = new System.Drawing.Size(251, 30);
            this.confirmPasswordTxt.TabIndex = 25;
            this.confirmPasswordTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.confirmPasswordTxt_MouseClick);
            this.confirmPasswordTxt.Enter += new System.EventHandler(this.confirmPasswordTxt_Enter);
            this.confirmPasswordTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.confirmPasswordTxt_KeyPress);
            this.confirmPasswordTxt.Leave += new System.EventHandler(this.confirmPasswordTxt_Leave);
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(15, 426);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(173, 25);
            this.confirmPasswordLabel.TabIndex = 24;
            this.confirmPasswordLabel.Text = "Nhập lại mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(157, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 41);
            this.label4.TabIndex = 77;
            this.label4.Text = "ĐĂNG KÝ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation.Properties.Resources._9977134;
            this.pictureBox1.Location = new System.Drawing.Point(162, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Image = global::Presentation.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(439, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(29, 37);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 67;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 543);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.confirmPasswordTxt);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.passwordPassengerLabel);
            this.Controls.Add(this.usernamePassengerLabel);
            this.Controls.Add(this.fullnameTxt);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.fullnameLabel);
            this.Controls.Add(this.welcomeNewUserLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "registerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeNewUserLabel;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.TextBox fullnameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label passwordPassengerLabel;
        private System.Windows.Forms.Label usernamePassengerLabel;
        private System.Windows.Forms.TextBox confirmPasswordTxt;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}