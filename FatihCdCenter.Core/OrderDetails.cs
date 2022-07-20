using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatihCdCenter.Core
{
    public static class OrderDetails
    {
        public static int Create(Model.OrderDetails entity)
        {
            try
            {
                SqlConnection con=Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into OrderDetails([Id],[OrderId],[MovieId],[Price])values (@Id,@OrderId,@MovieId,@Price)";
                cmd.Parameters.AddWithValue("@Id", entity.Id);
                cmd.Parameters.AddWithValue("OrderId", entity.OrderId);
                cmd.Parameters.AddWithValue("MovieId", entity.MovieId);
                cmd.Parameters.AddWithValue("@Price", entity.Price);
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
        public static IEnumerable<Model.OrderDetails> SelectTop(Model.OrderDetails entity)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select top 1([Id],[OrderId],[MovieId],[Price])from OrderDetails where Id=@Id";
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                List<Model.OrderDetails> OrderDetailsTopList = new List<Model.OrderDetails>();
                while (dr.Read())
                {
                    Model.OrderDetails orderDetails = new Model.OrderDetails();
                    orderDetails.Id = Convert.ToInt32(dr["Id"]);
                    orderDetails.OrderId = Convert.ToInt32(dr["OrderId"]);
                    orderDetails.MovieId = Convert.ToInt32(dr["MovieId"]);
                    orderDetails.Price = dr["Price"]?.ToString() ?? "";
                    OrderDetailsTopList.Add(orderDetails);
                }
                con.Close();
                return OrderDetailsTopList;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static bool Update(Model.OrderDetails entity)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update OrderDetails set Id=@Id,OrderId=@OrderId,MovieId=@MovieId,Price=@Price where Id=@Id";
                cmd.Parameters.AddWithValue("@Id", entity.Id);
                cmd.Parameters.AddWithValue("@OrderId", entity.OrderId);
                cmd.Parameters.AddWithValue("MovieId", entity.MovieId);
                cmd.Parameters.AddWithValue("Price", entity.Price);
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
        public static bool Update(int Id,int orderId,int movieId,string price)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection=con;
                cmd.CommandText= "update OrderDetails set Id = @Id,OrderId = @OrderId,MovieId = @MovieId,Price = @Price where Id = @Id";
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@OrderId", orderId);
                cmd.Parameters.AddWithValue("@MovieId", movieId);
                cmd.Parameters.AddWithValue("@Price", price);
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
        public static bool Delete(Model.OrderDetails entity)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from OrderDetails where Id=@Id";
                cmd.Parameters.AddWithValue("@Id", entity.Id);
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
                cmd.CommandText = "delete from OrderDetails where Id=@Id";
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
        public static IEnumerable<Model.OrderDetails> GetAllOrderDetails()
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select*from OrderDetails";
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                List<Model.OrderDetails> OrderDetailsList = new List<Model.OrderDetails>();
                while (dr.Read())
                {
                    Model.OrderDetails orderDetails = new Model.OrderDetails();
                    orderDetails.Id = Convert.ToInt32(dr["Id"]);
                    orderDetails.OrderId = Convert.ToInt32(dr["OrderId"]);
                    orderDetails.MovieId = Convert.ToInt32(dr["MovieId"]);
                    orderDetails.Price = dr["Price"]?.ToString() ?? "";
                    OrderDetailsList.Add(orderDetails);
                }
                con.Close();
                return OrderDetailsList;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static Model.OrderDetails GetOrderDetailsById(int id)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select*from OrderDetails where Id=@Id";
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Model.OrderDetails orderDetails = new Model.OrderDetails();

                while (dr.Read())
                {
                    orderDetails.Id = Convert.ToInt32(dr["Id"]);
                    orderDetails.OrderId = Convert.ToInt32(dr["OrderId"]);
                    orderDetails.MovieId = Convert.ToInt32(dr["MovieId"]);
                    orderDetails.Price = dr["Price"]?.ToString() ?? "";
                }
                con.Close();
                return orderDetails;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
