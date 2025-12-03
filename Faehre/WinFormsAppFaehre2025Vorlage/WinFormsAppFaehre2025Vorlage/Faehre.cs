using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppFaehre2025Vorlage
{
    public class Faehre
    {
        protected List<Fahrzeug> autoDeck;
        protected decimal erpreis;
        private decimal belegteLaenge;
        private decimal grundpreisPKW = 20;
        private decimal grundpreisLKW = 100;
        private decimal maxLaenge;
        private string name;
        private decimal preisProPerson = 10;
        private decimal preisProTonne = 10;



        public Faehre(decimal belegtelaenge, decimal grundpreisPKW, decimal grundPreisLKW, decimal maxLaenge, string name, decimal preisProPerson, decimal preisProTonne)
        {
            this.belegteLaenge = belegtelaenge;
            this.grundpreisPKW = grundpreisPKW;
            this.grundpreisLKW = grundPreisLKW;
            this.maxLaenge = maxLaenge;
            this.name = name;
            this.preisProPerson = preisProPerson;
            this.preisProTonne = preisProTonne;
        }

        public decimal BelegteLaenge { get => belegteLaenge; set => belegteLaenge = value; }
        public decimal GrundpreisPKW { get => grundpreisPKW; set => grundpreisPKW = value; }
        public decimal GrundpreisLKW { get => grundpreisLKW; set => grundpreisLKW = value; }
        public decimal MaxLaenge { get => maxLaenge; set => maxLaenge = value; }
        public string Name { get => name; set => name = value; }
        public decimal PreisProPerson { get => preisProPerson; set => preisProPerson = value; }
        public decimal PreisProTonne { get => preisProTonne; set => preisProTonne = value; }

        public Faehre(decimal decklaenge, string name)
             
        {

            MaxLaenge = decklaenge;

            Name = name;

        }

        public decimal FahrzeugAufnehmen(Fahrzeug fahrzeug)
        {
           
            if (fahrzeug.GetType() == typeof(PKW))
            {
                PKW p = (PKW)fahrzeug;
                erpreis = p.PersonenAnzahl;
            }
            else if (fahrzeug.GetType() == typeof(LKW))
            {
                LKW p = (LKW)fahrzeug;
                erpreis = p.Gesamtgewicht;
            }
            autoDeck.Add(fahrzeug);
            return erpreis;
        }
    }
}
