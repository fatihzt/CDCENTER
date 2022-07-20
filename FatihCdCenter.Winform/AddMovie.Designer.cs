namespace FatihCdCenter.Winform
{
    partial class AddMovie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMovie));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.istvseries_check = new System.Windows.Forms.CheckBox();
            this.mname_text = new System.Windows.Forms.TextBox();
            this.msummary_text = new System.Windows.Forms.TextBox();
            this.edit_movie_btn = new System.Windows.Forms.Button();
            this.remove_movie_btn = new System.Windows.Forms.Button();
            this.save_movie_btn = new System.Windows.Forms.Button();
            this.movielist_grid = new System.Windows.Forms.DataGridView();
            this.Movies_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movies_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movies_Summary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movies_Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsTVSeries = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BannerPatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mduration_text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bannerpic = new System.Windows.Forms.PictureBox();
            this.bannerpatch_text = new System.Windows.Forms.TextBox();
            this.openimg_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.movielist_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerpic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Movie Summary ";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Movie Duration";
            // 
            // istvseries_check
            // 
            this.istvseries_check.AutoSize = true;
            this.istvseries_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.istvseries_check.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.istvseries_check.ForeColor = System.Drawing.Color.OrangeRed;
            this.istvseries_check.Location = new System.Drawing.Point(12, 150);
            this.istvseries_check.Name = "istvseries_check";
            this.istvseries_check.Size = new System.Drawing.Size(137, 23);
            this.istvseries_check.TabIndex = 3;
            this.istvseries_check.Text = "Is it TVSeries?";
            this.istvseries_check.UseVisualStyleBackColor = false;
            // 
            // mname_text
            // 
            this.mname_text.Location = new System.Drawing.Point(189, 12);
            this.mname_text.Name = "mname_text";
            this.mname_text.Size = new System.Drawing.Size(267, 23);
            this.mname_text.TabIndex = 4;
            // 
            // msummary_text
            // 
            this.msummary_text.Location = new System.Drawing.Point(189, 60);
            this.msummary_text.Name = "msummary_text";
            this.msummary_text.Size = new System.Drawing.Size(267, 23);
            this.msummary_text.TabIndex = 6;
            // 
            // edit_movie_btn
            // 
            this.edit_movie_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.edit_movie_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.edit_movie_btn.FlatAppearance.BorderSize = 0;
            this.edit_movie_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.edit_movie_btn.ForeColor = System.Drawing.Color.OrangeRed;
            this.edit_movie_btn.Location = new System.Drawing.Point(371, 138);
            this.edit_movie_btn.Name = "edit_movie_btn";
            this.edit_movie_btn.Size = new System.Drawing.Size(85, 35);
            this.edit_movie_btn.TabIndex = 20;
            this.edit_movie_btn.Text = "Edit";
            this.edit_movie_btn.UseVisualStyleBackColor = false;
            this.edit_movie_btn.Click += new System.EventHandler(this.edit_movie_btn_Click);
            // 
            // remove_movie_btn
            // 
            this.remove_movie_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.remove_movie_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.remove_movie_btn.FlatAppearance.BorderSize = 0;
            this.remove_movie_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remove_movie_btn.ForeColor = System.Drawing.Color.OrangeRed;
            this.remove_movie_btn.Location = new System.Drawing.Point(267, 138);
            this.remove_movie_btn.Name = "remove_movie_btn";
            this.remove_movie_btn.Size = new System.Drawing.Size(85, 35);
            this.remove_movie_btn.TabIndex = 19;
            this.remove_movie_btn.Text = "Remove";
            this.remove_movie_btn.UseVisualStyleBackColor = false;
            this.remove_movie_btn.Click += new System.EventHandler(this.remove_movie_btn_Click);
            // 
            // save_movie_btn
            // 
            this.save_movie_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.save_movie_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.save_movie_btn.FlatAppearance.BorderSize = 0;
            this.save_movie_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.save_movie_btn.ForeColor = System.Drawing.Color.OrangeRed;
            this.save_movie_btn.Location = new System.Drawing.Point(161, 138);
            this.save_movie_btn.Name = "save_movie_btn";
            this.save_movie_btn.Size = new System.Drawing.Size(85, 35);
            this.save_movie_btn.TabIndex = 18;
            this.save_movie_btn.Text = "Save";
            this.save_movie_btn.UseVisualStyleBackColor = false;
            this.save_movie_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // movielist_grid
            // 
            this.movielist_grid.AllowUserToAddRows = false;
            this.movielist_grid.AllowUserToDeleteRows = false;
            this.movielist_grid.BackgroundColor = System.Drawing.Color.White;
            this.movielist_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.movielist_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movielist_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Movies_Id,
            this.Movies_Name,
            this.Movies_Summary,
            this.Movies_Duration,
            this.IsTVSeries,
            this.BannerPatch});
            this.movielist_grid.Location = new System.Drawing.Point(12, 188);
            this.movielist_grid.Name = "movielist_grid";
            this.movielist_grid.ReadOnly = true;
            this.movielist_grid.RowTemplate.Height = 25;
            this.movielist_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.movielist_grid.Size = new System.Drawing.Size(819, 301);
            this.movielist_grid.TabIndex = 21;
            this.movielist_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.movielist_grid_CellContentClick);
            this.movielist_grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.movielist_grid_CellDoubleClick);
            // 
            // Movies_Id
            // 
            this.Movies_Id.DataPropertyName = "Id";
            this.Movies_Id.HeaderText = "Id";
            this.Movies_Id.Name = "Movies_Id";
            this.Movies_Id.ReadOnly = true;
            this.Movies_Id.Width = 120;
            // 
            // Movies_Name
            // 
            this.Movies_Name.DataPropertyName = "Name";
            this.Movies_Name.HeaderText = "Name";
            this.Movies_Name.Name = "Movies_Name";
            this.Movies_Name.ReadOnly = true;
            this.Movies_Name.Width = 120;
            // 
            // Movies_Summary
            // 
            this.Movies_Summary.DataPropertyName = "MovieSummary";
            this.Movies_Summary.HeaderText = "Movies Summary";
            this.Movies_Summary.Name = "Movies_Summary";
            this.Movies_Summary.ReadOnly = true;
            this.Movies_Summary.Width = 120;
            // 
            // Movies_Duration
            // 
            this.Movies_Duration.DataPropertyName = "MovieDuration";
            this.Movies_Duration.HeaderText = "Movies Duration";
            this.Movies_Duration.Name = "Movies_Duration";
            this.Movies_Duration.ReadOnly = true;
            this.Movies_Duration.Width = 120;
            // 
            // IsTVSeries
            // 
            this.IsTVSeries.DataPropertyName = "IsTVSeries";
            this.IsTVSeries.HeaderText = "Is it TVSeries?";
            this.IsTVSeries.Name = "IsTVSeries";
            this.IsTVSeries.ReadOnly = true;
            this.IsTVSeries.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsTVSeries.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsTVSeries.Width = 120;
            // 
            // BannerPatch
            // 
            this.BannerPatch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BannerPatch.DataPropertyName = "BannerPatch";
            this.BannerPatch.HeaderText = "BannerPatch";
            this.BannerPatch.Name = "BannerPatch";
            this.BannerPatch.ReadOnly = true;
            // 
            // mduration_text
            // 
            this.mduration_text.Location = new System.Drawing.Point(189, 109);
            this.mduration_text.Multiline = true;
            this.mduration_text.Name = "mduration_text";
            this.mduration_text.Size = new System.Drawing.Size(267, 23);
            this.mduration_text.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::FatihCdCenter.Winform.Properties.Resources.output_onlinepngtools__13_;
            this.button1.Location = new System.Drawing.Point(781, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bannerpic
            // 
            this.bannerpic.BackColor = System.Drawing.Color.White;
            this.bannerpic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bannerpic.Location = new System.Drawing.Point(473, 13);
            this.bannerpic.Name = "bannerpic";
            this.bannerpic.Size = new System.Drawing.Size(267, 133);
            this.bannerpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bannerpic.TabIndex = 23;
            this.bannerpic.TabStop = false;
            // 
            // bannerpatch_text
            // 
            this.bannerpatch_text.Location = new System.Drawing.Point(473, 159);
            this.bannerpatch_text.Name = "bannerpatch_text";
            this.bannerpatch_text.Size = new System.Drawing.Size(267, 23);
            this.bannerpatch_text.TabIndex = 30;
            // 
            // openimg_btn
            // 
            this.openimg_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.openimg_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.openimg_btn.FlatAppearance.BorderSize = 0;
            this.openimg_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.openimg_btn.ForeColor = System.Drawing.Color.OrangeRed;
            this.openimg_btn.Location = new System.Drawing.Point(746, 147);
            this.openimg_btn.Name = "openimg_btn";
            this.openimg_btn.Size = new System.Drawing.Size(85, 35);
            this.openimg_btn.TabIndex = 29;
            this.openimg_btn.Text = "Open";
            this.openimg_btn.UseVisualStyleBackColor = false;
            this.openimg_btn.Click += new System.EventHandler(this.openimg_btn_Click);
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(843, 501);
            this.Controls.Add(this.bannerpatch_text);
            this.Controls.Add(this.openimg_btn);
            this.Controls.Add(this.bannerpic);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.movielist_grid);
            this.Controls.Add(this.edit_movie_btn);
            this.Controls.Add(this.remove_movie_btn);
            this.Controls.Add(this.save_movie_btn);
            this.Controls.Add(this.msummary_text);
            this.Controls.Add(this.mduration_text);
            this.Controls.Add(this.mname_text);
            this.Controls.Add(this.istvseries_check);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMovie";
            this.Load += new System.EventHandler(this.AddMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movielist_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox istvseries_check;
        private TextBox mname_text;
        private TextBox msummary_text;
        private Button edit_movie_btn;
        private Button remove_movie_btn;
        private Button save_movie_btn;
        private DataGridView movielist_grid;
        private TextBox mduration_text;
        private Button button1;
        private PictureBox bannerpic;
        private Label filename;
        private TextBox bannerpatch_text;
        private Button openimg_btn;
        private DataGridViewTextBoxColumn Movies_Id;
        private DataGridViewTextBoxColumn Movies_Name;
        private DataGridViewTextBoxColumn Movies_Summary;
        private DataGridViewTextBoxColumn Movies_Duration;
        private DataGridViewCheckBoxColumn IsTVSeries;
        private DataGridViewTextBoxColumn BannerPatch;
    }
}