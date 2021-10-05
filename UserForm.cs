using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMS.Common;

namespace TMS
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage lg = new LoginPage();
            lg.ShowDialog();
            this.Close();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {            
            //dgvUser.RowHeadersVisible = true;
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-NVR25D0\\MSSQLSERVER2019;Initial Catalog=TMS_V1;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT userId as UserId,firstName as FirstName,email as Email,role as UserType,userName as UseraName,createdOn as CreatedOn,createdBy as CreatedBy,isActive as Active FROM [User]", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvUser.DataSource = ds.Tables[0].DefaultView;
            con.Close();
             
        

            dgvUser.BorderStyle = BorderStyle.None;
            dgvUser.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvUser.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUser.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dgvUser.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvUser.BackgroundColor = Color.White;

            dgvUser.EnableHeadersVisualStyles = false;
            dgvUser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUser.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dgvUser.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvUser.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvUser.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvUser.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
            //for (int i = 0; i <= dgvUser.Columns.Count - 1; i++)
            //{
            //    // Store Auto Sized Widths:
            //    int colw = dgvUser.Columns[i].Width;

            //    // Remove AutoSizing:
            //    dgvUser.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            //    // Set Width to calculated AutoSize value:
            //    dgvUser.Columns[i].Width = colw;

            //}
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TruckManagement tm = new TruckManagement();
            tm.ShowDialog();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-NVR25D0\\MSSQLSERVER2019;Initial Catalog=TMS_V1;Integrated Security=True");
            if (txtUserName.Text != "" && txtPassword.Text != "" && txtConfirmPassword.Text != "" && txtFirstName.Text != "" && txtEmail.Text != "")  //validating the fields whether the fields or empty or not  
            {
                if (txtPassword.Text.ToString().Trim().ToLower() == txtConfirmPassword.Text.ToString().Trim().ToLower()) //validating Password textbox and confirm password textbox is match or unmatch    
                {
                    try
                    {
                        string UserName = txtUserName.Text;
                        string Password = CommonClass.Encrypt(txtPassword.Text.ToString());   // Passing the Password to Encrypt method and the method will return encrypted string and stored in Password variable.  
                        con.Open();
                        SqlCommand insert = new SqlCommand("insert into [user](firstName,email,userName,Password,role,createdOn,CreatedBy,isActive)values('" + txtFirstName.Text + "','" + txtEmail.Text + "','" + UserName + "','" + Password + "','" + ddlUserType.SelectedItem + "','" + DateTime.Now + "','Admin','" + 1 + "')", con);
                        insert.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {

                        throw;
                    }                    
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password doesn't match!.. Please Check..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);  //showing the error message if password and confirm password doesn't match  
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields!..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);  //showing the error message if any fields is empty  
            }
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
