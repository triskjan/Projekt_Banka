using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool JeVybranKlient { get { return listBox1.SelectedIndex != -1; } }
        private void bPridejKlienta_Click(object sender, EventArgs e)
        {
            Form_klient form_Klient = new Form_klient();
            if(form_Klient.ShowDialog() == DialogResult.OK)
            {
                if (form_Klient.klient != null)
                {
                    listBox1.Items.Add(form_Klient.klient);
                    MessageBox.Show($"Přidán klient: {form_Klient.klient.ToString()}");
                }
            }
        }

        private void bOdstranKlienta_Click(object sender, EventArgs e)
        {
            if(JeVybranKlient)
            {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
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
                Form_klient form_Klient = new Form_klient((Klient)listBox1.SelectedItem);
                if (form_Klient.ShowDialog() == DialogResult.OK)
                {
                    if (form_Klient.klient != null)
                    {
                        listBox1.Items[listBox1.SelectedIndex] = form_Klient.klient; //vizualni aktualizace udaju v listboxu
                        MessageBox.Show($"Upraven klient: {form_Klient.klient.ToString()}");
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(Klient.jmenoSouboru, false, Encoding.UTF8))
            {
                sw.WriteLine(Klient.CSVzahlavi);
                foreach (Klient klient in listBox1.Items)
                {
                    sw.WriteLine(klient.ToCSV());
                }
            }
            using (StreamWriter sw2 = new StreamWriter(Ucet.JmenoSouboru, false, Encoding.UTF8))
            {
                sw2.WriteLine("PouziteUcty");
                foreach (int cisloUctu in Ucet.SeznamUctu)
                {
                    sw2.WriteLine(cisloUctu.ToString());
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(Klient.jmenoSouboru))
                using (StreamReader sr = new StreamReader(Klient.jmenoSouboru, Encoding.UTF8))
                {
                    string csvData = null;
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        csvData = sr.ReadLine();
                        listBox1.Items.Add(new Klient(csvData));
                    }
                }
            if (File.Exists(Ucet.JmenoSouboru))
            {
                using (StreamReader sr = new StreamReader(Ucet.JmenoSouboru, Encoding.UTF8))
                        {
                    string csvData = null;
                    sr.ReadLine();//přeskočení hlavičky souboru s účty
                    while (!sr.EndOfStream)
                    {      
                        csvData = sr.ReadLine();
                        string[] data = csvData.Split(';');
                        string jmenoKlienta = data[0];

                        Klient klient = listBox1.Items.Cast<Klient>().FirstOrDefault(k => k.UzivatelskeJmeno == jmenoKlienta);
                        if (klient != null)
                        {
                            klient.Ucty.Add(new Ucet(Convert.ToInt32(data[1]), decimal.Parse(data[2])));
                        }
                    }
                }
                using (StreamReader sr2 = new StreamReader(Ucet.JmenoSouboru, Encoding.UTF8))
                {
                    sr2.ReadLine(); //přeskočení hlavičky souboru s čísly účtů
                    while (!sr2.EndOfStream)
                       Ucet.SeznamUctu.Add(Convert.ToInt32(sr2.ReadLine()));
                }
            }

        }

        private void bVkladyVybery_Click(object sender, EventArgs e)
        {
            if (JeVybranKlient)
            {
                Form_klient form_Klient = new Form_klient((Klient)listBox1.SelectedItem, true);
                //form_Klient.FinancniOperace = true; //nastavení indikace pro otevření formuláře pro finanční operace (vklad/výběr) místo pro úpravu klienta
                if (form_Klient.ShowDialog() == DialogResult.OK)
                {
                
                }
            }
        }
    }
}
