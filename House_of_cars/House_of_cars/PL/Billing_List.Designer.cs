namespace House_of_cars.PL
{
    partial class Billing_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing_List));
            this.dataGridBills = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBills)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridBills
            // 
            this.dataGridBills.AllowUserToAddRows = false;
            this.dataGridBills.AllowUserToDeleteRows = false;
            this.dataGridBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBills.BackgroundColor = System.Drawing.Color.White;
            this.dataGridBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBills.Location = new System.Drawing.Point(17, 54);
            this.dataGridBills.MultiSelect = false;
            this.dataGridBills.Name = "dataGridBills";
            this.dataGridBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBills.Size = new System.Drawing.Size(949, 315);
            this.dataGridBills.TabIndex = 1;
            this.dataGridBills.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBills_CellContentClick);
            this.dataGridBills.DoubleClick += new System.EventHandler(this.dataGridBills_DoubleClick);
            // 
            // Billing_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 422);
            this.Controls.Add(this.dataGridBills);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Billing_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing_List";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBills)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridBills;
    }
}