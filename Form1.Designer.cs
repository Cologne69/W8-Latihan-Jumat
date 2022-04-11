namespace W8_Latihan_Jumat
{
    partial class Form1
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
            this.cb_timHome = new System.Windows.Forms.ComboBox();
            this.cb_timAway = new System.Windows.Forms.ComboBox();
            this.lbl_managerHome = new System.Windows.Forms.Label();
            this.lbl_homecaptain = new System.Windows.Forms.Label();
            this.lbl_managerAway = new System.Windows.Forms.Label();
            this.lbl_captainAway = new System.Windows.Forms.Label();
            this.lbl_isimanagerAway = new System.Windows.Forms.Label();
            this.lbl_isicaptainAway = new System.Windows.Forms.Label();
            this.lbl_isicaptainHome = new System.Windows.Forms.Label();
            this.lbl_isimanagerHome = new System.Windows.Forms.Label();
            this.lbl_stadium = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_isiStadium = new System.Windows.Forms.Label();
            this.lbl_isiKapasitas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_timHome
            // 
            this.cb_timHome.FormattingEnabled = true;
            this.cb_timHome.Location = new System.Drawing.Point(28, 25);
            this.cb_timHome.Name = "cb_timHome";
            this.cb_timHome.Size = new System.Drawing.Size(213, 24);
            this.cb_timHome.TabIndex = 0;
            this.cb_timHome.SelectedIndexChanged += new System.EventHandler(this.cb_timHome_SelectedIndexChanged);
            // 
            // cb_timAway
            // 
            this.cb_timAway.FormattingEnabled = true;
            this.cb_timAway.Location = new System.Drawing.Point(456, 25);
            this.cb_timAway.Name = "cb_timAway";
            this.cb_timAway.Size = new System.Drawing.Size(213, 24);
            this.cb_timAway.TabIndex = 1;
            this.cb_timAway.SelectedIndexChanged += new System.EventHandler(this.cb_timAway_SelectedIndexChanged);
            // 
            // lbl_managerHome
            // 
            this.lbl_managerHome.AutoSize = true;
            this.lbl_managerHome.Location = new System.Drawing.Point(25, 88);
            this.lbl_managerHome.Name = "lbl_managerHome";
            this.lbl_managerHome.Size = new System.Drawing.Size(67, 16);
            this.lbl_managerHome.TabIndex = 2;
            this.lbl_managerHome.Text = "Manager :";
            // 
            // lbl_homecaptain
            // 
            this.lbl_homecaptain.AutoSize = true;
            this.lbl_homecaptain.Location = new System.Drawing.Point(25, 119);
            this.lbl_homecaptain.Name = "lbl_homecaptain";
            this.lbl_homecaptain.Size = new System.Drawing.Size(59, 16);
            this.lbl_homecaptain.TabIndex = 3;
            this.lbl_homecaptain.Text = "Captain :";
            // 
            // lbl_managerAway
            // 
            this.lbl_managerAway.AutoSize = true;
            this.lbl_managerAway.Location = new System.Drawing.Point(453, 88);
            this.lbl_managerAway.Name = "lbl_managerAway";
            this.lbl_managerAway.Size = new System.Drawing.Size(67, 16);
            this.lbl_managerAway.TabIndex = 4;
            this.lbl_managerAway.Text = "Manager :";
            // 
            // lbl_captainAway
            // 
            this.lbl_captainAway.AutoSize = true;
            this.lbl_captainAway.Location = new System.Drawing.Point(453, 119);
            this.lbl_captainAway.Name = "lbl_captainAway";
            this.lbl_captainAway.Size = new System.Drawing.Size(59, 16);
            this.lbl_captainAway.TabIndex = 5;
            this.lbl_captainAway.Text = "Captain :";
            // 
            // lbl_isimanagerAway
            // 
            this.lbl_isimanagerAway.AutoSize = true;
            this.lbl_isimanagerAway.Location = new System.Drawing.Point(526, 88);
            this.lbl_isimanagerAway.Name = "lbl_isimanagerAway";
            this.lbl_isimanagerAway.Size = new System.Drawing.Size(16, 16);
            this.lbl_isimanagerAway.TabIndex = 6;
            this.lbl_isimanagerAway.Text = "...";
            this.lbl_isimanagerAway.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_isicaptainAway
            // 
            this.lbl_isicaptainAway.AutoSize = true;
            this.lbl_isicaptainAway.Location = new System.Drawing.Point(526, 119);
            this.lbl_isicaptainAway.Name = "lbl_isicaptainAway";
            this.lbl_isicaptainAway.Size = new System.Drawing.Size(16, 16);
            this.lbl_isicaptainAway.TabIndex = 7;
            this.lbl_isicaptainAway.Text = "...";
            // 
            // lbl_isicaptainHome
            // 
            this.lbl_isicaptainHome.AutoSize = true;
            this.lbl_isicaptainHome.Location = new System.Drawing.Point(98, 119);
            this.lbl_isicaptainHome.Name = "lbl_isicaptainHome";
            this.lbl_isicaptainHome.Size = new System.Drawing.Size(16, 16);
            this.lbl_isicaptainHome.TabIndex = 8;
            this.lbl_isicaptainHome.Text = "...";
            // 
            // lbl_isimanagerHome
            // 
            this.lbl_isimanagerHome.AutoSize = true;
            this.lbl_isimanagerHome.Location = new System.Drawing.Point(98, 88);
            this.lbl_isimanagerHome.Name = "lbl_isimanagerHome";
            this.lbl_isimanagerHome.Size = new System.Drawing.Size(16, 16);
            this.lbl_isimanagerHome.TabIndex = 9;
            this.lbl_isimanagerHome.Text = "...";
            this.lbl_isimanagerHome.Click += new System.EventHandler(this.lbl_isimanagerHome_Click);
            // 
            // lbl_stadium
            // 
            this.lbl_stadium.AutoSize = true;
            this.lbl_stadium.Location = new System.Drawing.Point(249, 210);
            this.lbl_stadium.Name = "lbl_stadium";
            this.lbl_stadium.Size = new System.Drawing.Size(62, 16);
            this.lbl_stadium.TabIndex = 10;
            this.lbl_stadium.Text = "Stadium :";
            this.lbl_stadium.Click += new System.EventHandler(this.lbl_stadium_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Capacity :";
            // 
            // lbl_isiStadium
            // 
            this.lbl_isiStadium.AutoSize = true;
            this.lbl_isiStadium.Location = new System.Drawing.Point(327, 210);
            this.lbl_isiStadium.Name = "lbl_isiStadium";
            this.lbl_isiStadium.Size = new System.Drawing.Size(16, 16);
            this.lbl_isiStadium.TabIndex = 12;
            this.lbl_isiStadium.Text = "...";
            // 
            // lbl_isiKapasitas
            // 
            this.lbl_isiKapasitas.AutoSize = true;
            this.lbl_isiKapasitas.Location = new System.Drawing.Point(327, 235);
            this.lbl_isiKapasitas.Name = "lbl_isiKapasitas";
            this.lbl_isiKapasitas.Size = new System.Drawing.Size(16, 16);
            this.lbl_isiKapasitas.TabIndex = 13;
            this.lbl_isiKapasitas.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 302);
            this.Controls.Add(this.lbl_isiKapasitas);
            this.Controls.Add(this.lbl_isiStadium);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_stadium);
            this.Controls.Add(this.lbl_isimanagerHome);
            this.Controls.Add(this.lbl_isicaptainHome);
            this.Controls.Add(this.lbl_isicaptainAway);
            this.Controls.Add(this.lbl_isimanagerAway);
            this.Controls.Add(this.lbl_captainAway);
            this.Controls.Add(this.lbl_managerAway);
            this.Controls.Add(this.lbl_homecaptain);
            this.Controls.Add(this.lbl_managerHome);
            this.Controls.Add(this.cb_timAway);
            this.Controls.Add(this.cb_timHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form Judi Bola";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_timHome;
        private System.Windows.Forms.ComboBox cb_timAway;
        private System.Windows.Forms.Label lbl_managerHome;
        private System.Windows.Forms.Label lbl_homecaptain;
        private System.Windows.Forms.Label lbl_managerAway;
        private System.Windows.Forms.Label lbl_captainAway;
        private System.Windows.Forms.Label lbl_isimanagerAway;
        private System.Windows.Forms.Label lbl_isicaptainAway;
        private System.Windows.Forms.Label lbl_isicaptainHome;
        private System.Windows.Forms.Label lbl_isimanagerHome;
        private System.Windows.Forms.Label lbl_stadium;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_isiStadium;
        private System.Windows.Forms.Label lbl_isiKapasitas;
    }
}

