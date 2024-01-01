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
    public partial class Form2 : Form
    {


        public delegate void DataBackEventHandler(Object sender, int PersonID);
        public DataBackEventHandler DataBack;//object


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int PersonID = int.Parse(textBox1.Text) ;
            DataBack?.Invoke(this, PersonID);

            this.Close();

        }
    }
}
