using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;

namespace FatihCdCenter.Core
{
    public class Movies
    {
        public int Create(Model.Movies entity)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "insert into Movies([Name],[MovieSummary],[MovieDuration],[IsFinish]) values(@Name,@MovieSummary,@MovieDuration,@IsFinish) Select Scope_Identity()";
                cmd.Parameters.AddWithValue("@Name", entity.Name);
                cmd.Parameters.AddWithValue("@MovieSummary", entity.MovieSummary);
                cmd.Parameters.AddWithValue("@MovieDuration", entity.MovieDuration);
                cmd.Parameters.AddWithValue("@IsFinish", entity.IsFinish);

                con.Open();

                int value = cmd.ExecuteNonQuery();

                con.Close();
                

                return value;


            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public bool Update(Model.Movies entity)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Update Movies set Name = @Name,MovieSummary=@MovieSummary,MovieDuration=@MovieDuration where Id = @Id";
                cmd.Parameters.AddWithValue("@Name", entity.Name);
                cmd.Parameters.AddWithValue("@MovieSummary", entity.MovieSummary);
                cmd.Parameters.AddWithValue("@MovieDuration", entity.MovieDuration);
                cmd.Parameters.AddWithValue("@IsFinish", entity.IsFinish);
                cmd.Parameters.AddWithValue("@Id", entity.Id);

                con.Open();

                bool value = cmd.ExecuteNonQuery() > 0;

                con.Close();

                return value;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
       
        public bool Update(int Id,string name,string movieSummary,string movieDuration,bool isFinish)
        {
            try
            {
                SqlConnection con =Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Update Movies set MovieSummary=@MovieSummary,MovieDuration=@MovieDuration IsFinish=@IsFinish where Id = @Id";
               
                cmd.Parameters.AddWithValue("@Id",Id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@MovieSummary", movieSummary);
                cmd.Parameters.AddWithValue("@MovieDuration", movieDuration);
                cmd.Parameters.AddWithValue("@IsFinish", isFinish);
                

                con.Open();

                bool value = cmd.ExecuteNonQuery() > 0;

                con.Close();

                return value;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(Model.Movies entity)
        {
            try
            {
                SqlConnection con =Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from Movies where Id = @Id";
                cmd.Parameters.AddWithValue("@Id", entity.Id);

                con.Open();

                bool value = cmd.ExecuteNonQuery() > 0;

                con.Close();

                return value;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int Id)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from Movies where Id = @Id";
                cmd.Parameters.AddWithValue("@Id", Id);

                con.Open();

                bool value = cmd.ExecuteNonQuery() > 0;

                con.Close();

                return value;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<Model.Movies> GetAllMovies()
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "Select * From Movies";
                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                List<Model.Movies> MoviesList = new List<Model.Movies>();
                while (dr.Read())
                {
                    Model.Movies movie = new Model.Movies();
                    movie.Id = Convert.ToInt32(dr["Id"]);
                    movie.Name = dr["Name"].ToString();
                    movie.MovieSummary = dr["MovieSummary"].ToString();
                    movie.MovieDuration = dr["MovieDuration"].ToString();
                    movie.IsFinish = (bool)dr["IsFinish"];

                    MoviesList.Add(movie);
                }
                con.Close();
                return MoviesList;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Model.Movies GetMoviesById(int id)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "Select * From Movies Where Id=@Id";
                cmd.Parameters.AddWithValue(@"Id", id);
                con.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                Model.Movies movie = new Model.Movies();

                while (dr.Read())
                {
                    movie.Id = Convert.ToInt32(dr["Id"]);
                    movie.Name = dr["Name"].ToString();
                    movie.MovieSummary = dr["MovieSummary"].ToString();
                    movie.MovieDuration = dr["MovieDuration"].ToString();
                    movie.IsFinish = (bool)dr["IsFinish"];
                }
                con.Close();
                return movie;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
