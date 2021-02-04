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
    public partial class Form1 : Form
    {
        int i, j;
        Label lbl;
        Button btnS, btnM, btnL;
        public Form1()
        {
            Height = 150;
            Width = 360;
            Text = "Saali valimine";

            lbl = new Label();
            lbl.Text = "Vali saal:";
            lbl.Size = new Size(300, 20);
            lbl.Location = new Point(20, 10);
            Controls.Add(lbl);

            btnS = new Button();
            btnS.Text = "Väike";
            btnS.Size = new Size(100, 30);
            btnS.Location = new Point(20, 40);
            btnS.Click += BtnS_Click;
            Controls.Add(btnS);

            btnM = new Button();
            btnM.Text = "Keskmine";
            btnM.Size = new Size(100, 30);
            btnM.Location = new Point(120, 40);
            btnM.Click += BtnM_Click;
            Controls.Add(btnM);

            btnL = new Button();
            btnL.Text = "Suur";
            btnL.Size = new Size(100, 30);
            btnL.Location = new Point(220, 40);
            btnL.Click += BtnL_Click;
            Controls.Add(btnL);
        }

        private void BtnL_Click(object sender, EventArgs e)
        {
            i = 10; j = 10;
            Saalid hall = new Saalid(i, j);
            hall.Show();
            Hide();
        }

        private void BtnM_Click(object sender, EventArgs e)
        {
            i = 5; j = 5;
            Saalid hall = new Saalid(i, j);
            hall.Show();
            Hide();
        }

        private void BtnS_Click(object sender, EventArgs e)
        {
            i = 3; j = 3;
            Saalid hall = new Saalid(i, j);
            hall.Show();
            Hide();
        }
    }
}
