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
        public string CisloUctu { get; set; }
        public decimal Zustatek { get; set; }

        public Ucet(string cisloUctu)
        {
            CisloUctu = cisloUctu;
        }

        public Ucet(string cisloUctu, decimal zustatek) : this(cisloUctu)
        {
            Zustatek = zustatek;
        }

        public void VlozPenize(decimal castka)
        {

        }

        public void VyberPenize(decimal castka)
        {

        }
    }
}
