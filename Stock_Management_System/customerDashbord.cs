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
    public partial class customerDashbord : Form
    {
        public customerDashbord()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            addNewCustomer addnew = new addNewCustomer();
            addnew.ShowDialog();
        }

        private void btnaddnewItem_Click(object sender, EventArgs e)
        {
            inventry inventory = new inventry();
            inventory.ShowDialog();
        }
    }
}
