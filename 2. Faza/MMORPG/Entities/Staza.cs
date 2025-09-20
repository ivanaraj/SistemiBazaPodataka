using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Entities
{
    public class Staza
    {
        public virtual string Naziv { get; set; }
        public virtual bool TipStaze { get; set; }
        public virtual int? BonusPoeni { get; set; }

        public virtual IList<Tim> Timovi { get; set; } // N:M kroz igrao_tim
        public virtual IList<Predmet> KljucniPredmeti { get; set; } // N:M kroz kljucni_za
        public virtual IList<Predmet> Predmeti { get; set; } // N:M kroz nalazi_se_na
        public virtual IList<Rasa> ZahtevaneRase { get; set; } // N:M kroz zahteva_rasa
        public virtual IList<Klasa> ZahtevaneKlase { get; set; } // N:M kroz zahteva_klasa

        public virtual IList<Igrao> Igraci { get; set; } 

        public Staza() {
            Timovi = new List<Tim>(); 
            KljucniPredmeti = new List<Predmet>();
            Predmeti = new List<Predmet>();
            ZahtevaneRase = new List<Rasa>();
            ZahtevaneKlase = new List<Klasa>();
            Igraci = new List<Igrao>();
        }
    }
}
