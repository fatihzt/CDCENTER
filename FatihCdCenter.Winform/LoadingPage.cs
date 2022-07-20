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
    public partial class LoadingPage : Form
    {
        public LoadingPage()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint++;
            myprogress.Value = startpoint;
            if (myprogress.Value == 100)
            {
                myprogress.Value = 0;
                timer1.Stop();
                LoginPage log=new LoginPage();
                this.Hide();
                log.Show();
            }
        }

        private void LoadingPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
