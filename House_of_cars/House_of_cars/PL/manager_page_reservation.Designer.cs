namespace House_of_cars.PL
{
    partial class manager_page_reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager_page_reservation));
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.bntdelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.btnreturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sweet Movements Personal Use", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(521, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 65);
            this.label2.TabIndex = 60;
            this.label2.Text = "House of Cars";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(35, 48);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(460, 20);
            this.search.TabIndex = 59;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Transparent;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(644, 411);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(68, 31);
            this.btnadd.TabIndex = 58;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // bntdelete
            // 
            this.bntdelete.BackColor = System.Drawing.Color.Transparent;
            this.bntdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntdelete.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntdelete.ForeColor = System.Drawing.Color.White;
            this.bntdelete.Location = new System.Drawing.Point(491, 411);
            this.bntdelete.Name = "bntdelete";
            this.bntdelete.Size = new System.Drawing.Size(76, 31);
            this.bntdelete.TabIndex = 57;
            this.bntdelete.Text = "Delete";
            this.bntdelete.UseVisualStyleBackColor = false;
            this.bntdelete.Click += new System.EventHandler(this.bntdelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.Transparent;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.White;
            this.btnedit.Location = new System.Drawing.Point(573, 411);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(65, 31);
            this.btnedit.TabIndex = 56;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.GridColor = System.Drawing.Color.Black;
            this.dataGridView4.Location = new System.Drawing.Point(35, 77);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(677, 318);
            this.dataGridView4.TabIndex = 55;
            // 
            // btnreturn
            // 
            this.btnreturn.BackColor = System.Drawing.Color.Transparent;
            this.btnreturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreturn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreturn.ForeColor = System.Drawing.Color.White;
            this.btnreturn.Location = new System.Drawing.Point(35, 411);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(79, 31);
            this.btnreturn.TabIndex = 54;
            this.btnreturn.Text = "Return";
            this.btnreturn.UseVisualStyleBackColor = false;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // manager_page_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(750, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.bntdelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.btnreturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "manager_page_reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "manager_page_reservation";
            this.Load += new System.EventHandler(this.manager_page_reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button bntdelete;
        private System.Windows.Forms.Button btnedit;
        public System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button btnreturn;
    }
}