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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
            if(listBox1.SelectedIndex !=-1)
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
            if(listBox1.SelectedIndex !=-1)
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
    }
}
