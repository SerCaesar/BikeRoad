namespace BikeRoad
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.totalDays = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalAvarage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.totalKm = new System.Windows.Forms.Label();
            this.listYear = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.avarage_lbl = new System.Windows.Forms.Label();
            this.travel_lbl = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.time_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.km_lbl = new System.Windows.Forms.Label();
            this.remove = new System.Windows.Forms.Button();
            this.listTravel = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.listYear);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.remove);
            this.groupBox1.Controls.Add(this.listTravel);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 436);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Storico";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.totalDays);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.totalAvarage);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.totalTime);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.totalKm);
            this.groupBox3.Location = new System.Drawing.Point(7, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 241);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info Percorsi Annuale";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Media Totale:";
            // 
            // totalDays
            // 
            this.totalDays.AutoSize = true;
            this.totalDays.Location = new System.Drawing.Point(96, 113);
            this.totalDays.Name = "totalDays";
            this.totalDays.Size = new System.Drawing.Size(13, 13);
            this.totalDays.TabIndex = 24;
            this.totalDays.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Km Totali:";
            // 
            // totalAvarage
            // 
            this.totalAvarage.AutoSize = true;
            this.totalAvarage.Location = new System.Drawing.Point(96, 87);
            this.totalAvarage.Name = "totalAvarage";
            this.totalAvarage.Size = new System.Drawing.Size(22, 13);
            this.totalAvarage.TabIndex = 23;
            this.totalAvarage.Text = "0,0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tempo Totale:";
            // 
            // totalTime
            // 
            this.totalTime.AutoSize = true;
            this.totalTime.Location = new System.Drawing.Point(96, 60);
            this.totalTime.Name = "totalTime";
            this.totalTime.Size = new System.Drawing.Size(43, 13);
            this.totalTime.TabIndex = 22;
            this.totalTime.Text = "0:00:00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Numero Giorni:";
            // 
            // totalKm
            // 
            this.totalKm.AutoSize = true;
            this.totalKm.Location = new System.Drawing.Point(96, 32);
            this.totalKm.Name = "totalKm";
            this.totalKm.Size = new System.Drawing.Size(22, 13);
            this.totalKm.TabIndex = 21;
            this.totalKm.Text = "0,0";
            // 
            // listYear
            // 
            this.listYear.FormattingEnabled = true;
            this.listYear.Location = new System.Drawing.Point(6, 16);
            this.listYear.Name = "listYear";
            this.listYear.Size = new System.Drawing.Size(250, 134);
            this.listYear.TabIndex = 9;
            this.listYear.SelectedIndexChanged += new System.EventHandler(this.listYear_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.avarage_lbl);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.time_lbl);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.km_lbl);
            this.groupBox2.Location = new System.Drawing.Point(557, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 404);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dati Percorso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Km:";
            // 
            // avarage_lbl
            // 
            this.avarage_lbl.AutoSize = true;
            this.avarage_lbl.Location = new System.Drawing.Point(100, 85);
            this.avarage_lbl.Name = "avarage_lbl";
            this.avarage_lbl.Size = new System.Drawing.Size(22, 13);
            this.avarage_lbl.TabIndex = 7;
            this.avarage_lbl.Text = "0,0";
            // 
            // travel_lbl
            // 
            this.travel_lbl.Location = new System.Drawing.Point(6, 19);
            this.travel_lbl.Name = "travel_lbl";
            this.travel_lbl.Size = new System.Drawing.Size(280, 263);
            this.travel_lbl.TabIndex = 4;
            this.travel_lbl.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tempo:";
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.Location = new System.Drawing.Point(100, 55);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(43, 13);
            this.time_lbl.TabIndex = 6;
            this.time_lbl.Text = "0:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Media:";
            // 
            // km_lbl
            // 
            this.km_lbl.AutoSize = true;
            this.km_lbl.Location = new System.Drawing.Point(100, 27);
            this.km_lbl.Name = "km_lbl";
            this.km_lbl.Size = new System.Drawing.Size(22, 13);
            this.km_lbl.TabIndex = 5;
            this.km_lbl.Text = "0,0";
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(466, 400);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 23);
            this.remove.TabIndex = 8;
            this.remove.Text = "Rimuovi Percorso";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // listTravel
            // 
            this.listTravel.FormattingEnabled = true;
            this.listTravel.Location = new System.Drawing.Point(262, 16);
            this.listTravel.Name = "listTravel";
            this.listTravel.Size = new System.Drawing.Size(279, 381);
            this.listTravel.TabIndex = 0;
            this.listTravel.SelectedIndexChanged += new System.EventHandler(this.listTravel_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.travel_lbl);
            this.groupBox4.Location = new System.Drawing.Point(6, 110);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 288);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Info Percorso";
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 448);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(899, 486);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(899, 486);
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostra lo Storico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.History_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label avarage_lbl;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Label km_lbl;
        private System.Windows.Forms.RichTextBox travel_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listTravel;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listYear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalDays;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalAvarage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label totalKm;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}