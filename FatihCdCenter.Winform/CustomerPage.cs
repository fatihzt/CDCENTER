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
    
    public partial class CustomerPage : Form
    {
        
        
        public CustomerPage()
        {
            InitializeComponent();
            
            
        }
        private void clear_btn_Click(object sender, EventArgs e)
        {
            Model.Orders orders = new Model.Orders();
            var customer = Customers.GetCustomer(namecum_lb.Text);
            orders.CustomerId = customer.Id;
            orders.Date = date_lb.Text;
            orders.PaymentType = paymenttype_combo.Text;
            Orders.Create(orders);
            TakeOrderInformation();
            
            
        }
        void TakeOrderInformation()
        {
            var value = Customers.GetCustomer(namecum_lb.Text);
            var value1 = value.Id;
            try
            {
                orderoveralllist_grid.DataSource = Orders.GetAllOrdersById(value1);
            }
            catch (Exception ex)
            {

                MessageBox.Show(Environment.NewLine + ex.Message, caption: "Error takeorderınfo!");
            }
        }
        void TakeMovieInformation()
        {
            

            try
            {
                ordermovielist_grid.DataSource = Movies.GetAllMovies();

            }
            catch (Exception ex)
            {

                MessageBox.Show(Environment.NewLine + ex.Message, caption: "Error take ordermovie");
            }

        }
        

        private void CustomerPage_Load(object sender, EventArgs e)
        {
            date_lb.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            namecum_lb.Text = LoginPage.CustomerName;
            TakeMovieInformation();
            TakeOrderInformation();
            
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deleteorder_btn_Click(object sender, EventArgs e)
        {
            if(orderoveralllist_grid.SelectedRows.Count == 0)
            {
                return;
            }
            object value = orderoveralllist_grid.SelectedRows[0].Cells[0].Value;
            int Id = (int)value;
            Orders.Delete(Id);
        }

        private void ordermovielist_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ordermovielist_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string var = this.ordermovielist_grid.CurrentRow.Cells[5].Value?.ToString() ?? "";
            orderbanner_pic.Image = Image.FromFile(var);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Thank You For Shopping\n" +
                "FatihCdCenter",new Font("Arial",35,FontStyle.Bold),Brushes.Red,new Point(230));
            

            

        }

        private void bill_btn_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void orderbuy_btn_Click(object sender, EventArgs e)
        {
            string str = paymenttype_combo.Text;
            if(str!="Credit Card" && str != "Cash")
            {
                MessageBox.Show("Select a Payment Type Please!",caption:"Error!");
            }
            Model.OrderDetails orderDetails = new Model.OrderDetails();
            orderDetails.OrderId = Convert.ToInt32(orderoveralllist_grid.SelectedColumns[0]);
            orderDetails.MovieId = Convert.ToInt32(ordermovielist_grid.SelectedColumns[0]);
        }
    }
}
