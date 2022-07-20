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
        private string fileName;
        private int Id;
        
        public AddMovie()
        {
            InitializeComponent();
        }
        public AddMovie(int id)
        {
            InitializeComponent();
            
            Id = id;
            
            Model.Movies movies = new Model.Movies();
            movies.Id= Id;
            try
            {
                Movies.SelectTop(movies);
            }
            catch (Exception ex)
            {

                MessageBox.Show(Environment.NewLine + ex.Message, caption: "Error present");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Model.Movies movies=new Model.Movies();
            movies.Name = mname_text.Text;
            movies.MovieSummary = msummary_text.Text;
            movies.MovieDuration = mduration_text.Text;
            movies.IsTVSeries=istvseries_check.Checked;
            movies.BannerPatch = bannerpatch_text.Text;
            
            try
            {
                Movies.Create(movies);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(Environment.NewLine + ex.Message, caption: "error save");
            }
            TakeMovieInformation();

            mname_text.Clear();
            msummary_text.Clear();
            mduration_text.Clear();
            istvseries_check.Checked = false;
            bannerpatch_text.Clear();
            bannerpic.Image = null;
        }
         void TakeMovieInformation()
        {
             
            
            
            try
            {
                movielist_grid.DataSource = Movies.GetAllMovies();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(Environment.NewLine + ex.Message, caption: "Error take");
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
            Movies.Delete(Id);
            TakeMovieInformation();
            mname_text.Clear();
            msummary_text.Clear();
            mduration_text.Clear();
            istvseries_check.Checked = false;

        }

        private void edit_movie_btn_Click(object sender, EventArgs e)
        {
            if (movielist_grid.SelectedRows.Count == 0)
            {
                return;
            }
            object value = movielist_grid.SelectedRows[0].Cells[0].Value;
            int Id=(int)value;
            
            try
            {
                Movies.Update(Id,mname_text.Text,msummary_text.Text,mduration_text.Text,istvseries_check.Checked,bannerpatch_text.Text);
                MessageBox.Show("Update Successfully Done", caption: "Information");
            }
            catch (Exception ex)
            {

                MessageBox.Show(Environment.NewLine + ex.Message, caption: "Error update");
            }
            
            
            TakeMovieInformation();
            mname_text.Clear();
            msummary_text.Clear();
            mduration_text.Clear();
            istvseries_check.Checked = false;
            bannerpatch_text.Clear();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void movielist_grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                mname_text.Text = this.movielist_grid.CurrentRow.Cells[1].Value?.ToString() ?? "";
                msummary_text.Text = this.movielist_grid.CurrentRow.Cells[2].Value?.ToString() ?? "";
                mduration_text.Text = this.movielist_grid.CurrentRow.Cells[3].Value?.ToString() ?? "";
                istvseries_check.Checked =this.movielist_grid.CurrentRow.Cells[4].ValueType == typeof(bool);
                bannerpatch_text.Text = this.movielist_grid.CurrentRow.Cells[5].Value?.ToString() ?? "";
                bannerpic.Image = Image.FromFile(bannerpatch_text.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(Environment.NewLine + ex.Message, caption: "Error! double click ");
            } 
        }

        private void movielist_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        byte[] ConvertImageToByte(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
      

        private void openimg_btn_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd=new OpenFileDialog() { Filter = "JPEG|*jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileName = ofd.FileName;
                    bannerpatch_text.Text = fileName;
                    bannerpic.Image = Image.FromFile(fileName);
                }
            }
        }

        
    }
}
