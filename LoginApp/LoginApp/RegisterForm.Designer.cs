namespace LoginApp
{
    partial class RegisterForm
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
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.confirmPasswordInput = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.displayLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.displayLabel2 = new System.Windows.Forms.Label();
            this.displayLabel3 = new System.Windows.Forms.Label();
            this.displayLabel4 = new System.Windows.Forms.Label();
            this.agreeTnC = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(341, 139);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(100, 23);
            this.usernameInput.TabIndex = 0;
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(341, 196);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(100, 23);
            this.passwordInput.TabIndex = 1;
            // 
            // confirmPasswordInput
            // 
            this.confirmPasswordInput.Location = new System.Drawing.Point(341, 255);
            this.confirmPasswordInput.Name = "confirmPasswordInput";
            this.confirmPasswordInput.PasswordChar = '*';
            this.confirmPasswordInput.Size = new System.Drawing.Size(100, 23);
            this.confirmPasswordInput.TabIndex = 2;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(352, 325);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(352, 369);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // displayLabel1
            // 
            this.displayLabel1.AutoSize = true;
            this.displayLabel1.Location = new System.Drawing.Point(292, 70);
            this.displayLabel1.Name = "displayLabel1";
            this.displayLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.displayLabel1.Size = new System.Drawing.Size(209, 15);
            this.displayLabel1.TabIndex = 10;
            this.displayLabel1.Text = "Enter your details to create an account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 6;
            // 
            // displayLabel2
            // 
            this.displayLabel2.AutoSize = true;
            this.displayLabel2.Location = new System.Drawing.Point(275, 142);
            this.displayLabel2.Name = "displayLabel2";
            this.displayLabel2.Size = new System.Drawing.Size(60, 15);
            this.displayLabel2.TabIndex = 7;
            this.displayLabel2.Text = "Username";
            // 
            // displayLabel3
            // 
            this.displayLabel3.AutoSize = true;
            this.displayLabel3.Location = new System.Drawing.Point(278, 199);
            this.displayLabel3.Name = "displayLabel3";
            this.displayLabel3.Size = new System.Drawing.Size(57, 15);
            this.displayLabel3.TabIndex = 8;
            this.displayLabel3.Text = "Password";
            // 
            // displayLabel4
            // 
            this.displayLabel4.AutoSize = true;
            this.displayLabel4.Location = new System.Drawing.Point(231, 258);
            this.displayLabel4.Name = "displayLabel4";
            this.displayLabel4.Size = new System.Drawing.Size(104, 15);
            this.displayLabel4.TabIndex = 9;
            this.displayLabel4.Text = "Confirm password";
            // 
            // agreeTnC
            // 
            this.agreeTnC.AutoSize = true;
            this.agreeTnC.Location = new System.Drawing.Point(278, 300);
            this.agreeTnC.Name = "agreeTnC";
            this.agreeTnC.Size = new System.Drawing.Size(240, 19);
            this.agreeTnC.TabIndex = 3;
            this.agreeTnC.Text = "You agree with our terms and conditions";
            this.agreeTnC.UseVisualStyleBackColor = true;
            this.agreeTnC.CheckedChanged += new System.EventHandler(this.agreeTnC_CheckedChanged);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.agreeTnC);
            this.Controls.Add(this.displayLabel4);
            this.Controls.Add(this.displayLabel3);
            this.Controls.Add(this.displayLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayLabel1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.confirmPasswordInput);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.usernameInput);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox usernameInput;
        private TextBox passwordInput;
        private TextBox confirmPasswordInput;
        private Button registerButton;
        private Button loginButton;
        private Label displayLabel1;
        private Label label1;
        private Label displayLabel2;
        private Label displayLabel3;
        private Label displayLabel4;
        private CheckBox agreeTnC;
    }
}