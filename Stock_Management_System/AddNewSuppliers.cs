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
    public partial class AddNewSuppliers : Form
    {
        int id;
        string connectionString = @"Data Source=SURESH;Initial Catalog=Inventry_Management_System;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public AddNewSuppliers()
        {
            InitializeComponent();
        }

        private void AddNewSuppliers_Load(object sender, EventArgs e)
        {
            showSupplierDetails();
        }
        void showSupplierDetails()
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(connectionString);
                
                    using (sqlCon)
                    {
                        sqlCon.Open();
                        SqlCommand cmd = new SqlCommand("supplierDetailsAdd", sqlCon);
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT * FROM supplierDetails";
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);

                        dgvSupplier.DataSource = dt;
                        sqlCon.Close();
                    }
                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            addSupplierDetails();
            showSupplierDetails();
            Clear();
        }
        void addSupplierDetails()
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(connectionString);
                if (string.IsNullOrWhiteSpace(txtSupAddess.Text) || string.IsNullOrWhiteSpace(txtSupCom.Text) || string.IsNullOrWhiteSpace(txtSupCon.Text) || string.IsNullOrWhiteSpace(txtSupName.Text))
                {
                    MessageBox.Show("Please fill in all required fields before submitting.", "Validating Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Add New Supplier Successfully");
                    using (sqlCon)
                    {
                        sqlCon.Open();
                        SqlCommand cmd = new SqlCommand("supplierDetailsAdd", sqlCon);
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO supplierDetails VALUES('" + txtSupName.Text + "','" + txtSupCom.Text + "','" + txtSupAddess.Text + "','" + txtSupCon.Text + "')";
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        sqlCon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
            
        }
        

       private void dgvAddNewCustomer_click(object sender, DataGridViewCellEventArgs e)
       {
            
       }

        private void btnReset_click(object sender, EventArgs e)
        {
            Clear();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_click(object sender, EventArgs e)
        {
            DeleteSup();
            showSupplierDetails();
            
            
        }

        void DeleteSup()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string quary = "DELETE FROM supplierDetails WHERE supId ='" + id + "'";
                SqlCommand cmd = new SqlCommand(quary, sqlCon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Supplier delete suscessfully");
                sqlCon.Close();

            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void CellClick_click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvSupplier.Rows[e.RowIndex];
            id = Convert.ToInt32(row.Cells[0].Value);
        }

        void Clear()
        {
            txtSupAddess.Text = txtSupCom.Text = txtSupCon.Text = txtSupName.Text = ""; 
        }
    }
}
