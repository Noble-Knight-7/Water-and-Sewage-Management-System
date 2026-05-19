using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WaterSewageManagementSystem.Forms.Admin
{
    public partial class AssignComplaintsForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public AssignComplaintsForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            LoadComplaints();
            LoadEngineers();
        }

        private void LoadComplaints()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = @"SELECT 
                                    c.ComplaintID,
                                    c.CustomerID,
                                    u.FullName AS CustomerName,
                                    c.Category,
                                    c.Description,
                                    c.Priority,
                                    c.Status,
                                    c.AssignedEngineerID,
                                    ISNULL(e.FullName, 'Unassigned') AS EngineerName,
                                    c.DateSubmitted
                                 FROM Complaints c
                                 JOIN Customers cu ON c.CustomerID = cu.CustomerID
                                 JOIN Users u ON cu.UserID = u.UserID
                                 LEFT JOIN Users e ON c.AssignedEngineerID = e.UserID
                                 ORDER BY c.DateSubmitted DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adp.Fill(ds);

                DataTable dt = ds.Tables[0];
                dgvComplaints.DataSource = dt;
                dgvComplaints.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading complaints: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void LoadEngineers()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = @"SELECT UserID, FullName
                                 FROM Users
                                 WHERE Role='MaintenanceEngineer' AND Status='Active'
                                 ORDER BY FullName";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                cmbEngineer.DataSource = null;
                cmbEngineer.DataSource = dt;
                cmbEngineer.DisplayMember = "FullName";
                cmbEngineer.ValueMember = "UserID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading engineers: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (dgvComplaints.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a complaint.");
                return;
            }

            if (cmbEngineer.SelectedItem == null)
            {
                MessageBox.Show("Select an engineer.");
                return;
            }

            int complaintID = Convert.ToInt32(dgvComplaints.SelectedRows[0].Cells["ComplaintID"].Value);
            int engineerID = Convert.ToInt32(cmbEngineer.SelectedValue);

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string query = "UPDATE Complaints SET AssignedEngineerID=" + engineerID + ", Status='Assigned' WHERE ComplaintID=" + complaintID;
                SqlCommand cmd = new SqlCommand(query, conn);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Complaint assigned successfully.");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Failed to assign complaint.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error assigning complaint: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
