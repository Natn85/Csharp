using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppFaehre2025Vorlage
{
    public class Fahrzeug
    {
        protected decimal gesamatPreis;
        protected string kennzeichen;
        protected double laenge;
        protected int leergewicht;
        protected string marke;

        public Fahrzeug(decimal gesamatPreis, string kennzeichen, double laenge, int leergewicht, string marke)
        {
            this.gesamatPreis = gesamatPreis;
            this.kennzeichen = kennzeichen;
            this.laenge = laenge;
            this.leergewicht = leergewicht;
            this.marke = marke;
        }

        public decimal GesamtPreis { get => gesamatPreis; }
        public string Kennzeichen { get => kennzeichen; set => kennzeichen = value; }
        public double Laenge { get => laenge; }
        public int Leergewicht {  get => leergewicht; }
        public string Marke { get => marke; set => marke = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
