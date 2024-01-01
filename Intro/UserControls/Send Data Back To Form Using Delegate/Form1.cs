using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Send_Data_Back_To_Form_Using_Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form2_DataBack(object sender, int PersonID)
        {
            textBox1.Text = PersonID.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.DataBack += Form2_DataBack;
            frm.ShowDialog();

        }
    }
}
