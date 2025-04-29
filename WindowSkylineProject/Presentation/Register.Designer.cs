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
            this.registerTitleLabel = new System.Windows.Forms.Label();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.fullnameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordPassengerLabel = new System.Windows.Forms.Label();
            this.usernamePassengerLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTxt = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeNewUserLabel
            // 
            this.welcomeNewUserLabel.AutoSize = true;
            this.welcomeNewUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeNewUserLabel.Location = new System.Drawing.Point(115, 92);
            this.welcomeNewUserLabel.Name = "welcomeNewUserLabel";
            this.welcomeNewUserLabel.Size = new System.Drawing.Size(211, 24);
            this.welcomeNewUserLabel.TabIndex = 16;
            this.welcomeNewUserLabel.Text = "Welcome to Skyline 360";
            // 
            // registerTitleLabel
            // 
            this.registerTitleLabel.AutoSize = true;
            this.registerTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerTitleLabel.Location = new System.Drawing.Point(162, 40);
            this.registerTitleLabel.Name = "registerTitleLabel";
            this.registerTitleLabel.Size = new System.Drawing.Size(116, 31);
            this.registerTitleLabel.TabIndex = 15;
            this.registerTitleLabel.Text = "Register";
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameLabel.Location = new System.Drawing.Point(17, 176);
            this.fullnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(82, 20);
            this.fullnameLabel.TabIndex = 17;
            this.fullnameLabel.Text = "Fullname:";
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(174, 421);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(98, 37);
            this.registerBtn.TabIndex = 18;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // fullnameTxt
            // 
            this.fullnameTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.fullnameTxt.Location = new System.Drawing.Point(185, 178);
            this.fullnameTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fullnameTxt.Name = "fullnameTxt";
            this.fullnameTxt.Size = new System.Drawing.Size(251, 22);
            this.fullnameTxt.TabIndex = 19;
            this.fullnameTxt.Leave += new System.EventHandler(this.fullnameTxt_Leave);
            this.fullnameTxt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fullnameTxt_MouseDown);
            // 
            // passwordTxt
            // 
            this.passwordTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordTxt.Location = new System.Drawing.Point(185, 286);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(251, 22);
            this.passwordTxt.TabIndex = 22;
            this.passwordTxt.Leave += new System.EventHandler(this.passwordTxt_Leave);
            this.passwordTxt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.passwordTxt_MouseDown);
            // 
            // usernameTxt
            // 
            this.usernameTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.usernameTxt.Location = new System.Drawing.Point(185, 230);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(251, 22);
            this.usernameTxt.TabIndex = 23;
            this.usernameTxt.Leave += new System.EventHandler(this.usernameTxt_Leave);
            this.usernameTxt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.usernameTxt_MouseDown);
            // 
            // passwordPassengerLabel
            // 
            this.passwordPassengerLabel.AutoSize = true;
            this.passwordPassengerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordPassengerLabel.Location = new System.Drawing.Point(17, 286);
            this.passwordPassengerLabel.Name = "passwordPassengerLabel";
            this.passwordPassengerLabel.Size = new System.Drawing.Size(88, 20);
            this.passwordPassengerLabel.TabIndex = 20;
            this.passwordPassengerLabel.Text = "Password:";
            // 
            // usernamePassengerLabel
            // 
            this.usernamePassengerLabel.AutoSize = true;
            this.usernamePassengerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamePassengerLabel.Location = new System.Drawing.Point(17, 228);
            this.usernamePassengerLabel.Name = "usernamePassengerLabel";
            this.usernamePassengerLabel.Size = new System.Drawing.Size(91, 20);
            this.usernamePassengerLabel.TabIndex = 21;
            this.usernamePassengerLabel.Text = "Username:";
            // 
            // confirmPasswordTxt
            // 
            this.confirmPasswordTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.confirmPasswordTxt.Location = new System.Drawing.Point(185, 342);
            this.confirmPasswordTxt.Name = "confirmPasswordTxt";
            this.confirmPasswordTxt.Size = new System.Drawing.Size(251, 22);
            this.confirmPasswordTxt.TabIndex = 25;
            this.confirmPasswordTxt.Leave += new System.EventHandler(this.confirmPasswordTxt_Leave);
            this.confirmPasswordTxt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.confirmPasswordTxt_MouseDown);
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(17, 342);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(152, 20);
            this.confirmPasswordLabel.TabIndex = 24;
            this.confirmPasswordLabel.Text = "Confirm Password:";
            // 
            // btnBack
            // 
            this.btnBack.Image = global::Presentation.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(415, 12);
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
            this.ClientSize = new System.Drawing.Size(456, 523);
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
            this.Controls.Add(this.registerTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "registerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.registerForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeNewUserLabel;
        private System.Windows.Forms.Label registerTitleLabel;
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
    }
}