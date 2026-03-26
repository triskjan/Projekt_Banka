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

        private void button1_Click(object sender, EventArgs e)
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
    }
}
