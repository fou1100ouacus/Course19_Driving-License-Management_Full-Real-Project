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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        frmLogin _frmLogin;
        public frmMain(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;

        }

        private void managePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmManagePeoples());
            //frmManagePeoples frm = new frmManagePeoples();
            //frm.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmManageUser());
            //frmManageUser frm = new frmManageUser();
            //frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        public void loadform(object Form)
        {

            if (this.mainpanel2.Controls.Count > 0)
            {
                this.mainpanel2.Controls.RemoveAt(0);
                Form f = Form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.mainpanel2.Controls.Add(f);
                this.mainpanel2.Tag = f;
                f.Show();

            }

        }

        private void localLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///////////////
            ///
            frmAddUpdateLocalDrivingLicesnseApplication frm = new frmAddUpdateLocalDrivingLicesnseApplication();
            frm.Show();

        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        //{frmListApplications frm=new frmListApplications();
        //    frm.Show();
        { 
            loadform(new frmListApplications());


        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmTestTypesList());
            //frmTestTypesList frm=new frmTestTypesList();
            //frm.Show();
            
        }

        private void localDriveLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform( new frmListLocalDrivingLicesnseApplications());
            //frmListLocalDrivingLicesnseApplications frm=new frmListLocalDrivingLicesnseApplications();
            //frm.Show();
        }
        clsUser current;
        private void frmMain_Load(object sender, EventArgs e)
        {
            //current.UserName=clsUser.
           // clsGlobal.currentUser = current;
            lblusername.Text = clsGlobal.currentUser.UserName.ToString();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadform(new frmListDrivers());
            //frmListDrivers frm= new frmListDrivers();
            //frm.Show();
        }

        private void internaionalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicenseApplication frm=new frmNewInternationalLicenseApplication();
            frm.Show();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainLicenseApplication frm = new frmDetainLicenseApplication();
            frm.Show();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void drivingLicenceServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void applicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mainpanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            mainpanel2.Show( );
        }

        private void mangaeApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void detainLicencesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newDriveLiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void replacementForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
