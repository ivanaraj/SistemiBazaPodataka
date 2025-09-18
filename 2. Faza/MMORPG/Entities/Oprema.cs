using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Entities
{
    public class Oprema
    {
        public virtual int Id { get; set; }
        public virtual string Opis { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string TipOpreme { get; set; }
        public virtual int Napad { get; set; }
        public virtual int Odbrana { get; set; }
        public virtual int XpBonus { get; set; }

       
        public virtual IList<Igrac> Igraci { get; set; } // N:M
        public virtual IList<Rasa> Rase { get; set; } // N:M kroz moze_koristiti_rase
        public virtual IList<Klasa> Klase { get; set; } // N:M kroz moze_koristiti_klase

        public Oprema()
        {
            Igraci = new List<Igrac>();
            Rase = new List<Rasa>();
            Klase = new List<Klasa>();
        }
    }
}
