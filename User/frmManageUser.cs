using BussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_System
{
    public partial class frmManageUser : Form
    {
        public frmManageUser()
        {
            InitializeComponent();
        }
        private static DataTable _AllUserdata;//=clsUser.GetAllUsers();
        private  DataTable _dtableuser;
        private void _RefreshDataGridView()
        {
            _AllUserdata = clsUser.GetAllUsers();
            dgvUsers.DataSource = _AllUserdata.DefaultView.ToTable();
            cbFilterValues.SelectedIndex = 0;
            label2.Text = dgvUsers.Rows.Count.ToString();

            dgvUsers.Columns[0].HeaderText = "User ID";
            dgvUsers.Columns[0].Width = 110;

            dgvUsers.Columns[1].HeaderText = "Person ID";
            dgvUsers.Columns[1].Width = 120;

            dgvUsers.Columns[2].HeaderText = "Full Name";
            dgvUsers.Columns[2].Width = 350;

            dgvUsers.Columns[3].HeaderText = "UserName";
            dgvUsers.Columns[3].Width = 120;

            dgvUsers.Columns[4].HeaderText = "Is Active";
            dgvUsers.Columns[4].Width = 120;

        }
        private void frmManageUser_Load(object sender, EventArgs e)
        {
            _RefreshDataGridView();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        
        private void cbfilter_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

            //None
            //User ID
            //UserName
            //Person ID
            //Full Name
            //Is Active
            cbFilterValues.SelectedIndex = 0;
            string FilterColumn = "";
            switch (cbFilterValues.Text)
            {
               
                case "Full Name":

                    FilterColumn = "FullName";
                    break;
                case "User ID":

                    FilterColumn = "UserID";
                    break;
                case "UserName":

                    FilterColumn = "UserName";
                    break;
                case "Person ID": 

                    FilterColumn = "PersonID";
                    break;
                case "Is Active":

                    FilterColumn = "IsActive";
                    break;
                default :
                    FilterColumn = "None";
                    break;

            }
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtableuser.DefaultView.RowFilter = "";
                //lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
                return;
            }


            if (FilterColumn != "FullName" && FilterColumn != "UserName")
                //in this case we deal with integer not string.

                _dtableuser.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtableuser.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());





        }
       

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cbfilter2_SelectedIndexChanged(object sender, EventArgs e)
        {

            string FilterColumn = "IsActive";
            string FilterValue = cbFilterActive.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "All")
                _dtableuser.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtableuser.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

        //    lblRecordsCount.Text = _AllUserdata.Rows.Count.ToString();






        }

        private void cbfilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (cbFilterValues.Text == "Is Active")
            {
                txtFilterValue.Visible = false;
                cbFilterActive.Visible = true;
                cbFilterActive.Focus();
                cbFilterActive.SelectedIndex = 0;
            }

            else
            {

                txtFilterValue.Visible = (cbFilterValues.Text != "None");
                cbFilterActive.Visible = false;

                if (cbFilterValues.Text == "None")
                {
                    txtFilterValue.Enabled = false;
                }
                else
                    txtFilterValue.Enabled = true;

                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }


        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string FilterColumn = "IsActive";
            string FilterValue = cbFilterActive.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "All")
                _dtableuser.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtableuser.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            label2.Text = _dtableuser.Rows.Count.ToString();

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            frmAddNewUser frm = new frmAddNewUser();
            frm.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_TextChanged(object sender, EventArgs e)
        {
            //None
            //User ID
            //UserName
            //Person ID
            //Full Name
            //Is Active
            cbFilterValues.SelectedIndex = 0;
            string FilterColumn = "";
            switch (cbFilterValues.Text)
            {

                case "Full Name":

                    FilterColumn = "FullName";
                    break;
                case "User ID":

                    FilterColumn = "UserID";
                    break;
                case "UserName":

                    FilterColumn = "UserName";
                    break;
                case "Person ID":

                    FilterColumn = "PersonID";
                    break;
                case "Is Active":

                    FilterColumn = "IsActive";
                    break;
                default:
                    FilterColumn = "None";
                    break;

            }
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtableuser.DefaultView.RowFilter = "";
                //lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
                return;
            }


            if (FilterColumn != "FullName" && FilterColumn != "UserName")
                //in this case we deal with integer not string.

                _dtableuser.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtableuser.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());





        }

        private void txtfilter_TextChanged_1(object sender, EventArgs e)
        {

          
        }

        private void txtfilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            //we allow number incase person id or user id is selected.
            if (cbFilterValues.Text == "Person ID" || cbFilterValues.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
