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
    public partial class inventry : Form
    {
        string sqlConnection = @"Data Source=SURESH;Initial Catalog=Inventry_Management_System;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        int id;
        public inventry()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void inventry_Load(object sender, EventArgs e)
        {
            Clear();
            showSqlInventryTable();
           
        }
        
        void showSqlInventryTable()
        {
            dataGridView1.DataSource = null;

            SqlConnection sqlCon = new SqlConnection(sqlConnection);
            using (sqlCon)
            {
                sqlCon.Open();
                SqlCommand selectcmd = new SqlCommand("SELECT * FROM item", sqlCon);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(selectcmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlCon.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Clickj(object sender, EventArgs e)
        {

        }

        
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon1 = new SqlConnection(sqlConnection);
            if (string.IsNullOrWhiteSpace(txtItemCode.Text) || string.IsNullOrWhiteSpace(txtItemDiscription.Text) || string.IsNullOrWhiteSpace(txtItemName.Text) || string.IsNullOrWhiteSpace(txtSellingPrice.Text))
            {
                MessageBox.Show("Please fill in all required fields before submitting.", "Validating Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                MessageBox.Show("Add New Item Successfully");
                using (sqlCon1)
                {
                    sqlCon1.Open();
                    SqlCommand cmd = new SqlCommand("addNewItem", sqlCon1);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Item_Code", txtItemCode.Text);
                    cmd.Parameters.AddWithValue("@Item_Name", txtItemName.Text);
                    cmd.Parameters.AddWithValue("@Item_Discription", txtItemDiscription.Text);
                    cmd.Parameters.AddWithValue("@Item_Cost", txtCost.Text);
                    cmd.Parameters.AddWithValue("@Item_Selling_Price", txtSellingPrice.Text);

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
                    showSqlInventryTable();
                    sqlCon1.Close();
                }
                Clear();
            }
            
            //showSqlInventryTable();
        }

        void Clear()
        {
            txtItemCode.Text = txtCost.Text = txtItemDiscription.Text = txtItemName.Text = txtSellingPrice.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(sqlConnection))
            {
                sqlCon.Open();
                string quary = "DELETE FROM item WHERE Item_Id ='" + id+"'";
                SqlCommand cmd = new SqlCommand(quary,sqlCon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item delete suscessfully");
                sqlCon.Close();
                showSqlInventryTable();
            }
        }

        private void gridviewcellclick_Click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            id = Convert.ToInt32(row.Cells[0].Value);

        }
    }
}
