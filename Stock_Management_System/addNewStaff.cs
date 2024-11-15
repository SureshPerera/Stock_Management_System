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
    public partial class addNewStaff : Form
    {
        string connectionString = @"Data Source=SURESH;Initial Catalog=Inventry_Management_System;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        int id;

        public addNewStaff()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void addNewStaff_Load(object sender, EventArgs e)
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
                    dgvAddNewStaff.DataSource = dataTable;
                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStAdd_click(object sender, EventArgs e)
        {
            AddNewStaff();
            showStaffTable();
            Clear();

        }

        void AddNewStaff()
        {
            SqlConnection sqlCon1 = new SqlConnection(connectionString);
            if (string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtContact.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtFname.Text) || string.IsNullOrWhiteSpace(txtLname.Text) || string.IsNullOrWhiteSpace(txtNic.Text))
            {
                MessageBox.Show("Please fill in all required fields before submitting.", "Validating Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                MessageBox.Show("Add New Customer Successfully");
                using (sqlCon1)
                {
                    sqlCon1.Open();
                    SqlCommand cmd = new SqlCommand("addStaff", sqlCon1);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@stFirstName", txtFname.Text);
                    cmd.Parameters.AddWithValue("@stLastName", txtLname.Text);
                    cmd.Parameters.AddWithValue("@stNIC", txtNic.Text);
                    cmd.Parameters.AddWithValue("@stAddress", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@stContact", txtContact.Text);
                    cmd.Parameters.AddWithValue("@stEmail", txtEmail.Text);

                    DataTable dt = new DataTable();



                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    sqlCon1.Close();
                }

            }
        }

        void Clear()
        {
            txtAddress.Text = txtContact.Text = txtEmail.Text = txtFname.Text = txtLname.Text = txtNic.Text = "";
        }

        private void btnStDelect_click(object sender, EventArgs e)
        {
            DeleteStaff();
            showStaffTable();
        }

        void DeleteStaff()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string quary = "DELETE FROM staffDetails WHERE stId ='" + id + "'";
                SqlCommand cmd = new SqlCommand(quary, sqlCon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff Member delete suscessfully");
                sqlCon.Close();

            }
        }

        private void CellClick_click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvAddNewStaff.Rows[e.RowIndex];
            id = Convert.ToInt32(row.Cells[0].Value);
        }

        private void btnStReset_click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
