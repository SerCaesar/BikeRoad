using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BikeRoad
{
    public partial class Search : Form
    {

        Form1 main;
        List<Travel> selectedTrail = new List<Travel>();

        public Search(Form1 finestra)
        {
            main = finestra;
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                km_lbl.Text = selectedTrail[listBox1.SelectedIndex].km.ToString();
                time_lbl.Text = selectedTrail[listBox1.SelectedIndex].hours + ":" + selectedTrail[listBox1.SelectedIndex].mins.ToString().PadLeft(2, '0') + ":" + selectedTrail[listBox1.SelectedIndex].secs.ToString().PadLeft(2, '0');
                avarage_lbl.Text = selectedTrail[listBox1.SelectedIndex].avarage.ToString();
                trail_txtBox.Text = selectedTrail[listBox1.SelectedIndex].road;
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            selectedTrail.Clear();
            listBox1.Items.Clear();

            for (int i = 0; i < main.roadmap.Count; i++)
                if (main.roadmap[i].road.ToLower().Contains(searchBox.Text.ToLower()))
                {
                    selectedTrail.Add(main.roadmap[i]);
                    listBox1.Items.Add(main.roadmap[i].dateTravel.ToLongDateString());
                }

            trail_found.Text = selectedTrail.Count.ToString();
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                search_btn_Click(null, null);
        }
    }
}
