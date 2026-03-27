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
                        listBox1.Items[listBox1.SelectedIndex] = form_Klient.klient;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(File.Exists(Klient.jmenoSouboru))
                using (StreamReader sr = new StreamReader("klienti.csv", Encoding.UTF8))
                {
                    string csvData = null;
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        csvData = sr.ReadLine();
                        listBox1.Items.Add(new Klient(csvData));
                    }
                }
        }
    }
}
