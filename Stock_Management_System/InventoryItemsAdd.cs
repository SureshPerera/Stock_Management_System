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
    public partial class InventoryItemsAdd : Form
    {

        SqlConnection sqlcon = new SqlConnection(@"Data Source=SURESH;Initial Catalog=Inventry_Management_System;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        string connectionString = @"Data Source=SURESH;Initial Catalog=Inventry_Management_System;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        decimal totalSum = 0;
        decimal SetVat = 0;

        public InventoryItemsAdd()
        {
            InitializeComponent();
        }


        public class Product
        {
            public int ProductID { get; set; }
            //public string Product;
        }
        void BindComboboxVender()
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            using (sqlCon)
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("supplierDetailsAdd", sqlCon);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT supplier_Firm FROM supplierDetails";
                cmd.ExecuteNonQuery();
                DataTable dataTable = new DataTable();


                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                comboBoxVender.DataSource = dataTable;
                dataAdapter.Fill(dataTable);
                comboBoxVender.DisplayMember = "supplier_Firm";

                sqlCon.Close();
            }
        }

        private void InventoryItemsAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventry_Management_SystemDataSet1.supplierDetails' table. You can move, or remove it, as needed.
            this.supplierDetailsTableAdapter.Fill(this.inventry_Management_SystemDataSet1.supplierDetails);
            // TODO: This line of code loads data into the 'inventry_Management_SystemDataSet.item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.inventry_Management_SystemDataSet.item);
            dgvPurchaseList.CellValueChanged += dgvPurchaseList_CellValueChanged;
            BindComboboxVender();

        }

        private void btnaddnewItem_Click(object sender, EventArgs e)
        {

            inventry inventry = new inventry();
            inventry.ShowDialog(this);
        }

        private void dgvPurchaseList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the event is triggered by the ComboBox column
            if (dgvPurchaseList.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && e.RowIndex >= 0)
            {
                string selectedProduct = dgvPurchaseList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

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
                            dgvPurchaseList.Rows[e.RowIndex].Cells["Item_Discription"].Value = reader["Item_Discription"].ToString();
                            dgvPurchaseList.Rows[e.RowIndex].Cells["Item_Cost"].Value = reader["Item_Cost"].ToString();
                        }
                    }
                }


            }

        }

        void CalculateTotalPriceSum()
        {
            foreach (DataGridViewRow row in dgvPurchaseList.Rows)
            {
                if (row.Cells["total_price"].Value != null &&
                    decimal.TryParse(row.Cells["total_price"].Value.ToString(), out decimal cellValue))
                {
                    totalSum += cellValue;
                }
            }

            txtTotalPrice.Text = totalSum.ToString();
        }

        private void dgvPurchaseList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the updated column is Quantity
            if (dgvPurchaseList.Columns[e.ColumnIndex].Name == "product_Qty" && e.RowIndex >= 0)
            {
                // Get the value of Quantity and Unit Price
                if (dgvPurchaseList.Rows[e.RowIndex].Cells["product_Qty"].Value != null &&
                    dgvPurchaseList.Rows[e.RowIndex].Cells["Item_Cost"].Value != null)
                {
                    try
                    {
                        var quantityCell = dgvPurchaseList.Rows[e.RowIndex].Cells["product_Qty"];
                        var unitPriceCell = dgvPurchaseList.Rows[e.RowIndex].Cells["Item_Cost"];

                        int quantity = Convert.ToInt32(dgvPurchaseList.Rows[e.RowIndex].Cells["product_Qty"].Value);
                        decimal unitPrice = Convert.ToDecimal(dgvPurchaseList.Rows[e.RowIndex].Cells["Item_Cost"].Value);

                        // Calculate Total Price
                        decimal totalPrice = quantity * unitPrice;

                        // Update Total Price cell
                        dgvPurchaseList.Rows[e.RowIndex].Cells["total_price"].Value = totalPrice;


                        CalculateTotalPriceSum();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid input for Quantity. Please enter a numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        void CalculateVat()
        {
            decimal GetVat = 0;

            if (decimal.TryParse(txtGetTax.Text, out GetVat))
            {
                GetVat += GetVat;
            }

            SetVat = totalSum * GetVat / 100;

            txtSetTax.Text = SetVat.ToString();
        }

        void TotalPriceWithTax()
        {
            decimal finalTotalPrice = 0;

            finalTotalPrice = totalSum + SetVat;

            txtTotalPriceWithTax.Text = finalTotalPrice.ToString();
        }

        private void txtGetTax_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateVat();
            TotalPriceWithTax();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        void ResetAll()
        {
            dgvPurchaseList.Rows.Clear();
            comboBoxVender.SelectedIndex = -1;


            txtSetTax.Text = "";

            txtInvoNumber.Text = txtGetTax.Text = txtTotalPrice.Text = txtTotalPriceWithTax.Text = "";
           

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateComboBoxData();
            UpdateComboxVender();
        }

        void UpdateComboxVender()
        {
            string query = "SELECT supplier_Firm FROM supplierDetails"; // Adjust as needed

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                comboBoxVender.DataSource = dataTable;
                // Bind the DataGridViewComboBoxColumn


                comboBoxVender.DisplayMember = "supplier_Firm";
                comboBoxVender.ValueMember = "supplier_Firm";
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
                DataGridViewComboBoxColumn comboBoxColumn = (DataGridViewComboBoxColumn)dgvPurchaseList.Columns["Product_name"]; // Adjust the column name
                comboBoxColumn.DataSource = dataTable;
                comboBoxColumn.DisplayMember = "Item_Name";
                comboBoxColumn.ValueMember = "Item_Name";
            }
        }

        private void btnImgAddSuppliers_Click(object sender, EventArgs e)
        {
            AddNewSuppliers addNewSuppliers = new AddNewSuppliers();
            addNewSuppliers.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtInvoNumber.Text == "" && comboBoxVender.Text == ""  && txtGetTax.Text == "" && txtPurchaceDate.Text == "" && txtExpireDate.Text == "")
            {
                MessageBox.Show("Please Fill Relavent Filds!");
            }
            else
            {
                MessageBox.Show("Succsfully Added Inventory");
            }
        }
    }
}
