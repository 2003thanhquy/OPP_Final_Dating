namespace Tinder
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.llblCAccount = new System.Windows.Forms.LinkLabel();
            this.llblFPassword = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(332, 82);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email Address";
            this.txtEmail.Size = new System.Drawing.Size(327, 27);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(332, 174);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(327, 27);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // llblCAccount
            // 
            this.llblCAccount.AutoSize = true;
            this.llblCAccount.Location = new System.Drawing.Point(277, 230);
            this.llblCAccount.Name = "llblCAccount";
            this.llblCAccount.Size = new System.Drawing.Size(110, 20);
            this.llblCAccount.TabIndex = 4;
            this.llblCAccount.TabStop = true;
            this.llblCAccount.Text = "Create Account";
            this.llblCAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCAccount_LinkClicked);
            // 
            // llblFPassword
            // 
            this.llblFPassword.AutoSize = true;
            this.llblFPassword.Location = new System.Drawing.Point(465, 237);
            this.llblFPassword.Name = "llblFPassword";
            this.llblFPassword.Size = new System.Drawing.Size(117, 20);
            this.llblFPassword.TabIndex = 5;
            this.llblFPassword.TabStop = true;
            this.llblFPassword.Text = "Forget Password";
            this.llblFPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblFPassword_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(358, 308);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 29);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.llblFPassword);
            this.Controls.Add(this.llblCAccount);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Name = "fLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtPassword;
        private LinkLabel llblCAccount;
        private LinkLabel llblFPassword;
        private Button btnLogin;
        private PictureBox pictureBox1;
    }
}