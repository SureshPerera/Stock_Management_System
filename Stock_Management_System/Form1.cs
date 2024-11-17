using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management_System
{
    public partial class Form1 : Form
    {
        double totalSale, revenue, saleCost, profit, noOfPurchase, purchaseCost, canselOrder, returns, quntityInHand, willBeRecived, lowStockItems, itemGroup, noOfItem, totalCustomer, totalSupplier;
        page2 page2 = new page2();
        string connectionString = @"Data Source=SURESH;Initial Catalog=Inventry_Management_System;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        bool a;
        bool b;
        bool c;

        inventry inventry = new inventry();



        public Form1()
        {
            InitializeComponent();
           
        }

        public void btnPage2_Click(object sender, EventArgs e)
        {
            page2 page2 = new page2();
            Form1 form1 = new Form1();

            page2.Show();
            this.Hide();
            
            page2.FormClosed += (s, args) => this.Close();
        }

        private void btnPage1_Click(object sender, EventArgs e)
        {
            page1 page1 = new page1();
            Form1 form1 = new Form1();

            page1.Show();
            this.Hide();
            page1.FormClosed += (s, args) => this.Close();
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            btnBills.Enabled = false;
            btnSales.Enabled = false;
            
            
           btnDashbord_Click(sender, e);
           btnDashbord.Select();
            btnDashbord.Focus();

            pnlsaleOverview.Visible = false;
            pnlpurchasOverview.Visible = false;
            pnlInventorySummary.Visible = false;
            pnlNoOfUsers.Visible = false;
            pnlsaleOverview.Visible = false;
            pnlProductDetailes.Visible = false;

            //no of item update 

            string noOfItemquary = "SELECT SUM(CAST(Item_Code AS DECIMAL(10,2))) AS total FROM item WHERE ISNUMERIC(Item_Code) = 1";
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(noOfItemquary, sqlCon);
                object result = cmd.ExecuteNonQuery();

              
                if (result != DBNull.Value)
                {
                    decimal TotalNumOfItem = Convert.ToDecimal(result);
                    txtNoOfItems.Text = TotalNumOfItem.ToString();              
                }
                else
                {
                    txtNoOfItems.Text = "0";
                }
            }
            pressDashbordbtn();
            selectloging();
        }

        void selectloging()
        {
            pnlUser.Visible = false;

            pnladmin.Location = new Point(890, 10);
        }
       
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnImageSearch_Click(object sender, EventArgs e)
        {
            
            txtSearch.Text = "";
        }

        //button click
        private void btnDashbord_Click(object sender, EventArgs e)
        {
            try
            {
                bool a = true;
                bool b = false;

                //page2.Hide();

                //update data

                    pressDashbordbtn();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void pressDashbordbtn()
        {
            
                txtmainSection.Text = "Main Dashbord";
                pictureboxMainSection.Image = imgbtnDashbord.Image;
                pnlsaleOverview.Show();
                pnlpurchasOverview.Show();
                pnlNoOfUsers.Show();
                pnlProductDetailes.Show();
                pnlInventorySummary.Show();

                SelectButton(btnDashbord);
                SelectButtonClear(btnInventory);
                SelectButtonClear(btnBills);
                SelectButtonClear(btnSales);
                SelectButtonClear(btnPurchase);
                SelectButtonClear(btnSuppliers);
                SelectButtonClear(btnCustomers);
                SelectButtonClear(btnStaff);
                SelectButtonClear(btnInvoice);
                pnlmain.Hide();

                //sale overview
                txtTotalSale.Text = totalSale.ToString("Rs" + "250000");
             
                txtSaleCost.Text = saleCost.ToString("Rs" + "100000");
                txtRevenue.Text = revenue.ToString("Rs" + "500000");
                txtProfit.Text = profit.ToString("Rs" + "200000");
                //purchase overview
                txtNOPurchase.Text = noOfPurchase.ToString("200");
                txtCancelOrder.Text = canselOrder.ToString("20");
                txtPurchaseCost.Text = purchaseCost.ToString("Rs" + "20000");
                txtReturn.Text = returns.ToString("12");
                //inventoty summury
                txtQuantityInHand.Text = quntityInHand.ToString("470");
                txtWillbereceived.Text = willBeRecived.ToString("120");

                //product details
                txtLowStockItems.Text = lowStockItems.ToString("20");
                txtItemGroup.Text = itemGroup.ToString("15");
                //txtNoOfItems.Text = noOfItem.ToString();

                //No Of Users
                txtTotalCustomer.Text = totalCustomer.ToString("1.8K");
                txtSuppliers.Text = totalSupplier.ToString("30");

                
                inventry.Hide();
        }

        void changelist()
        {
            btnBills.Location = new System.Drawing.Point(92, 235);
        }
        public void btnInventory_Click(object sender, EventArgs e)
        {
            try
            { 
                    pressInventrybtn();

                //page2.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void pressInventrybtn()
        {
          
                pnlsaleOverview.Hide();
                pnlpurchasOverview.Hide();
                pnlNoOfUsers.Hide();
                pnlProductDetailes.Hide();
                pnlInventorySummary.Hide();
                btnImgPurchaseOrder.Hide();
                
                //pnlmain.Show();
                //btnImgPurchaseOrder.Hide();
                //btnImgAddUsers.Show();
                //btnImgAddUsers.Location = new Point(16, 14);

                txtmainSection.Text = "Inventory Dashbord";
                pictureboxMainSection.Image = imgbtnInventory.Image;
                SelectButton(btnInventory);
                SelectButtonClear(btnDashbord);
                SelectButtonClear(btnBills);
                SelectButtonClear(btnSales);
                SelectButtonClear(btnPurchase);
                SelectButtonClear(btnSuppliers);
                SelectButtonClear(btnCustomers);
                SelectButtonClear(btnStaff);
                SelectButtonClear(btnInvoice);
                SelectButtonClear(btnCategory);
                
                inventryDashbord inventryDashbord = new inventryDashbord();
                inventryDashbord.ShowDialog();
            
              

        }

        void pressCategorybtn()
        {

            pnlsaleOverview.Hide();
            pnlpurchasOverview.Hide();
            pnlNoOfUsers.Hide();
            pnlProductDetailes.Hide();
            pnlInventorySummary.Hide();
            btnImgPurchaseOrder.Hide();

            txtmainSection.Text = "Item Category Dashbord";
            pictureboxMainSection.Image =  btnCategoryImg.Image;
            SelectButton(btnCategory);
            SelectButtonClear(btnInventory);
            SelectButtonClear(btnDashbord);
            SelectButtonClear(btnBills);
            SelectButtonClear(btnSales);
            SelectButtonClear(btnPurchase);
            SelectButtonClear(btnSuppliers);
            SelectButtonClear(btnCustomers);
            SelectButtonClear(btnStaff);
            SelectButtonClear(btnInvoice);

            categoryDashbord category = new categoryDashbord();
            category.ShowDialog();

        }
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                pnlsaleOverview.Hide();
                pnlpurchasOverview.Hide();
                pnlNoOfUsers.Hide();
                pnlProductDetailes.Hide();
                pnlInventorySummary.Hide();
                
                //pnlmain.Show();
                //btnaddnewItem.Hide();
                //btnImgPurchaseOrder.Show();
                //btnImgPurchaseOrder.Location = new Point(16, 14);

                txtmainSection.Text = "Purchase Dashbord";
                pictureboxMainSection.Image = imgbtnPurchase.Image;
                SelectButton(btnPurchase);
                SelectButtonClear(btnDashbord);
                SelectButtonClear(btnInventory);
                SelectButtonClear(btnBills);
                SelectButtonClear(btnInvoice);
                SelectButtonClear(btnCategory);
                SelectButtonClear(btnSales);
                
                SelectButtonClear(btnSuppliers);
                SelectButtonClear(btnCustomers);
                SelectButtonClear(btnStaff);

                purchace_list purchace_List = new purchace_list();
                purchace_List.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSupReturn_Click(object sender, EventArgs e)
        {
            try
            {
                pnlsaleOverview.Hide();
                pnlpurchasOverview.Hide();
                pnlNoOfUsers.Hide();
                pnlProductDetailes.Hide();
                pnlInventorySummary.Hide();

                txtmainSection.Text = "Staff Dashbord";
                pictureboxMainSection.Image = imgbtnSupReturn.Image;
                SelectButton(btnStaff);
                SelectButtonClear(btnDashbord);
                SelectButtonClear(btnBills);
                SelectButtonClear(btnInventory);
                SelectButtonClear(btnSales);
                SelectButtonClear(btnPurchase);
                SelectButtonClear(btnSuppliers);
                SelectButtonClear(btnCustomers);
                SelectButtonClear(btnInvoice);
                SelectButtonClear(btnCategory);

                staffDetails sd = new staffDetails();
                sd.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                pnlsaleOverview.Hide();
                pnlpurchasOverview.Hide();
                pnlNoOfUsers.Hide();
                pnlProductDetailes.Hide();
                pnlInventorySummary.Hide();

                txtmainSection.Text = "Invoice Dashbord";
                pictureboxMainSection.Image = imgbtnInvoice.Image;
                SelectButton(btnInvoice);
                SelectButtonClear(btnDashbord);
                SelectButtonClear(btnBills);
                SelectButtonClear(btnInventory);
                SelectButtonClear(btnSales);
                SelectButtonClear(btnPurchase);
                SelectButtonClear(btnSuppliers);
                SelectButtonClear(btnCustomers);
                SelectButtonClear(btnStaff);
                SelectButtonClear(btnCategory);

                InvoiceCreate invoiceCreate = new InvoiceCreate();
                invoiceCreate.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            try
            {
                pnlsaleOverview.Hide();
                pnlpurchasOverview.Hide();
                pnlNoOfUsers.Hide();
                pnlProductDetailes.Hide();
                pnlInventorySummary.Hide();

                txtmainSection.Text = "Sales Dashbord";
                pictureboxMainSection.Image = imgbtnSales.Image;
                SelectButton(btnSales);
                SelectButtonClear(btnDashbord);
                SelectButtonClear(btnInventory);
                SelectButtonClear(btnBills);
                SelectButtonClear(btnInvoice);
                SelectButtonClear(btnPurchase);
                SelectButtonClear(btnSuppliers);
                SelectButtonClear(btnCustomers);
                SelectButtonClear(btnStaff);
                SelectButtonClear(btnCategory);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            try
            {
                pnlsaleOverview.Hide();
                pnlpurchasOverview.Hide();
                pnlNoOfUsers.Hide();
                pnlProductDetailes.Hide();
                pnlInventorySummary.Hide();

                txtmainSection.Text = "Bills Dashbord";
                pictureboxMainSection.Image = imgbtnBills.Image;
                SelectButton(btnBills);
                SelectButtonClear(btnDashbord);
                SelectButtonClear(btnInventory);
                SelectButtonClear(btnSales);
                SelectButtonClear(btnInvoice);
                SelectButtonClear(btnPurchase);
                SelectButtonClear(btnSuppliers);
                SelectButtonClear(btnCustomers);
                SelectButtonClear(btnStaff);
                SelectButtonClear(btnCategory);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnImgAddUsers_Click(object sender, EventArgs e)
        {
            UserSingUp userSingUp = new UserSingUp();
            userSingUp.ShowDialog();
        }

        private void btnaddnewItem_click(object sender, EventArgs e)
        {
            inventry.ShowDialog();
        }

        private void txtNoOfItems_Click(object sender, EventArgs e)
        {
           
        }

        private void btnImgPurchaseOrder_click(object sender, EventArgs e)
        {
            purchace_list purchace_List = new purchace_list();
            purchace_List.ShowDialog();

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnCategory_click(object sender, EventArgs e)
        {
            try
            {
                pressCategorybtn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picBoxTsale_hover(object sender, EventArgs e)
        {
        }

        private void picBoxTsale_enter(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel23_Click(object sender, EventArgs e)
        {

        }

        private void imgbtnDashbord_Click(object sender, EventArgs e)
        {

            try
            {
               btnDashbord_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void SelectButton(Guna2Button SelectButton)
        {
            SelectButton.FillColor = Color.DeepSkyBlue;
            SelectButton.BorderThickness = 2;
            SelectButton.BorderColor = Color.Blue;
            SelectButton.ForeColor = Color.FloralWhite;
            SelectButton.BorderRadius = 10;
            
        }
        void SelectButtonClear(Guna2Button UnselectButton)
        {
            UnselectButton.FillColor = Color.Transparent;
            UnselectButton.BorderThickness = 0;
            UnselectButton.ForeColor = Color.Black;
            UnselectButton.BorderColor = Color.Transparent;
            
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                pnlsaleOverview.Hide();
                pnlpurchasOverview.Hide();
                pnlNoOfUsers.Hide();
                pnlProductDetailes.Hide();
                pnlInventorySummary.Hide();
                

                txtmainSection.Text = "Customer Dashbord";
                pictureboxMainSection.Image = imgbtnPurchase.Image;
                SelectButton(btnCustomers);
                SelectButtonClear(btnInventory);
                SelectButtonClear(btnDashbord);
                SelectButtonClear(btnBills);
                SelectButtonClear(btnInvoice);
                SelectButtonClear(btnPurchase);
                SelectButtonClear(btnSales);
                SelectButtonClear(btnSuppliers);
                SelectButtonClear(btnStaff);
                SelectButtonClear(btnCategory);

                customerDashbord customerdashbord = new customerDashbord();
                customerdashbord.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {

            try
            {
                pnlsaleOverview.Hide();
                pnlpurchasOverview.Hide();
                pnlNoOfUsers.Hide();
                pnlProductDetailes.Hide();
                pnlInventorySummary.Hide();

                txtmainSection.Text = "Suppliers Dashbord";
                pictureboxMainSection.Image = imgbtnPurchase.Image;
                SelectButton(btnSuppliers);
                SelectButtonClear(btnDashbord);
                SelectButtonClear(btnInventory);
                SelectButtonClear(btnBills);
                SelectButtonClear(btnInvoice);
                SelectButtonClear(btnPurchase);
                SelectButtonClear(btnSales);
                SelectButtonClear(btnCustomers);
                SelectButtonClear(btnStaff);
                SelectButtonClear(btnCategory);


                suppliersDashbord suppliersDashbord = new suppliersDashbord();
                suppliersDashbord.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //image button 
        private void imgbtnInventory_Click(object sender, EventArgs e)
        {
            try
            {
                btnInventory_Click(sender, e);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void imgbtnPurchase_Click(object sender, EventArgs e)
        {

            try
            {
                btnPurchase_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void imgbtnSupReturn_Click(object sender, EventArgs e)
        {

            try
            {
                btnSupReturn_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void imgbtnInvoice_Click(object sender, EventArgs e)
        {

            try
            {
                btnInvoice_Click(sender, e);
                invoiceDashbord id = new invoiceDashbord();
                id.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void imgbtnSales_Click(object sender, EventArgs e)
        {

            try
            {
                btnSales_Click(sender, e);
                salesDashbord sd = new salesDashbord();
                sd.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void imgbtnBills_Click(object sender, EventArgs e)
        {

            try
            {
                btnBills_Click(sender, e);
                billDashbord bd = new billDashbord();
                bd.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void imgbtnCustomers_Click(object sender, EventArgs e)
        {

            try
            {
                btnCustomers_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void imgbtnSuppliers_Click(object sender, EventArgs e)
        {

            try
            {
                btnSuppliers_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
