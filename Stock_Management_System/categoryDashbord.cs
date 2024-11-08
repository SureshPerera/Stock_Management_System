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
    public partial class categoryDashbord : Form
    {
        string connectionString = @"Data Source=SURESH;Initial Catalog=Inventry_Management_System;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public categoryDashbord()
        {
            InitializeComponent();
        }

        private void btnAddNewCatergory_Click(object sender, EventArgs e)
        {
            AddCategory newCategory = new AddCategory();
            newCategory.ShowDialog();
        }
        void showCatogoryTable()
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            using (sqlCon)
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("addCategory", sqlCon);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Categories";
                cmd.ExecuteNonQuery();
                DataTable dataTable = new DataTable();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
                dgvCategoryDashbord.DataSource = dataTable;
                sqlCon.Close();
            }
        }

        private void categoryDashbordLoad_Click(object sender, EventArgs e)
        {
            showCatogoryTable();
        }
    }
}
