using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void simpleCalcu1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(simpleCalcu1.result.ToString());
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
       Form form = new Form2(int.Parse(gunaTextBox1.Text) );   
            form.ShowDialog();
                
                }
    }
}
