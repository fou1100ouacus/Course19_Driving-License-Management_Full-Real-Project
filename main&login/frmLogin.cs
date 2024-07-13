using BussinessLayer;
using DVLD_System.GlobalClASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            clsUser user = clsUser.FindByUsernameAndPassword(txtUsernamee.Text.Trim(),txtpasswordd.Text.Trim());
            if (user != null)
            {

                if (chkRememberMe.Checked)
                {
                    //store username and password
                    clsGlobal.RememberUsernameAndPassword(txtUsernamee.Text.Trim(), txtpasswordd.Text.Trim());

                }
                else
                {
                    //store empty username and password
                    clsGlobal.RememberUsernameAndPassword("", "");

                }

                //incase the user is not active
                if (!user.IsActive)
                {

                    txtUsernamee.Focus();
                    MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clsGlobal.currentUser = user;
                this.Hide();
                frmMain frm = new frmMain(this);
                frm.ShowDialog();


            }
            else
            {
                txtUsernamee.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
    }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                txtUsernamee.Text = UserName;
                txtpasswordd.Text = Password;
                chkRememberMe.Checked = true;
            }
            else
                chkRememberMe.Checked = false;
        }
    }
}
