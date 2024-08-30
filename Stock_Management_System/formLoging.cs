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

        public void btnSingup_Click(object sender, EventArgs e)
        {
            userName = txtUserName.Text;
            password = txtPassword.Text;

                Form1 form1 = new Form1();
            SqlConnection sqlCon = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("CheckPassword",sqlCon);
                cmd.CommandType = CommandType.Text;

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
                   
                       
                    this.Hide();
                    form1.ShowDialog();
                     

                    }
                    else if(userName == "user123")
                    {
                       
                        this.Hide();
                        form1.Show();
                    }

                   

                }
                else
                {
                    MessageBox.Show("Invalid details","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Clear();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                form1.FormClosed += (s, args) => this.Close();
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

        private void lblSingup_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void lblTermOfUse_Sizechange(object sender, EventArgs e)
        {
            
           
        }

        private void lblTermOfUse_MouseHover(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
            label6.Font = new Font(label6.Font.FontFamily, 10, FontStyle.Bold);
        }

        private void lblTermOfUse_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Blue;
            label6.Font = new Font(label6.Font.FontFamily, 8, FontStyle.Bold);


        }

        private void lblSingup_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void lblSingup_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
