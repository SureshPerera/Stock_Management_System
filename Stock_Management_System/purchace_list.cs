using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
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
        public purchace_list()
        {
            InitializeComponent();
            GetSupplierName();
            Console.WriteLine("asdasda");
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
                cmd.CommandText = "SELECT * FROM item WHERE Item_Discription = '" + Product_discriptions + "' and Item_Selling_price = '" + unit_price + "'";
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
    }
}
