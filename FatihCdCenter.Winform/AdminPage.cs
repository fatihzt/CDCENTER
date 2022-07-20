using FatihCdCenter.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FatihCdCenter.Winform
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        

        private void Credit_btn_Click(object sender, EventArgs e)
        {
            Credit credit = new Credit();
            credit.ShowDialog();
        }

        private void Movies_btn_Click(object sender, EventArgs e)
        {
            AddMovie addMovie = new AddMovie();
            addMovie.ShowDialog();
            
        }

        private void Contact_btn_Click(object sender, EventArgs e)
        {
            ContactUs contactUs = new ContactUs();
            contactUs.ShowDialog();
        }

        private void loginpage_btn_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
