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
    public partial class AddTVSeries : Form
    {
        private int Id;
        public AddTVSeries()
        {
            InitializeComponent();
        }
        public AddTVSeries(int id)
        {
            InitializeComponent();
            Id = id;
            Model.TVSeries tvSeries = new Model.TVSeries();
            tvSeries.Id = Id;
            try
            {
                TVSeries.SelectTop(tvSeries);
            }
            catch (Exception ex)
            {

                MessageBox.Show(Environment.NewLine + ex.Message, caption: "Error present");
            }
        }
        private void save_tvseries_btn_Click(object sender, EventArgs e)
        {
            
            Model.TVSeries tvSeries = new Model.TVSeries();
            tvSeries.Name = tvname_text.Text;
            tvSeries.TVSeriesSummary = tvsummary_text.Text;
            tvSeries.TVSeriesSeason = tvseason_text.Text;
            tvSeries.IsFinish = isfinishtv_check.Checked;
            try
            {
                TVSeries.Create(tvSeries);
                MessageBox.Show("Saved Successfuly ", caption: "Information");
            }
            catch (Exception ex)
            {

                MessageBox.Show(Environment.NewLine + ex.Message, caption: "Error SaveTVSeries");
            }
            TakeTVSeriesInformation();
        }
        void TakeTVSeriesInformation()
        {
            Model.TVSeries tvSeries = new Model.TVSeries();
            try
            {
                tvseries_grid.DataSource = Movies.GetAllMovies();

            }
            catch (Exception ex)
            {

                MessageBox.Show(Environment.NewLine + ex.Message, caption: "Error take");
            }
        }

        private void AddTVSeries_Load(object sender, EventArgs e)
        {
            TakeTVSeriesInformation();
        }

        private void remove_tvseries_btn_Click(object sender, EventArgs e)
        {
            if (tvseries_grid.SelectedRows.Count == 0)
            {
                return;
            }
            object value = tvseries_grid.SelectedRows[0].Cells[0].Value;
            int Id=(int)value;
            
            TVSeries.Delete(Id);
            TakeTVSeriesInformation();
        }

        private void edit_tvseries_btn_Click(object sender, EventArgs e)
        {
            if (tvseries_grid.SelectedRows.Count == 0)
            {
                return;
            }
            object value=tvseries_grid.SelectedRows[0].Cells[0].Value;
            int Id = (int)value;
            
            try
            {
                TVSeries.Update(Id,tvname_text.Text,tvsummary_text.Text,tvseason_text.Text,isfinishtv_check.Checked);
                MessageBox.Show("Updating successfully done", caption: "Information");
            }
            catch (Exception ex)
            {

                MessageBox.Show(Environment.NewLine + ex.Message, caption: "Error updating ");
            }
            
            TakeTVSeriesInformation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
