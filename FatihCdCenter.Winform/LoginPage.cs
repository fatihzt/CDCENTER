using FatihCdCenter.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FatihCdCenter.Winform
{
    public partial class LoginPage : Form
    {
        public static string CustomerName = "";
        public LoginPage()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            username_box.Clear();
            password_box.Clear();
            comboBox1.Items.Clear();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Admin")
            {
                if (username_box.Text == "admin" && password_box.Text == "admin")
                {
                    AdminPage adminPage = new AdminPage();
                    adminPage.Show();
                    this.Hide();
                }
            }
            else if (comboBox1.Text == "Customer")
            {
                var customer = Customers.GetCustomerOnLogin(username_box.Text, password_box.Text);

                if (customer !=null)
                {
                    CustomerName = username_box.Text;
                    CustomerPage customerPage = new CustomerPage();
                    customerPage.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please select a role ", caption: "Error!!");
            }


        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            RegisterCustomer registerCustomer = new RegisterCustomer();
            registerCustomer.Show();
        }
    }
}
