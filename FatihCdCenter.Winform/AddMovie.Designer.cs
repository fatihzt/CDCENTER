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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isfinishmov_check = new System.Windows.Forms.CheckBox();
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
            this.Movie_IsFinish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mduration_text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.movielist_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
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
            this.label2.ForeColor = System.Drawing.Color.Red;
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
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Movie Duration";
            // 
            // isfinishmov_check
            // 
            this.isfinishmov_check.AutoSize = true;
            this.isfinishmov_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.isfinishmov_check.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.isfinishmov_check.ForeColor = System.Drawing.Color.Red;
            this.isfinishmov_check.Location = new System.Drawing.Point(12, 150);
            this.isfinishmov_check.Name = "isfinishmov_check";
            this.isfinishmov_check.Size = new System.Drawing.Size(94, 23);
            this.isfinishmov_check.TabIndex = 3;
            this.isfinishmov_check.Text = "Watched";
            this.isfinishmov_check.UseVisualStyleBackColor = false;
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
            this.edit_movie_btn.ForeColor = System.Drawing.Color.Red;
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
            this.remove_movie_btn.ForeColor = System.Drawing.Color.Red;
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
            this.save_movie_btn.ForeColor = System.Drawing.Color.Red;
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
            this.movielist_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movielist_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Movies_Id,
            this.Movies_Name,
            this.Movies_Summary,
            this.Movies_Duration,
            this.Movie_IsFinish});
            this.movielist_grid.Location = new System.Drawing.Point(12, 188);
            this.movielist_grid.Name = "movielist_grid";
            this.movielist_grid.ReadOnly = true;
            this.movielist_grid.RowTemplate.Height = 25;
            this.movielist_grid.Size = new System.Drawing.Size(544, 301);
            this.movielist_grid.TabIndex = 21;
            // 
            // Movies_Id
            // 
            this.Movies_Id.HeaderText = "Id";
            this.Movies_Id.Name = "Movies_Id";
            this.Movies_Id.ReadOnly = true;
            // 
            // Movies_Name
            // 
            this.Movies_Name.HeaderText = "Name";
            this.Movies_Name.Name = "Movies_Name";
            this.Movies_Name.ReadOnly = true;
            // 
            // Movies_Summary
            // 
            this.Movies_Summary.HeaderText = "Movies Summary";
            this.Movies_Summary.Name = "Movies_Summary";
            this.Movies_Summary.ReadOnly = true;
            // 
            // Movies_Duration
            // 
            this.Movies_Duration.HeaderText = "Movies Duration";
            this.Movies_Duration.Name = "Movies_Duration";
            this.Movies_Duration.ReadOnly = true;
            // 
            // Movie_IsFinish
            // 
            this.Movie_IsFinish.HeaderText = "Movie IsFinish";
            this.Movie_IsFinish.Name = "Movie_IsFinish";
            this.Movie_IsFinish.ReadOnly = true;
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
            this.button1.Location = new System.Drawing.Point(506, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(569, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.movielist_grid);
            this.Controls.Add(this.edit_movie_btn);
            this.Controls.Add(this.remove_movie_btn);
            this.Controls.Add(this.save_movie_btn);
            this.Controls.Add(this.msummary_text);
            this.Controls.Add(this.mduration_text);
            this.Controls.Add(this.mname_text);
            this.Controls.Add(this.isfinishmov_check);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddMovie";
            this.Text = "AddMovie";
            this.Load += new System.EventHandler(this.AddMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movielist_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox isfinishmov_check;
        private TextBox mname_text;
        private TextBox msummary_text;
        private Button edit_movie_btn;
        private Button remove_movie_btn;
        private Button save_movie_btn;
        private DataGridView movielist_grid;
        private DataGridViewTextBoxColumn Movies_Id;
        private DataGridViewTextBoxColumn Movies_Name;
        private DataGridViewTextBoxColumn Movies_Summary;
        private DataGridViewTextBoxColumn Movies_Duration;
        private TextBox mduration_text;
        private DataGridViewTextBoxColumn Movie_IsFinish;
        private Button button1;
    }
}