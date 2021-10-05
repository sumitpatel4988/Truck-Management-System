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
    public partial class TruckManagement : Form
    {
        

        public TruckManagement()
        {
            InitializeComponent();
        }

        private void TruckManagement_Load(object sender, EventArgs e)
        {
            int n = 0;
            dgvTruckDetails.RowHeadersVisible = true;

            for (int i = 0; i < 10; i++)
            {

                n = dgvTruckDetails.Rows.Add();

                dgvTruckDetails.Rows[n].Cells[0].Value = n;
                dgvTruckDetails.Rows[n].Cells[1].Value = "Godhra";
                dgvTruckDetails.Rows[n].Cells[2].Value = "Ahmedabad";
                dgvTruckDetails.Rows[n].Cells[3].Value = "GJ17BC 3011";
                dgvTruckDetails.Rows[n].Cells[4].Value = "500 TN";
                dgvTruckDetails.Rows[n].Cells[5].Value = "100 TN";
                dgvTruckDetails.Rows[n].Cells[6].Value = "80 TN";
                dgvTruckDetails.Rows[n].Cells[7].Value = "31/05/2021";
                dgvTruckDetails.Rows[n].Cells[8].Value = "Link";

                n = dgvTruckDetails.Rows.Add();

                dgvTruckDetails.Rows[n].Cells[0].Value = n;
                dgvTruckDetails.Rows[n].Cells[1].Value = "Godhra";
                dgvTruckDetails.Rows[n].Cells[2].Value = "Ahmedabad";
                dgvTruckDetails.Rows[n].Cells[3].Value = "GJ17BC 3011";
                dgvTruckDetails.Rows[n].Cells[4].Value = "500 TN";
                dgvTruckDetails.Rows[n].Cells[5].Value = "100 TN";
                dgvTruckDetails.Rows[n].Cells[6].Value = "80 TN";
                dgvTruckDetails.Rows[n].Cells[7].Value = "31/05/2021";
                dgvTruckDetails.Rows[n].Cells[8].Value = "Link";

                n = dgvTruckDetails.Rows.Add();

                dgvTruckDetails.Rows[n].Cells[0].Value = n;
                dgvTruckDetails.Rows[n].Cells[1].Value = "Godhra";
                dgvTruckDetails.Rows[n].Cells[2].Value = "Ahmedabad";
                dgvTruckDetails.Rows[n].Cells[3].Value = "GJ17BC 3011";
                dgvTruckDetails.Rows[n].Cells[4].Value = "500 TN";
                dgvTruckDetails.Rows[n].Cells[5].Value = "100 TN";
                dgvTruckDetails.Rows[n].Cells[6].Value = "80 TN";
                dgvTruckDetails.Rows[n].Cells[7].Value = "31/05/2021";
                dgvTruckDetails.Rows[n].Cells[8].Value = "Link";

                n = dgvTruckDetails.Rows.Add();

                dgvTruckDetails.Rows[n].Cells[0].Value = n;
                dgvTruckDetails.Rows[n].Cells[1].Value = "Godhra";
                dgvTruckDetails.Rows[n].Cells[2].Value = "Ahmedabad";
                dgvTruckDetails.Rows[n].Cells[3].Value = "GJ17BC 3011";
                dgvTruckDetails.Rows[n].Cells[4].Value = "500 TN";
                dgvTruckDetails.Rows[n].Cells[5].Value = "100 TN";
                dgvTruckDetails.Rows[n].Cells[6].Value = "80 TN";
                dgvTruckDetails.Rows[n].Cells[7].Value = "31/05/2021";
                dgvTruckDetails.Rows[n].Cells[8].Value = "Link";

                n = dgvTruckDetails.Rows.Add();

                dgvTruckDetails.Rows[n].Cells[0].Value = n;
                dgvTruckDetails.Rows[n].Cells[1].Value = "Godhra";
                dgvTruckDetails.Rows[n].Cells[2].Value = "Ahmedabad";
                dgvTruckDetails.Rows[n].Cells[3].Value = "GJ17BC 3011";
                dgvTruckDetails.Rows[n].Cells[4].Value = "500 TN";
                dgvTruckDetails.Rows[n].Cells[5].Value = "100 TN";
                dgvTruckDetails.Rows[n].Cells[6].Value = "80 TN";
                dgvTruckDetails.Rows[n].Cells[7].Value = "31/05/2021";
                dgvTruckDetails.Rows[n].Cells[8].Value = "Link";

                n = dgvTruckDetails.Rows.Add();

                dgvTruckDetails.Rows[n].Cells[0].Value = n;
                dgvTruckDetails.Rows[n].Cells[1].Value = "Godhra";
                dgvTruckDetails.Rows[n].Cells[2].Value = "Ahmedabad";
                dgvTruckDetails.Rows[n].Cells[3].Value = "GJ17BC 3011";
                dgvTruckDetails.Rows[n].Cells[4].Value = "500 TN";
                dgvTruckDetails.Rows[n].Cells[5].Value = "100 TN";
                dgvTruckDetails.Rows[n].Cells[6].Value = "80 TN";
                dgvTruckDetails.Rows[n].Cells[7].Value = "31/05/2021";
                dgvTruckDetails.Rows[n].Cells[8].Value = "Link";

                n = dgvTruckDetails.Rows.Add();

                dgvTruckDetails.Rows[n].Cells[0].Value = n;
                dgvTruckDetails.Rows[n].Cells[1].Value = "Godhra";
                dgvTruckDetails.Rows[n].Cells[2].Value = "Ahmedabad";
                dgvTruckDetails.Rows[n].Cells[3].Value = "GJ17BC 3011";
                dgvTruckDetails.Rows[n].Cells[4].Value = "500 TN";
                dgvTruckDetails.Rows[n].Cells[5].Value = "100 TN";
                dgvTruckDetails.Rows[n].Cells[6].Value = "80 TN";
                dgvTruckDetails.Rows[n].Cells[7].Value = "31/05/2021";
                dgvTruckDetails.Rows[n].Cells[8].Value = "Link";

                n = dgvTruckDetails.Rows.Add();

                dgvTruckDetails.Rows[n].Cells[0].Value = n;
                dgvTruckDetails.Rows[n].Cells[1].Value = "Godhra";
                dgvTruckDetails.Rows[n].Cells[2].Value = "Ahmedabad";
                dgvTruckDetails.Rows[n].Cells[3].Value = "GJ17BC 3011";
                dgvTruckDetails.Rows[n].Cells[4].Value = "500 TN";
                dgvTruckDetails.Rows[n].Cells[5].Value = "100 TN";
                dgvTruckDetails.Rows[n].Cells[6].Value = "80 TN";
                dgvTruckDetails.Rows[n].Cells[7].Value = "31/05/2021";
                dgvTruckDetails.Rows[n].Cells[8].Value = "Link";

                n = dgvTruckDetails.Rows.Add();

                dgvTruckDetails.Rows[n].Cells[0].Value = n;
                dgvTruckDetails.Rows[n].Cells[1].Value = "Godhra";
                dgvTruckDetails.Rows[n].Cells[2].Value = "Ahmedabad";
                dgvTruckDetails.Rows[n].Cells[3].Value = "GJ17BC 3011";
                dgvTruckDetails.Rows[n].Cells[4].Value = "500 TN";
                dgvTruckDetails.Rows[n].Cells[5].Value = "100 TN";
                dgvTruckDetails.Rows[n].Cells[6].Value = "80 TN";
                dgvTruckDetails.Rows[n].Cells[7].Value = "31/05/2021";
                dgvTruckDetails.Rows[n].Cells[8].Value = "Link";

                n = dgvTruckDetails.Rows.Add();

                dgvTruckDetails.Rows[n].Cells[0].Value = n;
                dgvTruckDetails.Rows[n].Cells[1].Value = "Godhra";
                dgvTruckDetails.Rows[n].Cells[2].Value = "Ahmedabad";
                dgvTruckDetails.Rows[n].Cells[3].Value = "GJ17BC 3011";
                dgvTruckDetails.Rows[n].Cells[4].Value = "500 TN";
                dgvTruckDetails.Rows[n].Cells[5].Value = "100 TN";
                dgvTruckDetails.Rows[n].Cells[6].Value = "80 TN";
                dgvTruckDetails.Rows[n].Cells[7].Value = "31/05/2021";
                dgvTruckDetails.Rows[n].Cells[8].Value = "Link";

                n = dgvTruckDetails.Rows.Add();

                dgvTruckDetails.Rows[n].Cells[0].Value = n;
                dgvTruckDetails.Rows[n].Cells[1].Value = "Godhra";
                dgvTruckDetails.Rows[n].Cells[2].Value = "Ahmedabad";
                dgvTruckDetails.Rows[n].Cells[3].Value = "GJ17BC 3011";
                dgvTruckDetails.Rows[n].Cells[4].Value = "500 TN";
                dgvTruckDetails.Rows[n].Cells[5].Value = "100 TN";
                dgvTruckDetails.Rows[n].Cells[6].Value = "80 TN";
                dgvTruckDetails.Rows[n].Cells[7].Value = "31/05/2021";
                dgvTruckDetails.Rows[n].Cells[8].Value = "Link";

                n = dgvTruckDetails.Rows.Add();

                dgvTruckDetails.Rows[n].Cells[0].Value = n;
                dgvTruckDetails.Rows[n].Cells[1].Value = "Godhra";
                dgvTruckDetails.Rows[n].Cells[2].Value = "Ahmedabad";
                dgvTruckDetails.Rows[n].Cells[3].Value = "GJ17BC 3011";
                dgvTruckDetails.Rows[n].Cells[4].Value = "500 TN";
                dgvTruckDetails.Rows[n].Cells[5].Value = "100 TN";
                dgvTruckDetails.Rows[n].Cells[6].Value = "80 TN";
                dgvTruckDetails.Rows[n].Cells[7].Value = "31/05/2021";
                dgvTruckDetails.Rows[n].Cells[8].Value = "Link";

                n = dgvTruckDetails.Rows.Add();

                dgvTruckDetails.Rows[n].Cells[0].Value = n;
                dgvTruckDetails.Rows[n].Cells[1].Value = "Godhra";
                dgvTruckDetails.Rows[n].Cells[2].Value = "Ahmedabad";
                dgvTruckDetails.Rows[n].Cells[3].Value = "GJ17BC 3011";
                dgvTruckDetails.Rows[n].Cells[4].Value = "500 TN";
                dgvTruckDetails.Rows[n].Cells[5].Value = "100 TN";
                dgvTruckDetails.Rows[n].Cells[6].Value = "80 TN";
                dgvTruckDetails.Rows[n].Cells[7].Value = "31/05/2021";
                dgvTruckDetails.Rows[n].Cells[8].Value = "Link";

                n = dgvTruckDetails.Rows.Add();

                dgvTruckDetails.Rows[n].Cells[0].Value = n;
                dgvTruckDetails.Rows[n].Cells[1].Value = "Godhra";
                dgvTruckDetails.Rows[n].Cells[2].Value = "Ahmedabad";
                dgvTruckDetails.Rows[n].Cells[3].Value = "GJ17BC 3011";
                dgvTruckDetails.Rows[n].Cells[4].Value = "500 TN";
                dgvTruckDetails.Rows[n].Cells[5].Value = "100 TN";
                dgvTruckDetails.Rows[n].Cells[6].Value = "80 TN";
                dgvTruckDetails.Rows[n].Cells[7].Value = "31/05/2021";
                dgvTruckDetails.Rows[n].Cells[8].Value = "Link";
                n = dgvTruckDetails.Rows.Add();

                dgvTruckDetails.Rows[n].Cells[0].Value = n;
                dgvTruckDetails.Rows[n].Cells[1].Value = "Godhra";
                dgvTruckDetails.Rows[n].Cells[2].Value = "Ahmedabad";
                dgvTruckDetails.Rows[n].Cells[3].Value = "GJ17BC 3011";
                dgvTruckDetails.Rows[n].Cells[4].Value = "500 TN";
                dgvTruckDetails.Rows[n].Cells[5].Value = "100 TN";
                dgvTruckDetails.Rows[n].Cells[6].Value = "80 TN";
                dgvTruckDetails.Rows[n].Cells[7].Value = "31/05/2021";
                dgvTruckDetails.Rows[n].Cells[8].Value = "Link";


            }


            dgvTruckDetails.BorderStyle = BorderStyle.None;
            dgvTruckDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvTruckDetails.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTruckDetails.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dgvTruckDetails.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvTruckDetails.BackgroundColor = Color.White;

            dgvTruckDetails.EnableHeadersVisualStyles = false;
            dgvTruckDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTruckDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dgvTruckDetails.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            dgvTruckDetails.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvTruckDetails.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvTruckDetails.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Now that DataGridView has calculated it's Widths; we can now store each column Width values.
            for (int i = 0; i <= dgvTruckDetails.Columns.Count - 1; i++)
            {
                // Store Auto Sized Widths:
                int colw = dgvTruckDetails.Columns[i].Width;

                // Remove AutoSizing:
                dgvTruckDetails.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                // Set Width to calculated AutoSize value:
                dgvTruckDetails.Columns[i].Width = colw;

            }

        }
        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage lg = new LoginPage();
            lg.ShowDialog();
            this.Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {   
            UserForm user = new UserForm();
            user.ShowDialog();
            this.Close();
        }

        private void btnCPassword_Click(object sender, EventArgs e)
        {
            ChangePassword CP = new ChangePassword();
            CP.ShowDialog();
            this.Close();
        }
    }
}
