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
    public partial class fFPassword : Form
    {
        public fFPassword()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool isCheck = false;
            // Check txt
            if (!isCheck)
            {
               bool checkUpdatePass =  ExternalInterface.FogetPass(txtEmail.Text,txtPNumber.Text,txtCPaswrod.Text);
                if (checkUpdatePass)
                {
                    MessageBox.Show("Changed Password Complete");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Uncomplete");

                }
            }
        }
    }
}
