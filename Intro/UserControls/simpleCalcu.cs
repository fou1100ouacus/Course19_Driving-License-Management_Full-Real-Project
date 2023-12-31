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
    public partial class simpleCalcu : UserControl
    {
        public simpleCalcu()
        {
            InitializeComponent();
        }
        public float result
        {

            get
            {
                return (float)Convert.ToDouble(label1.Text);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            (label1.Text) = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }



    }
}
