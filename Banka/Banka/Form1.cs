using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Banka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool JeVybranKlient { get { return lbKlienti.SelectedIndex != -1; } }
        private void bPridejKlienta_Click(object sender, EventArgs e)
        {
            Form_klient form_Klient = new Form_klient();
            if(form_Klient.ShowDialog() == DialogResult.OK)
            {
                if (form_Klient.klient != null)
                {
                    lbKlienti.Items.Add(form_Klient.klient);
                    MessageBox.Show($"Přidán klient: {form_Klient.klient.ToString()}");
                }
            }
        }

        private void bOdstranKlienta_Click(object sender, EventArgs e)
        {
            if(JeVybranKlient)
            {
                    lbKlienti.Items.RemoveAt(lbKlienti.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Vyberte klienta k odstranění.");
            }
        }

        private void bUpravKlienta_Click(object sender, EventArgs e)
        {
            if(JeVybranKlient)
            {
                Form_klient form_Klient = new Form_klient((Klient)lbKlienti.SelectedItem);
                if (form_Klient.ShowDialog() == DialogResult.OK)
                {
                    if (form_Klient.klient != null)
                    {
                        lbKlienti.Items[lbKlienti.SelectedIndex] = form_Klient.klient; //vizualni aktualizace udaju v listboxu
                        MessageBox.Show($"Upraven klient: {form_Klient.klient.ToString()}");
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //uložení dat klientů do souboru při zavírání aplikace, aby nedošlo ke ztrátě dat při ukončení aplikace
            using (StreamWriter sw = new StreamWriter(Klient.SouborJmeno, false, Encoding.UTF8))
            {
                sw.WriteLine(Klient.CSVzahlavi);
                foreach (Klient klient in lbKlienti.Items)
                {
                    sw.WriteLine(klient.ToCSV());
                }
            }
            //uložení dat o použitých účtech do souboru při zavírání aplikace, aby nedošlo ke ztrátě dat o účtech při ukončení aplikace
            using (StreamWriter sw2 = new StreamWriter(Ucet.SouborUcty, false, Encoding.UTF8))
            {
                sw2.WriteLine(Ucet.CSVzahlavi);
                foreach (Klient klient in lbKlienti.Items)
                {
                    foreach (Ucet ucet in klient.Ucty)
                    {
                        sw2.WriteLine($"{klient.UzivatelskeJmeno};{ucet.ToCSV()}");
                    }
                }
            }
            //uložení všech účtu klientů do souboru při zavírání aplikace, aby nedošlo ke ztrátě dat o účtech klientů při ukončení aplikace
            using (StreamWriter sw3 = new StreamWriter(Ucet.SouborSeznamUctu, false, Encoding.UTF8))
            {
                sw3.WriteLine(Ucet.CSVzahlavi);
                foreach ( Klient klient in lbKlienti.Items)
                {
                    foreach (Ucet ucet in klient.Ucty)
                    {
                        sw3.WriteLine($"{klient.UzivatelskeJmeno};{ucet.ToCSV()}");
                    }
                }
            }
            //Uložení aktuálního maximálního čísla účtu do souboru při zavírání aplikace, aby bylo možné pokračovat v číslování účtů i po restartu aplikace
            File.WriteAllText(Ucet.SouborMaxUcet, Ucet.MaxCisloUctu.ToString()); //uložení aktuálního maximálního čísla účtu do souboru při zavírání aplikace, aby bylo možné pokračovat v číslování účtů i po restartu aplikace
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //načtení dat klientů ze souboru při spuštění aplikace, aby bylo možné pokračovat v práci s existujícími klienty i po restartu aplikace
            if (File.Exists(Klient.SouborJmeno))
                using (StreamReader sr = new StreamReader(Klient.SouborJmeno, Encoding.UTF8))
                {
                    sr.ReadLine(); //přeskočení hlavičky souboru s klienty
                    while (!sr.EndOfStream)
                    {
                        lbKlienti.Items.Add(new Klient(sr.ReadLine()));
                    }
                }
            //načtení dat o použitých účtech ze souboru při spuštění aplikace, aby bylo možné pokračovat v práci s existujícími účty i po restartu aplikace
            if (File.Exists(Ucet.SouborUcty)) //kontrola existence souboru s účty před načítáním dat, aby nedošlo k chybě při načítání z neexistujícího souboru
            {
                using (StreamReader sr = new StreamReader(Ucet.SouborUcty, Encoding.UTF8))
                {
                    sr.ReadLine();//přeskočení hlavičky souboru s účty
                    while (!sr.EndOfStream)
                    {
                        string[] data = sr.ReadLine().Split(';');
                        string jmenoKlienta = data[0];
                        //najdi klienta s odpovídajícím jménem a přidej mu účet do seznamu účtů klienta
                        Klient klient = lbKlienti.Items.Cast<Klient>().FirstOrDefault(k => k.UzivatelskeJmeno == jmenoKlienta);
                        if (klient != null)
                        {
                            klient.Ucty.Add(new Ucet(Convert.ToInt32(data[1]), decimal.Parse(data[2])));
                        }
                    }
                }
            }

            //načtení dat o maximálním čísle účtu ze souboru při spuštění aplikace, aby bylo možné pokračovat v číslování účtů i po restartu aplikace
            if (File.Exists(Ucet.SouborMaxUcet))
            {
                Ucet.MaxCisloUctu = Convert.ToInt32(File.ReadAllText(Ucet.SouborMaxUcet));
            }
            else Ucet.MaxCisloUctu = 10000;
            

        }

        private void bVkladyVybery_Click(object sender, EventArgs e)
        {
            if (JeVybranKlient)
            {
                Form_klient form_Klient = new Form_klient((Klient)lbKlienti.SelectedItem, true);
                //form_Klient.FinancniOperace = true; //nastavení indikace pro otevření formuláře pro finanční operace (vklad/výběr) místo pro úpravu klienta
                if (form_Klient.ShowDialog() == DialogResult.OK)
                {
                
                }
            }
        }
    }
}
