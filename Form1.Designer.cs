namespace BikeRoad
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caricaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.travelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTrailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertTravel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.roadText = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.secUpDown = new System.Windows.Forms.NumericUpDown();
            this.minUpDown = new System.Windows.Forms.NumericUpDown();
            this.hourUpDown = new System.Windows.Forms.NumericUpDown();
            this.avarageUpDown = new System.Windows.Forms.NumericUpDown();
            this.kmUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.frecciaVerde = new System.Windows.Forms.PictureBox();
            this.frecciaRossa = new System.Windows.Forms.PictureBox();
            this.totalDays = new System.Windows.Forms.Label();
            this.totalAvarage = new System.Windows.Forms.Label();
            this.totalTime = new System.Windows.Forms.Label();
            this.totalKm = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.bike = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avarageUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kmUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frecciaVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frecciaRossa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bike)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.monthCalendar);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 197);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserisci la Data";
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.SystemColors.Window;
            this.monthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar.Location = new System.Drawing.Point(12, 25);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.MinDate = new System.DateTime(2008, 1, 1, 0, 0, 0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(56, 261);
            this.progressBar.Maximum = 366;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(410, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 1;
            this.progressBar.Value = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.travelToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(529, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caricaToolStripMenuItem,
            this.salvaToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // caricaToolStripMenuItem
            // 
            this.caricaToolStripMenuItem.Image = global::BikeRoad.Properties.Resources.open;
            this.caricaToolStripMenuItem.Name = "caricaToolStripMenuItem";
            this.caricaToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.caricaToolStripMenuItem.Text = "Carica";
            this.caricaToolStripMenuItem.Click += new System.EventHandler(this.caricaToolStripMenuItem_Click);
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.Image = global::BikeRoad.Properties.Resources._32_save;
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.salvaToolStripMenuItem.Text = "Salva";
            this.salvaToolStripMenuItem.Click += new System.EventHandler(this.salvaToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Image = global::BikeRoad.Properties.Resources.exit;
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // travelToolStripMenuItem
            // 
            this.travelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHistoryToolStripMenuItem,
            this.searchTrailToolStripMenuItem});
            this.travelToolStripMenuItem.Name = "travelToolStripMenuItem";
            this.travelToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.travelToolStripMenuItem.Text = "Percorsi";
            // 
            // viewHistoryToolStripMenuItem
            // 
            this.viewHistoryToolStripMenuItem.Image = global::BikeRoad.Properties.Resources.month;
            this.viewHistoryToolStripMenuItem.Name = "viewHistoryToolStripMenuItem";
            this.viewHistoryToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.viewHistoryToolStripMenuItem.Text = "Mostra lo Storico";
            this.viewHistoryToolStripMenuItem.Click += new System.EventHandler(this.viewHistoryToolStripMenuItem_Click);
            // 
            // searchTrailToolStripMenuItem
            // 
            this.searchTrailToolStripMenuItem.Image = global::BikeRoad.Properties.Resources.search;
            this.searchTrailToolStripMenuItem.Name = "searchTrailToolStripMenuItem";
            this.searchTrailToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.searchTrailToolStripMenuItem.Text = "Cerca un Percorso";
            this.searchTrailToolStripMenuItem.Click += new System.EventHandler(this.searchTrailToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::BikeRoad.Properties.Resources.question;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // insertTravel
            // 
            this.insertTravel.Location = new System.Drawing.Point(209, 467);
            this.insertTravel.Name = "insertTravel";
            this.insertTravel.Size = new System.Drawing.Size(110, 23);
            this.insertTravel.TabIndex = 7;
            this.insertTravel.Text = "Inserisci Percorso";
            this.insertTravel.UseVisualStyleBackColor = true;
            this.insertTravel.Click += new System.EventHandler(this.insertTravel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.secUpDown);
            this.groupBox2.Controls.Add(this.minUpDown);
            this.groupBox2.Controls.Add(this.hourUpDown);
            this.groupBox2.Controls.Add(this.avarageUpDown);
            this.groupBox2.Controls.Add(this.kmUpDown);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 159);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dati Percorso";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.roadText);
            this.groupBox4.Location = new System.Drawing.Point(207, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(289, 140);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Info Percorso";
            // 
            // roadText
            // 
            this.roadText.Location = new System.Drawing.Point(6, 17);
            this.roadText.Name = "roadText";
            this.roadText.Size = new System.Drawing.Size(277, 117);
            this.roadText.TabIndex = 6;
            this.roadText.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(148, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(91, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = ":";
            // 
            // secUpDown
            // 
            this.secUpDown.Location = new System.Drawing.Point(165, 69);
            this.secUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secUpDown.Name = "secUpDown";
            this.secUpDown.Size = new System.Drawing.Size(34, 20);
            this.secUpDown.TabIndex = 4;
            // 
            // minUpDown
            // 
            this.minUpDown.Location = new System.Drawing.Point(108, 69);
            this.minUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minUpDown.Name = "minUpDown";
            this.minUpDown.Size = new System.Drawing.Size(34, 20);
            this.minUpDown.TabIndex = 3;
            // 
            // hourUpDown
            // 
            this.hourUpDown.Location = new System.Drawing.Point(51, 69);
            this.hourUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.hourUpDown.Name = "hourUpDown";
            this.hourUpDown.Size = new System.Drawing.Size(34, 20);
            this.hourUpDown.TabIndex = 2;
            // 
            // avarageUpDown
            // 
            this.avarageUpDown.DecimalPlaces = 2;
            this.avarageUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.avarageUpDown.Location = new System.Drawing.Point(62, 98);
            this.avarageUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.avarageUpDown.Name = "avarageUpDown";
            this.avarageUpDown.Size = new System.Drawing.Size(120, 20);
            this.avarageUpDown.TabIndex = 5;
            // 
            // kmUpDown
            // 
            this.kmUpDown.DecimalPlaces = 2;
            this.kmUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.kmUpDown.Location = new System.Drawing.Point(62, 43);
            this.kmUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.kmUpDown.Name = "kmUpDown";
            this.kmUpDown.Size = new System.Drawing.Size(120, 20);
            this.kmUpDown.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Media";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tempo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Km";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.frecciaVerde);
            this.groupBox3.Controls.Add(this.frecciaRossa);
            this.groupBox3.Controls.Add(this.totalDays);
            this.groupBox3.Controls.Add(this.totalAvarage);
            this.groupBox3.Controls.Add(this.totalTime);
            this.groupBox3.Controls.Add(this.totalKm);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(271, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 197);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info Percorsi Annuali";
            // 
            // frecciaVerde
            // 
            this.frecciaVerde.Image = global::BikeRoad.Properties.Resources.freccia_verde_su1;
            this.frecciaVerde.Location = new System.Drawing.Point(142, 105);
            this.frecciaVerde.Name = "frecciaVerde";
            this.frecciaVerde.Size = new System.Drawing.Size(15, 13);
            this.frecciaVerde.TabIndex = 17;
            this.frecciaVerde.TabStop = false;
            this.frecciaVerde.Visible = false;
            // 
            // frecciaRossa
            // 
            this.frecciaRossa.Image = global::BikeRoad.Properties.Resources.freccia_rossa_giu;
            this.frecciaRossa.Location = new System.Drawing.Point(142, 105);
            this.frecciaRossa.Name = "frecciaRossa";
            this.frecciaRossa.Size = new System.Drawing.Size(15, 13);
            this.frecciaRossa.TabIndex = 13;
            this.frecciaRossa.TabStop = false;
            this.frecciaRossa.Visible = false;
            // 
            // totalDays
            // 
            this.totalDays.AutoSize = true;
            this.totalDays.Location = new System.Drawing.Point(96, 132);
            this.totalDays.Name = "totalDays";
            this.totalDays.Size = new System.Drawing.Size(13, 13);
            this.totalDays.TabIndex = 16;
            this.totalDays.Text = "0";
            // 
            // totalAvarage
            // 
            this.totalAvarage.AutoSize = true;
            this.totalAvarage.Location = new System.Drawing.Point(96, 106);
            this.totalAvarage.Name = "totalAvarage";
            this.totalAvarage.Size = new System.Drawing.Size(22, 13);
            this.totalAvarage.TabIndex = 15;
            this.totalAvarage.Text = "0,0";
            // 
            // totalTime
            // 
            this.totalTime.AutoSize = true;
            this.totalTime.Location = new System.Drawing.Point(96, 79);
            this.totalTime.Name = "totalTime";
            this.totalTime.Size = new System.Drawing.Size(43, 13);
            this.totalTime.TabIndex = 14;
            this.totalTime.Text = "0:00:00";
            // 
            // totalKm
            // 
            this.totalKm.AutoSize = true;
            this.totalKm.Location = new System.Drawing.Point(96, 51);
            this.totalKm.Name = "totalKm";
            this.totalKm.Size = new System.Drawing.Size(22, 13);
            this.totalKm.TabIndex = 13;
            this.totalKm.Text = "0,0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Numero Giorni:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Media Totale:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tempo Totale:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Km Totali:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 266);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "1 Gen";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(472, 266);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "31 Dic";
            // 
            // bike
            // 
            this.bike.Image = global::BikeRoad.Properties.Resources.bike;
            this.bike.Location = new System.Drawing.Point(46, 230);
            this.bike.Name = "bike";
            this.bike.Size = new System.Drawing.Size(31, 29);
            this.bike.TabIndex = 8;
            this.bike.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 496);
            this.Controls.Add(this.bike);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.insertTravel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(545, 534);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(545, 534);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BikeRoad";
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.secUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avarageUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kmUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frecciaVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frecciaRossa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bike)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caricaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem travelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button insertTravel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox roadText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown kmUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown secUpDown;
        private System.Windows.Forms.NumericUpDown minUpDown;
        private System.Windows.Forms.NumericUpDown hourUpDown;
        private System.Windows.Forms.NumericUpDown avarageUpDown;
        private System.Windows.Forms.Label totalDays;
        private System.Windows.Forms.Label totalAvarage;
        private System.Windows.Forms.Label totalTime;
        private System.Windows.Forms.Label totalKm;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox bike;
        private System.Windows.Forms.PictureBox frecciaRossa;
        private System.Windows.Forms.PictureBox frecciaVerde;
        private System.Windows.Forms.ToolStripMenuItem searchTrailToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

