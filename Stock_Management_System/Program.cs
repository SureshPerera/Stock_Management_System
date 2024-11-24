using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Application.Run(new formLoging());
            //Application.Run(new inventry());
            //Application.Run(new purchace_list());
            //Application.Run(new inventryDashbord());
            //Application.Run(new suppliersDashbord());
            //Application.Run(new AddNewSuppliers());
            //Application.Run(new customerDashbord());
            //Application.Run(new AddCategory());
            //Application.Run(new addNewCustomer());
            //Application.Run(new addNewStaff());
            //Application.Run(new InvoiceCreate());
            //Application.Run(new InventoryItemsAdd());
        }
    }
}
