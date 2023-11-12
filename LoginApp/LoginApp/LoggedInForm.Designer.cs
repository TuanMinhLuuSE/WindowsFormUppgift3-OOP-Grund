namespace LoginApp
{
    partial class LoggedInForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.transferButton = new System.Windows.Forms.Button();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.changePasswordPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.displayLabel4_changePasswordPanel = new System.Windows.Forms.Label();
            this.displayLabel3_changePasswordPanel = new System.Windows.Forms.Label();
            this.displayLabel2_changePasswordPanel = new System.Windows.Forms.Label();
            this.displayLabel1_changePasswordPanel = new System.Windows.Forms.Label();
            this.changePasswordPanelButton = new System.Windows.Forms.Button();
            this.newPassword2 = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.oldPassword = new System.Windows.Forms.TextBox();
            this.bankaccountPicker = new System.Windows.Forms.ComboBox();
            this.withdrawPanel = new System.Windows.Forms.Panel();
            this.openBankaccountButton = new System.Windows.Forms.Button();
            this.openAccountPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.displayLabel3OpenAccountPanel = new System.Windows.Forms.Label();
            this.displayLabel2OpenAccountPanel = new System.Windows.Forms.Label();
            this.displayLabel1OpenAccountPanel = new System.Windows.Forms.Label();
            this.openAccountPanelButton = new System.Windows.Forms.Button();
            this.agreeTnCOpenAccount = new System.Windows.Forms.CheckBox();
            this.openAccountDepositInput = new System.Windows.Forms.TextBox();
            this.chooseBankaccountTypeBox = new System.Windows.Forms.ComboBox();
            this.bankaccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.changePasswordPanel.SuspendLayout();
            this.withdrawPanel.SuspendLayout();
            this.openAccountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankaccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(687, 24);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 1;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(46, 98);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(135, 23);
            this.withdrawButton.TabIndex = 2;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(46, 144);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(135, 23);
            this.depositButton.TabIndex = 3;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // transferButton
            // 
            this.transferButton.Location = new System.Drawing.Point(46, 191);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(135, 23);
            this.transferButton.TabIndex = 4;
            this.transferButton.Text = "Transfer";
            this.transferButton.UseVisualStyleBackColor = true;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(46, 294);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(135, 23);
            this.changePasswordButton.TabIndex = 5;
            this.changePasswordButton.Text = "Change password";
            this.changePasswordButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // changePasswordPanel
            // 
            this.changePasswordPanel.Controls.Add(this.label2);
            this.changePasswordPanel.Controls.Add(this.displayLabel4_changePasswordPanel);
            this.changePasswordPanel.Controls.Add(this.displayLabel3_changePasswordPanel);
            this.changePasswordPanel.Controls.Add(this.displayLabel2_changePasswordPanel);
            this.changePasswordPanel.Controls.Add(this.displayLabel1_changePasswordPanel);
            this.changePasswordPanel.Controls.Add(this.changePasswordPanelButton);
            this.changePasswordPanel.Controls.Add(this.newPassword2);
            this.changePasswordPanel.Controls.Add(this.newPassword);
            this.changePasswordPanel.Controls.Add(this.oldPassword);
            this.changePasswordPanel.Location = new System.Drawing.Point(780, 0);
            this.changePasswordPanel.Name = "changePasswordPanel";
            this.changePasswordPanel.Size = new System.Drawing.Size(357, 450);
            this.changePasswordPanel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 8;
            // 
            // displayLabel4_changePasswordPanel
            // 
            this.displayLabel4_changePasswordPanel.AutoSize = true;
            this.displayLabel4_changePasswordPanel.Location = new System.Drawing.Point(19, 252);
            this.displayLabel4_changePasswordPanel.Name = "displayLabel4_changePasswordPanel";
            this.displayLabel4_changePasswordPanel.Size = new System.Drawing.Size(104, 15);
            this.displayLabel4_changePasswordPanel.TabIndex = 7;
            this.displayLabel4_changePasswordPanel.Text = "Confirm password";
            // 
            // displayLabel3_changePasswordPanel
            // 
            this.displayLabel3_changePasswordPanel.AutoSize = true;
            this.displayLabel3_changePasswordPanel.Location = new System.Drawing.Point(35, 205);
            this.displayLabel3_changePasswordPanel.Name = "displayLabel3_changePasswordPanel";
            this.displayLabel3_changePasswordPanel.Size = new System.Drawing.Size(84, 15);
            this.displayLabel3_changePasswordPanel.TabIndex = 6;
            this.displayLabel3_changePasswordPanel.Text = "New password";
            // 
            // displayLabel2_changePasswordPanel
            // 
            this.displayLabel2_changePasswordPanel.AutoSize = true;
            this.displayLabel2_changePasswordPanel.Location = new System.Drawing.Point(19, 159);
            this.displayLabel2_changePasswordPanel.Name = "displayLabel2_changePasswordPanel";
            this.displayLabel2_changePasswordPanel.Size = new System.Drawing.Size(100, 15);
            this.displayLabel2_changePasswordPanel.TabIndex = 5;
            this.displayLabel2_changePasswordPanel.Text = "Current password";
            // 
            // displayLabel1_changePasswordPanel
            // 
            this.displayLabel1_changePasswordPanel.AutoSize = true;
            this.displayLabel1_changePasswordPanel.Location = new System.Drawing.Point(45, 76);
            this.displayLabel1_changePasswordPanel.Name = "displayLabel1_changePasswordPanel";
            this.displayLabel1_changePasswordPanel.Size = new System.Drawing.Size(287, 15);
            this.displayLabel1_changePasswordPanel.TabIndex = 4;
            this.displayLabel1_changePasswordPanel.Text = "Enter your password details to change your password";
            // 
            // changePasswordPanelButton
            // 
            this.changePasswordPanelButton.Location = new System.Drawing.Point(118, 304);
            this.changePasswordPanelButton.Name = "changePasswordPanelButton";
            this.changePasswordPanelButton.Size = new System.Drawing.Size(120, 23);
            this.changePasswordPanelButton.TabIndex = 3;
            this.changePasswordPanelButton.Text = "Change password";
            this.changePasswordPanelButton.UseVisualStyleBackColor = true;
            this.changePasswordPanelButton.Click += new System.EventHandler(this.changePasswordPanelButton_Click);
            // 
            // newPassword2
            // 
            this.newPassword2.Location = new System.Drawing.Point(129, 249);
            this.newPassword2.Name = "newPassword2";
            this.newPassword2.PasswordChar = '*';
            this.newPassword2.Size = new System.Drawing.Size(100, 23);
            this.newPassword2.TabIndex = 2;
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(129, 202);
            this.newPassword.Name = "newPassword";
            this.newPassword.PasswordChar = '*';
            this.newPassword.Size = new System.Drawing.Size(100, 23);
            this.newPassword.TabIndex = 1;
            // 
            // oldPassword
            // 
            this.oldPassword.Location = new System.Drawing.Point(129, 156);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.PasswordChar = '*';
            this.oldPassword.Size = new System.Drawing.Size(100, 23);
            this.oldPassword.TabIndex = 0;
            // 
            // bankaccountPicker
            // 
            this.bankaccountPicker.FormattingEnabled = true;
            this.bankaccountPicker.Location = new System.Drawing.Point(117, 192);
            this.bankaccountPicker.Name = "bankaccountPicker";
            this.bankaccountPicker.Size = new System.Drawing.Size(121, 23);
            this.bankaccountPicker.TabIndex = 7;
            // 
            // withdrawPanel
            // 
            this.withdrawPanel.Controls.Add(this.bankaccountPicker);
            this.withdrawPanel.Location = new System.Drawing.Point(248, 0);
            this.withdrawPanel.Name = "withdrawPanel";
            this.withdrawPanel.Size = new System.Drawing.Size(357, 450);
            this.withdrawPanel.TabIndex = 8;
            // 
            // openBankaccountButton
            // 
            this.openBankaccountButton.Location = new System.Drawing.Point(46, 244);
            this.openBankaccountButton.Name = "openBankaccountButton";
            this.openBankaccountButton.Size = new System.Drawing.Size(135, 23);
            this.openBankaccountButton.TabIndex = 9;
            this.openBankaccountButton.Text = "Open a bankaccount";
            this.openBankaccountButton.UseVisualStyleBackColor = true;
            this.openBankaccountButton.Click += new System.EventHandler(this.openBankaccountButton_Click);
            // 
            // openAccountPanel
            // 
            this.openAccountPanel.Controls.Add(this.label3);
            this.openAccountPanel.Controls.Add(this.displayLabel3OpenAccountPanel);
            this.openAccountPanel.Controls.Add(this.displayLabel2OpenAccountPanel);
            this.openAccountPanel.Controls.Add(this.displayLabel1OpenAccountPanel);
            this.openAccountPanel.Controls.Add(this.openAccountPanelButton);
            this.openAccountPanel.Controls.Add(this.agreeTnCOpenAccount);
            this.openAccountPanel.Controls.Add(this.openAccountDepositInput);
            this.openAccountPanel.Controls.Add(this.chooseBankaccountTypeBox);
            this.openAccountPanel.Location = new System.Drawing.Point(177, 389);
            this.openAccountPanel.Name = "openAccountPanel";
            this.openAccountPanel.Size = new System.Drawing.Size(357, 450);
            this.openAccountPanel.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // displayLabel3OpenAccountPanel
            // 
            this.displayLabel3OpenAccountPanel.AutoSize = true;
            this.displayLabel3OpenAccountPanel.Location = new System.Drawing.Point(132, 76);
            this.displayLabel3OpenAccountPanel.Name = "displayLabel3OpenAccountPanel";
            this.displayLabel3OpenAccountPanel.Size = new System.Drawing.Size(117, 15);
            this.displayLabel3OpenAccountPanel.TabIndex = 7;
            this.displayLabel3OpenAccountPanel.Text = "Open a bankaccount";
            // 
            // displayLabel2OpenAccountPanel
            // 
            this.displayLabel2OpenAccountPanel.AutoSize = true;
            this.displayLabel2OpenAccountPanel.Location = new System.Drawing.Point(3, 202);
            this.displayLabel2OpenAccountPanel.Name = "displayLabel2OpenAccountPanel";
            this.displayLabel2OpenAccountPanel.Size = new System.Drawing.Size(117, 15);
            this.displayLabel2OpenAccountPanel.TabIndex = 6;
            this.displayLabel2OpenAccountPanel.Text = "Deposit into account";
            // 
            // displayLabel1OpenAccountPanel
            // 
            this.displayLabel1OpenAccountPanel.AutoSize = true;
            this.displayLabel1OpenAccountPanel.Location = new System.Drawing.Point(16, 148);
            this.displayLabel1OpenAccountPanel.Name = "displayLabel1OpenAccountPanel";
            this.displayLabel1OpenAccountPanel.Size = new System.Drawing.Size(102, 15);
            this.displayLabel1OpenAccountPanel.TabIndex = 5;
            this.displayLabel1OpenAccountPanel.Text = "Bankaccount type";
            // 
            // openAccountPanelButton
            // 
            this.openAccountPanelButton.Location = new System.Drawing.Point(128, 282);
            this.openAccountPanelButton.Name = "openAccountPanelButton";
            this.openAccountPanelButton.Size = new System.Drawing.Size(121, 23);
            this.openAccountPanelButton.TabIndex = 4;
            this.openAccountPanelButton.Text = "Open account";
            this.openAccountPanelButton.UseVisualStyleBackColor = true;
            this.openAccountPanelButton.Click += new System.EventHandler(this.openAccountPanelButton_Click);
            // 
            // agreeTnCOpenAccount
            // 
            this.agreeTnCOpenAccount.AutoSize = true;
            this.agreeTnCOpenAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.agreeTnCOpenAccount.Location = new System.Drawing.Point(71, 248);
            this.agreeTnCOpenAccount.Name = "agreeTnCOpenAccount";
            this.agreeTnCOpenAccount.Size = new System.Drawing.Size(240, 19);
            this.agreeTnCOpenAccount.TabIndex = 3;
            this.agreeTnCOpenAccount.Text = "You agree with our terms and conditions";
            this.agreeTnCOpenAccount.UseVisualStyleBackColor = true;
            this.agreeTnCOpenAccount.CheckedChanged += new System.EventHandler(this.agreeTnCOpenAccount_CheckedChanged);
            // 
            // openAccountDepositInput
            // 
            this.openAccountDepositInput.Location = new System.Drawing.Point(124, 197);
            this.openAccountDepositInput.Name = "openAccountDepositInput";
            this.openAccountDepositInput.Size = new System.Drawing.Size(132, 23);
            this.openAccountDepositInput.TabIndex = 2;
            // 
            // chooseBankaccountTypeBox
            // 
            this.chooseBankaccountTypeBox.FormattingEnabled = true;
            this.chooseBankaccountTypeBox.Items.AddRange(new object[] {
            "Transaktionskonto",
            "Sparkonto",
            "Räntekonto",
            "Investeringssparkonto"});
            this.chooseBankaccountTypeBox.Location = new System.Drawing.Point(124, 144);
            this.chooseBankaccountTypeBox.Name = "chooseBankaccountTypeBox";
            this.chooseBankaccountTypeBox.Size = new System.Drawing.Size(132, 23);
            this.chooseBankaccountTypeBox.TabIndex = 1;
            // 
            // bankaccountsBindingSource
            // 
            this.bankaccountsBindingSource.DataSource = typeof(LoginApp.Bankaccounts);
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataSource = typeof(LoginApp.Accounts);
            // 
            // LoggedInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openAccountPanel);
            this.Controls.Add(this.openBankaccountButton);
            this.Controls.Add(this.withdrawPanel);
            this.Controls.Add(this.changePasswordPanel);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label1);
            this.Name = "LoggedInForm";
            this.Text = "Form2";
            this.changePasswordPanel.ResumeLayout(false);
            this.changePasswordPanel.PerformLayout();
            this.withdrawPanel.ResumeLayout(false);
            this.openAccountPanel.ResumeLayout(false);
            this.openAccountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankaccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label label1;
        private Button logout;
        private Button withdrawButton;
        private Button depositButton;
        private Button transferButton;
        private Button changePasswordButton;
        private Panel changePasswordPanel;
        private Label displayLabel1_changePasswordPanel;
        private Button changePasswordPanelButton;
        private TextBox newPassword2;
        private TextBox newPassword;
        private TextBox oldPassword;
        private Label displayLabel4_changePasswordPanel;
        private Label displayLabel3_changePasswordPanel;
        private Label displayLabel2_changePasswordPanel;
        private Label label2;
        private ComboBox bankaccountPicker;
        private Panel withdrawPanel;
        private Button openBankaccountButton;
        private Panel openAccountPanel;
        private Button openAccountPanelButton;
        private CheckBox agreeTnCOpenAccount;
        private TextBox openAccountDepositInput;
        private ComboBox chooseBankaccountTypeBox;
        private Label label3;
        private Label displayLabel3OpenAccountPanel;
        private Label displayLabel2OpenAccountPanel;
        private Label displayLabel1OpenAccountPanel;
        private BindingSource bankaccountsBindingSource;
        private BindingSource accountsBindingSource;
    }
}