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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Tvseries_btn_Click(object sender, EventArgs e)
        {
            AddTVSeries addTVSeries= new AddTVSeries();
            addTVSeries.ShowDialog();
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
       
    }
}
