namespace Projekt_Bank
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
            this.components = new System.ComponentModel.Container();
            this.labelRegister = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelRegister = new System.Windows.Forms.Panel();
            this.pictureBoxRegister = new System.Windows.Forms.PictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.panelRegisterMain = new System.Windows.Forms.Panel();
            this.panelStartAmount = new System.Windows.Forms.Panel();
            this.panelPIN = new System.Windows.Forms.Panel();
            this.panelID = new System.Windows.Forms.Panel();
            this.panelLastName = new System.Windows.Forms.Panel();
            this.panelFirstName = new System.Windows.Forms.Panel();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.idInput = new System.Windows.Forms.TextBox();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pinInput = new System.Windows.Forms.TextBox();
            this.startamountInput = new System.Windows.Forms.TextBox();
            this.lastnameInput = new System.Windows.Forms.TextBox();
            this.firstnameInput = new System.Windows.Forms.TextBox();
            this.labelStartAmount = new System.Windows.Forms.Label();
            this.labelPIN = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.panelRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegister)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.panelRegisterMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRegister
            // 
            this.labelRegister.Font = new System.Drawing.Font("Book Antiqua", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRegister.Location = new System.Drawing.Point(5, 13);
            this.labelRegister.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(252, 41);
            this.labelRegister.TabIndex = 24;
            this.labelRegister.Text = "Register panel";
            this.labelRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(575, 32);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(39, 17);
            this.timeLabel.TabIndex = 36;
            this.timeLabel.Text = "Time";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(655, 32);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 17);
            this.dateLabel.TabIndex = 35;
            this.dateLabel.Text = "Date";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timerTick);
            // 
            // panelRegister
            // 
            this.panelRegister.BackColor = System.Drawing.Color.White;
            this.panelRegister.Controls.Add(this.pictureBoxRegister);
            this.panelRegister.Controls.Add(this.labelRegister);
            this.panelRegister.Controls.Add(this.timeLabel);
            this.panelRegister.Controls.Add(this.dateLabel);
            this.panelRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRegister.Location = new System.Drawing.Point(0, 0);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(760, 69);
            this.panelRegister.TabIndex = 43;
            // 
            // pictureBoxRegister
            // 
            this.pictureBoxRegister.Image = global::Projekt_Bank.Properties.Resources.register;
            this.pictureBoxRegister.Location = new System.Drawing.Point(251, 12);
            this.pictureBoxRegister.Name = "pictureBoxRegister";
            this.pictureBoxRegister.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxRegister.TabIndex = 37;
            this.pictureBoxRegister.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.backButton);
            this.panelDesktop.Controls.Add(this.panelRegisterMain);
            this.panelDesktop.Controls.Add(this.registerButton);
            this.panelDesktop.Controls.Add(this.exitButton);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 69);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(760, 737);
            this.panelDesktop.TabIndex = 44;
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backButton.Image = global::Projekt_Bank.Properties.Resources.back;
            this.backButton.Location = new System.Drawing.Point(253, 660);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(112, 56);
            this.backButton.TabIndex = 63;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButtonClick);
            // 
            // panelRegisterMain
            // 
            this.panelRegisterMain.BackColor = System.Drawing.Color.White;
            this.panelRegisterMain.Controls.Add(this.panelStartAmount);
            this.panelRegisterMain.Controls.Add(this.panelPIN);
            this.panelRegisterMain.Controls.Add(this.panelID);
            this.panelRegisterMain.Controls.Add(this.panelLastName);
            this.panelRegisterMain.Controls.Add(this.panelFirstName);
            this.panelRegisterMain.Controls.Add(this.comboGender);
            this.panelRegisterMain.Controls.Add(this.labelGender);
            this.panelRegisterMain.Controls.Add(this.labelID);
            this.panelRegisterMain.Controls.Add(this.idInput);
            this.panelRegisterMain.Controls.Add(this.labelBirthday);
            this.panelRegisterMain.Controls.Add(this.dateTimePicker);
            this.panelRegisterMain.Controls.Add(this.pinInput);
            this.panelRegisterMain.Controls.Add(this.startamountInput);
            this.panelRegisterMain.Controls.Add(this.lastnameInput);
            this.panelRegisterMain.Controls.Add(this.firstnameInput);
            this.panelRegisterMain.Controls.Add(this.labelStartAmount);
            this.panelRegisterMain.Controls.Add(this.labelPIN);
            this.panelRegisterMain.Controls.Add(this.labelFirstName);
            this.panelRegisterMain.Controls.Add(this.labelLastName);
            this.panelRegisterMain.Location = new System.Drawing.Point(70, 37);
            this.panelRegisterMain.Name = "panelRegisterMain";
            this.panelRegisterMain.Size = new System.Drawing.Size(620, 526);
            this.panelRegisterMain.TabIndex = 60;
            // 
            // panelStartAmount
            // 
            this.panelStartAmount.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelStartAmount.Location = new System.Drawing.Point(181, 493);
            this.panelStartAmount.Name = "panelStartAmount";
            this.panelStartAmount.Size = new System.Drawing.Size(262, 1);
            this.panelStartAmount.TabIndex = 66;
            // 
            // panelPIN
            // 
            this.panelPIN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelPIN.Location = new System.Drawing.Point(182, 425);
            this.panelPIN.Name = "panelPIN";
            this.panelPIN.Size = new System.Drawing.Size(262, 1);
            this.panelPIN.TabIndex = 65;
            // 
            // panelID
            // 
            this.panelID.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelID.Location = new System.Drawing.Point(181, 355);
            this.panelID.Name = "panelID";
            this.panelID.Size = new System.Drawing.Size(262, 1);
            this.panelID.TabIndex = 64;
            // 
            // panelLastName
            // 
            this.panelLastName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelLastName.Location = new System.Drawing.Point(182, 147);
            this.panelLastName.Name = "panelLastName";
            this.panelLastName.Size = new System.Drawing.Size(262, 1);
            this.panelLastName.TabIndex = 64;
            // 
            // panelFirstName
            // 
            this.panelFirstName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelFirstName.Location = new System.Drawing.Point(181, 77);
            this.panelFirstName.Name = "panelFirstName";
            this.panelFirstName.Size = new System.Drawing.Size(262, 1);
            this.panelFirstName.TabIndex = 59;
            // 
            // comboGender
            // 
            this.comboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboGender.Location = new System.Drawing.Point(184, 260);
            this.comboGender.Margin = new System.Windows.Forms.Padding(4);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(252, 28);
            this.comboGender.TabIndex = 50;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGender.Location = new System.Drawing.Point(272, 230);
            this.labelGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(77, 24);
            this.labelGender.TabIndex = 58;
            this.labelGender.Text = "Gender";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelID.Location = new System.Drawing.Point(292, 300);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(32, 24);
            this.labelID.TabIndex = 57;
            this.labelID.Text = "ID";
            // 
            // idInput
            // 
            this.idInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idInput.Location = new System.Drawing.Point(181, 330);
            this.idInput.Margin = new System.Windows.Forms.Padding(4);
            this.idInput.Multiline = true;
            this.idInput.Name = "idInput";
            this.idInput.Size = new System.Drawing.Size(262, 24);
            this.idInput.TabIndex = 51;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBirthday.Location = new System.Drawing.Point(257, 160);
            this.labelBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(132, 24);
            this.labelBirthday.TabIndex = 56;
            this.labelBirthday.Text = "Birthday date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(184, 190);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(252, 27);
            this.dateTimePicker.TabIndex = 49;
            // 
            // pinInput
            // 
            this.pinInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pinInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pinInput.Location = new System.Drawing.Point(182, 400);
            this.pinInput.Margin = new System.Windows.Forms.Padding(4);
            this.pinInput.Multiline = true;
            this.pinInput.Name = "pinInput";
            this.pinInput.Size = new System.Drawing.Size(262, 24);
            this.pinInput.TabIndex = 52;
            // 
            // startamountInput
            // 
            this.startamountInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startamountInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startamountInput.Location = new System.Drawing.Point(181, 470);
            this.startamountInput.Margin = new System.Windows.Forms.Padding(4);
            this.startamountInput.Multiline = true;
            this.startamountInput.Name = "startamountInput";
            this.startamountInput.Size = new System.Drawing.Size(262, 24);
            this.startamountInput.TabIndex = 53;
            // 
            // lastnameInput
            // 
            this.lastnameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastnameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastnameInput.Location = new System.Drawing.Point(182, 120);
            this.lastnameInput.Margin = new System.Windows.Forms.Padding(4);
            this.lastnameInput.Multiline = true;
            this.lastnameInput.Name = "lastnameInput";
            this.lastnameInput.Size = new System.Drawing.Size(259, 24);
            this.lastnameInput.TabIndex = 48;
            // 
            // firstnameInput
            // 
            this.firstnameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstnameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstnameInput.Location = new System.Drawing.Point(182, 50);
            this.firstnameInput.Margin = new System.Windows.Forms.Padding(4);
            this.firstnameInput.Multiline = true;
            this.firstnameInput.Name = "firstnameInput";
            this.firstnameInput.Size = new System.Drawing.Size(261, 24);
            this.firstnameInput.TabIndex = 47;
            // 
            // labelStartAmount
            // 
            this.labelStartAmount.AutoSize = true;
            this.labelStartAmount.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStartAmount.Location = new System.Drawing.Point(257, 440);
            this.labelStartAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStartAmount.Name = "labelStartAmount";
            this.labelStartAmount.Size = new System.Drawing.Size(134, 24);
            this.labelStartAmount.TabIndex = 46;
            this.labelStartAmount.Text = "Start Amount";
            // 
            // labelPIN
            // 
            this.labelPIN.AutoSize = true;
            this.labelPIN.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPIN.Location = new System.Drawing.Point(287, 370);
            this.labelPIN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPIN.Name = "labelPIN";
            this.labelPIN.Size = new System.Drawing.Size(46, 24);
            this.labelPIN.TabIndex = 45;
            this.labelPIN.Text = "PIN";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirstName.Location = new System.Drawing.Point(268, 20);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(110, 24);
            this.labelFirstName.TabIndex = 44;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLastName.Location = new System.Drawing.Point(267, 90);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(107, 24);
            this.labelLastName.TabIndex = 43;
            this.labelLastName.Text = "Last Name";
            // 
            // registerButton
            // 
            this.registerButton.AutoSize = true;
            this.registerButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerButton.Image = global::Projekt_Bank.Properties.Resources.signin;
            this.registerButton.Location = new System.Drawing.Point(253, 582);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(253, 56);
            this.registerButton.TabIndex = 61;
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerClick);
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitButton.Image = global::Projekt_Bank.Properties.Resources.exit;
            this.exitButton.Location = new System.Drawing.Point(394, 660);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 56);
            this.exitButton.TabIndex = 62;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitClick);
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(760, 806);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(778, 853);
            this.MinimumSize = new System.Drawing.Size(778, 853);
            this.Name = "registerForm";
            this.ShowIcon = false;
            this.Text = "Register panel";
            this.Load += new System.EventHandler(this.registerForm_Load);
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegister)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.panelRegisterMain.ResumeLayout(false);
            this.panelRegisterMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel panelRegisterMain;
        private System.Windows.Forms.Panel panelPIN;
        private System.Windows.Forms.Panel panelID;
        private System.Windows.Forms.Panel panelLastName;
        private System.Windows.Forms.Panel panelFirstName;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox idInput;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox pinInput;
        private System.Windows.Forms.TextBox startamountInput;
        private System.Windows.Forms.TextBox lastnameInput;
        private System.Windows.Forms.TextBox firstnameInput;
        private System.Windows.Forms.Label labelStartAmount;
        private System.Windows.Forms.Label labelPIN;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panelStartAmount;
        private System.Windows.Forms.PictureBox pictureBoxRegister;
    }
}