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
    public partial class logingAccountDashbord : Form
    {

        string connectionString = @"Data Source=SURESH;Initial Catalog=Inventry_Management_System;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public logingAccountDashbord()
        {
            InitializeComponent();
        }

        private void btnImgAddUsers_Click(object sender, EventArgs e)
        {
            UserSingUp userSingUp = new UserSingUp();
            userSingUp.ShowDialog();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void logingAccountDashbord_Load(object sender, EventArgs e)
        {
            loginAccUpdateDgv();
        }

        void loginAccUpdateDgv()
        {
            try
            {

                SqlConnection sqlCon = new SqlConnection(connectionString);
                using (sqlCon)
                {
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("CheckPassword", sqlCon);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM Passwords";
                    cmd.ExecuteNonQuery();
                    DataTable dataTable = new DataTable();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dgvCustomerDetails.DataSource = dataTable;
                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loginAccUpdateDgv();
        }
    }
}
