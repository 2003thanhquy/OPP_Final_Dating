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
    public partial class uCIPublic : UserControl
    {
        private User userCurrLogin;
        public uCIPublic(User userCurrLogin)
        {
            InitializeComponent();
            this.userCurrLogin = userCurrLogin;
            initInfo();
        }
        private void initInfo()
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
        }
    }
}
