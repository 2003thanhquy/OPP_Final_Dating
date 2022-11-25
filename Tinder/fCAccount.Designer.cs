namespace Tinder
{
    partial class fCAccount
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
            this.clbHobbies = new System.Windows.Forms.CheckedListBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.rdoGFemale = new System.Windows.Forms.RadioButton();
            this.rdoGMale = new System.Windows.Forms.RadioButton();
            this.dtmDOBirth = new System.Windows.Forms.DateTimePicker();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.grpRealtionship = new System.Windows.Forms.GroupBox();
            this.rdoRMarried = new System.Windows.Forms.RadioButton();
            this.rdoRDating = new System.Windows.Forms.RadioButton();
            this.rdoRSingle = new System.Windows.Forms.RadioButton();
            this.txtPNumber = new System.Windows.Forms.TextBox();
            this.grpOSexualle = new System.Windows.Forms.GroupBox();
            this.rdoOSUnderfine = new System.Windows.Forms.RadioButton();
            this.rdoOSFemale = new System.Windows.Forms.RadioButton();
            this.rdoOSMale = new System.Windows.Forms.RadioButton();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtCPassword = new System.Windows.Forms.TextBox();
            this.btnCAccount = new System.Windows.Forms.Button();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.grpGender.SuspendLayout();
            this.grpRealtionship.SuspendLayout();
            this.grpOSexualle.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbHobbies
            // 
            this.clbHobbies.FormattingEnabled = true;
            this.clbHobbies.Items.AddRange(new object[] {
            "Music",
            "Language",
            "Travel",
            "Movie",
            "Shopping"});
            this.clbHobbies.Location = new System.Drawing.Point(857, 44);
            this.clbHobbies.Name = "clbHobbies";
            this.clbHobbies.Size = new System.Drawing.Size(311, 510);
            this.clbHobbies.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(496, 12);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceholderText = "Address";
            this.txtAddress.Size = new System.Drawing.Size(250, 27);
            this.txtAddress.TabIndex = 4;
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdoGFemale);
            this.grpGender.Controls.Add(this.rdoGMale);
            this.grpGender.Location = new System.Drawing.Point(49, 440);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(268, 125);
            this.grpGender.TabIndex = 6;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            // 
            // rdoGFemale
            // 
            this.rdoGFemale.AutoSize = true;
            this.rdoGFemale.Location = new System.Drawing.Point(141, 47);
            this.rdoGFemale.Name = "rdoGFemale";
            this.rdoGFemale.Size = new System.Drawing.Size(78, 24);
            this.rdoGFemale.TabIndex = 1;
            this.rdoGFemale.TabStop = true;
            this.rdoGFemale.Text = "Female";
            this.rdoGFemale.UseVisualStyleBackColor = true;
            // 
            // rdoGMale
            // 
            this.rdoGMale.AutoSize = true;
            this.rdoGMale.Location = new System.Drawing.Point(18, 47);
            this.rdoGMale.Name = "rdoGMale";
            this.rdoGMale.Size = new System.Drawing.Size(63, 24);
            this.rdoGMale.TabIndex = 0;
            this.rdoGMale.TabStop = true;
            this.rdoGMale.Text = "Male";
            this.rdoGMale.UseVisualStyleBackColor = true;
            // 
            // dtmDOBirth
            // 
            this.dtmDOBirth.Location = new System.Drawing.Point(49, 348);
            this.dtmDOBirth.Name = "dtmDOBirth";
            this.dtmDOBirth.Size = new System.Drawing.Size(250, 27);
            this.dtmDOBirth.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(49, 200);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(250, 27);
            this.txtPassword.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(49, 119);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(250, 27);
            this.txtEmail.TabIndex = 1;
            // 
            // grpRealtionship
            // 
            this.grpRealtionship.Controls.Add(this.rdoRMarried);
            this.grpRealtionship.Controls.Add(this.rdoRDating);
            this.grpRealtionship.Controls.Add(this.rdoRSingle);
            this.grpRealtionship.Location = new System.Drawing.Point(496, 307);
            this.grpRealtionship.Name = "grpRealtionship";
            this.grpRealtionship.Size = new System.Drawing.Size(281, 115);
            this.grpRealtionship.TabIndex = 7;
            this.grpRealtionship.TabStop = false;
            this.grpRealtionship.Text = "Realtionship";
            // 
            // rdoRMarried
            // 
            this.rdoRMarried.AutoSize = true;
            this.rdoRMarried.Location = new System.Drawing.Point(186, 44);
            this.rdoRMarried.Name = "rdoRMarried";
            this.rdoRMarried.Size = new System.Drawing.Size(82, 24);
            this.rdoRMarried.TabIndex = 3;
            this.rdoRMarried.TabStop = true;
            this.rdoRMarried.Text = "Married";
            this.rdoRMarried.UseVisualStyleBackColor = true;
            // 
            // rdoRDating
            // 
            this.rdoRDating.AutoSize = true;
            this.rdoRDating.Location = new System.Drawing.Point(107, 44);
            this.rdoRDating.Name = "rdoRDating";
            this.rdoRDating.Size = new System.Drawing.Size(75, 24);
            this.rdoRDating.TabIndex = 2;
            this.rdoRDating.TabStop = true;
            this.rdoRDating.Text = "Dating";
            this.rdoRDating.UseVisualStyleBackColor = true;
            // 
            // rdoRSingle
            // 
            this.rdoRSingle.AutoSize = true;
            this.rdoRSingle.Location = new System.Drawing.Point(18, 44);
            this.rdoRSingle.Name = "rdoRSingle";
            this.rdoRSingle.Size = new System.Drawing.Size(71, 24);
            this.rdoRSingle.TabIndex = 1;
            this.rdoRSingle.TabStop = true;
            this.rdoRSingle.Text = "Single";
            this.rdoRSingle.UseVisualStyleBackColor = true;
            // 
            // txtPNumber
            // 
            this.txtPNumber.Location = new System.Drawing.Point(496, 95);
            this.txtPNumber.Name = "txtPNumber";
            this.txtPNumber.PlaceholderText = "Phone Number";
            this.txtPNumber.Size = new System.Drawing.Size(250, 27);
            this.txtPNumber.TabIndex = 3;
            // 
            // grpOSexualle
            // 
            this.grpOSexualle.Controls.Add(this.rdoOSUnderfine);
            this.grpOSexualle.Controls.Add(this.rdoOSFemale);
            this.grpOSexualle.Controls.Add(this.rdoOSMale);
            this.grpOSexualle.Location = new System.Drawing.Point(486, 524);
            this.grpOSexualle.Name = "grpOSexualle";
            this.grpOSexualle.Size = new System.Drawing.Size(291, 105);
            this.grpOSexualle.TabIndex = 7;
            this.grpOSexualle.TabStop = false;
            this.grpOSexualle.Text = "Orientation Sexuelle";
            // 
            // rdoOSUnderfine
            // 
            this.rdoOSUnderfine.AutoSize = true;
            this.rdoOSUnderfine.Location = new System.Drawing.Point(172, 45);
            this.rdoOSUnderfine.Name = "rdoOSUnderfine";
            this.rdoOSUnderfine.Size = new System.Drawing.Size(95, 24);
            this.rdoOSUnderfine.TabIndex = 3;
            this.rdoOSUnderfine.TabStop = true;
            this.rdoOSUnderfine.Text = "Underfine";
            this.rdoOSUnderfine.UseVisualStyleBackColor = true;
            // 
            // rdoOSFemale
            // 
            this.rdoOSFemale.AutoSize = true;
            this.rdoOSFemale.Location = new System.Drawing.Point(88, 45);
            this.rdoOSFemale.Name = "rdoOSFemale";
            this.rdoOSFemale.Size = new System.Drawing.Size(78, 24);
            this.rdoOSFemale.TabIndex = 2;
            this.rdoOSFemale.TabStop = true;
            this.rdoOSFemale.Text = "Female";
            this.rdoOSFemale.UseVisualStyleBackColor = true;
            // 
            // rdoOSMale
            // 
            this.rdoOSMale.AutoSize = true;
            this.rdoOSMale.Location = new System.Drawing.Point(19, 45);
            this.rdoOSMale.Name = "rdoOSMale";
            this.rdoOSMale.Size = new System.Drawing.Size(63, 24);
            this.rdoOSMale.TabIndex = 1;
            this.rdoOSMale.TabStop = true;
            this.rdoOSMale.Text = "Male";
            this.rdoOSMale.UseVisualStyleBackColor = true;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(49, 34);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(250, 27);
            this.txtFullname.TabIndex = 0;
            this.txtFullname.Text = "FullName";
            // 
            // txtCPassword
            // 
            this.txtCPassword.Location = new System.Drawing.Point(49, 269);
            this.txtCPassword.Name = "txtCPassword";
            this.txtCPassword.PlaceholderText = "Confirm Password";
            this.txtCPassword.Size = new System.Drawing.Size(250, 27);
            this.txtCPassword.TabIndex = 3;
            // 
            // btnCAccount
            // 
            this.btnCAccount.Location = new System.Drawing.Point(367, 643);
            this.btnCAccount.Name = "btnCAccount";
            this.btnCAccount.Size = new System.Drawing.Size(649, 58);
            this.btnCAccount.TabIndex = 9;
            this.btnCAccount.Text = "Create Account";
            this.btnCAccount.UseVisualStyleBackColor = true;
            this.btnCAccount.Click += new System.EventHandler(this.btnCAccount_Click);
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(502, 178);
            this.txtJob.Name = "txtJob";
            this.txtJob.PlaceholderText = "Job";
            this.txtJob.Size = new System.Drawing.Size(244, 27);
            this.txtJob.TabIndex = 10;
            // 
            // fCAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 713);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.btnCAccount);
            this.Controls.Add(this.clbHobbies);
            this.Controls.Add(this.grpOSexualle);
            this.Controls.Add(this.grpRealtionship);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.dtmDOBirth);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCPassword);
            this.Controls.Add(this.txtPNumber);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFullname);
            this.Name = "fCAccount";
            this.Text = "fCAccount";
            this.Load += new System.EventHandler(this.fCAccount_Load);
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.grpRealtionship.ResumeLayout(false);
            this.grpRealtionship.PerformLayout();
            this.grpOSexualle.ResumeLayout(false);
            this.grpOSexualle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox clbHobbies;
        private TextBox txtAddress;
        private GroupBox grpGender;
        private DateTimePicker dtmDOBirth;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private GroupBox grpRealtionship;
        private TextBox txtPNumber;
        private GroupBox grpOSexualle;
        private TextBox txtFullname;
        private TextBox txtCPassword;
        private RadioButton rdoGFemale;
        private RadioButton rdoGMale;
        private RadioButton rdoRMarried;
        private RadioButton rdoRDating;
        private RadioButton rdoRSingle;
        private RadioButton rdoOSUnderfine;
        private RadioButton rdoOSFemale;
        private RadioButton rdoOSMale;
        private Button btnCAccount;
        private TextBox txtJob;
    }
}