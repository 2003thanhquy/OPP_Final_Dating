using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tinder
{

    public partial class fUInterface : Form
    {
        private User userCurrLogin =null;
        private Form currentFormChild;
        private UserControl currentUserControl;

        public fUInterface( )
        {      
            InitializeComponent();
        }
        public fUInterface(User userCurrLogin)
        {
            this.userCurrLogin = userCurrLogin;
            InitializeComponent();

        }

        private void OpenChildForm(Form childForm)
        {

            if(childForm  == null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void openUserControl(UserControl curr)
        { 

            currentUserControl = curr;
            panelBody.Controls.Clear();
            panelBody.Controls.Add(currentUserControl);

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            uCIPublic uCInforPublic = new uCIPublic(userCurrLogin);
            openUserControl(uCInforPublic);

            foreach ( var control in panelChild.Controls)
            {
                if(control is Button)
                {
                    var rdo = control as Button;
                    rdo.Visible = false;
                }
                
            }

            btn1.Visible = true;
            btn1.Text = "Edit Information";
            
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            btn1.Visible = true;
            btn1.Text = "Edit Information";
            btn2.Visible = true;
            btn2.Text = "Change Password";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
             
            if(btn1.Text == "Edit Information")
            {
                uCEInformation editInformation = new uCEInformation(userCurrLogin);
                openUserControl(editInformation);
            }
        }
    }
}
