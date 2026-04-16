using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public class Ucet
    {
        /*
         * a.	Vlastnosti
            i.	CisloUctu
            ii.	Zustatek
            b.	Metody
            i.	VlozPenize()
            ii.	VyberPenize()
        */
        public static string JmenoSouboru = "ucty.csv";
        public static string CSVzahlavi = "klient;CisloUctu;Zustatek";
        public static List<int> SeznamUctu = new List<int>(); //seznam všech čísel účtů pro kontrolu unikátnosti při vytváření nového účtu
        public int CisloUctu { get; set; }
        public decimal Zustatek { get; set; }

        public Ucet(int cisloUctu)
        {
            CisloUctu = cisloUctu;
        }

        public Ucet(int cisloUctu, decimal zustatek) : this(cisloUctu)
        {
            Zustatek = zustatek;
        }

        public override string ToString()
        {
            return CisloUctu.ToString();
        }

        public void VlozPenize(decimal castka)
        {
            if (castka > 0) //ochrana proti vkladu záporné částky
            {
                this.Zustatek += castka;
            }
        }

        public bool VyberPenize(decimal castka)
        {//ochrana proti výběru záporné částky a proti výběru větší částky než je zůstatek na účtu
            if (castka <= this.Zustatek)
            {
                this.Zustatek -= castka;
                return true;
            }
            else
            {
                throw new InvalidOperationException("Nedostatečný zůstatek na účtu.");
            }
        }
    }
}
