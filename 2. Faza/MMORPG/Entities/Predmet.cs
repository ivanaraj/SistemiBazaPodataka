using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Entities
{
    public class Predmet
    {
        public virtual string Id { get; set; }
        public virtual string Opis { get; set; }
        public virtual string Naziv { get; set; }
        public virtual int XpBonus { get; set; }

        public virtual IList<Staza> StazeKljucniPredmet { get; set; } // N:M kroz kljucni_za
        public virtual IList<Staza> StazePredmet { get; set; } // N:M kroz nalazi_se_na
        public virtual IList<Igrac> IgraciKoriste { get; set; } // N:M kroz koristi
        public virtual IList<Rasa> RaseMoguIskoristiti { get; set; } // N:M kroz moze_iskoristiti


        public Predmet() { 
           StazeKljucniPredmet = new List<Staza>();
           StazePredmet = new List<Staza>();
           IgraciKoriste = new List<Igrac>();
           RaseMoguIskoristiti = new List<Rasa>();
        }
    }
}
