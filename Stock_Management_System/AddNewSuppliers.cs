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

                    dgvAddNewCustomer.DataSource = dt;
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
        }
        void addSupplierDetails()
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(connectionString);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
            
        }
        void delectSupplierDetails()
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(connectionString);
                using (sqlCon)
                {
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("supplierDetails", sqlCon);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM supplierDetails WHERE supId = '" + id + "'";
                    showSupplierDetails();
                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

       private void dgvAddNewCustomer_click(object sender, DataGridViewCellEventArgs e)
       {
            try
            {
               DataGridViewRow row = this.dgvAddNewCustomer.Rows[e.RowIndex];
               id = Convert.ToInt32(row.Cells[0].Value);

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       }

        private void btnReset_click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_click(object sender, EventArgs e)
        {

        }
    }
}
