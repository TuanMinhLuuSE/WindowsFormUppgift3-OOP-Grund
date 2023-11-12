namespace LoginApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.loginUsername = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.displayLabel1 = new System.Windows.Forms.Label();
            this.displayLabel2 = new System.Windows.Forms.Label();
            this.displayLabel3 = new System.Windows.Forms.Label();
            this.displayLabel4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(359, 197);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.Login_Click);
            // 
            // loginPassword
            // 
            this.loginPassword.Location = new System.Drawing.Point(346, 168);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.PasswordChar = '*';
            this.loginPassword.Size = new System.Drawing.Size(100, 23);
            this.loginPassword.TabIndex = 1;
            // 
            // loginUsername
            // 
            this.loginUsername.Location = new System.Drawing.Point(346, 139);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(100, 23);
            this.loginUsername.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Register_Click);
            // 
            // displayLabel1
            // 
            this.displayLabel1.AutoSize = true;
            this.displayLabel1.Location = new System.Drawing.Point(327, 87);
            this.displayLabel1.Name = "displayLabel1";
            this.displayLabel1.Size = new System.Drawing.Size(142, 15);
            this.displayLabel1.TabIndex = 4;
            this.displayLabel1.Text = "Enter your details to login";
            // 
            // displayLabel2
            // 
            this.displayLabel2.AutoSize = true;
            this.displayLabel2.Location = new System.Drawing.Point(280, 142);
            this.displayLabel2.Name = "displayLabel2";
            this.displayLabel2.Size = new System.Drawing.Size(60, 15);
            this.displayLabel2.TabIndex = 5;
            this.displayLabel2.Text = "Username";
            // 
            // displayLabel3
            // 
            this.displayLabel3.AutoSize = true;
            this.displayLabel3.Location = new System.Drawing.Point(280, 168);
            this.displayLabel3.Name = "displayLabel3";
            this.displayLabel3.Size = new System.Drawing.Size(57, 15);
            this.displayLabel3.TabIndex = 6;
            this.displayLabel3.Text = "Password";
            // 
            // displayLabel4
            // 
            this.displayLabel4.AutoSize = true;
            this.displayLabel4.Location = new System.Drawing.Point(318, 248);
            this.displayLabel4.Name = "displayLabel4";
            this.displayLabel4.Size = new System.Drawing.Size(173, 15);
            this.displayLabel4.TabIndex = 7;
            this.displayLabel4.Text = "No account yet? Register below";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 9;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayLabel4);
            this.Controls.Add(this.displayLabel3);
            this.Controls.Add(this.displayLabel2);
            this.Controls.Add(this.displayLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.loginUsername);
            this.Controls.Add(this.loginPassword);
            this.Controls.Add(this.loginButton);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button loginButton;
        private TextBox loginPassword;
        private TextBox loginUsername;
        private Button button2;
        private FontDialog fontDialog1;
        private Label displayLabel1;
        private Label displayLabel2;
        private Label displayLabel3;
        private Label displayLabel4;
        private Label label1;
    }
}