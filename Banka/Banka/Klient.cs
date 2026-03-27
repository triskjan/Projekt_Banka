using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public class Klient
    {
        public static string CSVzahlavi = "Jmeno;Prijmeni;UzivatelskeJmeno;Heslo";
        public static string jmenoSouboru = "klienti.csv";
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
        public Klient(string csvData)
        {
            string[] data = csvData.Split(';');
            this.Jmeno = data[0];
            this.Prijmeni = data[1];
            this.UzivatelskeJmeno = data[2];
            this.Heslo = data[3];
        }
        public string ToCSV()
        {
            return $"{Jmeno};{Prijmeni};{UzivatelskeJmeno};{Heslo}";
        }
        public override string ToString()
        {
            return $"{Prijmeni} {Jmeno} - {UzivatelskeJmeno}";
        }
    }
}
