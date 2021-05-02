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
        public Form1 frm1 = new Form1();
        
        
        //Methods

        private void ClickToOrderBtn_Click(object sender, EventArgs e)
        {
            frm1.Show();
            this.Hide();
            
        }
    }
}
