using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatihCdCenter.Core
{
    public class TVSeries
    {
        public int Create(Model.TVSeries entity)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into TVSeries([Name],[TVSeriesSummary],[TVSeriesSeason],[IsFinish])values (@Name,@TVSeriesSummary,@TVSeriesSeason,@IsFinish) Select Scope_Identity()";
                cmd.Parameters.AddWithValue("@Name", entity.Name);
                cmd.Parameters.AddWithValue("@TVSeriesSummary", entity.TVSeriesSummary);
                cmd.Parameters.AddWithValue("@TVSeriesSeason", entity.TVSeriesSeason);
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
        public bool Update(Model.TVSeries entity)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update TVSeries set Name=@Name,TVSeriesSummary=@TVSeriesSummary,TVSeriesSeason=@TVSeriesSeason,IsFinish=@IsFinish";
                cmd.Parameters.AddWithValue("@TVSeriesSummary", entity.TVSeriesSummary);
                cmd.Parameters.AddWithValue("@TVSeriesSeason", entity.TVSeriesSeason);
                cmd.Parameters.AddWithValue("@IsFinish", entity.IsFinish);
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
        public bool Update(int Id,string name,string tvseriesSummary,string tvseriesSeason,bool isFinish)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Update TVSeries set Name=@Name,TVSeriesSummary=@TVSeriesSummary,TVSeriesSeason=@TVSeriesSeason,IsFinish=@IsFinish where Id = @Id";
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@TVSeriesSummary", tvseriesSummary);
                cmd.Parameters.AddWithValue("@TVSeriesSeason", tvseriesSeason);
                cmd.Parameters.AddWithValue("@IsFinish", isFinish);
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
        public bool Delete(Model.TVSeries entity)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd=new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from TVSeries where Id=@Id";
                cmd.Parameters.AddWithValue("@Id",entity.Id);
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
                cmd.CommandText = "Delete from TVSeries where Id=@Id";
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
        public IEnumerable<Model.TVSeries> GetAllTVSeries()
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd=new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select*from TVSeries";
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                List<Model.TVSeries> TVSerieslist = new List<Model.TVSeries>();
                while (dr.Read())
                {
                    Model.TVSeries tvseries = new Model.TVSeries();
                    tvseries.Id = Convert.ToInt32(dr["Id"]);
                    tvseries.Name = dr["Name"].ToString();
                    tvseries.TVSeriesSummary = dr["TVSeriesSummary"].ToString();
                    tvseries.TVSeriesSeason = dr["TVSeriesSeason"].ToString();
                    tvseries.IsFinish = (bool)dr["IsFinish"];
                    TVSerieslist.Add(tvseries);

                }
                con.Close();
                return TVSerieslist;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public Model.TVSeries GetTVSeriesById(int id)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection=con;
                cmd.CommandText = "select*from TVSeries where Id=@Id";
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                Model.TVSeries tvseries = new Model.TVSeries();
                while (dr.Read())
                {
                    tvseries.Id = Convert.ToInt32(dr["Id"]);
                    tvseries.Name = dr["Name"].ToString();
                    tvseries.TVSeriesSummary = dr["TVSeriesSummary"].ToString();
                    tvseries.TVSeriesSeason = dr["TVSeriesSeason"].ToString();
                    tvseries.IsFinish = (bool)dr["IsFinish"];
                }
                con.Close();
                return tvseries;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
