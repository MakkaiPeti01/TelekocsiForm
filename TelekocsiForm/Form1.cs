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
using System.IO;
using System.Runtime.CompilerServices;

namespace telekocsiform
{
    public partial class frmFo : Form
    {
        private List<Auto> autok = new List<Auto>();
        private List<Igeny> igeny = new List<Igeny>();
        public frmFo()
        {
            InitializeComponent();
            lbKimenet.Items.Clear();
        }

        private void btnBeolvasas_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader be = new StreamReader("autok.csv");
                be.ReadLine();
                while (!be.EndOfStream)
                {
                    autok.Add(new Auto(be.ReadLine()));
                }
                be.Close();


                Console.WriteLine($"2. Feladat\n\t{autok.Count} autós hirdet fuvart");

                StreamReader be2 = new StreamReader("igenyek.csv");
                be2.ReadLine();
                while (!be2.EndOfStream)
                {
                    igeny.Add(new Igeny(be2.ReadLine()));
                }
                be2.Close();
                btn_Masodik.Enabled = true;
                btnBeolvasas.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Masodik_Click(object sender, EventArgs e)
        {
            lbKimenet.Items.Add("2.Feladat");
            lbKimenet.Items.Add($"    {autok.Count} autós hirdet fuvart");
            btn_Harmadik.Enabled = true;
            btn_Masodik.Enabled = false;

        }

        private void btn_Harmadik_Click(object sender, EventArgs e)
        {
            lbKimenet.Items.Clear();

            int hely = 0;
            foreach (var i in autok)
            {
                if (i.Utvonal == "Budapest-Miskolc")
                {
                    hely = hely + i.Ferohely;
                }
            }
            lbKimenet.Items.Add("3.Feladat");
            lbKimenet.Items.Add($"  Összesen {hely} férőhelyet hirdettek az autósok Budapestről Miskolcra");
            btn_Harmadik.Enabled = false;
            btn_Negyedik.Enabled = true;

        }

        private void btn_Negyedik_Click(object sender, EventArgs e)
        {
            lbKimenet.Items.Clear();

            int max = 0;
            string utv = "";

            var utvonalak = from a in autok
                            orderby a.Utvonal
                            group a by a.Utvonal into temp
                            select temp;
            foreach (var ut in utvonalak)
            {
                int fh = ut.Sum(x => x.Ferohely);
                if (max < fh)
                {
                    max = fh;
                    utv = ut.Key;
                }
            }
            lbKimenet.Items.Add("4. Feladat");
            lbKimenet.Items.Add($"   A legtöbb férőhelyet ({max}) a {utv} útvonalon ajánlottak fel a hírdetők");
            btn_Negyedik.Enabled = false;
            btn_Otodik.Enabled = true;

        }

        private void btn_Otodik_Click(object sender, EventArgs e)
        {
            lbKimenet.Items.Clear();
            lbKimenet.Items.Add("5. feladat");

            foreach (var igeny in igeny)
            {
                int i = igeny.VanAuto(autok);

                if (i > -1)
                {
                    lbKimenet.Items.Add($"  {igeny.Azonosito}=>{autok[i].Rendszam}");
                }
            }
            btn_Otodik.Enabled = false;
            btn_Hatodik.Enabled = true;

        }

        private void btn_Hatodik_Click(object sender, EventArgs e)
        {
            lbKimenet.Items.Clear();
            lbKimenet.Items.Add("6. feladat");
            StreamWriter file = new StreamWriter("utasuzenetek.txt");

            foreach (var igeny in igeny)
            {
                int i = igeny.VanAuto(autok);

                if (i > -1)
                {
                    file.WriteLine($"{igeny.Azonosito}: Rendszám: {autok[i].Rendszam}, Telefonszám: {autok[i].Telefonszam}");
                }
                else
                {
                    file.WriteLine($"{igeny.Azonosito}: Sajnos nem sikerült autót találni");
                }
            }
            file.Close();
            lbKimenet.Items.Add("Adatok fájlba írása megtörtént");

            btn_Hatodik.Enabled = false;
        }

        private void btn_Kilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
