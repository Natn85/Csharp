using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppFaehre2025Vorlage
{
    public class LKW : Fahrzeug
    {
        private decimal gesamtGewicht;
        public LKW(decimal gesamatPreis, string kennzeichen, double laenge, int leergewicht, string marke, decimal gesamtGewicht) : base(gesamatPreis, kennzeichen, laenge, leergewicht, marke)
        {
            this.gesamtGewicht = gesamtGewicht;
        }
        
        public decimal Gesamtgewicht { get => gesamtGewicht; set => gesamatPreis = value;  }

        public override string ToString()
        {
            return $"{gesamtGewicht}";
        }
    }
}
