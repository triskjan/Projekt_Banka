using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public class Klient
    {
        /*
    *            * a.	Vlastnosti
    *             i.	Jmeno
*                 ii.	Prijmeni
*                 iii.	UzivatelskeJmeno
*                  iv.	Heslo
*                                                                                   */
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string UzivatelskeJmeno { get; set; }
        public string Heslo { get; set; }
        
        public Klient(string jmeno, string prijmeni, string uzivatelskeJmeno, string heslo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            UzivatelskeJmeno = uzivatelskeJmeno;
            Heslo = heslo;
        }
        public override string ToString()
        {
            return $"{Prijmeni} {Jmeno} - {UzivatelskeJmeno}";
        }
    }
}
