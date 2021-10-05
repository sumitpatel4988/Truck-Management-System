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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            TruckManagement lg = new TruckManagement();
            lg.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            txtUserName.Text = LoginInfo.UserName;
            txtOldPassword.Text = LoginInfo.Password;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-NVR25D0\\MSSQLSERVER2019;Initial Catalog=TMS_V1;Integrated Security=True");
            try
            {                
                if(txtNewPassword.Text.Trim() == txtConfirmPassword.Text.Trim())
                {
                    string Password = CommonClass.Encrypt(txtNewPassword.Text.ToString());   // Passing the Password to Encrypt method and the method will return encrypted string and stored in Password variable.  
                    con.Open();
                    SqlCommand insert = new SqlCommand("update [user] set password = '" + Password + "' where userName = '" + txtUserName.Text + "'", con);
                    insert.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Password change successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password doesn't match!.. Please Check..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);  //showing the error message if password and confirm password doesn't match  
                }
            }
            catch (Exception)
            {

                throw;
            }            
        }
    }
}
