namespace House_of_cars
{
    partial class manager_page_bills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager_page_bills));
            this.btnreturn = new System.Windows.Forms.Button();
            this.dataGridReservation = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ID_CLIENT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DRIVER_LICENSE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cin2 = new System.Windows.Forms.Label();
            this.name2 = new System.Windows.Forms.Label();
            this.CIN = new System.Windows.Forms.TextBox();
            this.FNAME = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ID_RESERVATION = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DATE_RESERVATION = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MODEL_NAME = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RENTAL_DAYS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.IMPORT = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.AMOUNT = new System.Windows.Forms.TextBox();
            this.bntsave = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.importbtn = new System.Windows.Forms.Button();
            this.BILL_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TOTAL_AMOUNT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BILL_DATE = new System.Windows.Forms.TextBox();
            this.STATUS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnreturn
            // 
            this.btnreturn.BackColor = System.Drawing.Color.Transparent;
            this.btnreturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreturn.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreturn.ForeColor = System.Drawing.Color.White;
            this.btnreturn.Location = new System.Drawing.Point(21, 449);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(66, 26);
            this.btnreturn.TabIndex = 13;
            this.btnreturn.Text = "Return";
            this.btnreturn.UseVisualStyleBackColor = false;
            this.btnreturn.Click += new System.EventHandler(this.Deconnect_Button_Click);
            // 
            // dataGridReservation
            // 
            this.dataGridReservation.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReservation.ColumnHeadersVisible = false;
            this.dataGridReservation.Location = new System.Drawing.Point(21, 228);
            this.dataGridReservation.MultiSelect = false;
            this.dataGridReservation.Name = "dataGridReservation";
            this.dataGridReservation.ReadOnly = true;
            this.dataGridReservation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridReservation.Size = new System.Drawing.Size(953, 215);
            this.dataGridReservation.TabIndex = 14;
            this.dataGridReservation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReservation_CellContentClick);
            this.dataGridReservation.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridReservation_RowsRemoved);
            this.dataGridReservation.DoubleClick += new System.EventHandler(this.dataGridReservation_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ID_CLIENT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DRIVER_LICENSE);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cin2);
            this.groupBox1.Controls.Add(this.name2);
            this.groupBox1.Controls.Add(this.CIN);
            this.groupBox1.Controls.Add(this.FNAME);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(21, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 158);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Infos";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(379, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 26);
            this.button1.TabIndex = 93;
            this.button1.Text = "Import";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ID_CLIENT
            // 
            this.ID_CLIENT.Location = new System.Drawing.Point(12, 39);
            this.ID_CLIENT.Name = "ID_CLIENT";
            this.ID_CLIENT.ReadOnly = true;
            this.ID_CLIENT.Size = new System.Drawing.Size(204, 21);
            this.ID_CLIENT.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(227, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 91;
            this.label2.Text = "Driver\'s License*";
            // 
            // DRIVER_LICENSE
            // 
            this.DRIVER_LICENSE.Location = new System.Drawing.Point(227, 91);
            this.DRIVER_LICENSE.Name = "DRIVER_LICENSE";
            this.DRIVER_LICENSE.ReadOnly = true;
            this.DRIVER_LICENSE.Size = new System.Drawing.Size(209, 21);
            this.DRIVER_LICENSE.TabIndex = 88;
            this.DRIVER_LICENSE.TextChanged += new System.EventHandler(this.DRIVER_LICENSE_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 18);
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
            this.cin2.Location = new System.Drawing.Point(227, 18);
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
            this.name2.Location = new System.Drawing.Point(12, 70);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(54, 18);
            this.name2.TabIndex = 87;
            this.name2.Text = "Name*";
            // 
            // CIN
            // 
            this.CIN.Location = new System.Drawing.Point(227, 39);
            this.CIN.Name = "CIN";
            this.CIN.ReadOnly = true;
            this.CIN.Size = new System.Drawing.Size(209, 21);
            this.CIN.TabIndex = 85;
            // 
            // FNAME
            // 
            this.FNAME.Location = new System.Drawing.Point(12, 91);
            this.FNAME.Name = "FNAME";
            this.FNAME.ReadOnly = true;
            this.FNAME.Size = new System.Drawing.Size(204, 21);
            this.FNAME.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Search";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 202);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 18;
            // 
            // ID_RESERVATION
            // 
            this.ID_RESERVATION.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_RESERVATION.Location = new System.Drawing.Point(140, 202);
            this.ID_RESERVATION.Name = "ID_RESERVATION";
            this.ID_RESERVATION.Size = new System.Drawing.Size(146, 22);
            this.ID_RESERVATION.TabIndex = 20;
            this.ID_RESERVATION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Reservation Id";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DATE_RESERVATION
            // 
            this.DATE_RESERVATION.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATE_RESERVATION.Location = new System.Drawing.Point(400, 202);
            this.DATE_RESERVATION.Name = "DATE_RESERVATION";
            this.DATE_RESERVATION.ReadOnly = true;
            this.DATE_RESERVATION.Size = new System.Drawing.Size(206, 22);
            this.DATE_RESERVATION.TabIndex = 22;
            this.DATE_RESERVATION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(405, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "Reservation Date";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MODEL_NAME
            // 
            this.MODEL_NAME.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MODEL_NAME.Location = new System.Drawing.Point(605, 202);
            this.MODEL_NAME.Name = "MODEL_NAME";
            this.MODEL_NAME.ReadOnly = true;
            this.MODEL_NAME.Size = new System.Drawing.Size(229, 22);
            this.MODEL_NAME.TabIndex = 24;
            this.MODEL_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(603, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Model Car Name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RENTAL_DAYS
            // 
            this.RENTAL_DAYS.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RENTAL_DAYS.Location = new System.Drawing.Point(832, 202);
            this.RENTAL_DAYS.MaxLength = 8;
            this.RENTAL_DAYS.Name = "RENTAL_DAYS";
            this.RENTAL_DAYS.Size = new System.Drawing.Size(141, 22);
            this.RENTAL_DAYS.TabIndex = 1;
            this.RENTAL_DAYS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RENTAL_DAYS.TextChanged += new System.EventHandler(this.RENTAL_DAYS_TextChanged);
            this.RENTAL_DAYS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AMOUNT_KeyPress);
            this.RENTAL_DAYS.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RENTAL_DAYS_KeyUp);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(829, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 22);
            this.label8.TabIndex = 25;
            this.label8.Text = "RENTAL DAYS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IMPORT
            // 
            this.IMPORT.BackColor = System.Drawing.Color.LightGray;
            this.IMPORT.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IMPORT.ForeColor = System.Drawing.Color.Black;
            this.IMPORT.Location = new System.Drawing.Point(21, 202);
            this.IMPORT.Name = "IMPORT";
            this.IMPORT.Size = new System.Drawing.Size(121, 22);
            this.IMPORT.TabIndex = 27;
            this.IMPORT.Text = "Import";
            this.IMPORT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.IMPORT.UseVisualStyleBackColor = false;
            this.IMPORT.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(292, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 22);
            this.label9.TabIndex = 28;
            this.label9.Text = "AMOUNT";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AMOUNT
            // 
            this.AMOUNT.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMOUNT.Location = new System.Drawing.Point(282, 202);
            this.AMOUNT.MaxLength = 8;
            this.AMOUNT.Name = "AMOUNT";
            this.AMOUNT.Size = new System.Drawing.Size(120, 22);
            this.AMOUNT.TabIndex = 29;
            this.AMOUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AMOUNT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AMOUNT_KeyDown_1);
            this.AMOUNT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AMOUNT_KeyPress_1);
            this.AMOUNT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AMOUNT_KeyUp_1);
            // 
            // bntsave
            // 
            this.bntsave.BackColor = System.Drawing.Color.Transparent;
            this.bntsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntsave.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntsave.ForeColor = System.Drawing.Color.White;
            this.bntsave.Location = new System.Drawing.Point(908, 449);
            this.bntsave.Name = "bntsave";
            this.bntsave.Size = new System.Drawing.Size(66, 26);
            this.bntsave.TabIndex = 30;
            this.bntsave.Text = "Report";
            this.bntsave.UseVisualStyleBackColor = false;
            this.bntsave.Click += new System.EventHandler(this.bntsave_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.importbtn);
            this.groupBox2.Controls.Add(this.BILL_ID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TOTAL_AMOUNT);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.BILL_DATE);
            this.groupBox2.Controls.Add(this.STATUS);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(525, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 158);
            this.groupBox2.TabIndex = 94;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Billing Details";
            // 
            // importbtn
            // 
            this.importbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importbtn.ForeColor = System.Drawing.Color.Transparent;
            this.importbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.importbtn.Location = new System.Drawing.Point(379, 120);
            this.importbtn.Name = "importbtn";
            this.importbtn.Size = new System.Drawing.Size(57, 26);
            this.importbtn.TabIndex = 93;
            this.importbtn.Text = "Import";
            this.importbtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.importbtn.UseVisualStyleBackColor = true;
            this.importbtn.Click += new System.EventHandler(this.importbtn_Click);
            // 
            // BILL_ID
            // 
            this.BILL_ID.Location = new System.Drawing.Point(12, 39);
            this.BILL_ID.Name = "BILL_ID";
            this.BILL_ID.ReadOnly = true;
            this.BILL_ID.Size = new System.Drawing.Size(204, 21);
            this.BILL_ID.TabIndex = 92;
            this.BILL_ID.TextChanged += new System.EventHandler(this.BILL_ID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(227, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 91;
            this.label1.Text = "TOTAL AMOUNT*";
            // 
            // TOTAL_AMOUNT
            // 
            this.TOTAL_AMOUNT.Location = new System.Drawing.Point(227, 91);
            this.TOTAL_AMOUNT.Name = "TOTAL_AMOUNT";
            this.TOTAL_AMOUNT.Size = new System.Drawing.Size(209, 21);
            this.TOTAL_AMOUNT.TabIndex = 88;
            this.TOTAL_AMOUNT.TextChanged += new System.EventHandler(this.TOTAL_AMOUNT_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(12, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 18);
            this.label10.TabIndex = 90;
            this.label10.Text = "BILL ID*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(227, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 18);
            this.label11.TabIndex = 89;
            this.label11.Text = "BILLING DATE*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(12, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 18);
            this.label12.TabIndex = 87;
            this.label12.Text = "STATUS*";
            // 
            // BILL_DATE
            // 
            this.BILL_DATE.Location = new System.Drawing.Point(227, 39);
            this.BILL_DATE.Name = "BILL_DATE";
            this.BILL_DATE.ReadOnly = true;
            this.BILL_DATE.Size = new System.Drawing.Size(209, 21);
            this.BILL_DATE.TabIndex = 85;
            // 
            // STATUS
            // 
            this.STATUS.Location = new System.Drawing.Point(12, 91);
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            this.STATUS.Size = new System.Drawing.Size(204, 21);
            this.STATUS.TabIndex = 86;
            // 
            // manager_page_bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(998, 487);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bntsave);
            this.Controls.Add(this.ID_RESERVATION);
            this.Controls.Add(this.AMOUNT);
            this.Controls.Add(this.MODEL_NAME);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.IMPORT);
            this.Controls.Add(this.RENTAL_DAYS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DATE_RESERVATION);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridReservation);
            this.Controls.Add(this.btnreturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "manager_page_bills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Space - Bills Control";
            this.Load += new System.EventHandler(this.Adminpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReservation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cin2;
        private System.Windows.Forms.Label name2;
        public System.Windows.Forms.DataGridView dataGridReservation;
        public System.Windows.Forms.TextBox DRIVER_LICENSE;
        public System.Windows.Forms.TextBox CIN;
        public System.Windows.Forms.TextBox FNAME;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox ID_CLIENT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button IMPORT;
        public System.Windows.Forms.TextBox ID_RESERVATION;
        public System.Windows.Forms.TextBox DATE_RESERVATION;
        public System.Windows.Forms.TextBox MODEL_NAME;
        public System.Windows.Forms.TextBox RENTAL_DAYS;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox AMOUNT;
        private System.Windows.Forms.Button bntsave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button importbtn;
        public System.Windows.Forms.TextBox BILL_ID;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TOTAL_AMOUNT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox BILL_DATE;
        public System.Windows.Forms.TextBox STATUS;
    }
}