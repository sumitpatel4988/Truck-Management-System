using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using TMS.Common;

namespace TMS
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txtPassword.BackColor= SystemColors.Control;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {

            txtPassword.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            txtUserName.BackColor = SystemColors.Control;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-NVR25D0\\MSSQLSERVER2019;Initial Catalog=TMS_V1;Integrated Security=True");
                string Password = "",role = "";
                bool IsExist = false;
                con.Open();
                SqlCommand cmd = new SqlCommand("select userName,password,firstName,role from [User] where userName='" + txtUserName.Text + "'", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    Password = sdr.GetString(1);  //get the user password from db if the user name is exist in that.  
                    role = sdr.GetString(3);
                    IsExist = true;
                }
                con.Close();
                if (IsExist)  //if record exis in db , it will return true, otherwise it will return false  
                {
                    if (CommonClass.Decrypt(Password).Equals(txtPassword.Text))
                    {
                        try
                        {
                            LoginInfo.UserName = txtUserName.Text;
                            LoginInfo.Password = txtPassword.Text;
                            LoginInfo.Role = role;
                            MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            TruckManagement tm = new TruckManagement();
                            tm.ShowDialog();
                            this.Close();
                        }
                        catch (Exception ex)
                        {

                            throw;
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("Password is wrong!...", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else  //showing the error message if user credential is wrong  
                {
                    MessageBox.Show("Please enter the valid credentials", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter Username and password", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
