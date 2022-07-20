using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatihCdCenter.Core
{
    public static class Orders
    {
        public static int Create(Model.Orders entity)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText= "insert into Orders ([CustomerId],[Date],[PaymentType]) values (@CustomerId, @Date,@PaymentType)";
                //cmd.Parameters.AddWithValue("@Id",entity.Id);
                cmd.Parameters.AddWithValue("@Id", entity.Id);
                cmd.Parameters.AddWithValue("@CustomerId", entity.CustomerId);
                cmd.Parameters.AddWithValue("@Date", entity.Date);
                cmd.Parameters.AddWithValue("@PaymentType", entity.PaymentType);
                
                con.Open();
                int value = cmd.ExecuteNonQuery();
                con.Close();
                return value;
            }
            catch (Exception)
            {

                return -1;
            }
        }
        public static bool Delete(Model.Orders entity)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from Orders where Id=@Id";
                cmd.Parameters.AddWithValue("id", entity.Id);
                con.Open();
                bool value = cmd.ExecuteNonQuery() > 0;
                con.Close();
                return value;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public static bool Delete(int Id)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from Orders where Id=@Id";
                cmd.Parameters.AddWithValue("@Id", Id);
                con.Open();
                bool value = cmd.ExecuteNonQuery() > 0;
                con.Close();
                return value;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public static IEnumerable<Model.Orders> GetAllOrders()
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select*from Orders";
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                List<Model.Orders> allOrders = new List<Model.Orders>();
                while (dr.Read())
                {
                    Model.Orders orders = new Model.Orders();
                    orders.Id = (int)(int?)dr["Id"];
                    orders.CustomerId = (int)(int?)dr["CustomerId"];
                    orders.Date = dr["Date"]?.ToString() ?? "";
                    orders.PaymentType = dr["PaymentType"]?.ToString() ?? "";
                    allOrders.Add(orders);
                }
                con.Close();
                return allOrders;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static IEnumerable<Model.Orders> GetAllOrdersById(int id)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select*from Orders where CustomerId=@CustomerId";
                cmd.Parameters.AddWithValue("@CustomerId", id);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                List<Model.Orders> allOrdersById=new List<Model.Orders>();
                while (dr.Read())
                {
                    Model.Orders orders = new Model.Orders();
                    orders.Id = (int)(int?)dr["Id"];
                    orders.CustomerId = (int)(int?)dr["CustomerId"];
                    orders.Date = dr["Date"]?.ToString() ?? "";
                    orders.PaymentType = dr["PaymentType"]?.ToString() ?? "";
                    allOrdersById.Add(orders);
                }
                con.Close();
                return allOrdersById;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
