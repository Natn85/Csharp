using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppFaehre2025Vorlage
{
    public class PKW : Fahrzeug
    {
        protected int personenAnzahl;
        public PKW(decimal gesamatPreis, string kennzeichen, double laenge, int leergewicht, string marke, int personenAnzahl) : base(gesamatPreis, kennzeichen, laenge, leergewicht, marke)
        {
            this.personenAnzahl = personenAnzahl;
        }
        
        public int PersonenAnzahl { get => personenAnzahl; set => personenAnzahl = value; }

        public override string ToString()
        {
            return $"{personenAnzahl}";
        }
    }
}
