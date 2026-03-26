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
    }
}
