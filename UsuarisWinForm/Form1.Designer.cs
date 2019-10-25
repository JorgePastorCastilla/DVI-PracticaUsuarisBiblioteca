namespace UsuarisWinForm
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RegisterUser = new System.Windows.Forms.TabPage();
            this.TownComboBox = new System.Windows.Forms.ComboBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.TownLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DniTextBox = new System.Windows.Forms.TextBox();
            this.DNILabel = new System.Windows.Forms.Label();
            this.FindUser = new System.Windows.Forms.TabPage();
            this.UserListBox = new System.Windows.Forms.ListBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.FindTownComboBox = new System.Windows.Forms.ComboBox();
            this.FindEmailTextBox = new System.Windows.Forms.TextBox();
            this.FindSurnameTextBox = new System.Windows.Forms.TextBox();
            this.FindNameTextBox = new System.Windows.Forms.TextBox();
            this.FindDNITextBox = new System.Windows.Forms.TextBox();
            this.FindEmailLabel = new System.Windows.Forms.Label();
            this.FindDNILabel = new System.Windows.Forms.Label();
            this.FindSurnameLabel = new System.Windows.Forms.Label();
            this.FindTownLabel = new System.Windows.Forms.Label();
            this.FindNameLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.RegisterUser.SuspendLayout();
            this.FindUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.RegisterUser);
            this.tabControl1.Controls.Add(this.FindUser);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 444);
            this.tabControl1.TabIndex = 0;
            // 
            // RegisterUser
            // 
            this.RegisterUser.Controls.Add(this.TownComboBox);
            this.RegisterUser.Controls.Add(this.RegisterButton);
            this.RegisterUser.Controls.Add(this.ConfirmPasswordTextBox);
            this.RegisterUser.Controls.Add(this.ConfirmPasswordLabel);
            this.RegisterUser.Controls.Add(this.PasswordTextBox);
            this.RegisterUser.Controls.Add(this.PasswordLabel);
            this.RegisterUser.Controls.Add(this.EmailTextBox);
            this.RegisterUser.Controls.Add(this.EmailLabel);
            this.RegisterUser.Controls.Add(this.SurnameTextBox);
            this.RegisterUser.Controls.Add(this.TownLabel);
            this.RegisterUser.Controls.Add(this.SurnameLabel);
            this.RegisterUser.Controls.Add(this.NameTextBox);
            this.RegisterUser.Controls.Add(this.NameLabel);
            this.RegisterUser.Controls.Add(this.DniTextBox);
            this.RegisterUser.Controls.Add(this.DNILabel);
            this.RegisterUser.Location = new System.Drawing.Point(4, 22);
            this.RegisterUser.Name = "RegisterUser";
            this.RegisterUser.Padding = new System.Windows.Forms.Padding(3);
            this.RegisterUser.Size = new System.Drawing.Size(576, 418);
            this.RegisterUser.TabIndex = 0;
            this.RegisterUser.Text = "Register User";
            this.RegisterUser.UseVisualStyleBackColor = true;
            this.RegisterUser.Click += new System.EventHandler(this.RegisterUser_Click);
            // 
            // TownComboBox
            // 
            this.TownComboBox.FormattingEnabled = true;
            this.TownComboBox.Items.AddRange(new object[] {
            "Inca",
            "Palma",
            "Manacor"});
            this.TownComboBox.Location = new System.Drawing.Point(71, 127);
            this.TownComboBox.Name = "TownComboBox";
            this.TownComboBox.Size = new System.Drawing.Size(123, 21);
            this.TownComboBox.TabIndex = 4;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(238, 127);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(96, 35);
            this.RegisterButton.TabIndex = 14;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.Registerbutton_Click);
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(333, 91);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(154, 20);
            this.ConfirmPasswordTextBox.TabIndex = 7;
            this.ConfirmPasswordTextBox.UseSystemPasswordChar = true;
            this.ConfirmPasswordTextBox.TextChanged += new System.EventHandler(this.ConfirmPasswordTextBox_TextChanged);
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(235, 94);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(91, 13);
            this.ConfirmPasswordLabel.TabIndex = 12;
            this.ConfirmPasswordLabel.Text = "Confirm Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(333, 55);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(154, 20);
            this.PasswordTextBox.TabIndex = 6;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(235, 58);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Password";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(333, 25);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(154, 20);
            this.EmailTextBox.TabIndex = 5;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(235, 28);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 8;
            this.EmailLabel.Text = "Email";
            this.EmailLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(70, 91);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(124, 20);
            this.SurnameTextBox.TabIndex = 3;
            // 
            // TownLabel
            // 
            this.TownLabel.AutoSize = true;
            this.TownLabel.Location = new System.Drawing.Point(15, 130);
            this.TownLabel.Name = "TownLabel";
            this.TownLabel.Size = new System.Drawing.Size(34, 13);
            this.TownLabel.TabIndex = 6;
            this.TownLabel.Text = "Town";
            this.TownLabel.Click += new System.EventHandler(this.Town_Click);
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(15, 94);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(49, 13);
            this.SurnameLabel.TabIndex = 4;
            this.SurnameLabel.Text = "Surname";
            this.SurnameLabel.Click += new System.EventHandler(this.Surname_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(71, 55);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(123, 20);
            this.NameTextBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(15, 58);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            this.NameLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // DniTextBox
            // 
            this.DniTextBox.Location = new System.Drawing.Point(71, 25);
            this.DniTextBox.Name = "DniTextBox";
            this.DniTextBox.Size = new System.Drawing.Size(123, 20);
            this.DniTextBox.TabIndex = 1;
            this.DniTextBox.Text = "12345678V";
            // 
            // DNILabel
            // 
            this.DNILabel.AutoSize = true;
            this.DNILabel.Location = new System.Drawing.Point(15, 28);
            this.DNILabel.Name = "DNILabel";
            this.DNILabel.Size = new System.Drawing.Size(26, 13);
            this.DNILabel.TabIndex = 0;
            this.DNILabel.Text = "DNI";
            this.DNILabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // FindUser
            // 
            this.FindUser.Controls.Add(this.UserListBox);
            this.FindUser.Controls.Add(this.FindButton);
            this.FindUser.Controls.Add(this.FindTownComboBox);
            this.FindUser.Controls.Add(this.FindEmailTextBox);
            this.FindUser.Controls.Add(this.FindSurnameTextBox);
            this.FindUser.Controls.Add(this.FindNameTextBox);
            this.FindUser.Controls.Add(this.FindDNITextBox);
            this.FindUser.Controls.Add(this.FindEmailLabel);
            this.FindUser.Controls.Add(this.FindDNILabel);
            this.FindUser.Controls.Add(this.FindSurnameLabel);
            this.FindUser.Controls.Add(this.FindTownLabel);
            this.FindUser.Controls.Add(this.FindNameLabel);
            this.FindUser.Location = new System.Drawing.Point(4, 22);
            this.FindUser.Name = "FindUser";
            this.FindUser.Padding = new System.Windows.Forms.Padding(3);
            this.FindUser.Size = new System.Drawing.Size(576, 418);
            this.FindUser.TabIndex = 1;
            this.FindUser.Text = "Find User";
            this.FindUser.UseVisualStyleBackColor = true;
            // 
            // UserListBox
            // 
            this.UserListBox.FormattingEnabled = true;
            this.UserListBox.Location = new System.Drawing.Point(32, 138);
            this.UserListBox.Name = "UserListBox";
            this.UserListBox.Size = new System.Drawing.Size(390, 134);
            this.UserListBox.TabIndex = 1;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(248, 96);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(174, 30);
            this.FindButton.TabIndex = 10;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // FindTownComboBox
            // 
            this.FindTownComboBox.FormattingEnabled = true;
            this.FindTownComboBox.Items.AddRange(new object[] {
            "Inca",
            "Palma",
            "Manacor"});
            this.FindTownComboBox.Location = new System.Drawing.Point(284, 25);
            this.FindTownComboBox.Name = "FindTownComboBox";
            this.FindTownComboBox.Size = new System.Drawing.Size(138, 21);
            this.FindTownComboBox.TabIndex = 9;
            // 
            // FindEmailTextBox
            // 
            this.FindEmailTextBox.Location = new System.Drawing.Point(284, 63);
            this.FindEmailTextBox.Name = "FindEmailTextBox";
            this.FindEmailTextBox.Size = new System.Drawing.Size(139, 20);
            this.FindEmailTextBox.TabIndex = 8;
            // 
            // FindSurnameTextBox
            // 
            this.FindSurnameTextBox.Location = new System.Drawing.Point(81, 102);
            this.FindSurnameTextBox.Name = "FindSurnameTextBox";
            this.FindSurnameTextBox.Size = new System.Drawing.Size(139, 20);
            this.FindSurnameTextBox.TabIndex = 7;
            this.FindSurnameTextBox.TextChanged += new System.EventHandler(this.FindSurnameTextBox_TextChanged);
            // 
            // FindNameTextBox
            // 
            this.FindNameTextBox.Location = new System.Drawing.Point(81, 63);
            this.FindNameTextBox.Name = "FindNameTextBox";
            this.FindNameTextBox.Size = new System.Drawing.Size(139, 20);
            this.FindNameTextBox.TabIndex = 6;
            // 
            // FindDNITextBox
            // 
            this.FindDNITextBox.Location = new System.Drawing.Point(81, 25);
            this.FindDNITextBox.Name = "FindDNITextBox";
            this.FindDNITextBox.Size = new System.Drawing.Size(139, 20);
            this.FindDNITextBox.TabIndex = 5;
            // 
            // FindEmailLabel
            // 
            this.FindEmailLabel.AutoSize = true;
            this.FindEmailLabel.Location = new System.Drawing.Point(245, 66);
            this.FindEmailLabel.Name = "FindEmailLabel";
            this.FindEmailLabel.Size = new System.Drawing.Size(32, 13);
            this.FindEmailLabel.TabIndex = 4;
            this.FindEmailLabel.Text = "Email";
            // 
            // FindDNILabel
            // 
            this.FindDNILabel.AutoSize = true;
            this.FindDNILabel.Location = new System.Drawing.Point(26, 28);
            this.FindDNILabel.Name = "FindDNILabel";
            this.FindDNILabel.Size = new System.Drawing.Size(26, 13);
            this.FindDNILabel.TabIndex = 3;
            this.FindDNILabel.Text = "DNI";
            // 
            // FindSurnameLabel
            // 
            this.FindSurnameLabel.AutoSize = true;
            this.FindSurnameLabel.Location = new System.Drawing.Point(26, 105);
            this.FindSurnameLabel.Name = "FindSurnameLabel";
            this.FindSurnameLabel.Size = new System.Drawing.Size(49, 13);
            this.FindSurnameLabel.TabIndex = 2;
            this.FindSurnameLabel.Text = "Surname";
            this.FindSurnameLabel.Click += new System.EventHandler(this.FindSurnameLabel_Click);
            // 
            // FindTownLabel
            // 
            this.FindTownLabel.AutoSize = true;
            this.FindTownLabel.Location = new System.Drawing.Point(243, 28);
            this.FindTownLabel.Name = "FindTownLabel";
            this.FindTownLabel.Size = new System.Drawing.Size(34, 13);
            this.FindTownLabel.TabIndex = 1;
            this.FindTownLabel.Text = "Town";
            this.FindTownLabel.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // FindNameLabel
            // 
            this.FindNameLabel.AutoSize = true;
            this.FindNameLabel.Location = new System.Drawing.Point(26, 66);
            this.FindNameLabel.Name = "FindNameLabel";
            this.FindNameLabel.Size = new System.Drawing.Size(35, 13);
            this.FindNameLabel.TabIndex = 0;
            this.FindNameLabel.Text = "Name";
            this.FindNameLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // Form1
            // 
            this.AcceptButton = this.RegisterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 331);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.RegisterUser.ResumeLayout(false);
            this.RegisterUser.PerformLayout();
            this.FindUser.ResumeLayout(false);
            this.FindUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage RegisterUser;
        private System.Windows.Forms.Label DNILabel;
        private System.Windows.Forms.TabPage FindUser;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label TownLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox DniTextBox;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.ComboBox TownComboBox;
        private System.Windows.Forms.Label FindNameLabel;
        private System.Windows.Forms.Label FindTownLabel;
        private System.Windows.Forms.Label FindSurnameLabel;
        private System.Windows.Forms.Label FindDNILabel;
        private System.Windows.Forms.ComboBox FindTownComboBox;
        private System.Windows.Forms.TextBox FindEmailTextBox;
        private System.Windows.Forms.TextBox FindSurnameTextBox;
        private System.Windows.Forms.TextBox FindNameTextBox;
        private System.Windows.Forms.TextBox FindDNITextBox;
        private System.Windows.Forms.Label FindEmailLabel;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.ListBox UserListBox;
    }
}

