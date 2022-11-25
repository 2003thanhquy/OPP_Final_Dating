namespace Tinder
{
    partial class fFPassword
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPNumber = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtCPaswrod = new System.Windows.Forms.TextBox();
            this.txtNPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(267, 53);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(125, 27);
            this.txtEmail.TabIndex = 0;
            // 
            // txtPNumber
            // 
            this.txtPNumber.Location = new System.Drawing.Point(267, 131);
            this.txtPNumber.Name = "txtPNumber";
            this.txtPNumber.PlaceholderText = "Phone Number";
            this.txtPNumber.Size = new System.Drawing.Size(125, 27);
            this.txtPNumber.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(281, 355);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(94, 29);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtCPaswrod
            // 
            this.txtCPaswrod.Location = new System.Drawing.Point(267, 276);
            this.txtCPaswrod.Name = "txtCPaswrod";
            this.txtCPaswrod.PlaceholderText = "Confirm Password";
            this.txtCPaswrod.Size = new System.Drawing.Size(125, 27);
            this.txtCPaswrod.TabIndex = 4;
            // 
            // txtNPassword
            // 
            this.txtNPassword.Location = new System.Drawing.Point(267, 210);
            this.txtNPassword.Name = "txtNPassword";
            this.txtNPassword.PlaceholderText = "New Password";
            this.txtNPassword.Size = new System.Drawing.Size(125, 27);
            this.txtNPassword.TabIndex = 3;
            // 
            // fFPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCPaswrod);
            this.Controls.Add(this.txtNPassword);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtPNumber);
            this.Controls.Add(this.txtEmail);
            this.Name = "fFPassword";
            this.Text = "fFPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtPNumber;
        private Button btnConfirm;
        private TextBox txtCPaswrod;
        private TextBox txtNPassword;
    }
}