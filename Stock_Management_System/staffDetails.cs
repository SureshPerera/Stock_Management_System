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
    public partial class staffDetails : Form
    {
        string connectionString = @"Data Source=SURESH;Initial Catalog=Inventry_Management_System;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public staffDetails()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void staffDetails_Load(object sender, EventArgs e)
        {
            showStaffTable();
        }
        public void showStaffTable()
        {
            try
            {

                SqlConnection sqlCon = new SqlConnection(connectionString);
                using (sqlCon)
                {
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("addStaff", sqlCon);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM staffDetails";
                    cmd.ExecuteNonQuery();
                    DataTable dataTable = new DataTable();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dgvStaffDetails.DataSource = dataTable;
                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            addNewStaff nf = new addNewStaff();
            nf.ShowDialog();
        }
    }
}
