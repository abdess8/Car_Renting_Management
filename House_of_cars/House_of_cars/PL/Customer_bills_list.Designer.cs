namespace House_of_cars.PL
{
    partial class Customer_bills_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_bills_list));
            this.dataGridcustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridcustomer
            // 
            this.dataGridcustomer.AllowUserToAddRows = false;
            this.dataGridcustomer.AllowUserToDeleteRows = false;
            this.dataGridcustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridcustomer.BackgroundColor = System.Drawing.Color.White;
            this.dataGridcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridcustomer.Location = new System.Drawing.Point(16, 54);
            this.dataGridcustomer.Name = "dataGridcustomer";
            this.dataGridcustomer.ReadOnly = true;
            this.dataGridcustomer.Size = new System.Drawing.Size(954, 322);
            this.dataGridcustomer.TabIndex = 0;
            this.dataGridcustomer.DoubleClick += new System.EventHandler(this.dataGridcustomer_DoubleClick);
            // 
            // Customer_bills_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 422);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridcustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer_bills_list";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_bills_list";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridcustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridcustomer;
    }
}