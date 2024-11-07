using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management_System
{
    public partial class suppliersDashbord : Form
    {
        string connectionString = @"Data Source=SURESH;Initial Catalog=Inventry_Management_System;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        
        public suppliersDashbord()
        {
            InitializeComponent();
        }

        private void suppliersDashbord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventry_Management_SystemDataSet.item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.inventry_Management_SystemDataSet.item);
            showSupplierDetails();
        }
        void showSupplierDetails()
        {
        SqlConnection sqlCon = new SqlConnection(connectionString);
            using (sqlCon)
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("supplierDetailsAdd",sqlCon);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM supplierDetails";
                DataTable dt = new DataTable(); 
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvSupplierDetails.DataSource = dt;
                sqlCon.Close();
            }
        }

        private void btnImgAddSuppliers_click(object sender, EventArgs e)
        {
            AddNewSuppliers addNewSuppliers = new AddNewSuppliers();
            addNewSuppliers.ShowDialog();
        }

        private void btnaddnewItem_Click(object sender, EventArgs e)
        {
            inventry inventry = new inventry();
            inventry.ShowDialog();
        }
    }
}
