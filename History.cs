using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BikeRoad
{
    public partial class History : Form
    {

        Form1 main;
        public List<Travel> founded = new List<Travel>();

        public History(Form1 finestra)
        {
            main = finestra;
            InitializeComponent();

            for (int i = 0; i < main.roadmap.Count; i++)
                if (listYear.Items.Count == 0)
                    listYear.Items.Add(main.roadmap[i].dateTravel.Year);
                else if (!main.roadmap[i].dateTravel.Year.ToString().Equals(listYear.Items[listYear.Items.Count - 1].ToString()))
                    listYear.Items.Add(main.roadmap[i].dateTravel.Year);
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (listTravel.SelectedIndices.Count > 0)
            {
                main.roadmap.RemoveAt(listTravel.SelectedIndices[0]);

                listTravel.Items.Clear();
                for (int i = 0; i < main.roadmap.Count; i++)
                    listTravel.Items.Add(main.roadmap[i].dateTravel);
            }
        }

        private void listTravel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTravel.SelectedItem != null)
            {
                km_lbl.Text = founded[listTravel.SelectedIndex].km.ToString();
                time_lbl.Text = founded[listTravel.SelectedIndex].hours + ":" + founded[listTravel.SelectedIndex].mins.ToString().PadLeft(2, '0') + ":" + founded[listTravel.SelectedIndex].secs.ToString().PadLeft(2, '0');
                avarage_lbl.Text = founded[listTravel.SelectedIndex].avarage.ToString();
                travel_lbl.Text = founded[listTravel.SelectedIndex].road;
            }
        }

        private void listYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listYear.SelectedItem != null)
            {
                listTravel.Items.Clear();
                founded.Clear();
                for (int i = 0; i < main.roadmap.Count; i++)
                    if (main.roadmap[i].dateTravel.Year.ToString().Equals(listYear.SelectedItem.ToString()))
                    {
                        founded.Add(main.roadmap[i]);
                        listTravel.Items.Add(main.roadmap[i].dateTravel.ToLongDateString());
                    }

                calc_total_year(Convert.ToInt32(listYear.SelectedItem.ToString()));

            }
        }

        private void History_FormClosing(object sender, FormClosingEventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter br = new BinaryFormatter();
            using (FileStream fs = new FileStream(main.filePath, FileMode.OpenOrCreate))
            {
                try
                {
                    br.Serialize(ms, main.roadmap);
                    ms.WriteTo(fs);
                }
                catch (Exception ex) { MessageBox.Show("Errore nel salvataggio " + ex.StackTrace, "Errore"); }
                finally { fs.Close(); }
            }
            main.update_stat();
        }

        private void calc_total_year(int selected)
        {
            decimal tempKm = 0;
            decimal tempAv = 0;
            int tempHours = 0;
            int tempMins = 0;
            int tempSecs = 0;
            int tempDays = 0;

            main.findPos(selected);
            for (int i = main.pos; (i < main.roadmap.Count)&&(selected == main.roadmap[i].dateTravel.Year); i++)
            {
                tempKm += main.roadmap[i].km;
                tempAv += main.roadmap[i].avarage;
                tempDays++;

                tempSecs += main.roadmap[i].secs;
                if (tempSecs > 60)
                {
                    tempSecs -= 60;
                    tempMins++;
                }

                tempMins += main.roadmap[i].mins;
                if (tempMins > 60)
                {
                    tempMins -= 60;
                    tempHours++;
                }

                tempHours += main.roadmap[i].hours;
            }

            if (tempDays != 0)
                tempAv = Math.Round(tempAv / tempDays, 2);

            totalKm.Text = tempKm.ToString();
            totalTime.Text = tempHours.ToString() + ":" + tempMins.ToString().PadLeft(2, '0') + ":" + tempSecs.ToString().PadLeft(2, '0');
            totalAvarage.Text = tempAv.ToString();
            totalDays.Text = tempDays.ToString();
        }
    }
}
