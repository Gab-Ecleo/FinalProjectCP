using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectCP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Classess



        //Methods

        private void ClickToOrderBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help frm4 = new Help();
            frm4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm5 = new Form5();
            frm5.Show();
        }
    }
}
    

