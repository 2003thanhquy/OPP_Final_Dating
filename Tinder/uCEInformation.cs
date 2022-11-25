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
    public partial class uCEInformation : UserControl
    {
        private User userCurrLogin;
        public uCEInformation(User userCurrLogin)
        {
            this.userCurrLogin = userCurrLogin;
            InitializeComponent();
            InitInfo();
        }
        private void InitInfo()
        {
            txtFullname.Text = userCurrLogin.userName;
            txtEmail.Text = userCurrLogin.email;
            dtmDOB.Text = userCurrLogin.dayOfDate.ToString();
            foreach (var control in grpGender.Controls)
            {
                var rd = control as RadioButton;
                if (rd.Text == userCurrLogin.gender)
                {
                    rd.Checked = true;
                    break;
                }
            }
            txtAddress.Text = userCurrLogin.address;
            txtPhone.Text = userCurrLogin.PhoneNumber;
            txtJob.Text = userCurrLogin.job;
            foreach (var control in grpRealtionship.Controls)
            {
                var rd = control as RadioButton;
                if (rd.Text == userCurrLogin.Relationship)
                {
                    rd.Checked = true;
                    break;
                }
            }
            foreach (var control in grpOSexualle.Controls)
            {
                var rd = control as RadioButton;
                if (rd.Text == userCurrLogin.orientationSexuelle)
                {
                    rd.Checked = true;
                    break;
                }
            }
            for (int i = 0; i < clbHobbies.Items.Count; i++)
            {
                if (userCurrLogin.Hobbies.Contains(clbHobbies.Items[i]))
                {
                    clbHobbies.SetItemChecked(i, true);
                }
            }
            //dong 
            foreach (var control in Controls)
            {
                if (control is TextBox)
                {
                    var txt = control as TextBox;
                    txt.ReadOnly = true;
                }
                if (control is GroupBox)
                {
                    var grp = control as GroupBox;
                    grp.Enabled = false;
                }
                if (control is CheckedListBox)
                {
                    var clb = control as CheckedListBox;
                    clb.Enabled = false;
                }
            }
            btnConfirm.Visible = false;
        }
        void Xx() { }
        private  void UpdateInfo()
        {
            userCurrLogin.userName = txtFullname.Text;
            userCurrLogin.email = txtEmail.Text; 
            userCurrLogin.dayOfDate = dtmDOB.Value;
            userCurrLogin.phoneNumber = txtPhone.Text;
            userCurrLogin.job = txtJob.Text;
            userCurrLogin.address = txtAddress.Text;
            List<string> hobbies = new List<string>();
            //Check txt

            foreach (string item in clbHobbies.CheckedItems)
            {
                hobbies.Add(item);
            }
            foreach (RadioButton rb in grpGender.Controls)
            {
                if (rb.Checked)
                {
                    userCurrLogin.gender = rb.Text;
                    break;
                }
            }
            foreach (RadioButton rb in grpOSexualle.Controls)
            {
                if (rb.Checked)
                {
                    userCurrLogin.orientationSexuelle = rb.Text;
                    break;
                }
            }
            foreach (RadioButton rb in grpRealtionship.Controls)
            {
                if (rb.Checked)
                {
                    userCurrLogin.relationship = rb.Text;
                    break;
                }
            }
            userCurrLogin.hobbies = hobbies;
           

        }
   

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
