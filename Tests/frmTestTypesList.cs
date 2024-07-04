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
    public partial class frmTestTypesList : Form
    {
        public frmTestTypesList()
        {
            InitializeComponent();
        }
        private DataTable _dtAllTestTypes;
        private void frmTestTypesList_Load(object sender, EventArgs e)
        {
            _dtAllTestTypes = clsTestType.GetAllTestTypes();
            dataGridView1.DataSource = _dtAllTestTypes;
        }
    }
}
