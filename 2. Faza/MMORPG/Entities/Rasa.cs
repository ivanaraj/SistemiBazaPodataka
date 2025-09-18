using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Entities
{
    public class Rasa
    {
        public virtual string Naziv { get; set; }
        public virtual string TipOruzja { get; set; }
        public virtual bool? UmesnostUSkrivanju { get; set; }
        public virtual int? NivoEnergije { get; set; }

        public virtual IList<Lik> Likovi { get; set; } // 1:N
        public virtual IList<Pomocnik> Pomocnici { get; set; } // 1:N
        public virtual IList<Predmet> XPPredmeti { get; set; } // n:m kroz moze_iskoristiti
        public virtual IList<Staza> Staze { get; set; } // N:M kroz zahteva_rasa
        public virtual IList<Oprema> Opreme { get; set; } // N:M kroz moze_koristiti_rase

        public Rasa()
        {
            Likovi = new List<Lik>(); // 1:N
            Pomocnici = new List<Pomocnik>(); // 1:N
            XPPredmeti = new List<Predmet>(); // N:M
            Staze = new List<Staza>(); // N:M
            Opreme = new List<Oprema>(); // N:M
        }
    }
}
