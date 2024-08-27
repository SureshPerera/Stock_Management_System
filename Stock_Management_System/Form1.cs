using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management_System
{
    public partial class Form1 : Form
    {
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

        }

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
                txtmainSection.Text = "Inventory";
                pictureboxMainSection.Image = imgbtnInventory.Image;
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
                txtmainSection.Text = "Purchase";
                pictureboxMainSection.Image = imgbtnPurchase.Image;
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
                txtmainSection.Text = "Supplies Returns";
                pictureboxMainSection.Image = imgbtnSupReturn.Image;
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
                txtmainSection.Text = "Invoice";
                pictureboxMainSection.Image = imgbtnInvoice.Image;
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
                txtmainSection.Text = "Sales";
                pictureboxMainSection.Image = imgbtnSales.Image;
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
                txtmainSection.Text = "Bills";
                pictureboxMainSection.Image = imgbtnBills.Image;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
