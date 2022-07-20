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
    public partial class RegisterCustomer : Form
    {
        public RegisterCustomer()
        {
            InitializeComponent();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            Model.Customers customers=new Model.Customers();
            customers.Name=name_box.Text;
            customers.Birthday=birthday_box.Text;
            customers.Mail = mail_box.Text;
            customers.Address=address_box.Text;
            customers.Phone=phone_box.Text;
            customers.Password = password_box.Text;
            try
            {
                Customers.Create(customers);
                MessageBox.Show("You are successfully register", caption: "Information");
            }
            catch (Exception ex)
            {

                MessageBox.Show(Environment.NewLine + ex.Message, caption: "Error register");
            }
            name_box.Clear();
            birthday_box.Clear();
            mail_box.Clear();
            address_box.Clear();
            phone_box.Clear();
            password_box.Clear();

        }

        private void loginpage_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
