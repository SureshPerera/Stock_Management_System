﻿using System;
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
    public partial class customerDashbord : Form
    {
        string connectionString = @"Data Source=SURESH;Initial Catalog=Inventry_Management_System;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public customerDashbord()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            addNewCustomer addnew = new addNewCustomer();
            addnew.ShowDialog();
        }

        private void btnaddnewItem_Click(object sender, EventArgs e)
        {
            inventry inventory = new inventry();
            inventory.ShowDialog();
        }

        private void customerDashbordload_click(object sender, EventArgs e)
        {
            updateCustomerDetailDGV();
        }

        void updateCustomerDetailDGV()
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
                    dgvCustomerDetails.DataSource = dataTable;
                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvCustomerDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            updateCustomerDetailDGV();
        }
    }
}
