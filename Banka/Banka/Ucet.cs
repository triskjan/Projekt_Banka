using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public class Ucet
    {
        public static string SouborUcty = "ucty.csv";
        public static string SouborSeznamUctu = "Seznam_uctu.txt"; //soubor pro uložení seznamu všech čísel účtů pro kontrolu unikátnosti při vytváření nového účtu
        public static string SouborMaxUcet = "MaxCisloUctu.txt"; //soubor pro uložení aktuálního maximálního čísla účtu, aby bylo možné pokračovat v číslování účtů i po restartu aplikace
        public static int MaxCisloUctu = 0;
        public static string CSVzahlavi = "klient;CisloUctu;Zustatek";

        public int CisloUctu { get; set; }
        public decimal Zustatek { get; set; }

        public Ucet(int cisloUctu)
        {
            CisloUctu = ++MaxCisloUctu;
            Zustatek = 0;
        }

        public Ucet(int cisloUctu, decimal zustatek) : this(cisloUctu)
        {
            CisloUctu = cisloUctu; //při načítání účtu z CSV souboru se číslo účtu nastaví na hodnotu z CSV, ale zároveň se aktualizuje MaxCisloUctu, aby bylo zajištěno, že nové účty budou mít unikátní čísla
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
        public string ToCSV()
        {
            return $"{CisloUctu};{Zustatek}";
        }
    }
}
