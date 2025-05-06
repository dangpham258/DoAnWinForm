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
            this.welcomepassengerLabel = new System.Windows.Forms.Label();
            this.bookingTitleLabel = new System.Windows.Forms.Label();
            this.registerLabel = new System.Windows.Forms.Label();
            this.askForRegisterLabel = new System.Windows.Forms.Label();
            this.loginAsPassengerBtn = new System.Windows.Forms.Button();
            this.passwordPassengerTxt = new System.Windows.Forms.TextBox();
            this.usernamePassengerTxt = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.scheduleFlightPanel = new System.Windows.Forms.Panel();
            this.scheduleTitleLabel = new System.Windows.Forms.Label();
            this.welcomeFlightCrewLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crewMemberRadioBtn = new System.Windows.Forms.RadioButton();
            this.controllerRadioBtn = new System.Windows.Forms.RadioButton();
            this.loginAsFlightCrewBtn = new System.Windows.Forms.Button();
            this.passwordFlightCrewTxt = new System.Windows.Forms.TextBox();
            this.usernameFlightCrewTxt = new System.Windows.Forms.TextBox();
            this.passwordFlightCrewLabel = new System.Windows.Forms.Label();
            this.usernameFlightCrewLabel = new System.Windows.Forms.Label();
            this.bookingPanel.SuspendLayout();
            this.scheduleFlightPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookingBtn
            // 
            this.bookingBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingBtn.Location = new System.Drawing.Point(227, -1);
            this.bookingBtn.Name = "bookingBtn";
            this.bookingBtn.Size = new System.Drawing.Size(229, 51);
            this.bookingBtn.TabIndex = 1;
            this.bookingBtn.Text = "Đặt vé";
            this.bookingBtn.UseVisualStyleBackColor = true;
            this.bookingBtn.Click += new System.EventHandler(this.bookingBtn_Click);
            // 
            // scheduleBtn
            // 
            this.scheduleBtn.BackColor = System.Drawing.SystemColors.Control;
            this.scheduleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleBtn.Location = new System.Drawing.Point(0, -1);
            this.scheduleBtn.Name = "scheduleBtn";
            this.scheduleBtn.Size = new System.Drawing.Size(229, 51);
            this.scheduleBtn.TabIndex = 1;
            this.scheduleBtn.Text = "Phi hành đoàn";
            this.scheduleBtn.UseVisualStyleBackColor = false;
            this.scheduleBtn.Click += new System.EventHandler(this.scheduleBtn_Click);
            // 
            // bookingPanel
            // 
            this.bookingPanel.BackColor = System.Drawing.SystemColors.Control;
            this.bookingPanel.Controls.Add(this.welcomepassengerLabel);
            this.bookingPanel.Controls.Add(this.bookingTitleLabel);
            this.bookingPanel.Controls.Add(this.registerLabel);
            this.bookingPanel.Controls.Add(this.askForRegisterLabel);
            this.bookingPanel.Controls.Add(this.loginAsPassengerBtn);
            this.bookingPanel.Controls.Add(this.passwordPassengerTxt);
            this.bookingPanel.Controls.Add(this.usernamePassengerTxt);
            this.bookingPanel.Controls.Add(this.passwordLabel);
            this.bookingPanel.Controls.Add(this.usernameLabel);
            this.bookingPanel.Location = new System.Drawing.Point(0, 54);
            this.bookingPanel.Name = "bookingPanel";
            this.bookingPanel.Size = new System.Drawing.Size(456, 469);
            this.bookingPanel.TabIndex = 18;
            // 
            // welcomepassengerLabel
            // 
            this.welcomepassengerLabel.AutoSize = true;
            this.welcomepassengerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomepassengerLabel.Location = new System.Drawing.Point(79, 53);
            this.welcomepassengerLabel.Name = "welcomepassengerLabel";
            this.welcomepassengerLabel.Size = new System.Drawing.Size(295, 28);
            this.welcomepassengerLabel.TabIndex = 79;
            this.welcomepassengerLabel.Text = "Chào mừng đến với Skyline 360";
            // 
            // bookingTitleLabel
            // 
            this.bookingTitleLabel.AutoSize = true;
            this.bookingTitleLabel.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingTitleLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.bookingTitleLabel.Location = new System.Drawing.Point(123, 12);
            this.bookingTitleLabel.Name = "bookingTitleLabel";
            this.bookingTitleLabel.Size = new System.Drawing.Size(200, 41);
            this.bookingTitleLabel.TabIndex = 78;
            this.bookingTitleLabel.Text = "APP ĐẶT VÉ";
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.registerLabel.Location = new System.Drawing.Point(261, 420);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(79, 25);
            this.registerLabel.TabIndex = 16;
            this.registerLabel.Text = "Đăng ký";
            this.registerLabel.Click += new System.EventHandler(this.registerLabel_Click);
            // 
            // askForRegisterLabel
            // 
            this.askForRegisterLabel.AutoSize = true;
            this.askForRegisterLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.askForRegisterLabel.Location = new System.Drawing.Point(94, 420);
            this.askForRegisterLabel.Name = "askForRegisterLabel";
            this.askForRegisterLabel.Size = new System.Drawing.Size(161, 25);
            this.askForRegisterLabel.TabIndex = 15;
            this.askForRegisterLabel.Text = "Bạn là người mới?";
            // 
            // loginAsPassengerBtn
            // 
            this.loginAsPassengerBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAsPassengerBtn.Location = new System.Drawing.Point(122, 327);
            this.loginAsPassengerBtn.Name = "loginAsPassengerBtn";
            this.loginAsPassengerBtn.Size = new System.Drawing.Size(201, 49);
            this.loginAsPassengerBtn.TabIndex = 13;
            this.loginAsPassengerBtn.Text = "Đăng nhập";
            this.loginAsPassengerBtn.UseVisualStyleBackColor = true;
            this.loginAsPassengerBtn.Click += new System.EventHandler(this.loginAsPassengerBtn_Click);
            // 
            // passwordPassengerTxt
            // 
            this.passwordPassengerTxt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordPassengerTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordPassengerTxt.Location = new System.Drawing.Point(149, 230);
            this.passwordPassengerTxt.Name = "passwordPassengerTxt";
            this.passwordPassengerTxt.PasswordChar = '*';
            this.passwordPassengerTxt.Size = new System.Drawing.Size(268, 31);
            this.passwordPassengerTxt.TabIndex = 11;
            this.passwordPassengerTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passwordPassengerTxt_MouseClick);
            this.passwordPassengerTxt.Enter += new System.EventHandler(this.passwordPassengerTxt_Enter);
            this.passwordPassengerTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordPassengerTxt_KeyPress);
            this.passwordPassengerTxt.Leave += new System.EventHandler(this.passwordPassengerTxt_Leave);
            // 
            // usernamePassengerTxt
            // 
            this.usernamePassengerTxt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamePassengerTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.usernamePassengerTxt.Location = new System.Drawing.Point(149, 165);
            this.usernamePassengerTxt.Name = "usernamePassengerTxt";
            this.usernamePassengerTxt.Size = new System.Drawing.Size(268, 31);
            this.usernamePassengerTxt.TabIndex = 12;
            this.usernamePassengerTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.usernamePassengerTxt_MouseClick);
            this.usernamePassengerTxt.Enter += new System.EventHandler(this.usernamePassengerTxt_Enter);
            this.usernamePassengerTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernamePassengerTxt_KeyPress);
            this.usernamePassengerTxt.Leave += new System.EventHandler(this.usernamePassengerTxt_Leave);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(24, 233);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(98, 25);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Mật khẩu:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(24, 169);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(99, 25);
            this.usernameLabel.TabIndex = 10;
            this.usernameLabel.Text = "Tài khoản:";
            // 
            // scheduleFlightPanel
            // 
            this.scheduleFlightPanel.BackColor = System.Drawing.SystemColors.Control;
            this.scheduleFlightPanel.Controls.Add(this.scheduleTitleLabel);
            this.scheduleFlightPanel.Controls.Add(this.welcomeFlightCrewLabel);
            this.scheduleFlightPanel.Controls.Add(this.groupBox1);
            this.scheduleFlightPanel.Controls.Add(this.loginAsFlightCrewBtn);
            this.scheduleFlightPanel.Controls.Add(this.passwordFlightCrewTxt);
            this.scheduleFlightPanel.Controls.Add(this.usernameFlightCrewTxt);
            this.scheduleFlightPanel.Controls.Add(this.passwordFlightCrewLabel);
            this.scheduleFlightPanel.Controls.Add(this.usernameFlightCrewLabel);
            this.scheduleFlightPanel.Location = new System.Drawing.Point(-1, 54);
            this.scheduleFlightPanel.Name = "scheduleFlightPanel";
            this.scheduleFlightPanel.Size = new System.Drawing.Size(456, 469);
            this.scheduleFlightPanel.TabIndex = 17;
            // 
            // scheduleTitleLabel
            // 
            this.scheduleTitleLabel.AutoSize = true;
            this.scheduleTitleLabel.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleTitleLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.scheduleTitleLabel.Location = new System.Drawing.Point(114, 18);
            this.scheduleTitleLabel.Name = "scheduleTitleLabel";
            this.scheduleTitleLabel.Size = new System.Drawing.Size(209, 41);
            this.scheduleTitleLabel.TabIndex = 78;
            this.scheduleTitleLabel.Text = "ĐĂNG NHẬP";
            // 
            // welcomeFlightCrewLabel
            // 
            this.welcomeFlightCrewLabel.AutoSize = true;
            this.welcomeFlightCrewLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeFlightCrewLabel.Location = new System.Drawing.Point(79, 59);
            this.welcomeFlightCrewLabel.Name = "welcomeFlightCrewLabel";
            this.welcomeFlightCrewLabel.Size = new System.Drawing.Size(295, 28);
            this.welcomeFlightCrewLabel.TabIndex = 23;
            this.welcomeFlightCrewLabel.Text = "Chào mừng đến với Skyline 360";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crewMemberRadioBtn);
            this.groupBox1.Controls.Add(this.controllerRadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 257);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(427, 118);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // crewMemberRadioBtn
            // 
            this.crewMemberRadioBtn.AutoSize = true;
            this.crewMemberRadioBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crewMemberRadioBtn.Location = new System.Drawing.Point(27, 70);
            this.crewMemberRadioBtn.Margin = new System.Windows.Forms.Padding(2);
            this.crewMemberRadioBtn.Name = "crewMemberRadioBtn";
            this.crewMemberRadioBtn.Size = new System.Drawing.Size(270, 32);
            this.crewMemberRadioBtn.TabIndex = 1;
            this.crewMemberRadioBtn.TabStop = true;
            this.crewMemberRadioBtn.Text = "Thành viên phi hành đoàn";
            this.crewMemberRadioBtn.UseVisualStyleBackColor = true;
            // 
            // controllerRadioBtn
            // 
            this.controllerRadioBtn.AutoSize = true;
            this.controllerRadioBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controllerRadioBtn.Location = new System.Drawing.Point(27, 24);
            this.controllerRadioBtn.Margin = new System.Windows.Forms.Padding(2);
            this.controllerRadioBtn.Name = "controllerRadioBtn";
            this.controllerRadioBtn.Size = new System.Drawing.Size(335, 32);
            this.controllerRadioBtn.TabIndex = 0;
            this.controllerRadioBtn.TabStop = true;
            this.controllerRadioBtn.Text = "Chuyên viên quản lý và kiểm soát";
            this.controllerRadioBtn.UseVisualStyleBackColor = true;
            // 
            // loginAsFlightCrewBtn
            // 
            this.loginAsFlightCrewBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAsFlightCrewBtn.Location = new System.Drawing.Point(15, 396);
            this.loginAsFlightCrewBtn.Name = "loginAsFlightCrewBtn";
            this.loginAsFlightCrewBtn.Size = new System.Drawing.Size(430, 59);
            this.loginAsFlightCrewBtn.TabIndex = 20;
            this.loginAsFlightCrewBtn.Text = "Đăng nhập";
            this.loginAsFlightCrewBtn.UseVisualStyleBackColor = true;
            this.loginAsFlightCrewBtn.Click += new System.EventHandler(this.loginAsFlightCrewBtn_Click);
            // 
            // passwordFlightCrewTxt
            // 
            this.passwordFlightCrewTxt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordFlightCrewTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordFlightCrewTxt.Location = new System.Drawing.Point(159, 199);
            this.passwordFlightCrewTxt.Name = "passwordFlightCrewTxt";
            this.passwordFlightCrewTxt.PasswordChar = '*';
            this.passwordFlightCrewTxt.Size = new System.Drawing.Size(268, 31);
            this.passwordFlightCrewTxt.TabIndex = 18;
            this.passwordFlightCrewTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passwordFlightCrewTxt_MouseClick);
            this.passwordFlightCrewTxt.Enter += new System.EventHandler(this.passwordFlightCrewTxt_Enter);
            this.passwordFlightCrewTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordFlightCrewTxt_KeyPress);
            this.passwordFlightCrewTxt.Leave += new System.EventHandler(this.passwordFlightCrewTxt_Leave);
            // 
            // usernameFlightCrewTxt
            // 
            this.usernameFlightCrewTxt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameFlightCrewTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.usernameFlightCrewTxt.Location = new System.Drawing.Point(159, 134);
            this.usernameFlightCrewTxt.Name = "usernameFlightCrewTxt";
            this.usernameFlightCrewTxt.Size = new System.Drawing.Size(268, 31);
            this.usernameFlightCrewTxt.TabIndex = 19;
            this.usernameFlightCrewTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.usernameFlightCrewTxt_MouseClick);
            this.usernameFlightCrewTxt.Enter += new System.EventHandler(this.usernameFlightCrewTxt_Enter);
            this.usernameFlightCrewTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usernameFlightCrewTxt_KeyPress);
            this.usernameFlightCrewTxt.Leave += new System.EventHandler(this.usernameFlightCrewTxt_Leave);
            // 
            // passwordFlightCrewLabel
            // 
            this.passwordFlightCrewLabel.AutoSize = true;
            this.passwordFlightCrewLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordFlightCrewLabel.Location = new System.Drawing.Point(37, 199);
            this.passwordFlightCrewLabel.Name = "passwordFlightCrewLabel";
            this.passwordFlightCrewLabel.Size = new System.Drawing.Size(98, 25);
            this.passwordFlightCrewLabel.TabIndex = 15;
            this.passwordFlightCrewLabel.Text = "Mật khẩu:";
            // 
            // usernameFlightCrewLabel
            // 
            this.usernameFlightCrewLabel.AutoSize = true;
            this.usernameFlightCrewLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameFlightCrewLabel.Location = new System.Drawing.Point(37, 136);
            this.usernameFlightCrewLabel.Name = "usernameFlightCrewLabel";
            this.usernameFlightCrewLabel.Size = new System.Drawing.Size(99, 25);
            this.usernameFlightCrewLabel.TabIndex = 17;
            this.usernameFlightCrewLabel.Text = "Tài khoản:";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 523);
            this.Controls.Add(this.scheduleFlightPanel);
            this.Controls.Add(this.bookingBtn);
            this.Controls.Add(this.scheduleBtn);
            this.Controls.Add(this.bookingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.loginForm_FormClosing);
            this.Load += new System.EventHandler(this.loginForm_Load);
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
        private System.Windows.Forms.Button loginAsPassengerBtn;
        private System.Windows.Forms.TextBox passwordPassengerTxt;
        private System.Windows.Forms.TextBox usernamePassengerTxt;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Panel scheduleFlightPanel;
        private System.Windows.Forms.Button loginAsFlightCrewBtn;
        private System.Windows.Forms.TextBox passwordFlightCrewTxt;
        private System.Windows.Forms.TextBox usernameFlightCrewTxt;
        private System.Windows.Forms.Label passwordFlightCrewLabel;
        private System.Windows.Forms.Label usernameFlightCrewLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton crewMemberRadioBtn;
        private System.Windows.Forms.RadioButton controllerRadioBtn;
        private System.Windows.Forms.Label bookingTitleLabel;
        private System.Windows.Forms.Label welcomepassengerLabel;
        private System.Windows.Forms.Label welcomeFlightCrewLabel;
        private System.Windows.Forms.Label scheduleTitleLabel;
    }
}