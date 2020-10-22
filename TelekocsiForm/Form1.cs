using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TelekocsiForm
{
    public partial class frmFo : Form
    {
        private List<Autok> autok = new List<Autok>();
        private List<Igeny> igeny = new List<Igeny>();
        public frmFo()
        {
            InitializeComponent();
            lb_Kimenet.Items.Clear();
        }

        private void btn_Beolvasas_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader olvas = new StreamReader("autok.csv");
                olvas.ReadLine();
                while (!olvas.EndOfStream)
                {
                    autok.Add(new Autok(olvas.ReadLine()));
                }
                olvas.Close();
                StreamReader sr = new StreamReader("igenyek.csv");
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    igeny.Add(new Igeny(sr.ReadLine()));
                }
                sr.Close();
                btn_Masodik.Enabled = true;
                btn_Beolvasas.Enabled = false;
               // lb_Kimenet.Items.Add("2. feladat\n\t{0} autós hirdet fuvart", autok.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Hiba",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Masodik_Click(object sender, EventArgs e)
        {
            lb_Kimenet.Items.Add("2. feladat autós hirdet fuvart");
            lb_Kimenet.Items.Add(autok.Count);
            btn_Masodik.Enabled = false;
            btn_Harmadik.Enabled = true;
        }

        private void btn_Harmadik_Click(object sender, EventArgs e)
        {
            lb_Kimenet.Items.Clear();
            int ferohely = 0;
            foreach (var i in autok)
            {
                if (i.Utvonal=="Budapest-Miskolc")
                {
                    ferohely = ferohely + i.Hely;
                }
            }
            Console.WriteLine($"3. feladat\n\t Összesen {ferohely} férőhelyet hirdettek" +
                $"az autósok Budapestről Miskolcra");
            lb_Kimenet.Items.Add("3. feladat");
            lb_Kimenet.Items.Add($"Összesen {ferohely} érőhelyet hirdettek az autósok Budapestről Miskolcra");
            btn_Harmadik.Enabled = false;
            btn_Negyedik.Enabled = true;
        }

        private void btn_Negyedik_Click(object sender, EventArgs e)
        {
            btn_Harmadik.Enabled = false;
            lb_Kimenet.Items.Clear();
            var utvonalak = from a in autok
                            orderby a.Utvonal
                            group a by a.Utvonal into temp
                            select temp;
            int max = 0;
            string utvonal = "";
            foreach (var i in utvonalak)
            {
                int ferohely = i.Sum(x => x.Hely);
                if (max < ferohely)
                {
                    max = ferohely;
                    utvonal = i.Key;
                }
            }
            lb_Kimenet.Items.Add("4. feladat");
            lb_Kimenet.Items.Add($"A legtöbb férőhelyet ({max}-at) a {utvonal} útvonalon ajánlották fel a hirdetők");
            btn_Negyedik.Enabled = false;
        }
    }
}
