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
    public partial class AddMovie : Form
    {
        private int Id;
        
        public AddMovie()
        {
            InitializeComponent();
        }
        public AddMovie(int id)
        {
            InitializeComponent();
            
            Id = id;
            SqlConnection con = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select top 1 [Id],[Name],[MoviesSummary],[MoviesDuration],[IsFinish] from Movies where Id=@Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    mname_text.Text = dr.GetString(1);
                    msummary_text.Text=dr.GetString(2);
                    mduration_text.Text = dr.GetString(3);
                    Movie_IsFinish.Tag = dr.GetString(4);
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(Environment.NewLine + ex.Message, caption: "Error present");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Core.Movies moviesManager=new Core.Movies();
            Model.Movies movies=new Model.Movies();
            movies.Name = mname_text.Text;
            movies.MovieSummary = msummary_text.Text;
            movies.MovieDuration = mduration_text.Text;
            movies.IsFinish=isfinishmov_check.Checked;
            
            try
            {
                moviesManager.Create(movies);
                MessageBox.Show("Saved successfully",caption:"Information");
            }
            catch (Exception ex)
            {

                MessageBox.Show(Environment.NewLine + ex.Message, caption: "Error SaveMovie");
            }
            TakeMovieInformation();
            

        }
         void TakeMovieInformation()
        {
            SqlConnection con = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con;
            cmd.CommandText = "select [Id],[Name],[MovieSummary],[MovieDuration],[IsFinish] from Movies";
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                movielist_grid.Rows.Clear();
                while (dr.Read())
                {
                    movielist_grid.Rows.Add(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3),dr.GetBoolean(4));

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(Environment.NewLine + ex.Message, caption: "Error take");
            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }

        }

        private void AddMovie_Load(object sender, EventArgs e)
        {
            TakeMovieInformation();
        }

        private void remove_movie_btn_Click(object sender, EventArgs e)
        {
            
            if (movielist_grid.SelectedRows.Count == 0)
            {
                return;
            }
            object value = movielist_grid.SelectedRows[0].Cells[0].Value;
            int Id = (int)value;
            Core.Movies moviesRemoving = new Core.Movies();
            moviesRemoving.Delete(Id);
            TakeMovieInformation();

        }

        private void edit_movie_btn_Click(object sender, EventArgs e)
        {
            if(movielist_grid.SelectedRows.Count == 0)
            {
                return;
            }
            
            object value = movielist_grid.SelectedRows[0].Cells[0].Value;
            int Id=(int)value;
            Core.Movies moviesupdating = new Core.Movies();
            try
            {
                moviesupdating.Update(Id,mname_text.Text,msummary_text.Text,mduration_text.Text,isfinishmov_check.Checked);
                MessageBox.Show("Update Successfully Done", caption: "Information");
            }
            catch (Exception ex)
            {

                MessageBox.Show(Environment.NewLine + ex.Message, caption: "Error update");
            }
            
            
            TakeMovieInformation();
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }
    }
}
