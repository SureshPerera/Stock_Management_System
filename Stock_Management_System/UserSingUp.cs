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
    public partial class UserSingUp : Form
    {
        String ConnectionString = @"Data Source=SURESH;Initial Catalog=Inventry_Management_System;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        string fname, lname, address, userName, password, email, conPassword;

        public UserSingUp()
        {
            InitializeComponent();
        }

        private void btnSingup_Click(object sender, EventArgs e)
        {
            try
            {
                

                fname = Convert.ToString( txtFirstName.Text);
                lname = Convert.ToString(txtLastName.Text);
                address = txtEmail.Text;
                userName = txtUsername.Text;
                password = txtPassword.Text;
                email = txtEmail.Text;
                conPassword = txtPasswordCon.Text;

                if (string.IsNullOrWhiteSpace(fname) || string.IsNullOrWhiteSpace(lname) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(conPassword))
                {
                    MessageBox.Show("All filled should compalsory");
                }

                else
                {
                    SqlConnection sqlCon = new SqlConnection(ConnectionString);

                    using (sqlCon)
                    {
                        int a = 0;

                        sqlCon.Open();
                        SqlCommand cmd = new SqlCommand("CheckPassword", sqlCon);
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select * from Passwords where UserName = '" + userName + "'";
                        cmd.ExecuteNonQuery();
                        DataTable dataTable = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dataTable);
                        a = Convert.ToInt32(dataTable.Rows.Count.ToString());

                        if (a == 0)
                        {
                            cmd = new SqlCommand("CheckPassword", sqlCon);
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "insert into Passwords values('" + userName + "','" + password + "','" + fname + "','" + lname + "','" + email + "')";
                            cmd.ExecuteNonQuery();
                            Clear();
                            MessageBox.Show("Successfully Created New User Account");
                        }
                        else
                        {
                            MessageBox.Show("This Username alredy registered please choose another user name ");

                        }
                    }

                
               
                    
                }
                
               

               
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserSingUp_Load(object sender, EventArgs e)
        {
            txtFirstName.Select();


            
        }

        private void lblTeamOfUse_Hover(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
            label6.Font = new Font(label6.Font.FontFamily, 10, FontStyle.Bold);
        }

        private void lblTeamOfUse_Leave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Blue;
            label6.Font = new Font(label6.Font.FontFamily, 8, FontStyle.Bold);
        }
        
        void Clear()
        {
            txtFirstName.Text = txtLastName.Text = txtPassword.Text = txtUsername.Text = txtEmail.Text = txtPasswordCon.Text = "";
            txtFirstName.Select();

        }
    }
}
