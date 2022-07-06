namespace FatihCdCenter.Winform
{
    partial class AddTVSeries
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
            this.tvsummary_text = new System.Windows.Forms.TextBox();
            this.tvname_text = new System.Windows.Forms.TextBox();
            this.isfinishtv_check = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tvseries_grid = new System.Windows.Forms.DataGridView();
            this.TVSeries_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVSeries_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVSeries_Summary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVSeries_Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVSeries_IsFinish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.save_tvseries_btn = new System.Windows.Forms.Button();
            this.remove_tvseries_btn = new System.Windows.Forms.Button();
            this.edit_tvseries_btn = new System.Windows.Forms.Button();
            this.tvseason_text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tvseries_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // tvsummary_text
            // 
            this.tvsummary_text.Location = new System.Drawing.Point(189, 48);
            this.tvsummary_text.Multiline = true;
            this.tvsummary_text.Name = "tvsummary_text";
            this.tvsummary_text.Size = new System.Drawing.Size(267, 40);
            this.tvsummary_text.TabIndex = 13;
            // 
            // tvname_text
            // 
            this.tvname_text.Location = new System.Drawing.Point(189, 12);
            this.tvname_text.Name = "tvname_text";
            this.tvname_text.Size = new System.Drawing.Size(267, 23);
            this.tvname_text.TabIndex = 11;
            // 
            // isfinishtv_check
            // 
            this.isfinishtv_check.AutoSize = true;
            this.isfinishtv_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.isfinishtv_check.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.isfinishtv_check.ForeColor = System.Drawing.Color.Red;
            this.isfinishtv_check.Location = new System.Drawing.Point(12, 163);
            this.isfinishtv_check.Name = "isfinishtv_check";
            this.isfinishtv_check.Size = new System.Drawing.Size(94, 23);
            this.isfinishtv_check.TabIndex = 10;
            this.isfinishtv_check.Text = "Watched";
            this.isfinishtv_check.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tv Series Season";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tv Series Summary ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // tvseries_grid
            // 
            this.tvseries_grid.AllowUserToAddRows = false;
            this.tvseries_grid.AllowUserToDeleteRows = false;
            this.tvseries_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tvseries_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TVSeries_Id,
            this.TVSeries_Name,
            this.TVSeries_Summary,
            this.TVSeries_Duration,
            this.TVSeries_IsFinish});
            this.tvseries_grid.Location = new System.Drawing.Point(12, 201);
            this.tvseries_grid.Name = "tvseries_grid";
            this.tvseries_grid.ReadOnly = true;
            this.tvseries_grid.RowTemplate.Height = 25;
            this.tvseries_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tvseries_grid.Size = new System.Drawing.Size(535, 288);
            this.tvseries_grid.TabIndex = 14;
            // 
            // TVSeries_Id
            // 
            this.TVSeries_Id.HeaderText = "Id";
            this.TVSeries_Id.Name = "TVSeries_Id";
            this.TVSeries_Id.ReadOnly = true;
            // 
            // TVSeries_Name
            // 
            this.TVSeries_Name.HeaderText = "Name";
            this.TVSeries_Name.Name = "TVSeries_Name";
            this.TVSeries_Name.ReadOnly = true;
            // 
            // TVSeries_Summary
            // 
            this.TVSeries_Summary.HeaderText = "TVSeries Summary";
            this.TVSeries_Summary.Name = "TVSeries_Summary";
            this.TVSeries_Summary.ReadOnly = true;
            // 
            // TVSeries_Duration
            // 
            this.TVSeries_Duration.HeaderText = "TVSeries Duration";
            this.TVSeries_Duration.Name = "TVSeries_Duration";
            this.TVSeries_Duration.ReadOnly = true;
            // 
            // TVSeries_IsFinish
            // 
            this.TVSeries_IsFinish.HeaderText = "TVSeries IsFinish";
            this.TVSeries_IsFinish.Name = "TVSeries_IsFinish";
            this.TVSeries_IsFinish.ReadOnly = true;
            // 
            // save_tvseries_btn
            // 
            this.save_tvseries_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.save_tvseries_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.save_tvseries_btn.FlatAppearance.BorderSize = 0;
            this.save_tvseries_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.save_tvseries_btn.ForeColor = System.Drawing.Color.Red;
            this.save_tvseries_btn.Location = new System.Drawing.Point(161, 151);
            this.save_tvseries_btn.Name = "save_tvseries_btn";
            this.save_tvseries_btn.Size = new System.Drawing.Size(85, 35);
            this.save_tvseries_btn.TabIndex = 15;
            this.save_tvseries_btn.Text = "Save";
            this.save_tvseries_btn.UseVisualStyleBackColor = false;
            this.save_tvseries_btn.Click += new System.EventHandler(this.save_tvseries_btn_Click);
            // 
            // remove_tvseries_btn
            // 
            this.remove_tvseries_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.remove_tvseries_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.remove_tvseries_btn.FlatAppearance.BorderSize = 0;
            this.remove_tvseries_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remove_tvseries_btn.ForeColor = System.Drawing.Color.Red;
            this.remove_tvseries_btn.Location = new System.Drawing.Point(267, 151);
            this.remove_tvseries_btn.Name = "remove_tvseries_btn";
            this.remove_tvseries_btn.Size = new System.Drawing.Size(85, 35);
            this.remove_tvseries_btn.TabIndex = 16;
            this.remove_tvseries_btn.Text = "Remove";
            this.remove_tvseries_btn.UseVisualStyleBackColor = false;
            this.remove_tvseries_btn.Click += new System.EventHandler(this.remove_tvseries_btn_Click);
            // 
            // edit_tvseries_btn
            // 
            this.edit_tvseries_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.edit_tvseries_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.edit_tvseries_btn.FlatAppearance.BorderSize = 0;
            this.edit_tvseries_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.edit_tvseries_btn.ForeColor = System.Drawing.Color.Red;
            this.edit_tvseries_btn.Location = new System.Drawing.Point(371, 151);
            this.edit_tvseries_btn.Name = "edit_tvseries_btn";
            this.edit_tvseries_btn.Size = new System.Drawing.Size(85, 35);
            this.edit_tvseries_btn.TabIndex = 17;
            this.edit_tvseries_btn.Text = "Edit";
            this.edit_tvseries_btn.UseVisualStyleBackColor = false;
            this.edit_tvseries_btn.Click += new System.EventHandler(this.edit_tvseries_btn_Click);
            // 
            // tvseason_text
            // 
            this.tvseason_text.Location = new System.Drawing.Point(189, 108);
            this.tvseason_text.Multiline = true;
            this.tvseason_text.Name = "tvseason_text";
            this.tvseason_text.Size = new System.Drawing.Size(267, 38);
            this.tvseason_text.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::FatihCdCenter.Winform.Properties.Resources.output_onlinepngtools__13_;
            this.button1.Location = new System.Drawing.Point(497, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddTVSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(559, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edit_tvseries_btn);
            this.Controls.Add(this.remove_tvseries_btn);
            this.Controls.Add(this.save_tvseries_btn);
            this.Controls.Add(this.tvseries_grid);
            this.Controls.Add(this.tvsummary_text);
            this.Controls.Add(this.tvseason_text);
            this.Controls.Add(this.tvname_text);
            this.Controls.Add(this.isfinishtv_check);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddTVSeries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTVSeries";
            this.Load += new System.EventHandler(this.AddTVSeries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tvseries_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tvsummary_text;
        private TextBox tvname_text;
        private CheckBox isfinishtv_check;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView tvseries_grid;
        private Button save_tvseries_btn;
        private Button remove_tvseries_btn;
        private Button edit_tvseries_btn;
        private TextBox tvseason_text;
        private DataGridViewTextBoxColumn TVSeries_Id;
        private DataGridViewTextBoxColumn TVSeries_Name;
        private DataGridViewTextBoxColumn TVSeries_Summary;
        private DataGridViewTextBoxColumn TVSeries_Duration;
        private DataGridViewTextBoxColumn TVSeries_IsFinish;
        private Button button1;
    }
}