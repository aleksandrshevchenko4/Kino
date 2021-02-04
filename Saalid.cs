using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino
{
    public partial class Saalid : Form
    {
        int i, j;
        Label[,] _arr;
        public Saalid(int i_, int j_)
        {
            _arr = new Label[i_, j_];
            Size = new Size(i_ * 80, j_ * 75);
            Text = "Saal";
            for (i = 0; i < i_; i++)
            {
                for (j = 0; j < j_; j++)
                {
                    _arr[i, j] = new Label();
                    _arr[i, j].BackColor = Color.DarkGreen;
                    _arr[i, j].Text = "Koht " + (j + 1);
                    _arr[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    _arr[i, j].Size = new Size(55, 55);
                    _arr[i, j].BorderStyle = BorderStyle.Fixed3D;
                    _arr[i, j].Location = new Point(j * 55 + 55, i * 55);
                    Controls.Add(_arr[i, j]);
                    _arr[i, j].Tag = new int[] { i, j };
                    _arr[i, j].Click += new System.EventHandler(Saalid_Click);
                }
            }
        }

        private void Saalid_Click(object sender, EventArgs e)
        {
            var label = (Label)sender;
            var tag = (int[])label.Tag;
            if (_arr[tag[0], tag[1]].Text != "Valitud")
            {
                _arr[tag[0], tag[1]].Text = "Valitud";
                _arr[tag[0], tag[1]].BackColor = Color.DarkOrange;
            }
            else
            {
                MessageBox.Show("Rida: " + (tag[0] + 1) + ", Koht: " + (tag[1] + 1) + " - juba võetud!");
            }
        }
    }
}