using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatihCdCenter.Core
{
    public static class Customers
    {
        
        public static int Create(Model.Customers entity)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into Customers ([Name],[Birthday],[Mail],[Address],[Phone],[Password]) values (@Name,@Birthday,@Mail,@Address,@Phone,@Password)";
                cmd.Parameters.AddWithValue("@Name", entity.Name);
                cmd.Parameters.AddWithValue("@Birthday", entity.Birthday);
                cmd.Parameters.AddWithValue("@Mail", entity.Mail);
                cmd.Parameters.AddWithValue("@Address", entity.Address);
                cmd.Parameters.AddWithValue("@Phone", entity.Phone);
                cmd.Parameters.AddWithValue("@Password", entity.Password);
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
        public static IEnumerable<Model.Customers> SelectTop(Model.Customers entity)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select top 1 ([Id],[Name],[Birthday],[Mail],[Address],[Phone],[Password])from Customers where Id=@Id";
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                List<Model.Customers> CustomerListTop = new List<Model.Customers>();
                while (dr.Read())
                {
                    Model.Customers customer = new Model.Customers();
                    customer.Id = Convert.ToInt32(dr["Id"]);
                    customer.Name = dr["Name"]?.ToString() ?? "";
                    customer.Birthday = dr["Birthday"]?.ToString() ?? "";
                    customer.Mail = dr["Mail"]?.ToString() ?? "";
                    customer.Address = dr["Address"]?.ToString() ?? "";
                    customer.Phone = dr["Phone"]?.ToString() ?? "";
                    customer.Password = dr["Password"]?.ToString() ?? "";
                    CustomerListTop.Add(customer);
                }
                con.Close();
                return CustomerListTop;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static bool Update(Model.Customers entity)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText= "Update Customer set Name = @Name,Birthday=@Birthday,Mail=@Mail,Address=@Address,Phone=@Phone,Password=@Password where Id = @Id";
                cmd.Parameters.AddWithValue("@Name", entity.Name);
                cmd.Parameters.AddWithValue("@Birthday", entity.Birthday);
                cmd.Parameters.AddWithValue("@Mail", entity.Mail);
                cmd.Parameters.AddWithValue("@Address", entity.Address);
                cmd.Parameters.AddWithValue("@Phone", entity.Phone);
                cmd.Parameters.AddWithValue("@Id", entity.Id);
                cmd.Parameters.AddWithValue("@Password", entity.Password);
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
        public static bool Update(int Id,string name,string birthday,string mail,string address,string phone,string password)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText= "Update Customer set Name = @Name,Birthday=@Birthday,Mail=@Mail,Address=@Address,Phone=@Phone,Password=@Password where Id = @Id";
                cmd.Parameters.AddWithValue("@Name",name);
                cmd.Parameters.AddWithValue("@Birthday",birthday);
                cmd.Parameters.AddWithValue("@Mail",mail);
                cmd.Parameters.AddWithValue("@Address",address);
                cmd.Parameters.AddWithValue("@Phone",phone);
                cmd.Parameters.AddWithValue("@Id",Id);
                cmd.Parameters.AddWithValue("@Password", password);
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
        public static bool Delete(Model.Customers entity)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from Customers where Id=@Id";
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
                cmd.CommandText = "delete from Customers where Id=@Id";
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
        public static IEnumerable<Model.Customers> GetAllCustomers()
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select*from Customers";
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                List<Model.Customers> CustomerList= new List<Model.Customers>();
                while (dr.Read())
                {
                    Model.Customers customer= new Model.Customers();
                    customer.Id = Convert.ToInt32(dr["Id"]);
                    customer.Name = dr["Name"]?.ToString() ?? "";
                    customer.Birthday = dr["Birthday"]?.ToString() ?? "";
                    customer.Mail = dr["Mail"]?.ToString() ?? "";
                    customer.Address = dr["Address"]?.ToString() ?? "";
                    customer.Phone = dr["Phone"]?.ToString() ?? "";
                    customer.Password = dr["Password"]?.ToString() ?? "";
                    CustomerList.Add(customer);
                }
                con.Close();
                return CustomerList;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static Model.Customers GetCustomersById(int id)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "Select * From Custoemrs Where Id=@Id";
                cmd.Parameters.AddWithValue(@"Id", id);
                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                Model.Customers customer = new Model.Customers();

                while (dr.Read())
                {
                    customer.Id = Convert.ToInt32(dr["Id"]);
                    customer.Name = dr["Name"]?.ToString() ?? "";
                    customer.Birthday = dr["Birthday"]?.ToString() ?? "";
                    customer.Mail = dr["Mail"]?.ToString() ?? "";
                    customer.Address = dr["Address"]?.ToString() ?? "";
                    customer.Phone = dr["Phone"]?.ToString() ?? "";
                    customer.Password = dr["Password"]?.ToString() ?? "";
                }
                con.Close();
                return customer;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static Model.Customers GetCustomerOnLogin(string name,string password)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select*from Customers where Name=@Name and Password=@Password";
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Name", name);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Model.Customers customers = new Model.Customers();
                while (dr.Read())
                {
                    customers.Id = Convert.ToInt32(dr["Id"]);
                    customers.Name = dr["Name"]?.ToString() ?? "";
                    customers.Birthday = dr["Birthday"]?.ToString() ?? "";
                    customers.Mail = dr["Mail"]?.ToString() ?? "";
                    customers.Address = dr["Address"]?.ToString() ?? "";
                    customers.Phone = dr["Phone"]?.ToString() ?? "";
                    customers.Password = dr["Password"]?.ToString() ?? "";
                }
                con.Close();
                return customers;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static Model.Customers GetCustomer(string name)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select*from Customers where Name=@Name";
                cmd.Parameters.AddWithValue("@Name", name);
                con.Open();
                SqlDataReader dr=cmd.ExecuteReader();
                Model.Customers customers = new Model.Customers();
                while (dr.Read())
                {
                    customers.Id = Convert.ToInt32(dr["Id"]);
                    customers.Name = dr["Name"]?.ToString() ?? "";
                    customers.Birthday = dr["Birthday"]?.ToString() ?? "";
                    customers.Mail = dr["Mail"]?.ToString() ?? "";
                    customers.Address = dr["Address"]?.ToString() ?? "";
                    customers.Phone = dr["Phone"]?.ToString() ?? "";
                    customers.Password = dr["Password"]?.ToString() ?? "";
                }
                con.Close();
                return customers;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

