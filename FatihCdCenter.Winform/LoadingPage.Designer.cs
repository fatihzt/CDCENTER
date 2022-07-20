namespace FatihCdCenter.Winform
{
    partial class LoadingPage
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
            this.components = new System.ComponentModel.Container();
            this.welcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.myprogress = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcome.ForeColor = System.Drawing.Color.White;
            this.welcome.Location = new System.Drawing.Point(121, 43);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(418, 32);
            this.welcome.TabIndex = 1;
            this.welcome.Text = "Fatih\'s CD Center ";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Version 1.0";
            // 
            // myprogress
            // 
            this.myprogress.BackColor = System.Drawing.Color.DarkOrange;
            this.myprogress.ForeColor = System.Drawing.Color.DarkOrange;
            this.myprogress.Location = new System.Drawing.Point(0, 251);
            this.myprogress.Name = "myprogress";
            this.myprogress.Size = new System.Drawing.Size(657, 17);
            this.myprogress.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox3.Image = global::FatihCdCenter.Winform.Properties.Resources.cd__1_;
            this.pictureBox3.Location = new System.Drawing.Point(251, 78);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // LoadingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(657, 268);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.myprogress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcome);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingPage";
            this.Text = "LoadingPage";
            this.Load += new System.EventHandler(this.LoadingPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label welcome;
        private Label label1;
        private ProgressBar myprogress;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox3;
    }
}