namespace Projekt_Bank
{
    partial class loginForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.labelLoginPanel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.panelMainLogin = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.labelID = new System.Windows.Forms.Label();
            this.panelLoginPIN = new System.Windows.Forms.Panel();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.panelLoginID = new System.Windows.Forms.Panel();
            this.pinTextBox = new System.Windows.Forms.TextBox();
            this.labelPIN = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.panelMainLogin.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLoginPanel
            // 
            this.labelLoginPanel.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoginPanel.Location = new System.Drawing.Point(5, 13);
            this.labelLoginPanel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelLoginPanel.Name = "labelLoginPanel";
            this.labelLoginPanel.Size = new System.Drawing.Size(233, 41);
            this.labelLoginPanel.TabIndex = 23;
            this.labelLoginPanel.Text = "Login panel";
            this.labelLoginPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateLabel.Location = new System.Drawing.Point(478, 27);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(46, 22);
            this.dateLabel.TabIndex = 26;
            this.dateLabel.Text = "Date";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timerTick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLabel.Location = new System.Drawing.Point(398, 27);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(48, 22);
            this.timeLabel.TabIndex = 27;
            this.timeLabel.Text = "Time";
            // 
            // panelMainLogin
            // 
            this.panelMainLogin.BackColor = System.Drawing.Color.White;
            this.panelMainLogin.Controls.Add(this.pictureBoxLogin);
            this.panelMainLogin.Controls.Add(this.labelLoginPanel);
            this.panelMainLogin.Controls.Add(this.dateLabel);
            this.panelMainLogin.Controls.Add(this.timeLabel);
            this.panelMainLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainLogin.Location = new System.Drawing.Point(0, 0);
            this.panelMainLogin.Name = "panelMainLogin";
            this.panelMainLogin.Size = new System.Drawing.Size(588, 65);
            this.panelMainLogin.TabIndex = 28;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.panelLogin);
            this.panelDesktop.Controls.Add(this.buttonRegister);
            this.panelDesktop.Controls.Add(this.buttonExit);
            this.panelDesktop.Controls.Add(this.buttonLogin);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 65);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(588, 494);
            this.panelDesktop.TabIndex = 29;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.Controls.Add(this.labelID);
            this.panelLogin.Controls.Add(this.panelLoginPIN);
            this.panelLogin.Controls.Add(this.idTextBox);
            this.panelLogin.Controls.Add(this.panelLoginID);
            this.panelLogin.Controls.Add(this.pinTextBox);
            this.panelLogin.Controls.Add(this.labelPIN);
            this.panelLogin.Location = new System.Drawing.Point(80, 33);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(428, 184);
            this.panelLogin.TabIndex = 35;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelID.Location = new System.Drawing.Point(203, 17);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(32, 24);
            this.labelID.TabIndex = 8;
            this.labelID.Text = "ID";
            // 
            // panelLoginPIN
            // 
            this.panelLoginPIN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelLoginPIN.Location = new System.Drawing.Point(66, 146);
            this.panelLoginPIN.Name = "panelLoginPIN";
            this.panelLoginPIN.Size = new System.Drawing.Size(300, 1);
            this.panelLoginPIN.TabIndex = 30;
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.Color.White;
            this.idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTextBox.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idTextBox.Location = new System.Drawing.Point(66, 48);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(300, 22);
            this.idTextBox.TabIndex = 6;
            // 
            // panelLoginID
            // 
            this.panelLoginID.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelLoginID.Location = new System.Drawing.Point(66, 71);
            this.panelLoginID.Name = "panelLoginID";
            this.panelLoginID.Size = new System.Drawing.Size(300, 1);
            this.panelLoginID.TabIndex = 29;
            // 
            // pinTextBox
            // 
            this.pinTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pinTextBox.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pinTextBox.Location = new System.Drawing.Point(66, 123);
            this.pinTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.pinTextBox.Name = "pinTextBox";
            this.pinTextBox.Size = new System.Drawing.Size(300, 22);
            this.pinTextBox.TabIndex = 7;
            // 
            // labelPIN
            // 
            this.labelPIN.AutoSize = true;
            this.labelPIN.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPIN.Location = new System.Drawing.Point(199, 89);
            this.labelPIN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPIN.Name = "labelPIN";
            this.labelPIN.Size = new System.Drawing.Size(46, 24);
            this.labelPIN.TabIndex = 9;
            this.labelPIN.Text = "PIN";
            // 
            // buttonRegister
            // 
            this.buttonRegister.AutoSize = true;
            this.buttonRegister.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRegister.Image = ((System.Drawing.Image)(resources.GetObject("buttonRegister.Image")));
            this.buttonRegister.Location = new System.Drawing.Point(190, 333);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(226, 46);
            this.buttonRegister.TabIndex = 33;
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.registerClick);
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSize = true;
            this.buttonExit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.Image = global::Projekt_Bank.Properties.Resources.exitlogin;
            this.buttonExit.Location = new System.Drawing.Point(190, 404);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(226, 46);
            this.buttonExit.TabIndex = 34;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.exitClick);
            // 
            // buttonLogin
            // 
            this.buttonLogin.AutoSize = true;
            this.buttonLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogin.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogin.Image")));
            this.buttonLogin.Location = new System.Drawing.Point(190, 264);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(226, 46);
            this.buttonLogin.TabIndex = 32;
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.loginButtonClick);
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.Image = global::Projekt_Bank.Properties.Resources.login;
            this.pictureBoxLogin.Location = new System.Drawing.Point(218, 9);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLogin.TabIndex = 28;
            this.pictureBoxLogin.TabStop = false;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 559);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMainLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(606, 606);
            this.MinimumSize = new System.Drawing.Size(606, 606);
            this.Name = "loginForm";
            this.ShowIcon = false;
            this.Text = "Login panel";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.panelMainLogin.ResumeLayout(false);
            this.panelMainLogin.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelLoginPanel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Panel panelMainLogin;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Panel panelLoginPIN;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Panel panelLoginID;
        private System.Windows.Forms.TextBox pinTextBox;
        private System.Windows.Forms.Label labelPIN;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
    }
}

