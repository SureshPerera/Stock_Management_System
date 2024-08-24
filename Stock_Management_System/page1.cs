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
    public partial class page1 : Form
    {
        public page1()
        {
            InitializeComponent();
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            page2 page2 = new page2();

            this.Hide();
            form1.ShowDialog();

            form1.FormClosed += (s, args) => this.Close();
           
        }

        private void Page1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
