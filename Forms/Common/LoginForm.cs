using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterSewageManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            comboBox_role_selector.Items.Add("Admin");
            comboBox_role_selector.Items.Add("Customer");
            comboBox_role_selector.Items.Add("Service Officer");
            comboBox_role_selector.Items.Add("Maintenance Engineer");

            comboBox_role_selector.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button_login_clicked(object sender, EventArgs e)
        {

        }

        private void linkLabel_register_clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel_forgot_password_clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void comboBox_role_selector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
