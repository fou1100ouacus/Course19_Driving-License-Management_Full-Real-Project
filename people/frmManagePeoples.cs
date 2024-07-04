using BussinessLayer;
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
    public partial class frmManagePeoples : Form
    {
        public frmManagePeoples()
        {
            InitializeComponent();
        }                   // 
        private static DataTable _dtAllPeople = clsPerson.PeoplesList();
        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "Gendor", "DateOfBirth",
                                                       "Phone", "Email");

        private void _RefreshList()
        {     
            _dtAllPeople = clsPerson.PeoplesList();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                      "FirstName", "SecondName", "ThirdName", "LastName",
                                                      "Gendor", "DateOfBirth",
                                                      "Phone", "Email");
            dataGridView1.DataSource = _dtPeople; 

        }
        private void frmManagePeoplecs_Load(object sender, EventArgs e)
        {
            _RefreshList();

        }

        private void guna2Button1_MouseClick(object sender, MouseEventArgs e)
        {
            frmAddUpdatePersonn frm= new frmAddUpdatePersonn();
            frm.ShowDialog();
            


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {/////////////////////

            frmAddUpdatePersonn frm = new frmAddUpdatePersonn();
            frm.ShowDialog();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int currentid = (int)dataGridView1.CurrentRow.Cells[0].Value;

            frmAddUpdatePersonn frm = new frmAddUpdatePersonn(currentid);
            frm.Show();









        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure to delete this member  " + dataGridView1.CurrentRow.Cells[0].Value, "Confirm Delete"

               , MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsPerson.IsDeleted((int)dataGridView1.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show(" Deleted Successfully");

                    _RefreshList();

                }
                else
                {
                    MessageBox.Show(" not deleted");

                }

            }
            //else
            //{
            //    MessageBox.Show("  not deleted");


            //}

        }

        private void cbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtsearch.Visible = cbsearch.Text!="None"; //?
            if(txtsearch.Visible )
            {
                txtsearch.Text = "";
                txtsearch.Focus();
            }


        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbsearch.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Second Name":
                    FilterColumn = "SecondName";
                    break;

                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Nationality":
                    FilterColumn = "CountryName";
                    break;

                case "Gendor":
                    FilterColumn = "GendorCaption";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtsearch.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                //lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "PersonID")
                //in this case we deal with integer not string.

                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtsearch.Text.Trim());
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtsearch.Text.Trim());

          //  lblRecordsCount.Text = dgvPeople.Rows.Count.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
