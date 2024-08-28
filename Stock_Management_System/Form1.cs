using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
           btnDashbord_Click(sender, e);
           btnDashbord.Select();
            btnDashbord.Focus();

            pnlsaleOverview.Visible = false;
            pnlpurchasOverview.Visible = false;
            pnlInventorySummary.Visible = false;
            pnlNoOfUsers.Visible = false;
            pnlsaleOverview.Visible = false;
            pnlProductDetailes.Visible = false;
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
                
                txtmainSection.Text = "Dashbord";
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
                SelectButtonClear(btnSupReturn);
                SelectButtonClear(btnInvoice);
                page2.Hide();

                //update data
                //sale overview
                txtTotalSale.Text = totalSale.ToString("Rs"+"250000");
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
                txtNoOfItems.Text = noOfItem.ToString("270");

                //No Of Users
                txtTotalCustomer.Text = totalCustomer.ToString("1.8K");
                txtSuppliers.Text = totalSupplier.ToString("30");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            try
            {
                pnlsaleOverview.Hide();
                pnlpurchasOverview.Hide();
                pnlNoOfUsers.Hide();
                pnlProductDetailes.Hide();
                pnlInventorySummary.Hide();

                txtmainSection.Text = "Inventory";
                pictureboxMainSection.Image = imgbtnInventory.Image;
                SelectButton(btnInventory);
                SelectButtonClear(btnDashbord);
                SelectButtonClear(btnBills);
                SelectButtonClear(btnSales);
                SelectButtonClear(btnPurchase);
                SelectButtonClear(btnSuppliers);
                SelectButtonClear(btnCustomers);
                SelectButtonClear(btnSupReturn);
                SelectButtonClear(btnInvoice);

                

                page2.Show();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

                txtmainSection.Text = "Purchase";
                pictureboxMainSection.Image = imgbtnPurchase.Image;
                SelectButton(btnPurchase);
                SelectButtonClear(btnDashbord);
                SelectButtonClear(btnInventory);
                SelectButtonClear(btnBills);
                SelectButtonClear(btnInvoice);

                SelectButtonClear(btnSales);
                
                SelectButtonClear(btnSuppliers);
                SelectButtonClear(btnCustomers);
                SelectButtonClear(btnSupReturn);
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

                txtmainSection.Text = "Supplies Returns";
                pictureboxMainSection.Image = imgbtnSupReturn.Image;
                SelectButton(btnSupReturn);
                SelectButtonClear(btnDashbord);
                SelectButtonClear(btnBills);
                SelectButtonClear(btnInventory);
                SelectButtonClear(btnSales);
                SelectButtonClear(btnPurchase);
                SelectButtonClear(btnSuppliers);
                SelectButtonClear(btnCustomers);
                SelectButtonClear(btnInvoice);


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

                txtmainSection.Text = "Invoice";
                pictureboxMainSection.Image = imgbtnInvoice.Image;
                SelectButton(btnInvoice);
                SelectButtonClear(btnDashbord);
                SelectButtonClear(btnBills);
                SelectButtonClear(btnInventory);
                SelectButtonClear(btnSales);
                SelectButtonClear(btnPurchase);
                SelectButtonClear(btnSuppliers);
                SelectButtonClear(btnCustomers);
                SelectButtonClear(btnSupReturn);
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

                txtmainSection.Text = "Sales";
                pictureboxMainSection.Image = imgbtnSales.Image;
                SelectButton(btnSales);
                SelectButtonClear(btnDashbord);
                SelectButtonClear(btnInventory);
                SelectButtonClear(btnBills);
                SelectButtonClear(btnInvoice);
                SelectButtonClear(btnPurchase);
                SelectButtonClear(btnSuppliers);
                SelectButtonClear(btnCustomers);
                SelectButtonClear(btnSupReturn);
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

                txtmainSection.Text = "Bills";
                pictureboxMainSection.Image = imgbtnBills.Image;
                SelectButton(btnBills);
                SelectButtonClear(btnDashbord);
                SelectButtonClear(btnInventory);
                SelectButtonClear(btnSales);
                SelectButtonClear(btnInvoice);
                SelectButtonClear(btnPurchase);
                SelectButtonClear(btnSuppliers);
                SelectButtonClear(btnCustomers);
                SelectButtonClear(btnSupReturn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
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

                txtmainSection.Text = "Customer";
                pictureboxMainSection.Image = imgbtnPurchase.Image;
                SelectButton(btnCustomers);
                SelectButtonClear(btnDashbord);
                SelectButtonClear(btnInventory);
                SelectButtonClear(btnBills);
                SelectButtonClear(btnInvoice);
                SelectButtonClear(btnPurchase);
                SelectButtonClear(btnSales);
                SelectButtonClear(btnSuppliers);
                SelectButtonClear(btnSupReturn);
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

                txtmainSection.Text = "Suppliers";
                pictureboxMainSection.Image = imgbtnPurchase.Image;
                SelectButton(btnSuppliers);
                SelectButtonClear(btnDashbord);
                SelectButtonClear(btnInventory);
                SelectButtonClear(btnBills);
                SelectButtonClear(btnInvoice);
                SelectButtonClear(btnPurchase);
                SelectButtonClear(btnSales);
                SelectButtonClear(btnCustomers);
                SelectButtonClear(btnSupReturn);
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
