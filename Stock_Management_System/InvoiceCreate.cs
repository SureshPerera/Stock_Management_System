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
    public partial class InvoiceCreate : Form
    {
        string connectionString = @"Data Source=SURESH;Initial Catalog=Inventry_Management_System;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        double totalSum = 0;
        double SetVat = 0;
        double setDiscount = 0;
        public InvoiceCreate()
        {
            InitializeComponent();
        }

        private void InvoiceCreate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventry_Management_SystemDataSet1.supplierDetails' table. You can move, or remove it, as needed.
            this.supplierDetailsTableAdapter.Fill(this.inventry_Management_SystemDataSet1.supplierDetails);
            // TODO: This line of code loads data into the 'inventry_Management_SystemDataSet.item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.inventry_Management_SystemDataSet.item);
            BindComboboxCustomer();
        }

        private void btnaddnewItem_Click(object sender, EventArgs e)
        {
            inventry inventry = new inventry();
            inventry.ShowDialog();
        }

        private void btnImgAddCustomer_Click(object sender, EventArgs e)
        {
            addNewCustomer addNewCustomer = new addNewCustomer();
            addNewCustomer.ShowDialog();
        }
        void BindComboboxCustomer()
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            using (sqlCon)
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("addCustomer", sqlCon);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT cusName FROM customerDetails";
                cmd.ExecuteNonQuery();
                DataTable dataTable = new DataTable();


                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                comboxBillTo.DataSource = dataTable;
                dataAdapter.Fill(dataTable);
                comboxBillTo.DisplayMember = "cusName";

                sqlCon.Close();
            }
        }



        private void dgvSaleInvoice_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            


            // Check if the updated column is Quantity
            if (dgvSaleInvoice.Columns[e.ColumnIndex].Name == "product_Qty" && e.RowIndex >= 0)
            {
                // Get the value of Quantity and Unit Price
                if (dgvSaleInvoice.Rows[e.RowIndex].Cells["product_Qty"].Value != null &&
                    dgvSaleInvoice.Rows[e.RowIndex].Cells["Item_Cost"].Value != null)
                {
                    try
                    {
                        var quantityCell = dgvSaleInvoice.Rows[e.RowIndex].Cells["product_Qty"];
                        var unitPriceCell = dgvSaleInvoice.Rows[e.RowIndex].Cells["Item_Cost"];

                        int quantity = Convert.ToInt32(dgvSaleInvoice.Rows[e.RowIndex].Cells["product_Qty"].Value);
                        decimal unitPrice = Convert.ToDecimal(dgvSaleInvoice.Rows[e.RowIndex].Cells["Item_Cost"].Value);

                        // Calculate Total Price
                        decimal totalPrice = quantity * unitPrice;

                        // Update Total Price cell
                        dgvSaleInvoice.Rows[e.RowIndex].Cells["total_price"].Value = totalPrice;

                        CalculateTotalPriceSum();




                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid input for Quantity. Please enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvSaleInvoice_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            // Check if the event is triggered by the ComboBox column
            if (dgvSaleInvoice.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && e.RowIndex >= 0)
            {
                string selectedProduct = dgvSaleInvoice.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                // Fetch product details from the database

                string query = "SELECT Item_Discription, Item_Cost FROM item WHERE Item_Name = @Item_Name";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Item_Name", selectedProduct);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Update other columns in the same row
                            dgvSaleInvoice.Rows[e.RowIndex].Cells["Item_Discription"].Value = reader["Item_Discription"].ToString();
                            dgvSaleInvoice.Rows[e.RowIndex].Cells["Item_Cost"].Value = reader["Item_Cost"].ToString();
                        }
                    }
                }


            }
        }

        void CalculateTotalPriceSum()
        {
            foreach (DataGridViewRow row in dgvSaleInvoice.Rows)
            {
                if (row.Cells["total_price"].Value != null &&
                    double.TryParse(row.Cells["total_price"].Value.ToString(), out double cellValue))
                {
                    totalSum += cellValue;
                }
            }

            txtTotalPrice.Text = totalSum.ToString();
        }

        void CalculateVat()
        {
            double GetVat = 0;

            if (double.TryParse(txtVat.Text, out GetVat))
            {
                GetVat += GetVat;
            }

            SetVat = totalSum * GetVat / 100;

            txtTaxShow.Text = SetVat.ToString();
        }

        void CalculateDiscount()
        {
            double GetDiscount ;
            if(double.TryParse(txtDiscountGet.Text, out GetDiscount))
            {
                GetDiscount += GetDiscount;
            }

            setDiscount = totalSum * GetDiscount / 100  ;
            txtDiscountShow.Text = setDiscount.ToString();
        }
        void TotalPriceWithTax()
        {
            double finalTotalPrice = 0;
            
            finalTotalPrice = totalSum - setDiscount + SetVat;

            txtTotalPriceWithTax.Text = finalTotalPrice.ToString();
        }

        private void txtVat_TextChanged(object sender, EventArgs e)
        {
            CalculateVat();
            TotalPriceWithTax();
        }

        private void txtDiscountGet_TextChanged(object sender, EventArgs e)
        {
            CalculateDiscount();
            TotalPriceWithTax();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateComboxCustomer();
            UpdateComboBoxData();
        }

        void UpdateComboxCustomer()
        {
            string query = "SELECT cusName FROM customerDetails"; // Adjust as needed

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                comboxBillTo.DataSource = dataTable;
                // Bind the DataGridViewComboBoxColumn


                comboxBillTo.DisplayMember = "cusName";
                comboxBillTo.ValueMember = "cusName";
            }
        }
        private void UpdateComboBoxData()
        {

            string query = "SELECT Item_Name FROM item"; // Adjust as needed

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind the DataGridViewComboBoxColumn
                DataGridViewComboBoxColumn comboBoxColumn = (DataGridViewComboBoxColumn)dgvSaleInvoice.Columns["Item_Name"]; // Adjust the column name
                comboBoxColumn.DataSource = dataTable;
                comboBoxColumn.DisplayMember = "Item_Name";
                comboBoxColumn.ValueMember = "Item_Name";
            }
        }
    }
}
