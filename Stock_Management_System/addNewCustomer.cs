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
    public partial class addNewCustomer : Form
    {
        string connectionString = @"Data Source=SURESH;Initial Catalog=Inventry_Management_System;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        int id;

        public addNewCustomer()
        {
            InitializeComponent();
        }

        private void addNewCustomer_Load(object sender, EventArgs e)
        {
            showCustomerTable();
        }
        public void showCustomerTable()
        {
            try
            {

                SqlConnection sqlCon = new SqlConnection(connectionString);
                using (sqlCon)
                {
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("addCustomer", sqlCon);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM customerDetails";
                    cmd.ExecuteNonQuery();
                    DataTable dataTable = new DataTable();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    dataAdapter.Fill(dataTable);
                    dgvAddNewCus.DataSource = dataTable;
                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCus_click(object sender, EventArgs e)
        {
            AddNew();
            showCustomerTable();
            Clear();
        }

        void AddNew()
        {
            SqlConnection sqlCon1 = new SqlConnection(connectionString);
            if (string.IsNullOrWhiteSpace(txtCusName.Text) || string.IsNullOrWhiteSpace(txtCusAddress.Text) || string.IsNullOrWhiteSpace(txtCusEmail.Text) || string.IsNullOrWhiteSpace(txtCusContact.Text))
            {
                MessageBox.Show("Please fill in all required fields before submitting.", "Validating Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                MessageBox.Show("Add New Customer Successfully");
                using (sqlCon1)
                {
                    sqlCon1.Open();
                    SqlCommand cmd = new SqlCommand("addCustomer", sqlCon1);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cusName", txtCusName.Text);
                    cmd.Parameters.AddWithValue("@cusContact", txtCusContact.Text);
                    cmd.Parameters.AddWithValue("@cusEmail", txtCusEmail.Text);
                    cmd.Parameters.AddWithValue("@cusAddress", txtCusAddress.Text);
                    cmd.Parameters.AddWithValue("@cusTin", txtCusTin.Text);

                    DataTable dt = new DataTable();



                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    
                    sqlCon1.Close();
                }

            }
        }

        void Clear()
        {
            txtCusName.Text = txtCusAddress.Text = txtCusContact.Text = txtCusEmail.Text = txtCusTin.Text = "";
        }

        private void btnDeleteCus_click(object sender, EventArgs e)
        {
            DeleteCus();
            showCustomerTable();
            Clear();
        }

        void DeleteCus()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string quary = "DELETE FROM customerDetails WHERE cusId ='" + id + "'";
                SqlCommand cmd = new SqlCommand(quary, sqlCon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer delete suscessfully");
                sqlCon.Close();

            }
        }

        private void CellClick_click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvAddNewCus.Rows[e.RowIndex];
            id = Convert.ToInt32(row.Cells[0].Value);
        }

        private void btnResetCus_click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
