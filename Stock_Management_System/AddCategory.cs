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
    public partial class AddCategory : Form
    {
        string connectionString = @"Data Source=SURESH;Initial Catalog=Inventry_Management_System;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        int id;

        public AddCategory()
        {
            InitializeComponent();
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            showcategoryTable();
        }

        public void showcategoryTable()
        {
            try
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
                    dgvAddNewCatogory.DataSource = dataTable;
                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnaddCat_click(object sender, EventArgs e)
        {
            addNew();
            clear();
        }
        

        void addNew()
        {
            SqlConnection sqlCon1 = new SqlConnection(connectionString);
            if (string.IsNullOrWhiteSpace(txtCatId.Text) || string.IsNullOrWhiteSpace(txtCatName.Text) || string.IsNullOrWhiteSpace(txtCatDiscription.Text))
            {
                MessageBox.Show("Please fill in all required fields before submitting.", "Validating Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                MessageBox.Show("Add New Category Successfully");
                using (sqlCon1)
                {
                    sqlCon1.Open();
                    SqlCommand cmd = new SqlCommand("addCategory", sqlCon1);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@catId", txtCatId.Text);
                    cmd.Parameters.AddWithValue("@catName", txtCatName.Text);
                    cmd.Parameters.AddWithValue("@catDiscription", txtCatDiscription.Text);
                   

                    //int i = cmd.ExecuteNonQuery();
                    //if (i != 0)
                    //{
                    //    MessageBox.Show("New Item Added");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Error");
                    //}
                    DataTable dt = new DataTable();



                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    showcategoryTable();
                    sqlCon1.Close();
                }
                
            }
        }

        void clear()
        {
            txtCatId.Text = txtCatName.Text = txtCatDiscription.Text = "";
        }

        private void btnDeleteCat_click(object sender, EventArgs e)
        {
            deleteCat();
            showcategoryTable();
        }

        void deleteCat()
        {
            using(SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string quary = "DELETE FROM Categories WHERE catId ='" + id + "'";
                SqlCommand cmd = new SqlCommand(quary, sqlCon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item delete suscessfully");
                sqlCon.Close();
                
            }
        }

        private void gridViwe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dgvAddNewCatogory.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells[0].Value);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnClearCat_click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
