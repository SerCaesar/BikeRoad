using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using BikeRoad.Properties;

namespace BikeRoad
{
    public partial class Form1 : Form
    {

        public List<Travel> roadmap = new List<Travel>();
        public string filePath = "travel.bt";
        public int pos;

        public Form1()
        {
            InitializeComponent();

            DateTime dt = new DateTime(DateTime.Today.Year, 1, 1);
            TimeSpan ts = monthCalendar.SelectionStart - dt;

            progressBar.Value = ts.Days;
            bike.Location = new Point(bike.Location.X + ts.Days, bike.Location.Y);

            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    fs.Seek(0, SeekOrigin.Begin);
                    roadmap = (List<Travel>)bf.Deserialize(fs);
                }
                catch (Exception) { MessageBox.Show("Errore nel caricamento", "Errore"); }
                finally { fs.Close(); }
            }
            if (roadmap.Count > 0)
                update_stat();
        }

        private void insertTravel_Click(object sender, EventArgs e)
        {
            if ((kmUpDown.Value != 0) && (avarageUpDown.Value != 0))
            {
                decimal backupAv = Convert.ToDecimal(totalAvarage.Text);
                bool trovato = false;
                Travel newTravel = new Travel(monthCalendar.SelectionStart, kmUpDown.Value, avarageUpDown.Value, (int)hourUpDown.Value, (int)minUpDown.Value, (int)secUpDown.Value, roadText.Text);

                for (int i = 0; i < roadmap.Count; i++)
                {
                    if (roadmap[i].dateTravel > newTravel.dateTravel)
                    {
                        roadmap.Insert(i, newTravel);
                        trovato = true;
                        break;
                    }
                }

                if (!trovato)
                    roadmap.Add(newTravel);
                    

                MemoryStream ms = new MemoryStream();
                BinaryFormatter br = new BinaryFormatter();
                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    try
                    {
                        br.Serialize(ms, roadmap);
                        ms.WriteTo(fs);
                    }
                    catch (Exception ex) { MessageBox.Show("Errore nel salvataggio " + ex.StackTrace, "Errore"); }
                    finally { fs.Close(); }
                }

                update_stat();

                decimal tempAv = Convert.ToDecimal(totalAvarage.Text);
                if (tempAv > backupAv)
                {
                    frecciaRossa.Visible = false;
                    frecciaVerde.Visible = true;
                }
                else if (tempAv < backupAv)
                {
                    frecciaRossa.Visible = true;
                    frecciaVerde.Visible = false;
                }
                kmUpDown.Value = 0;
                hourUpDown.Value = 0;
                minUpDown.Value = 0;
                secUpDown.Value = 0;
                avarageUpDown.Value = 0;
                roadText.Text = "";
            }
            else
                MessageBox.Show("Please check all field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create new SaveFileDialog object
            SaveFileDialog DialogSave = new SaveFileDialog();

            // Default file extension
            DialogSave.DefaultExt = "bt";

            // Available file extensions
            DialogSave.Filter = "File BikeTravel (*.bt)|*.bt|Tutti i file (*.*)|*.*";

            // Adds a extension if the user does not
            DialogSave.AddExtension = true;

            // Restores the selected directory, next time
            DialogSave.RestoreDirectory = true;

            DialogSave.CheckPathExists = true;
            DialogSave.OverwritePrompt = true;

            // Dialog title
            DialogSave.Title = "Dove vuoi salvare il file?";

            // Startup directory
            DialogSave.InitialDirectory = @"C:/";

            // Show the dialog and process the result
            if (DialogSave.ShowDialog() == DialogResult.OK)
            {
                MemoryStream ms = new MemoryStream();
                BinaryFormatter br = new BinaryFormatter();

                using (FileStream fs = new FileStream(DialogSave.FileName, FileMode.OpenOrCreate))
                {
                    try
                    {
                        br.Serialize(ms, roadmap);
                        ms.WriteTo(fs);
                    }
                    catch (Exception ex) { MessageBox.Show("Errore nel salvataggio " + ex.StackTrace, "Errore"); }
                    finally { fs.Close(); }
                }

                filePath = DialogSave.FileName;

                DialogSave.Dispose();
                DialogSave = null;
            }
        }

        private void caricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog DialogOpen = new OpenFileDialog();
            DialogOpen.Filter = "File BikeTravel (*.bt)|*.bt";
            DialogOpen.InitialDirectory = @"C:/";
            DialogOpen.Title = "Seleziona il file che vuoi caricare";
            DialogOpen.Multiselect = false;

            if (DialogOpen.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(DialogOpen.FileName, FileMode.OpenOrCreate))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    try
                    {
                        fs.Seek(0, SeekOrigin.Begin);
                        roadmap = (List<Travel>)bf.Deserialize(fs);
                    }
                    catch (Exception) { MessageBox.Show("Errore nel caricamento", "Errore"); }
                    finally { fs.Close(); }
                }
            }

            filePath = DialogOpen.FileName;

            DialogOpen.Dispose();
            DialogOpen = null;
            update_stat();
        }

        private void viewHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History hist = new History(this);
            hist.Show();
        }

        private void searchTrailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search(this);
            search.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form aboutForm = new Form();
            PictureBox pictAbout = new PictureBox();
            Label labelRights = new Label();
            Label labelAbout = new Label();
            Label labelScripted = new Label();
            Label labelCaesar = new Label();

            aboutForm.ClientSize = new System.Drawing.Size(243, 210);
            aboutForm.Icon = Resources.Icon;
            aboutForm.MaximumSize = new System.Drawing.Size(243, 210);
            aboutForm.MinimumSize = new System.Drawing.Size(243, 210);
            aboutForm.Name = "aboutForm";
            aboutForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            aboutForm.Text = "About";
            aboutForm.Visible = true;

            labelRights.AutoSize = true;
            labelRights.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelRights.Location = new System.Drawing.Point(57, 10);
            labelRights.Size = new System.Drawing.Size(47, 13);
            labelRights.TabIndex = 14;
            labelRights.Text = "All Rights Reserved ©";

            pictAbout.Image = Resources.about;
            pictAbout.Location = new System.Drawing.Point(85, 30);
            pictAbout.Name = "AboutImage";
            pictAbout.Size = new System.Drawing.Size(80, 50);
            pictAbout.TabIndex = 25;
            pictAbout.TabStop = false;
            ((System.ComponentModel.ISupportInitialize)(pictAbout)).BeginInit();

            labelAbout.AutoSize = true;
            labelAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelAbout.Location = new System.Drawing.Point(65, 90);
            labelAbout.Size = new System.Drawing.Size(47, 13);
            labelAbout.TabIndex = 14;
            labelAbout.Text = "Bike Road";

            labelScripted.AutoSize = true;
            labelScripted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelScripted.Location = new System.Drawing.Point(10, 125);
            labelScripted.Size = new System.Drawing.Size(47, 13);
            labelScripted.TabIndex = 14;
            labelScripted.Text = "Scripted by:";

            labelCaesar.AutoSize = true;
            labelCaesar.Location = new System.Drawing.Point(10, 145);
            labelCaesar.Size = new System.Drawing.Size(47, 13);
            labelCaesar.TabIndex = 14;
            labelCaesar.Text = "Ser Caesar - neon_adam@hotmail.com";

            aboutForm.Controls.Add(labelRights);
            aboutForm.Controls.Add(pictAbout);
            aboutForm.Controls.Add(labelAbout);
            aboutForm.Controls.Add(labelScripted);
            aboutForm.Controls.Add(labelCaesar);

            aboutForm.Show();
        }

        public void update_stat()
        {
            decimal tempKm = 0;
            decimal tempAv = 0;
            int tempHours = 0;
            int tempMins = 0;
            int tempSecs = 0;
            int tempDays = 0;

            findPos(DateTime.Today.Year);
            for (int i = pos; i < roadmap.Count; i++)
            {
                tempKm += roadmap[i].km;
                tempAv += roadmap[i].avarage;
                tempDays++;

                tempSecs += roadmap[i].secs;
                if (tempSecs > 60)
                {
                    tempSecs -= 60;
                    tempMins++;
                }

                tempMins += roadmap[i].mins;
                if (tempMins > 60)
                {
                    tempMins -= 60;
                    tempHours++;
                }

                tempHours += roadmap[i].hours;
            }

            if (tempDays != 0)
                tempAv = Math.Round(tempAv / tempDays,2);

            totalKm.Text = tempKm.ToString();
            totalTime.Text = tempHours.ToString() + ":" + tempMins.ToString().PadLeft(2, '0') + ":" + tempSecs.ToString().PadLeft(2, '0');
            totalAvarage.Text = tempAv.ToString();
            totalDays.Text = tempDays.ToString();
        }

        public void findPos(int anno)
        {
            DateTime dt = new DateTime(anno, 1, 1);
            for (int i = 0; i < roadmap.Count; i++)
            {
                if (dt.Year == roadmap[i].dateTravel.Year)
                {
                    pos = i;
                    break;
                }
            }
        }

    }
}
