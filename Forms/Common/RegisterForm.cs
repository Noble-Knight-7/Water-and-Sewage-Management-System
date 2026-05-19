using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WaterSewageManagementSystem.Forms.Common
{
    public partial class RegisterForm : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=WaterSewageManagementDB;Integrated Security=True;TrustServerCertificate=True";

        public RegisterForm()
        {
            InitializeComponent();

            lblConType.Hide();
            cmbConType.Hide();
            lblHolding.Hide();
            txtHoldingNumber.Hide();

            errorlblAdress.Text = "";
            errorlblConfPass.Text = "";
            errorlblPhone.Text = "";
            errorlblConn.Text = "";
            errorlblEmail.Text = "";
            errorlblGender.Text = "";
            errorlblHold.Text = "";
            errorlblName.Text = "";
            errorlblPass.Text = "";
            errorlblRole.Text = "";
            errorlblPassNotMatch.Text = "";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string password = txtPassword.Text;
            string confirmPass = txtConfirmPass.Text;
            string role = cmbRole.SelectedItem?.ToString();
            string address = txtAddress.Text.Trim();
            string holdingNumber = txtHoldingNumber.Text.Trim();
            string connectionType = cmbConType.SelectedItem?.ToString();

            string gender = "";
            if (radioButton_Male.Checked)
            {
                gender = "Male";
            }
            else if (radioButton_Female.Checked)
            {
                gender = "Female";
            }

            bool hasError = false;

            //errorlblAdress.Text = "";
            //errorlblConfPass.Text = "";
            //errorlblPhone.Text = "";
            //errorlblConn.Text = "";
            //errorlblEmail.Text = "";
            //errorlblGender.Text = "";
            //errorlblHold.Text = "";
            //errorlblName.Text = "";
            //errorlblPass.Text = "";
            //errorlblRole.Text = "";
            //errorlblPassNotMatch.Text = "";

            if (name == "")
            {
                errorlblName.Text = "Please enter your name";
                hasError = true;
            }

            if (email == "")
            {
                errorlblEmail.Text = "Please enter your email";
                hasError = true;
            }

            if (phone == "")
            {
                errorlblPhone.Text = "Please enter your phone";
                hasError = true;
            }

            if (password == "")
            {
                errorlblPass.Text = "Please enter a password";
                hasError = true;
            }

            if (confirmPass == "")
            {
                errorlblConfPass.Text = "Enter your password again";
                hasError = true;
            }

            if (password != confirmPass)
            {
                errorlblPassNotMatch.Text = "Password do not match";
                hasError = true;
            }

            if (role == null || role == "")
            {
                errorlblRole.Text = "Select a role";
                hasError = true;
            }

            if (address == "")
            {
                errorlblAdress.Text = "Please enter your address";
                hasError = true;
            }

            if (gender == "")
            {
                errorlblGender.Text = "Choose a gender";
                hasError = true;
            }

            if (role == "Customer")
            {
                if (holdingNumber == "")
                {
                    errorlblHold.Text = "Please enter your holding number";
                    hasError = true;
                }

                if (connectionType == null || connectionType == "")
                {
                    errorlblConn.Text = "Select a connection type";
                    hasError = true;
                }
            }

            if (hasError == true)
            {
                return;
            }

            string status = "";

            if (role == "Customer")
            {
                status = "Active";
            }
            else
            {
                status = "Pending";
            }

            SqlConnection conn = new SqlConnection(connectionString);
            SqlTransaction transaction = null;

            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();

                string checkQuery = "SELECT * FROM Users WHERE Email = @Email";

                SqlCommand checkCmd = new SqlCommand(checkQuery, conn, transaction);
                checkCmd.Parameters.AddWithValue("@Email", email);

                SqlDataAdapter adp = new SqlDataAdapter(checkCmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    transaction.Rollback();

                    MessageBox.Show("This email is already registered. Please use a different email.");
                    txtEmail.Focus();
                    return;
                }

                string insertUserQuery = @"
                    INSERT INTO Users
                    (
                        FullName,
                        Email,
                        Phone,
                        Password,
                        Role,
                        Address,
                        Gender,
                        Status,
                        CreatedAt
                    )
                    OUTPUT INSERTED.UserID
                    VALUES
                    (
                        @FullName,
                        @Email,
                        @Phone,
                        @Password,
                        @Role,
                        @Address,
                        @Gender,
                        @Status,
                        GETDATE()
                    )";

                SqlCommand insertUserCmd = new SqlCommand(insertUserQuery, conn, transaction);
                insertUserCmd.Parameters.AddWithValue("@FullName", name);
                insertUserCmd.Parameters.AddWithValue("@Email", email);
                insertUserCmd.Parameters.AddWithValue("@Phone", phone);
                insertUserCmd.Parameters.AddWithValue("@Password", password);
                insertUserCmd.Parameters.AddWithValue("@Role", role);
                insertUserCmd.Parameters.AddWithValue("@Address", address);
                insertUserCmd.Parameters.AddWithValue("@Gender", gender);
                insertUserCmd.Parameters.AddWithValue("@Status", status);

                int newUserID = Convert.ToInt32(insertUserCmd.ExecuteScalar());

                if (role == "Customer")
                {
                    string insertCustomerQuery = @"
                        INSERT INTO Customers
                        (
                            UserID,
                            MeterNumber,
                            HoldingNumber,
                            ConnectionType
                        )
                        VALUES
                        (
                            @UserID,
                            @MeterNumber,
                            @HoldingNumber,
                            @ConnectionType
                        )";

                    SqlCommand insertCustomerCmd = new SqlCommand(insertCustomerQuery, conn, transaction);
                    insertCustomerCmd.Parameters.AddWithValue("@UserID", newUserID);
                    insertCustomerCmd.Parameters.AddWithValue("@MeterNumber", DBNull.Value);
                    insertCustomerCmd.Parameters.AddWithValue("@HoldingNumber", holdingNumber);
                    insertCustomerCmd.Parameters.AddWithValue("@ConnectionType", connectionType);

                    insertCustomerCmd.ExecuteNonQuery();
                }

                transaction.Commit();

                if (role == "Customer")
                {
                    MessageBox.Show("Registration successful! You can now log in.");
                }
                else
                {
                    MessageBox.Show("Account created! Please wait for Admin approval before logging in.");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }

                MessageBox.Show("Registration failed: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void cmb_role_selection_change(object sender, EventArgs e)
        {
            string role = cmbRole.SelectedItem?.ToString();

            if (role == "Customer")
            {
                lblConType.Show();
                cmbConType.Show();
                lblHolding.Show();
                txtHoldingNumber.Show();
            }
            else
            {
                lblConType.Hide();
                cmbConType.Hide();
                lblHolding.Hide();
                txtHoldingNumber.Hide();

                txtHoldingNumber.Clear();
                cmbConType.SelectedIndex = -1;

                errorlblHold.Text = "";
                errorlblConn.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}