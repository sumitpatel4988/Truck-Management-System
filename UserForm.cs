using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            int n = 0;
            dgvUser.RowHeadersVisible = true;

            for (int i = 0; i < 10; i++)
            {

                n = dgvUser.Rows.Add();

                dgvUser.Rows[n].Cells[0].Value = n;
                dgvUser.Rows[n].Cells[1].Value = "Bhavik";
                dgvUser.Rows[n].Cells[2].Value = "Shah.bhavik.31@gmail.com";
                dgvUser.Rows[n].Cells[3].Value = "bhavikshah";
                dgvUser.Rows[n].Cells[4].Value = "Admin";
                dgvUser.Rows[n].Cells[5].Value = "Active";
                dgvUser.Rows[n].Cells[6].Value = "Admin";
                dgvUser.Rows[n].Cells[6].Value = "22/12/2002";

                n = dgvUser.Rows.Add();

                dgvUser.Rows[n].Cells[0].Value = n;
                dgvUser.Rows[n].Cells[1].Value = "Bhavik";
                dgvUser.Rows[n].Cells[2].Value = "Shah.bhavik.31@gmail.com";
                dgvUser.Rows[n].Cells[3].Value = "bhavikshah";
                dgvUser.Rows[n].Cells[4].Value = "Admin";
                dgvUser.Rows[n].Cells[5].Value = "Active";
                dgvUser.Rows[n].Cells[6].Value = "Admin";
                dgvUser.Rows[n].Cells[6].Value = "22/12/2002";

                n = dgvUser.Rows.Add();

                dgvUser.Rows[n].Cells[0].Value = n;
                dgvUser.Rows[n].Cells[1].Value = "Bhavik";
                dgvUser.Rows[n].Cells[2].Value = "Shah.bhavik.31@gmail.com";
                dgvUser.Rows[n].Cells[3].Value = "bhavikshah";
                dgvUser.Rows[n].Cells[4].Value = "Admin";
                dgvUser.Rows[n].Cells[5].Value = "Active";
                dgvUser.Rows[n].Cells[6].Value = "Admin";
                dgvUser.Rows[n].Cells[6].Value = "22/12/2002";

            }
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
            for (int i = 0; i <= dgvUser.Columns.Count - 1; i++)
            {
                // Store Auto Sized Widths:
                int colw = dgvUser.Columns[i].Width;

                // Remove AutoSizing:
                dgvUser.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                dgvUser.Columns[i].Width = colw;

            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TruckManagement tm = new TruckManagement();
            tm.ShowDialog();
            this.Close();
        }
    }
}
