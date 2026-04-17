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

namespace Banka
{
    public partial class Form_klient : Form
    {
        public bool FinancniOperace { get; set; } //indikace, zda je formulář otevřen pro finanční operace (vklad/výběr) nebo pro přidání/úpravu klienta
        public Form_klient()
        {
            InitializeComponent();
            this.Text = "Přidat klienta";
            bOK.Text = "Přidat";
            bOK.Click += bPridat_Click;
            groupBox1.Enabled = groupBox2.Enabled = false; //deaktivace pole pro úpravu údajů klienta při přidávání nového klienta, protože údaje se zadávají do textových polí a neexistuje žádný klient k úpravě
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
            groupBox1.Enabled = groupBox2.Enabled = false;
        }
public Form_klient(Klient klient, bool financniOperace) : this(klient) //konstruktor pro otevření formuláře pro finanční operace, který využívá konstruktor pro úpravu klienta a navíc nastaví indikátor finanční operace
        {
            if (financniOperace)
            {
                this.Text = "Finanční operace klient";
                bOK.Text = "Zavřít";
                groupBox3.Enabled = false; //deaktivace pole pro úpravu údajů klienta při finanční operaci, aby nedošlo k nechtěné změně údajů klienta při vkladu/výběru peněz
                bOK.Click -= bUpravit_Click; //odpojení původní akce pro úpravu klienta
                bOK.Click += bOK_Click; //připojení nové akce pro zavření formuláře po provedení finanční operace
                groupBox1.Enabled = groupBox2.Enabled = true;
                AktualizujUctyKlienta();
            }
        }

        public Klient klient;
        void bOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
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

        private void bPridatUcet_Click(object sender, EventArgs e)
        {
            int noveCisloUctu = Ucet.MaxCisloUctu + 1; //generování nového čísla účtu jako maximum z existujících čísel účtů + 1 pro zajištění unikátnosti
            klient.Ucty.Add(new Ucet( noveCisloUctu,0)); //přidání nového účtu do seznamu účtů klienta
            AktualizujUctyKlienta();

        }
        private void AktualizujUctyKlienta()
        {
            lbUcty.Items.Clear();
            foreach (Ucet ucet in klient.Ucty)
            {
                lbUcty.Items.Add(ucet);
            }
        }

        private void lbUcty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbUcty.SelectedItem != null)
            {
                Ucet selectedUcet = (Ucet)lbUcty.SelectedItem;
                nudZustatek.Value = selectedUcet.Zustatek; //zobrazení zůstatku na účtu v numerickém poli pro možnost provedení finanční operace (vklad/výběr)
                
            }
        }

        private void Form_klient_Load(object sender, EventArgs e)
        {
            nudZustatek.Enabled = false; 
        }

        private void bVlozit_Click(object sender, EventArgs e)
        {
            if(lbUcty.SelectedItem != null)
            {
                Ucet vybranyUcet = (Ucet)lbUcty.SelectedItem;
                vybranyUcet.VlozPenize(nudCastka.Value); //provedení vkladu peněz na vybraný účet pomocí metody VlozPenize třídy Ucet
                nudZustatek.Value = vybranyUcet.Zustatek;   
            }
            else
            {
                MessageBox.Show("Vyberte účet pro vklad peněz.");
            }
        }

        private void bVybrat_Click(object sender, EventArgs e)
        {
            if (lbUcty.SelectedItem != null)
            {
                Ucet vybranyUcet = (Ucet)lbUcty.SelectedItem;
                vybranyUcet.VyberPenize(nudCastka.Value); //provedení vkladu peněz na vybraný účet pomocí metody VlozPenize třídy Ucet
                nudZustatek.Value = vybranyUcet.Zustatek;
            }
            else
            {
                MessageBox.Show("Vyberte účet pro výběr peněz.");
            }
        }
    }
}
