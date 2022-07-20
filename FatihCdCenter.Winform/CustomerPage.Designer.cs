namespace FatihCdCenter.Winform
{
    partial class CustomerPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPage));
            this.ordermovielist_grid = new System.Windows.Forms.DataGridView();
            this.addorder_btn = new System.Windows.Forms.Button();
            this.deleteorder_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.orderbuy_btn = new System.Windows.Forms.Button();
            this.date_lb = new System.Windows.Forms.Label();
            this.namecum_lb = new System.Windows.Forms.Label();
            this.paymenttype_combo = new System.Windows.Forms.ComboBox();
            this.PaymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderoveralllist_grid = new System.Windows.Forms.DataGridView();
            this.orderbanner_pic = new System.Windows.Forms.PictureBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.bill_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordermovielist_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderoveralllist_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderbanner_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // ordermovielist_grid
            // 
            this.ordermovielist_grid.AllowUserToAddRows = false;
            this.ordermovielist_grid.AllowUserToDeleteRows = false;
            this.ordermovielist_grid.BackgroundColor = System.Drawing.Color.White;
            this.ordermovielist_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordermovielist_grid.Location = new System.Drawing.Point(6, 306);
            this.ordermovielist_grid.Name = "ordermovielist_grid";
            this.ordermovielist_grid.ReadOnly = true;
            this.ordermovielist_grid.RowTemplate.Height = 25;
            this.ordermovielist_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordermovielist_grid.Size = new System.Drawing.Size(868, 317);
            this.ordermovielist_grid.TabIndex = 0;
            this.ordermovielist_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordermovielist_grid_CellContentClick);
            this.ordermovielist_grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordermovielist_grid_CellDoubleClick);
            // 
            // addorder_btn
            // 
            this.addorder_btn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addorder_btn.ForeColor = System.Drawing.Color.OrangeRed;
            this.addorder_btn.Location = new System.Drawing.Point(6, 265);
            this.addorder_btn.Name = "addorder_btn";
            this.addorder_btn.Size = new System.Drawing.Size(107, 35);
            this.addorder_btn.TabIndex = 9;
            this.addorder_btn.Text = "ADD";
            this.addorder_btn.UseVisualStyleBackColor = true;
            this.addorder_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // deleteorder_btn
            // 
            this.deleteorder_btn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteorder_btn.ForeColor = System.Drawing.Color.OrangeRed;
            this.deleteorder_btn.Location = new System.Drawing.Point(119, 265);
            this.deleteorder_btn.Name = "deleteorder_btn";
            this.deleteorder_btn.Size = new System.Drawing.Size(107, 35);
            this.deleteorder_btn.TabIndex = 11;
            this.deleteorder_btn.Text = "DELETE";
            this.deleteorder_btn.UseVisualStyleBackColor = true;
            this.deleteorder_btn.Click += new System.EventHandler(this.deleteorder_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(856, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // orderbuy_btn
            // 
            this.orderbuy_btn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderbuy_btn.ForeColor = System.Drawing.Color.OrangeRed;
            this.orderbuy_btn.Location = new System.Drawing.Point(232, 265);
            this.orderbuy_btn.Name = "orderbuy_btn";
            this.orderbuy_btn.Size = new System.Drawing.Size(107, 35);
            this.orderbuy_btn.TabIndex = 13;
            this.orderbuy_btn.Text = "BUY";
            this.orderbuy_btn.UseVisualStyleBackColor = true;
            this.orderbuy_btn.Click += new System.EventHandler(this.orderbuy_btn_Click);
            // 
            // date_lb
            // 
            this.date_lb.AutoSize = true;
            this.date_lb.BackColor = System.Drawing.Color.White;
            this.date_lb.Location = new System.Drawing.Point(437, 84);
            this.date_lb.Name = "date_lb";
            this.date_lb.Size = new System.Drawing.Size(38, 15);
            this.date_lb.TabIndex = 18;
            this.date_lb.Text = "label2";
            // 
            // namecum_lb
            // 
            this.namecum_lb.BackColor = System.Drawing.Color.White;
            this.namecum_lb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.namecum_lb.ForeColor = System.Drawing.Color.OrangeRed;
            this.namecum_lb.Location = new System.Drawing.Point(613, 59);
            this.namecum_lb.Name = "namecum_lb";
            this.namecum_lb.Size = new System.Drawing.Size(261, 40);
            this.namecum_lb.TabIndex = 19;
            this.namecum_lb.Text = "label2";
            this.namecum_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paymenttype_combo
            // 
            this.paymenttype_combo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.paymenttype_combo.ForeColor = System.Drawing.Color.OrangeRed;
            this.paymenttype_combo.FormattingEnabled = true;
            this.paymenttype_combo.Items.AddRange(new object[] {
            "Credit Card",
            "Cash"});
            this.paymenttype_combo.Location = new System.Drawing.Point(6, 232);
            this.paymenttype_combo.Name = "paymenttype_combo";
            this.paymenttype_combo.Size = new System.Drawing.Size(267, 27);
            this.paymenttype_combo.TabIndex = 21;
            this.paymenttype_combo.Text = "Payment Type";
            // 
            // PaymentType
            // 
            this.PaymentType.DataPropertyName = "PaymentType";
            this.PaymentType.HeaderText = "PaymentType";
            this.PaymentType.Name = "PaymentType";
            this.PaymentType.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "CustomerId";
            this.CustomerId.HeaderText = "CustomerId";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // orderoveralllist_grid
            // 
            this.orderoveralllist_grid.AllowUserToAddRows = false;
            this.orderoveralllist_grid.AllowUserToDeleteRows = false;
            this.orderoveralllist_grid.BackgroundColor = System.Drawing.Color.White;
            this.orderoveralllist_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderoveralllist_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CustomerId,
            this.Date,
            this.PaymentType});
            this.orderoveralllist_grid.Location = new System.Drawing.Point(437, 102);
            this.orderoveralllist_grid.Name = "orderoveralllist_grid";
            this.orderoveralllist_grid.ReadOnly = true;
            this.orderoveralllist_grid.RowTemplate.Height = 25;
            this.orderoveralllist_grid.Size = new System.Drawing.Size(437, 198);
            this.orderoveralllist_grid.TabIndex = 8;
            // 
            // orderbanner_pic
            // 
            this.orderbanner_pic.BackColor = System.Drawing.Color.White;
            this.orderbanner_pic.Location = new System.Drawing.Point(6, 12);
            this.orderbanner_pic.Name = "orderbanner_pic";
            this.orderbanner_pic.Size = new System.Drawing.Size(267, 133);
            this.orderbanner_pic.TabIndex = 22;
            this.orderbanner_pic.TabStop = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // bill_btn
            // 
            this.bill_btn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bill_btn.ForeColor = System.Drawing.Color.OrangeRed;
            this.bill_btn.Location = new System.Drawing.Point(6, 191);
            this.bill_btn.Name = "bill_btn";
            this.bill_btn.Size = new System.Drawing.Size(267, 35);
            this.bill_btn.TabIndex = 23;
            this.bill_btn.Text = "TAKE A BILL";
            this.bill_btn.UseVisualStyleBackColor = true;
            this.bill_btn.Click += new System.EventHandler(this.bill_btn_Click);
            // 
            // CustomerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(892, 635);
            this.Controls.Add(this.bill_btn);
            this.Controls.Add(this.orderbanner_pic);
            this.Controls.Add(this.paymenttype_combo);
            this.Controls.Add(this.namecum_lb);
            this.Controls.Add(this.date_lb);
            this.Controls.Add(this.orderbuy_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteorder_btn);
            this.Controls.Add(this.addorder_btn);
            this.Controls.Add(this.orderoveralllist_grid);
            this.Controls.Add(this.ordermovielist_grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerPage";
            this.Text = "CustomerPage";
            this.Load += new System.EventHandler(this.CustomerPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordermovielist_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderoveralllist_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderbanner_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView ordermovielist_grid;
        private Button addorder_btn;
        private Button deleteorder_btn;
        private Button button1;
        private Button orderbuy_btn;
        private Label date_lb;
        private Label namecum_lb;
        private ComboBox paymenttype_combo;
        private DataGridViewTextBoxColumn PaymentType;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn CustomerId;
        private DataGridViewTextBoxColumn Id;
        private DataGridView orderoveralllist_grid;
        private PictureBox orderbanner_pic;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button bill_btn;
    }
}