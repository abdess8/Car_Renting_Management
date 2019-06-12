namespace House_of_cars.PL
{
    partial class adminpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminpage));
            this.managers = new System.Windows.Forms.Button();
            this.Deconnect_Button = new System.Windows.Forms.Button();
            this.reservation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // managers
            // 
            this.managers.BackColor = System.Drawing.Color.Transparent;
            this.managers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managers.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managers.ForeColor = System.Drawing.Color.White;
            this.managers.Location = new System.Drawing.Point(161, 266);
            this.managers.Name = "managers";
            this.managers.Size = new System.Drawing.Size(176, 31);
            this.managers.TabIndex = 26;
            this.managers.Text = "Managers List";
            this.managers.UseVisualStyleBackColor = false;
            this.managers.Click += new System.EventHandler(this.managers_Click);
            // 
            // Deconnect_Button
            // 
            this.Deconnect_Button.BackColor = System.Drawing.Color.Transparent;
            this.Deconnect_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deconnect_Button.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deconnect_Button.ForeColor = System.Drawing.Color.White;
            this.Deconnect_Button.Location = new System.Drawing.Point(161, 373);
            this.Deconnect_Button.Name = "Deconnect_Button";
            this.Deconnect_Button.Size = new System.Drawing.Size(176, 31);
            this.Deconnect_Button.TabIndex = 25;
            this.Deconnect_Button.Text = "Disconnect";
            this.Deconnect_Button.UseVisualStyleBackColor = false;
            this.Deconnect_Button.Click += new System.EventHandler(this.Deconnect_Button_Click);
            // 
            // reservation
            // 
            this.reservation.BackColor = System.Drawing.Color.Transparent;
            this.reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservation.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservation.ForeColor = System.Drawing.Color.White;
            this.reservation.Location = new System.Drawing.Point(161, 319);
            this.reservation.Name = "reservation";
            this.reservation.Size = new System.Drawing.Size(176, 31);
            this.reservation.TabIndex = 24;
            this.reservation.Text = "Reservation List";
            this.reservation.UseVisualStyleBackColor = false;
            this.reservation.Click += new System.EventHandler(this.reservation_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(170, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Welcome Sir to the";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sweet Movements Personal Use", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(31, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 143);
            this.label1.TabIndex = 22;
            this.label1.Text = "House of Cars";
            // 
            // Adminpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.managers);
            this.Controls.Add(this.Deconnect_Button);
            this.Controls.Add(this.reservation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adminpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminpage2";
            this.Load += new System.EventHandler(this.Adminpage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button managers;
        private System.Windows.Forms.Button Deconnect_Button;
        private System.Windows.Forms.Button reservation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}