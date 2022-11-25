using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tinder
{
    public partial class fCAccount : Form
    {
        public fCAccount()
        {
            InitializeComponent();
        }

        private void fCAccount_Load(object sender, EventArgs e)
        {
            

        }

        private void btnCAccount_Click(object sender, EventArgs e)
        {
            bool isCheck = false;
            List<string> hobbies = new List<string>();
            string gender="";
            string oSexualle="";
            string realtionship="";

            //Check txt

            foreach (string item in clbHobbies.CheckedItems)
            {
                hobbies.Add(item);
            }
            foreach (RadioButton rb in grpGender.Controls)
            {
                if(rb.Checked)
                {
                    gender = rb.Text;
                    break;
                }
            }
            foreach (RadioButton rb in grpOSexualle.Controls)
            {
                if (rb.Checked)
                {
                    oSexualle = rb.Text;
                    break;
                }
            }
            foreach (RadioButton rb in grpRealtionship.Controls)
            {
                if (rb.Checked)
                {
                    realtionship = rb.Text;
                    break;
                }
            }
            if (!isCheck)
            {
                 ExternalInterface.CreateNewAccount(txtFullname.Text,dtmDOBirth.Value,txtAddress.Text,txtPNumber.Text,hobbies,txtJob.Text,gender,txtEmail.Text,
                     txtPassword.Text,oSexualle,realtionship);
              
            }
            
        }
    }
}
