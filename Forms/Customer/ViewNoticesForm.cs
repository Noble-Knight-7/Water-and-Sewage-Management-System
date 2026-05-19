using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace WaterSewageManagementSystem.Forms.Customer
{
    public partial class ViewNoticesForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public ViewNoticesForm()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                LoadNotices();
            }
        }

        private void LoadNotices()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = @"SELECT 
                                    NoticeID,
                                    Title,
                                    Description,
                                    Area,
                                    NoticeType,
                                    PublishDate
                                 FROM Notices
                                 ORDER BY PublishDate DESC";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                dgvNotices.DataSource = dt;
                dgvNotices.AutoGenerateColumns = true;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No notices found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading notices: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ViewNoticesForm_Load(object sender, EventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void dgvNotices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
