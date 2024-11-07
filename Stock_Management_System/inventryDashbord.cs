using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stock_Management_System
{
    public partial class inventryDashbord : Form
    {
        string connectionString = @"Data Source=SURESH;Initial Catalog=Inventry_Management_System;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public inventryDashbord()
        {
            InitializeComponent();
        }

        private void inventryDashbord_Load(object sender, EventArgs e)
        {
            showInventryTable();
        
        }

        void showInventryTable()
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            using (sqlCon)
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("item", sqlCon);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM item";
                cmd.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
               
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
                dgvInterntrydetails.DataSource = dataTable;
                sqlCon.Close();
            }
        }

       //private void btnImgPurchaseOrder_Click(object sender, EventArgs e)
       //{
       //   
       //}
       //
        private void btnaddnewItem_Click(object sender, EventArgs e)
        {
            inventry inventry = new inventry();
            inventry.ShowDialog();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            
         
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            inventryDashbord inventryDashbord = new inventryDashbord();
            inventryDashbord.Show();
        }

        private void btnimgSerach_Click(object sender, EventArgs e)
        {

        }
    }
}
