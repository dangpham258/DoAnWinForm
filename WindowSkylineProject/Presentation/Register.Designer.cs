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
            this.welcomeNewUserLabel.Location = new System.Drawing.Point(172, 144);
            this.welcomeNewUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeNewUserLabel.Name = "welcomeNewUserLabel";
            this.welcomeNewUserLabel.Size = new System.Drawing.Size(328, 33);
            this.welcomeNewUserLabel.TabIndex = 16;
            this.welcomeNewUserLabel.Text = "Welcome to Skyline 360";
            // 
            // registerTitleLabel
            // 
            this.registerTitleLabel.AutoSize = true;
            this.registerTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerTitleLabel.Location = new System.Drawing.Point(243, 62);
            this.registerTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerTitleLabel.Name = "registerTitleLabel";
            this.registerTitleLabel.Size = new System.Drawing.Size(183, 51);
            this.registerTitleLabel.TabIndex = 15;
            this.registerTitleLabel.Text = "Register";
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameLabel.Location = new System.Drawing.Point(26, 275);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(133, 31);
            this.fullnameLabel.TabIndex = 17;
            this.fullnameLabel.Text = "Fullname:";
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(261, 658);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(147, 58);
            this.registerBtn.TabIndex = 18;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // fullnameTxt
            // 
            this.fullnameTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.fullnameTxt.Location = new System.Drawing.Point(278, 278);
            this.fullnameTxt.Name = "fullnameTxt";
            this.fullnameTxt.Size = new System.Drawing.Size(374, 31);
            this.fullnameTxt.TabIndex = 19;
            this.fullnameTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fullnameTxt_MouseClick);
            this.fullnameTxt.Enter += new System.EventHandler(this.fullnameTxt_Enter);
            this.fullnameTxt.Leave += new System.EventHandler(this.fullnameTxt_Leave);
            // 
            // passwordTxt
            // 
            this.passwordTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordTxt.Location = new System.Drawing.Point(278, 447);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(374, 31);
            this.passwordTxt.TabIndex = 22;
            this.passwordTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passwordTxt_MouseClick);
            this.passwordTxt.Enter += new System.EventHandler(this.passwordTxt_Enter);
            this.passwordTxt.Leave += new System.EventHandler(this.passwordTxt_Leave);
            // 
            // usernameTxt
            // 
            this.usernameTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.usernameTxt.Location = new System.Drawing.Point(278, 359);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(374, 31);
            this.usernameTxt.TabIndex = 23;
            this.usernameTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.usernameTxt_MouseClick);
            this.usernameTxt.Enter += new System.EventHandler(this.usernameTxt_Enter);
            this.usernameTxt.Leave += new System.EventHandler(this.usernameTxt_Leave);
            // 
            // passwordPassengerLabel
            // 
            this.passwordPassengerLabel.AutoSize = true;
            this.passwordPassengerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordPassengerLabel.Location = new System.Drawing.Point(26, 447);
            this.passwordPassengerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordPassengerLabel.Name = "passwordPassengerLabel";
            this.passwordPassengerLabel.Size = new System.Drawing.Size(142, 31);
            this.passwordPassengerLabel.TabIndex = 20;
            this.passwordPassengerLabel.Text = "Password:";
            // 
            // usernamePassengerLabel
            // 
            this.usernamePassengerLabel.AutoSize = true;
            this.usernamePassengerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamePassengerLabel.Location = new System.Drawing.Point(26, 356);
            this.usernamePassengerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernamePassengerLabel.Name = "usernamePassengerLabel";
            this.usernamePassengerLabel.Size = new System.Drawing.Size(147, 31);
            this.usernamePassengerLabel.TabIndex = 21;
            this.usernamePassengerLabel.Text = "Username:";
            // 
            // confirmPasswordTxt
            // 
            this.confirmPasswordTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.confirmPasswordTxt.Location = new System.Drawing.Point(278, 534);
            this.confirmPasswordTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmPasswordTxt.Name = "confirmPasswordTxt";
            this.confirmPasswordTxt.Size = new System.Drawing.Size(374, 31);
            this.confirmPasswordTxt.TabIndex = 25;
            this.confirmPasswordTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.confirmPasswordTxt_MouseClick);
            this.confirmPasswordTxt.Enter += new System.EventHandler(this.confirmPasswordTxt_Enter);
            this.confirmPasswordTxt.Leave += new System.EventHandler(this.confirmPasswordTxt_Leave);
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(26, 534);
            this.confirmPasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(244, 31);
            this.confirmPasswordLabel.TabIndex = 24;
            this.confirmPasswordLabel.Text = "Confirm Password:";
            // 
            // btnBack
            // 
            this.btnBack.Image = global::Presentation.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(622, 19);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(44, 58);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 67;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 817);
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