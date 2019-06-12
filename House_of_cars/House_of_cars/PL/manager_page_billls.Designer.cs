namespace House_of_cars.PL
{
    partial class manager_page_billls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager_page_bills));
            this.btnreturn = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clientidcombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DRIVER_LICENSE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cin2 = new System.Windows.Forms.Label();
            this.name2 = new System.Windows.Forms.Label();
            this.CIN = new System.Windows.Forms.TextBox();
            this.FNAME = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.billidcombo = new System.Windows.Forms.ComboBox();
            this.BILL_DATE = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.BILL_STATUS = new System.Windows.Forms.TextBox();
            this.fjofhdf = new System.Windows.Forms.Label();
            this.TOTAL_AMOUNT = new System.Windows.Forms.TextBox();
            this.typecar2 = new System.Windows.Forms.Label();
            this.carid2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnreturn
            // 
            this.btnreturn.BackColor = System.Drawing.Color.Transparent;
            this.btnreturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreturn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreturn.ForeColor = System.Drawing.Color.White;
            this.btnreturn.Location = new System.Drawing.Point(22, 414);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(65, 31);
            this.btnreturn.TabIndex = 13;
            this.btnreturn.Text = "Return";
            this.btnreturn.UseVisualStyleBackColor = false;
            this.btnreturn.Click += new System.EventHandler(this.Deconnect_Button_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(21, 196);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(953, 205);
            this.dataGridView5.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.clientidcombo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DRIVER_LICENSE);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cin2);
            this.groupBox1.Controls.Add(this.name2);
            this.groupBox1.Controls.Add(this.CIN);
            this.groupBox1.Controls.Add(this.FNAME);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(21, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 144);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Infos";
            // 
            // clientidcombo
            // 
            this.clientidcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientidcombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientidcombo.FormattingEnabled = true;
            this.clientidcombo.Location = new System.Drawing.Point(12, 48);
            this.clientidcombo.Name = "clientidcombo";
            this.clientidcombo.Size = new System.Drawing.Size(204, 23);
            this.clientidcombo.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(227, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 91;
            this.label2.Text = "Driver\'s License*";
            // 
            // DRIVER_LICENSE
            // 
            this.DRIVER_LICENSE.Location = new System.Drawing.Point(227, 100);
            this.DRIVER_LICENSE.Name = "DRIVER_LICENSE";
            this.DRIVER_LICENSE.Size = new System.Drawing.Size(209, 21);
            this.DRIVER_LICENSE.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 90;
            this.label3.Text = "Client ID*";
            // 
            // cin2
            // 
            this.cin2.AutoSize = true;
            this.cin2.BackColor = System.Drawing.Color.Transparent;
            this.cin2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cin2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cin2.Location = new System.Drawing.Point(227, 27);
            this.cin2.Name = "cin2";
            this.cin2.Size = new System.Drawing.Size(37, 18);
            this.cin2.TabIndex = 89;
            this.cin2.Text = "CIN*";
            // 
            // name2
            // 
            this.name2.AutoSize = true;
            this.name2.BackColor = System.Drawing.Color.Transparent;
            this.name2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.name2.Location = new System.Drawing.Point(12, 79);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(54, 18);
            this.name2.TabIndex = 87;
            this.name2.Text = "Name*";
            // 
            // CIN
            // 
            this.CIN.Location = new System.Drawing.Point(227, 48);
            this.CIN.Name = "CIN";
            this.CIN.Size = new System.Drawing.Size(209, 21);
            this.CIN.TabIndex = 85;
            // 
            // FNAME
            // 
            this.FNAME.Location = new System.Drawing.Point(12, 100);
            this.FNAME.Name = "FNAME";
            this.FNAME.Size = new System.Drawing.Size(204, 21);
            this.FNAME.TabIndex = 86;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.billidcombo);
            this.groupBox2.Controls.Add(this.BILL_DATE);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.BILL_STATUS);
            this.groupBox2.Controls.Add(this.fjofhdf);
            this.groupBox2.Controls.Add(this.TOTAL_AMOUNT);
            this.groupBox2.Controls.Add(this.typecar2);
            this.groupBox2.Controls.Add(this.carid2);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(525, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 144);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bills";
            // 
            // billidcombo
            // 
            this.billidcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.billidcombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billidcombo.FormattingEnabled = true;
            this.billidcombo.Location = new System.Drawing.Point(18, 48);
            this.billidcombo.Name = "billidcombo";
            this.billidcombo.Size = new System.Drawing.Size(204, 23);
            this.billidcombo.TabIndex = 93;
            // 
            // BILL_DATE
            // 
            this.BILL_DATE.Location = new System.Drawing.Point(228, 48);
            this.BILL_DATE.Name = "BILL_DATE";
            this.BILL_DATE.Size = new System.Drawing.Size(209, 21);
            this.BILL_DATE.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(228, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 81;
            this.label1.Text = "Bill Date*";
            // 
            // BILL_STATUS
            // 
            this.BILL_STATUS.Location = new System.Drawing.Point(18, 100);
            this.BILL_STATUS.Name = "BILL_STATUS";
            this.BILL_STATUS.Size = new System.Drawing.Size(204, 21);
            this.BILL_STATUS.TabIndex = 76;
            // 
            // fjofhdf
            // 
            this.fjofhdf.AutoSize = true;
            this.fjofhdf.BackColor = System.Drawing.Color.Transparent;
            this.fjofhdf.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fjofhdf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fjofhdf.Location = new System.Drawing.Point(18, 27);
            this.fjofhdf.Name = "fjofhdf";
            this.fjofhdf.Size = new System.Drawing.Size(50, 18);
            this.fjofhdf.TabIndex = 80;
            this.fjofhdf.Text = "Bill ID*";
            // 
            // TOTAL_AMOUNT
            // 
            this.TOTAL_AMOUNT.Location = new System.Drawing.Point(228, 100);
            this.TOTAL_AMOUNT.Name = "TOTAL_AMOUNT";
            this.TOTAL_AMOUNT.Size = new System.Drawing.Size(209, 21);
            this.TOTAL_AMOUNT.TabIndex = 77;
            // 
            // typecar2
            // 
            this.typecar2.AutoSize = true;
            this.typecar2.BackColor = System.Drawing.Color.Transparent;
            this.typecar2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typecar2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.typecar2.Location = new System.Drawing.Point(233, 81);
            this.typecar2.Name = "typecar2";
            this.typecar2.Size = new System.Drawing.Size(100, 18);
            this.typecar2.TabIndex = 79;
            this.typecar2.Text = "Total Amount*";
            // 
            // carid2
            // 
            this.carid2.AutoSize = true;
            this.carid2.BackColor = System.Drawing.Color.Transparent;
            this.carid2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carid2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.carid2.Location = new System.Drawing.Point(18, 79);
            this.carid2.Name = "carid2";
            this.carid2.Size = new System.Drawing.Size(76, 18);
            this.carid2.TabIndex = 78;
            this.carid2.Text = "Bill Status*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(18, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 92;
            this.label4.Text = "Bills List";
            // 
            // manager_page_bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(998, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.btnreturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "manager_page_bills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Space - Bills Control";
            this.Load += new System.EventHandler(this.Adminpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fjofhdf;
        private System.Windows.Forms.Label typecar2;
        private System.Windows.Forms.Label carid2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cin2;
        private System.Windows.Forms.Label name2;
        public System.Windows.Forms.DataGridView dataGridView5;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DateTimePicker BILL_DATE;
        public System.Windows.Forms.TextBox BILL_STATUS;
        public System.Windows.Forms.TextBox TOTAL_AMOUNT;
        public System.Windows.Forms.TextBox DRIVER_LICENSE;
        public System.Windows.Forms.TextBox CIN;
        public System.Windows.Forms.TextBox FNAME;
        public System.Windows.Forms.ComboBox clientidcombo;
        public System.Windows.Forms.ComboBox billidcombo;
        private System.Windows.Forms.Label label4;
    }
}