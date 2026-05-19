using System;
using System.Drawing;
using System.Windows.Forms;
using WaterSewageManagementSystem.Forms.Common;
using WaterSewageManagementSystem.Forms.Customer.v2;
using WaterSewageManagementSystem.Helpers;

namespace WaterSewageManagementSystem.Forms.Customer
{
    public partial class CustomerDashboardForm : Form
    {
        public CustomerDashboardForm()
        {
            InitializeComponent();

            if (SessionManager.CurrentUser != null)
            {
                lblWelcome.Text = "Welcome, " + SessionManager.CurrentUser.FullName;
            }
            else
            {
                lblWelcome.Text = "Welcome, Customer";
            }
        }
        //private void CreateDashboardButtons()
        //{
        //    string[] labels =
        //    {
        //        "Current Bill",
        //        "Bill History",
        //        "Submit Dispute",
        //        "Submit Complaint",
        //        "Track Complaint",
        //        "New Connection",
        //        "Track Application",
        //        "View Notices",
        //        "My Profile",
        //        "Logout"
        //    };

        //    Button[] btns =
        //    {
        //        btnCurrentBill,
        //        btnBillHistory,
        //        btnDispute,
        //        btnComplaint,
        //        btnTrackComplaint,
        //        btnConnection,
        //        btnTrackApp,
        //        btnNotices,
        //        btnProfile,
        //        btnLogout
        //    };

        //    Color[] colors =
        //    {
        //        Color.FromArgb(0, 105, 92),
        //        Color.FromArgb(21, 101, 192),
        //        Color.FromArgb(230, 81, 0),
        //        Color.FromArgb(183, 28, 28),
        //        Color.FromArgb(106, 27, 154),
        //        Color.FromArgb(46, 125, 50),
        //        Color.FromArgb(0, 96, 100),
        //        Color.FromArgb(74, 20, 140),
        //        Color.FromArgb(33, 33, 33),
        //        Color.FromArgb(136, 14, 79)
        //    };

        //    EventHandler[] handlers =
        //    {
        //        btnCurrentBill_Click,
        //        btnBillHistory_Click,
        //        btnDispute_Click,
        //        btnComplaint_Click,
        //        btnTrackComplaint_Click,
        //        btnConnection_Click,
        //        btnTrackApp_Click,
        //        btnNotices_Click,
        //        btnProfile_Click,
        //        btnLogout_Click
        //    };

        //    for (int i = 0; i < btns.Length; i++)
        //    {
        //        int col = i % 4;
        //        int row = i / 4;

        //        btns[i].Text = labels[i];
        //        btns[i].Location = new Point(30 + col * 205, 90 + row * 120);
        //        btns[i].Size = new Size(185, 90);
        //        btns[i].Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        //        btns[i].ForeColor = Color.White;
        //        btns[i].BackColor = colors[i];
        //        btns[i].FlatStyle = FlatStyle.Flat;
        //        btns[i].FlatAppearance.BorderSize = 0;
        //        btns[i].Cursor = Cursors.Hand;
        //        btns[i].Click += handlers[i];

        //        this.Controls.Add(btns[i]);
        //    }
        //}   
        private void btnCurrentBill_Click(object sender, EventArgs e)    => new CurrentBillForm().ShowDialog();
        private void btnBillHistory_Click(object sender, EventArgs e)     => new BillHistoryForm().ShowDialog();
        private void btnDispute_Click(object sender, EventArgs e)         => new SubmitBillDisputeForm().ShowDialog();
        private void btnComplaint_Click(object sender, EventArgs e)       => new SubmitComplaintForm().ShowDialog();
        private void btnTrackComplaint_Click(object sender, EventArgs e)  => new TrackComplaintForm().ShowDialog();
        private void btnConnection_Click(object sender, EventArgs e)      => new ConnectionApplicationForm().ShowDialog();
        private void btnTrackApp_Click(object sender, EventArgs e)        => new TrackApplicationForm().ShowDialog();
        private void btnNotices_Click(object sender, EventArgs e)         => new ViewNoticesForm().ShowDialog();
        private void btnProfile_Click(object sender, EventArgs e)         => new ProfileForm().ShowDialog();
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageHelper.ShowConfirm("Are you sure you want to logout?") == DialogResult.Yes)
            {
                SessionManager.Logout();
                LoginForm login = new LoginForm();
                login.Show();

                this.Close();
            }
        }

        private void CustomerDashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
