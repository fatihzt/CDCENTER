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
            SqlConnection con = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select top 1 [Id],[Name],[TVSeriesSummary],[TVSeriesSeason],[IsFinish] from TVSeries where Id=@Id";
            cmd.Parameters.AddWithValue("@Id", Id);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tvname_text.Text = dr.GetString(1);
                    tvsummary_text.Text = dr.GetString(2);
                    tvseason_text.Text = dr.GetString(3);
                    isfinishtv_check.Tag = dr.GetString(4);
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(Environment.NewLine + ex.Message, caption: "Error present");
            }
        }
        private void save_tvseries_btn_Click(object sender, EventArgs e)
        {
            Core.TVSeries tvseriesManager=new Core.TVSeries();
            Model.TVSeries tvSeries = new Model.TVSeries();
            tvSeries.Name = tvname_text.Text;
            tvSeries.TVSeriesSummary = tvsummary_text.Text;
            tvSeries.TVSeriesSeason = tvseason_text.Text;
            tvSeries.IsFinish = isfinishtv_check.Checked;
            try
            {
                tvseriesManager.Create(tvSeries);
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
            SqlConnection con = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select [Id],[Name],[TVSeriesSummary],[TVSeriesSeason],[IsFinish] from TVSeries ";
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                tvseries_grid.Rows.Clear();
                while (dr.Read())
                {
                    tvseries_grid.Rows.Add(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetBoolean(4));
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
            Core.TVSeries tvseriesRemoving=new Core.TVSeries();
            tvseriesRemoving.Delete(Id);
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
            Core.TVSeries tvseriesUpdating = new Core.TVSeries();
            try
            {
                tvseriesUpdating.Update(Id,tvname_text.Text,tvsummary_text.Text,tvseason_text.Text,isfinishtv_check.Checked);
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
            MainPage mainPage = new MainPage();
            mainPage.ShowDialog();
        }
    }
}
