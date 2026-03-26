using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka
{
    public partial class Form_klient : Form
    {
        public Form_klient()
        {
            InitializeComponent();
            this.Text = "Přidat klienta";
            bOK.Text = "Přidat";
            bOK.Click += bPridat_Click;
        }
        public Form_klient(Klient klient)
        {
            InitializeComponent();
            this.Text = "Upravit klienta";
            bOK.Text = "Upravit";
            bOK.Click += bUpravit_Click;
            tbJmeno.Text = klient.Jmeno;
            tbPrijmeni.Text = klient.Prijmeni;
            tbUzivatelskeJmeno.Text = klient.UzivatelskeJmeno;
            tbHeslo.Text = klient.Heslo;
            this.klient = klient;
        }

        public Klient klient;
        void bPridat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbJmeno.Text) || string.IsNullOrWhiteSpace(tbPrijmeni.Text) ||
                               string.IsNullOrWhiteSpace(tbUzivatelskeJmeno.Text) || string.IsNullOrWhiteSpace(tbHeslo.Text))
            {
                MessageBox.Show("Vyplňte všechna pole.");
                return;
            }
            klient = new Klient(tbJmeno.Text, tbPrijmeni.Text, tbUzivatelskeJmeno.Text, tbHeslo.Text);
            this.DialogResult = DialogResult.OK;

        }
        void bUpravit_Click(object sender, EventArgs e)
        {
            if (klient == null)
            {
                MessageBox.Show("Žádný klient k úpravě.");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbJmeno.Text) || string.IsNullOrWhiteSpace(tbPrijmeni.Text) ||
                                              string.IsNullOrWhiteSpace(tbUzivatelskeJmeno.Text) || string.IsNullOrWhiteSpace(tbHeslo.Text))
            {
                MessageBox.Show("Vyplňte všechna pole.");
                return;
            }
            klient = new Klient(tbJmeno.Text, tbPrijmeni.Text, tbUzivatelskeJmeno.Text, tbHeslo.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}
