using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Stock_Management_System
{
    public partial class purchace_list : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=SURESH;Initial Catalog=Inventry_Management_System;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        string connectionString = @"Data Source=SURESH;Initial Catalog=Inventry_Management_System;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        decimal totalSum = 0;
        decimal SetVat = 0;
        public purchace_list()
        {
            InitializeComponent();
            GetSupplierName();
           
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void dgvPurchaseList_cellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //fill_itemDiscription();

        }

        //public void fillPopulateProductComboBox()
        //{
        //    
        //
        //    dgvPurchaseList.CellValueChanged += dgvPurchaseList_CellValueChanged;
        //    dgvPurchaseList.CellValueChanged += dgvPurchaseList_EditingControlShowing;
        //}

        // public void dgvPurchaseList_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        // {
        //     if (dgvPurchaseList.CurrentCell.ColumnIndex == 0)
        //     {
        //         ComboBox comboBox = e.Control as ComboBox;
        //         if (comboBox != null)
        //         {
        //             comboBox.SelectedIndexChanged -= new EventHandler(ComboBox_SelectIndexChange);
        //             comboBox.SelectedIndexChanged += new EventHandler(ComboBox_SelectIndexChange);
        //
        //         }
        //     }
        // }
        //public void ComboBox_SelectIndexChange(object sender,EventArgs e)
        //{
        //    ComboBox comboBox = sender as ComboBox;
        //    if (comboBox != null)
        //    {
        //        string selectedProduct = comboBox.Text;
        //        var productDetails = GetProductDetails();
        //
        //        DataGridViewRow currentRow = dgvPurchaseList.CurrentRow;
        //        currentRow.Cells["Item_Discription"].Value = productDetails.Discription;
        //        currentRow.Cells["Item_Cost"].Value = productDetails.Unit_price;
        //        
        //
        //    }
        //}
        //

        public void GetProductDetails(string Pname)
        {
            Product product = null;
            using (sqlcon)
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM item WHERE Item_Discription = '" + Item_Discription + "' and Item_Selling_price = '" + Item_Cost + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                sqlcon.Close();
            }
        }
        public void GetSupplierName()
        {
            using (sqlcon)
            {
                sqlcon.Open();
                SqlCommand cmd = sqlcon.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM supplierDetails WHERE supplier_Name = '" + comboBoxVender + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                sqlcon.Close();
            }

        }
        public class Product
        {
            public int ProductID { get; set; }
            //public string Product;
        }
        private void purchace_list_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventry_Management_SystemDataSet1.supplierDetails' table. You can move, or remove it, as needed.
            this.supplierDetailsTableAdapter.Fill(this.inventry_Management_SystemDataSet1.supplierDetails);
            // TODO: This line of code loads data into the 'inventry_Management_SystemDataSet.item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.inventry_Management_SystemDataSet.item);
            BindComboboxVender();
            dgvPurchaseList.CellValueChanged += DgvCellValueChange_Click;

          
            
           
           
           

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
        private void btnaddnewItem_Click(object sender, EventArgs e)
        {
            inventry inventry = new inventry();
            inventry.ShowDialog(this);
        }

        private void dgvPurchaseList_cellleave(object sender, DataGridViewCellEventArgs e)
        {
            //fill_itemDiscription();
        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel12_Click(object sender, EventArgs e)
        {
            var a = comboBoxVender.DisplayMember = "Item_name";
            var b = comboBoxVender.DataSource = itemBindingSource;

            comboBoxVender.DisplayMember = a + b;

        }

        private void comboBoxVender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DgvCellValueChange_Click(object sender, DataGridViewCellEventArgs e)
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
        private void dgvCellEndEdit_click(object sender, DataGridViewCellEventArgs e)
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

            if (decimal.TryParse(comboxTax.Text, out GetVat))
            {
                GetVat += GetVat;
            }

            SetVat = totalSum * GetVat / 100;

            txtTax.Text = SetVat.ToString();
        }

        void TotalPriceWithTax()
        {
            decimal finalTotalPrice = 0;

            finalTotalPrice = totalSum + SetVat;

            txtTotalPriceWithTax.Text = finalTotalPrice.ToString();
        }


        private void txtChange_click(object sender, EventArgs e)
        {

        }

        private void comboxTax_SelectedIndexChanged(object sender, EventArgs e)
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

            comboxPurchacetype.SelectedIndex = -1;
            comboxTax.SelectedIndex = 0;
            
            txtPoNumber.Text = txtTax.Text = txtTotalPrice.Text = txtTotalPriceWithTax.Text = "";
            comBoxDeliver.SelectedIndex = -1;

        }

        private void btnRefresh_click(object sender, EventArgs e)
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

        public void AskAndPrintInvoice()
        {
            DialogResult result = MessageBox.Show("Do you want to print the Purchase Order Invoice?", "Print Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Printed Invoice Successfully");

                createHTML();

            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Successfully Saved Invoice");
            }

        }

        void createHTML()
        {
            string htmlCss = @"
            <style>
                          html{
                padding: 0;
                margin: 0;
            }

            .contacin1{
                display: flex;
                flex-wrap: wrap;
                justify-content: center;
            }
            .contacin2{
                height: 40rem;
                width: 40rem;
                border: 2px solid black;
                background-color: beige;

            }
            h2{
                font-family: 'Courier New', Courier, monospace;
                font-size: 25px;
                font-weight: bold;
                text-align: center;

            }

            
            .detals{
                font-size: 18px;
                margin-left: 1rem;
            }

            .final{
                font-size: 18px;
                margin-left: 25rem;  
                margin-top: 16rem;
            }

            table{
                border: 1px solid black;
                border-collapse: collapse;
                width: 100%;
                height: 2rem;
                grid-row: inherit;
                grid-column: auto;
            }  

               </style>         
                        "
            ;


            string htmlContent = $@"
                <html>
                <head>
                {htmlCss}
                </head>
                <body>
                        <div class=""contain1"">
                            <div class=""contacin2"">
                                <h2>ABC PVT LTD PURCHASE INVOICE</h2>
                                <br>
                                <div class=""detals"">
                                    <label for="""">Vender </label><label style=""color: darkblue; font-weight: bold; margin-left: 4rem;"" for="""">: {comboBoxVender.Text}</label>
                                <br>
                                <label for="""">PO Number</label><label style=""color: darkblue; font-weight: bold; margin-left: 2rem"" for="""">: {txtPoNumber.Text}</label>
                                <br>
                                <label for="""">Purchase Date</label><label style=""color: darkblue; font-weight: bold; margin-left:1rem"" for="""">: {purchDate.Value}</label>
                                <br>
                                <label for="""">Payoment Type</label><label style=""color: darkblue; font-weight: bold;margin-left: 10px"" for="""">: {comboxPurchacetype.Text}</label>
                                <br>
                                <label for="""">Deliver TO</label>  <label style=""color: darkblue; font-weight: bold;margin-left: 2.3rem"" for="""">: {comBoxDeliver.Text}</label>  

                                </div>
                
                                <br>
                                <table>
                                    <tr>
                                        <td> Product Name </td>
                                        <td> Product Discription </td>
                                        <td> Product Qty </td>
                                        <td> Unit Price </td>
                                        <td> Total Price </td>
                                    </tr>
                   
                    
                                </table>
                                <br>
                               <div class=""final"">
                                <label style=""margin-left: -24rem;"" for="""">Tax  </label><label style=""color: darkblue; font-weight: bold; margin-left: 3.2rem"" for="""">: {comboxTax.Text}%</label> 
                                <br>
                               
                                    <label for="""">SubTotal  </label><label style=""color: darkblue; font-weight: bold;margin-left: 12px"" for="""">: {txtTotalPrice.Text}</label> 
                                    <br>
                                    <label for="""">Tax  </label><label style=""color: darkblue; font-weight: bold;margin-left: 3.1rem"" for="""">: {txtTax.Text}</label> 
                                    <br>
                                    
                                    <label for="""">Total Price </label><label style=""color: darkblue; font-weight: bold; margin-left: -0.1rem"" for="""">: {txtTotalPriceWithTax.Text}</label> 
                                    <br>
                                </div>

                            </div>
                        </div>
                </body>
                </html>

                ";

            string filePath = Path.Combine(Environment.CurrentDirectory, "invoiceHTML.html");
            File.WriteAllText(filePath, htmlContent);

            var process = new System.Diagnostics.Process
            {
                StartInfo = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "invoiceHTML.html",
                    UseShellExecute = true
                }
            };
            process.Start();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtPoNumber.Text == "" || comboBoxVender.Text == "" || comBoxDeliver.Text == "" || comboxPurchacetype.Text == "" || txtTax.Text == "" || purchDate.Text == "")
            {
                MessageBox.Show("Please Fill Relavent Filds!", "REMENDING!", MessageBoxButtons.OK);
                
            }
            else
            {
                AskAndPrintInvoice();
            }

           


        }

        private void txtTotalPriceWithTax_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
