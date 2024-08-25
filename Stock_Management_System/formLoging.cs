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
    public partial class formLoging : Form
    {
        string userName;
        string password;

        string connectionString = @"Data Source=SURESH;Initial Catalog=Inventry_Management_System;Integrated Security=True;TrustServerCertificate=True";

        public formLoging()
        {
            InitializeComponent();
        }

        private void formLoging_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnSingup_Click(object sender, EventArgs e)
        {
            userName = txtUserName.Text;
            password = txtPassword.Text;

            SqlConnection sqlCon = new SqlConnection(connectionString);
            try
            {
                string quarry = "SELECT * FROM Passwords WHERE UserName ='" + userName + "' AND Passwords ='" + password + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(quarry,sqlCon);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    userName = txtUserName.Text;
                    password = txtPassword.Text;
                    if (userName == "admin123")
                    {
                    Form1 form1 = new Form1();
                    this.Hide();
                    form1.ShowDialog();

                    }else if(userName == "user123")
                    {
                        page1 page1 = new page1();
                        this.Hide();
                        page1.Show();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Invalid details","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Clear();
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            
            
        }

        private void btnImgSwiter_Click(object sender, EventArgs e)
        {

        }

        private void btnImgApple_Click(object sender, EventArgs e)
        {

        }

        private void btnImgFb_Click(object sender, EventArgs e)
        {

        }
        void Clear()
        {
            txtPassword.Text = txtUserName.Text = "";
            txtUserName.Select();
        }
    }
}
