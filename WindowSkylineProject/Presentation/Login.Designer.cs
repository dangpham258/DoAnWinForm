namespace Presentation
{
    partial class loginForm
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
            this.bookingBtn = new System.Windows.Forms.Button();
            this.scheduleBtn = new System.Windows.Forms.Button();
            this.bookingPanel = new System.Windows.Forms.Panel();
            this.registerLabel = new System.Windows.Forms.Label();
            this.askForRegisterLabel = new System.Windows.Forms.Label();
            this.welcomepassengerLabel = new System.Windows.Forms.Label();
            this.loginAsPassengerBtn = new System.Windows.Forms.Button();
            this.passwordPassengerTxt = new System.Windows.Forms.TextBox();
            this.usernamePassengerTxt = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.bookingTitleLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.scheduleFlightPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crewMemberRadioBtn = new System.Windows.Forms.RadioButton();
            this.controllerRadioBtn = new System.Windows.Forms.RadioButton();
            this.welcomeFlightCrewLabel = new System.Windows.Forms.Label();
            this.loginAsFlightCrewBtn = new System.Windows.Forms.Button();
            this.passwordFlightCrewTxt = new System.Windows.Forms.TextBox();
            this.usernameFlightCrewTxt = new System.Windows.Forms.TextBox();
            this.passwordFlightCrewLabel = new System.Windows.Forms.Label();
            this.scheduleTitleLabel = new System.Windows.Forms.Label();
            this.usernameFlightCrewLabel = new System.Windows.Forms.Label();
            this.bookingPanel.SuspendLayout();
            this.scheduleFlightPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookingBtn
            // 
            this.bookingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingBtn.Location = new System.Drawing.Point(340, -2);
            this.bookingBtn.Margin = new System.Windows.Forms.Padding(4);
            this.bookingBtn.Name = "bookingBtn";
            this.bookingBtn.Size = new System.Drawing.Size(344, 79);
            this.bookingBtn.TabIndex = 1;
            this.bookingBtn.Text = "Booking";
            this.bookingBtn.UseVisualStyleBackColor = true;
            this.bookingBtn.Click += new System.EventHandler(this.bookingBtn_Click);
            // 
            // scheduleBtn
            // 
            this.scheduleBtn.BackColor = System.Drawing.SystemColors.Control;
            this.scheduleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleBtn.Location = new System.Drawing.Point(0, -2);
            this.scheduleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.scheduleBtn.Name = "scheduleBtn";
            this.scheduleBtn.Size = new System.Drawing.Size(344, 79);
            this.scheduleBtn.TabIndex = 1;
            this.scheduleBtn.Text = "Flight Schedule";
            this.scheduleBtn.UseVisualStyleBackColor = false;
            this.scheduleBtn.Click += new System.EventHandler(this.scheduleBtn_Click);
            // 
            // bookingPanel
            // 
            this.bookingPanel.Controls.Add(this.registerLabel);
            this.bookingPanel.Controls.Add(this.askForRegisterLabel);
            this.bookingPanel.Controls.Add(this.welcomepassengerLabel);
            this.bookingPanel.Controls.Add(this.loginAsPassengerBtn);
            this.bookingPanel.Controls.Add(this.passwordPassengerTxt);
            this.bookingPanel.Controls.Add(this.usernamePassengerTxt);
            this.bookingPanel.Controls.Add(this.passwordLabel);
            this.bookingPanel.Controls.Add(this.bookingTitleLabel);
            this.bookingPanel.Controls.Add(this.usernameLabel);
            this.bookingPanel.Location = new System.Drawing.Point(0, 85);
            this.bookingPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bookingPanel.Name = "bookingPanel";
            this.bookingPanel.Size = new System.Drawing.Size(684, 733);
            this.bookingPanel.TabIndex = 18;
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.registerLabel.Location = new System.Drawing.Point(467, 552);
            this.registerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(104, 29);
            this.registerLabel.TabIndex = 16;
            this.registerLabel.Text = "Register";
            this.registerLabel.Click += new System.EventHandler(this.registerLabel_Click);
            // 
            // askForRegisterLabel
            // 
            this.askForRegisterLabel.AutoSize = true;
            this.askForRegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.askForRegisterLabel.Location = new System.Drawing.Point(91, 552);
            this.askForRegisterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.askForRegisterLabel.Name = "askForRegisterLabel";
            this.askForRegisterLabel.Size = new System.Drawing.Size(368, 29);
            this.askForRegisterLabel.TabIndex = 15;
            this.askForRegisterLabel.Text = "Have you had your own account ?";
            // 
            // welcomepassengerLabel
            // 
            this.welcomepassengerLabel.AutoSize = true;
            this.welcomepassengerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomepassengerLabel.Location = new System.Drawing.Point(180, 151);
            this.welcomepassengerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomepassengerLabel.Name = "welcomepassengerLabel";
            this.welcomepassengerLabel.Size = new System.Drawing.Size(328, 33);
            this.welcomepassengerLabel.TabIndex = 14;
            this.welcomepassengerLabel.Text = "Welcome to Skyline 360";
            // 
            // loginAsPassengerBtn
            // 
            this.loginAsPassengerBtn.Location = new System.Drawing.Point(248, 454);
            this.loginAsPassengerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loginAsPassengerBtn.Name = "loginAsPassengerBtn";
            this.loginAsPassengerBtn.Size = new System.Drawing.Size(204, 62);
            this.loginAsPassengerBtn.TabIndex = 13;
            this.loginAsPassengerBtn.Text = "Login";
            this.loginAsPassengerBtn.UseVisualStyleBackColor = true;
            this.loginAsPassengerBtn.Click += new System.EventHandler(this.loginAsPassengerBtn_Click);
            // 
            // passwordPassengerTxt
            // 
            this.passwordPassengerTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordPassengerTxt.Location = new System.Drawing.Point(224, 360);
            this.passwordPassengerTxt.Margin = new System.Windows.Forms.Padding(4);
            this.passwordPassengerTxt.Name = "passwordPassengerTxt";
            this.passwordPassengerTxt.PasswordChar = '*';
            this.passwordPassengerTxt.Size = new System.Drawing.Size(400, 31);
            this.passwordPassengerTxt.TabIndex = 11;
            this.passwordPassengerTxt.Leave += new System.EventHandler(this.passwordPassengerTxt_Leave);
            this.passwordPassengerTxt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.passwordPassengerTxt_MouseDown);
            // 
            // usernamePassengerTxt
            // 
            this.usernamePassengerTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.usernamePassengerTxt.Location = new System.Drawing.Point(224, 258);
            this.usernamePassengerTxt.Margin = new System.Windows.Forms.Padding(4);
            this.usernamePassengerTxt.Name = "usernamePassengerTxt";
            this.usernamePassengerTxt.Size = new System.Drawing.Size(400, 31);
            this.usernamePassengerTxt.TabIndex = 12;
            this.usernamePassengerTxt.Leave += new System.EventHandler(this.usernamePassengerTxt_Leave);
            this.usernamePassengerTxt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.usernamePassengerTxt_MouseDown);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(52, 356);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(142, 31);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password:";
            // 
            // bookingTitleLabel
            // 
            this.bookingTitleLabel.AutoSize = true;
            this.bookingTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingTitleLabel.Location = new System.Drawing.Point(250, 71);
            this.bookingTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookingTitleLabel.Name = "bookingTitleLabel";
            this.bookingTitleLabel.Size = new System.Drawing.Size(179, 51);
            this.bookingTitleLabel.TabIndex = 9;
            this.bookingTitleLabel.Text = "Booking";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(52, 256);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(147, 31);
            this.usernameLabel.TabIndex = 10;
            this.usernameLabel.Text = "Username:";
            // 
            // scheduleFlightPanel
            // 
            this.scheduleFlightPanel.Controls.Add(this.groupBox1);
            this.scheduleFlightPanel.Controls.Add(this.welcomeFlightCrewLabel);
            this.scheduleFlightPanel.Controls.Add(this.loginAsFlightCrewBtn);
            this.scheduleFlightPanel.Controls.Add(this.passwordFlightCrewTxt);
            this.scheduleFlightPanel.Controls.Add(this.usernameFlightCrewTxt);
            this.scheduleFlightPanel.Controls.Add(this.passwordFlightCrewLabel);
            this.scheduleFlightPanel.Controls.Add(this.scheduleTitleLabel);
            this.scheduleFlightPanel.Controls.Add(this.usernameFlightCrewLabel);
            this.scheduleFlightPanel.Location = new System.Drawing.Point(4, 89);
            this.scheduleFlightPanel.Margin = new System.Windows.Forms.Padding(4);
            this.scheduleFlightPanel.Name = "scheduleFlightPanel";
            this.scheduleFlightPanel.Size = new System.Drawing.Size(680, 729);
            this.scheduleFlightPanel.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crewMemberRadioBtn);
            this.groupBox1.Controls.Add(this.controllerRadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(142, 436);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 76);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // crewMemberRadioBtn
            // 
            this.crewMemberRadioBtn.AutoSize = true;
            this.crewMemberRadioBtn.Location = new System.Drawing.Point(200, 28);
            this.crewMemberRadioBtn.Name = "crewMemberRadioBtn";
            this.crewMemberRadioBtn.Size = new System.Drawing.Size(214, 35);
            this.crewMemberRadioBtn.TabIndex = 1;
            this.crewMemberRadioBtn.TabStop = true;
            this.crewMemberRadioBtn.Text = "Crew Member";
            this.crewMemberRadioBtn.UseVisualStyleBackColor = true;
            // 
            // controllerRadioBtn
            // 
            this.controllerRadioBtn.AutoSize = true;
            this.controllerRadioBtn.Location = new System.Drawing.Point(6, 28);
            this.controllerRadioBtn.Name = "controllerRadioBtn";
            this.controllerRadioBtn.Size = new System.Drawing.Size(163, 35);
            this.controllerRadioBtn.TabIndex = 0;
            this.controllerRadioBtn.TabStop = true;
            this.controllerRadioBtn.Text = "Controller";
            this.controllerRadioBtn.UseVisualStyleBackColor = true;
            // 
            // welcomeFlightCrewLabel
            // 
            this.welcomeFlightCrewLabel.AutoSize = true;
            this.welcomeFlightCrewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeFlightCrewLabel.Location = new System.Drawing.Point(176, 173);
            this.welcomeFlightCrewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeFlightCrewLabel.Name = "welcomeFlightCrewLabel";
            this.welcomeFlightCrewLabel.Size = new System.Drawing.Size(328, 33);
            this.welcomeFlightCrewLabel.TabIndex = 21;
            this.welcomeFlightCrewLabel.Text = "Welcome to Skyline 360";
            // 
            // loginAsFlightCrewBtn
            // 
            this.loginAsFlightCrewBtn.Location = new System.Drawing.Point(244, 571);
            this.loginAsFlightCrewBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loginAsFlightCrewBtn.Name = "loginAsFlightCrewBtn";
            this.loginAsFlightCrewBtn.Size = new System.Drawing.Size(204, 62);
            this.loginAsFlightCrewBtn.TabIndex = 20;
            this.loginAsFlightCrewBtn.Text = "Login";
            this.loginAsFlightCrewBtn.UseVisualStyleBackColor = true;
            // 
            // passwordFlightCrewTxt
            // 
            this.passwordFlightCrewTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordFlightCrewTxt.Location = new System.Drawing.Point(220, 357);
            this.passwordFlightCrewTxt.Margin = new System.Windows.Forms.Padding(4);
            this.passwordFlightCrewTxt.Name = "passwordFlightCrewTxt";
            this.passwordFlightCrewTxt.PasswordChar = '*';
            this.passwordFlightCrewTxt.Size = new System.Drawing.Size(400, 31);
            this.passwordFlightCrewTxt.TabIndex = 18;
            this.passwordFlightCrewTxt.Leave += new System.EventHandler(this.passwordFlightCrewTxt_Leave);
            this.passwordFlightCrewTxt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.passwordFlightCrewTxt_MouseDown);
            // 
            // usernameFlightCrewTxt
            // 
            this.usernameFlightCrewTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.usernameFlightCrewTxt.Location = new System.Drawing.Point(220, 255);
            this.usernameFlightCrewTxt.Margin = new System.Windows.Forms.Padding(4);
            this.usernameFlightCrewTxt.Name = "usernameFlightCrewTxt";
            this.usernameFlightCrewTxt.Size = new System.Drawing.Size(400, 31);
            this.usernameFlightCrewTxt.TabIndex = 19;
            this.usernameFlightCrewTxt.Leave += new System.EventHandler(this.usernameFlightCrewTxt_Leave);
            this.usernameFlightCrewTxt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.usernameFlightCrewTxt_MouseDown);
            // 
            // passwordFlightCrewLabel
            // 
            this.passwordFlightCrewLabel.AutoSize = true;
            this.passwordFlightCrewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordFlightCrewLabel.Location = new System.Drawing.Point(48, 353);
            this.passwordFlightCrewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordFlightCrewLabel.Name = "passwordFlightCrewLabel";
            this.passwordFlightCrewLabel.Size = new System.Drawing.Size(142, 31);
            this.passwordFlightCrewLabel.TabIndex = 15;
            this.passwordFlightCrewLabel.Text = "Password:";
            // 
            // scheduleTitleLabel
            // 
            this.scheduleTitleLabel.AutoSize = true;
            this.scheduleTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleTitleLabel.Location = new System.Drawing.Point(184, 96);
            this.scheduleTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scheduleTitleLabel.Name = "scheduleTitleLabel";
            this.scheduleTitleLabel.Size = new System.Drawing.Size(320, 51);
            this.scheduleTitleLabel.TabIndex = 16;
            this.scheduleTitleLabel.Text = "Flight Schedule";
            // 
            // usernameFlightCrewLabel
            // 
            this.usernameFlightCrewLabel.AutoSize = true;
            this.usernameFlightCrewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameFlightCrewLabel.Location = new System.Drawing.Point(48, 253);
            this.usernameFlightCrewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameFlightCrewLabel.Name = "usernameFlightCrewLabel";
            this.usernameFlightCrewLabel.Size = new System.Drawing.Size(147, 31);
            this.usernameFlightCrewLabel.TabIndex = 17;
            this.usernameFlightCrewLabel.Text = "Username:";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 817);
            this.Controls.Add(this.bookingBtn);
            this.Controls.Add(this.scheduleBtn);
            this.Controls.Add(this.bookingPanel);
            this.Controls.Add(this.scheduleFlightPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule/Book";
            this.bookingPanel.ResumeLayout(false);
            this.bookingPanel.PerformLayout();
            this.scheduleFlightPanel.ResumeLayout(false);
            this.scheduleFlightPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bookingBtn;
        private System.Windows.Forms.Button scheduleBtn;
        private System.Windows.Forms.Panel bookingPanel;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Label askForRegisterLabel;
        private System.Windows.Forms.Label welcomepassengerLabel;
        private System.Windows.Forms.Button loginAsPassengerBtn;
        private System.Windows.Forms.TextBox passwordPassengerTxt;
        private System.Windows.Forms.TextBox usernamePassengerTxt;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label bookingTitleLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Panel scheduleFlightPanel;
        private System.Windows.Forms.Label welcomeFlightCrewLabel;
        private System.Windows.Forms.Button loginAsFlightCrewBtn;
        private System.Windows.Forms.TextBox passwordFlightCrewTxt;
        private System.Windows.Forms.TextBox usernameFlightCrewTxt;
        private System.Windows.Forms.Label passwordFlightCrewLabel;
        private System.Windows.Forms.Label scheduleTitleLabel;
        private System.Windows.Forms.Label usernameFlightCrewLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton crewMemberRadioBtn;
        private System.Windows.Forms.RadioButton controllerRadioBtn;
    }
}