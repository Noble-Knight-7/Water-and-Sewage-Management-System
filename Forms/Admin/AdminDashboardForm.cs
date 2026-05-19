using System;
using System.Drawing;
using System.Windows.Forms;
using WaterSewageManagementSystem.Forms.Common;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Services;

namespace WaterSewageManagementSystem.Forms.Admin
{
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
            //CreateDashboardButtons();
            LoadDashboardStats();

            //if (SessionManager.CurrentUser != null)
            //{
            //    lblWelcome.Text = "Welcome, " + SessionManager.CurrentUser.FullName;
            //}
            //else
            //{
            //    lblWelcome.Text = "Welcome, Admin";
            //}
        }

        private readonly UserService _userService = new UserService();
        private readonly ComplaintService _complaintService = new ComplaintService();
        private readonly NoticeService _noticeService = new NoticeService();

        private void LoadDashboardStats()
        {
            lblCard1Num.Text = _userService.GetAllUsers().Count.ToString();
            lblCard2Num.Text = _complaintService.GetAll().Count.ToString();
            lblCard3Num.Text = _userService.GetPendingEmployees().Count.ToString();
            lblCard4Num.Text = _noticeService.GetAll().Count.ToString();
        }

        //private void CreateDashboardButtons()
        //{
        //    btnManageUsers = new Button();
        //    btnApproveEmployees = new Button();
        //    btnAssignComplaints = new Button();
        //    btnNotices = new Button();
        //    btnReports = new Button();
        //    btnProfile = new Button();
        //    btnLogout = new Button();

        //    string[] labels =
        //    {
        //        "Manage Users",
        //        "Approve Employees",
        //        "Assign Complaints",
        //        "Notice Management",
        //        "System Reports",
        //        "My Profile",
        //        "Logout"
        //    };

        //    Button[] btns =
        //    {
        //        btnManageUsers,
        //        btnApproveEmployees,
        //        btnAssignComplaints,
        //        btnNotices,
        //        btnReports,
        //        btnProfile,
        //        btnLogout
        //    };

        //    Color[] colors =
        //    {
        //        Color.FromArgb(21, 101, 192),
        //        Color.FromArgb(46, 125, 50),
        //        Color.FromArgb(230, 81, 0),
        //        Color.FromArgb(106, 27, 154),
        //        Color.FromArgb(0, 96, 100),
        //        Color.FromArgb(33, 33, 33),
        //        Color.FromArgb(183, 28, 28)
        //    };

        //    EventHandler[] handlers =
        //    {
        //        btnManageUsers_Click,
        //        btnApproveEmployees_Click,
        //        btnAssignComplaints_Click,
        //        btnNotices_Click,
        //        btnReports_Click,
        //        btnProfile_Click,
        //        btnLogout_Click
        //    };

        //    for (int i = 0; i < btns.Length; i++)
        //    {
        //        int col = i % 3;
        //        int row = i / 3;

        //        btns[i].Text = labels[i];
        //        btns[i].Location = new Point(50 + col * 235, 100 + row * 130);
        //        btns[i].Size = new Size(200, 100);
        //        btns[i].Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        //        btns[i].ForeColor = Color.White;
        //        btns[i].BackColor = colors[i];
        //        btns[i].FlatStyle = FlatStyle.Flat;
        //        btns[i].FlatAppearance.BorderSize = 0;
        //        btns[i].Cursor = Cursors.Hand;
        //        btns[i].Click += handlers[i];

        //        this.Controls.Add(btns[i]);
        //    }
        //}

        private void btnManageUsers_Click(object sender, EventArgs e) => new ManageUsersForm().ShowDialog();

        private void btnApproveEmployees_Click(object sender, EventArgs e) => new ApproveEmployeesForm().ShowDialog();

        private void btnAssignComplaints_Click(object sender, EventArgs e) => new AssignComplaintsForm().ShowDialog();

        private void btnNotices_Click(object sender, EventArgs e) => new NoticeManagementForm().ShowDialog();

        private void btnReports_Click(object sender, EventArgs e) => new SystemReportForm().ShowDialog();

        private void btnProfile_Click(object sender, EventArgs e) => new ProfileForm().ShowDialog();

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

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogoArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblLogoName_Click(object sender, EventArgs e)
        {

        }

        private void lblLogoSub_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void card1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCard1Num_Click(object sender, EventArgs e)
        {

        }
    }
}