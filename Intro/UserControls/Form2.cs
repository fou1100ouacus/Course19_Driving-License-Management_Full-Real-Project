using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls
{
    public partial class Form2 : Form
    {
        private int _ID = -1;
        public Form2(int id)
        {
            InitializeComponent();
            _ID = id;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            gunaLabel1.Text = _ID.ToString();

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
