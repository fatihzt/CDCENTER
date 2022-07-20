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
    public static class Movies
    {
        //IMAGE INSERT TO DATABASE AND LOAD THEM.

       

        public static int Create(Model.Movies entity)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "insert into Movies([Name],[MovieSummary],[MovieDuration],[IsTVSeries],[BannerPatch]) values (@Name,@MovieSummary,@MovieDuration,@IsTVSeries,@BannerPatch)  ";

                cmd.Parameters.AddWithValue("@Name", entity.Name);
                cmd.Parameters.AddWithValue("@MovieSummary", entity.MovieSummary);
                cmd.Parameters.AddWithValue("@MovieDuration", entity.MovieDuration);
                cmd.Parameters.AddWithValue("@IsTVSeries", entity.IsTVSeries);
                cmd.Parameters.AddWithValue("@BannerPatch", entity.BannerPatch);


                con.Open();
                
                int value = cmd.ExecuteNonQuery();

                con.Close();
                

                return value;


            }
            catch (Exception )
            {
                return -1;
            }
        }
        public static IEnumerable<Model.Movies> SelectTop(Model.Movies entity)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select top 1 [Id],[Name],[MoviesSummary],[MoviesDuration],[IsFinish] from Movies where Id=@Id";
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                List<Model.Movies> MoviesListTop = new List<Model.Movies>();
                while (dr.Read())
                {
                    Model.Movies movies = new Model.Movies();
                    movies.Id = Convert.ToInt32(dr["Id"]);
                    movies.Name = dr["Name"]?.ToString()?? "";
                    movies.MovieSummary = dr["MovieSummary"]?.ToString()?? "";
                    movies.MovieDuration = dr["MovieDuration"]?.ToString()?? "";
                    movies.IsTVSeries = (bool)dr["IsTVSeries"];
                    movies.BannerPatch = dr["BannerPatch"]?.ToString() ?? "";
                    MoviesListTop.Add(movies);
                }
                con.Close();
                return MoviesListTop;

            }
            catch (Exception )
            {

                throw;
            }
        }

        public static bool Update(Model.Movies entity)
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
                cmd.Parameters.AddWithValue("@IsFinish", entity.IsTVSeries);
                cmd.Parameters.AddWithValue("@BannerPatch", entity.BannerPatch);
                cmd.Parameters.AddWithValue("@Id", entity.Id);

                con.Open();

                bool value = cmd.ExecuteNonQuery() > 0;

                con.Close();

                return value;

            }
            catch (Exception )
            {
                return false;
            }
        }
       
        public static bool Update(int Id,string name,string movieSummary,string movieDuration,bool isTVSeries,string bannerPatch)
        {
            try
            {
                SqlConnection con =Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Update Movies set MovieSummary=@MovieSummary,MovieDuration=@MovieDuration ,IsTVSeries=@IsTVSeries,BannerPatch=@BannerPatch where Id = @Id";
                cmd.Parameters.AddWithValue("@Id",Id);
                cmd.Parameters.AddWithValue("@Name",name);
                cmd.Parameters.AddWithValue("@MovieSummary",movieSummary);
                cmd.Parameters.AddWithValue("@MovieDuration",movieDuration);
                cmd.Parameters.AddWithValue("@IsTVSeries", isTVSeries);
                cmd.Parameters.AddWithValue("@BannerPatch", bannerPatch);
                con.Open();

                bool value = cmd.ExecuteNonQuery() > 0;

                con.Close();

                return value;

            }
            catch (Exception )
            {
                return false;
            }
        }

        public static bool Delete(Model.Movies entity)
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
            catch (Exception )
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
                cmd.CommandText = "delete from Movies where Id = @Id";
                cmd.Parameters.AddWithValue("@Id", Id);

                con.Open();

                bool value = cmd.ExecuteNonQuery() > 0;

                con.Close();

                return value;

            }
            catch (Exception )
            {
                return false;
            }
        }

        public static IEnumerable<Model.Movies> GetAllMovies()
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
                    movie.Id = (int)(int?) dr["Id"];
                    movie.Name = dr["Name"]?.ToString() ?? "";
                    movie.MovieSummary = dr["MovieSummary"]?.ToString() ?? "";
                    movie.MovieDuration = dr["MovieDuration"]?.ToString() ?? "";
                    movie.IsTVSeries = (bool)dr["IsTVSeries"];
                    movie.BannerPatch = dr["BannerPatch"]?.ToString() ?? "";

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
        public static Model.Movies GetMoviesById(int id)
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
                    movie.Name = dr["Name"]?.ToString()?? "";
                    movie.MovieSummary = dr["MovieSummary"]?.ToString()?? "";
                    movie.MovieDuration = dr["MovieDuration"]?.ToString()?? "";
                    movie.IsTVSeries = (bool)dr["IsTVSeries"];
                    movie.BannerPatch = dr["BannerPatch"]?.ToString() ?? "";
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
