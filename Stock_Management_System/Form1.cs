using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPage2_Click(object sender, EventArgs e)
        {
            page2 page2 = new page2();
            Form1 form1 = new Form1();

            page2.Show();
            this.Hide();

            page2.FormClosed += (s, args) => this.Close();
        }

        private void btnPage1_Click(object sender, EventArgs e)
        {
            page1 page1 = new page1();
            Form1 form1 = new Form1();

            page1.Show();
            this.Hide();
            page1.FormClosed += (s, args) => this.Close();
           
            
        }
    }
}
