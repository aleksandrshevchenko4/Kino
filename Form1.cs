using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino
{
    
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\AppData\Kino.mdf; Integrated Security = True");
        SqlCommand command;
        SqlDataAdapter Saalide_adapter;
        int i, j;
        Label lbl;
        Button btnS, btnM, btnL;
        int[] rida_list;
        int[] koht_list;
        public Form1()
        {
            Height = 150;
            Width = 360;
            Text = "Saali valimine";

            con.Open();
            Saalide_adapter = new SqlDataAdapter("SELECT * FROM Saalid_tabel", con);
            DataTable salid_tabel = new DataTable();
            Saalide_adapter.Fill(salid_tabel);
            foreach(DataRow row in salid_tabel.Rows)
            {
                saalide_list.Items.Add(row["Saalinimetus"]);//fix
            }
            rida_list = new int[salid_tabel.Rows.Count]; 
            koht_list = new int[salid_tabel.Rows.Count];
            int a = 0;
            foreach(DataRow row in salid_tabel.Rows)
            {
                rida_list[a] = (int)row["Rida"];
                koht_list[a] = (int)row["Koht"];
                a = a + 1;
            }
            con.Close();

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

        private void Saalide_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            //i = rida_list[Saalide_list: selectedIndex];
            //j = rida_list[Saalide_list: selectedIndex];
            if (saalide_list.SelectedIndex == 0)
            {
                i = rida_list[0];j = koht_list[0];
            }
            else if (saalide_list.SelectedIndex == 0)
            {
                i = rida_list[1]; j = koht_list[1];
            }
            else if (saalide_list.SelectedIndex == 0)
            {
                i = rida_list[2]; j = koht_list[2];
            }
            else if (saalide_list.SelectedIndex == 0)
            {
                i = rida_list[3]; j = koht_list[3];
            }
            else
            {
                MessageBox.Show("Viga!", "Vaja saal vilada");
            }
            Saalid saalid = new Saalid(i, j);
            saalid.Show();
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
