using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Entities
{
    public class Lik
    {
        public virtual int Id { get; set; }
        public virtual int StepenZamora { get; set; }
        public virtual int Iskustvo { get; set; }
        public virtual int KolicinaZlata { get; set; }
        public virtual int NivoZdravstvenogStanja { get; set; }

        public virtual Rasa Rasa { get; set; }   // FK naziv_rase
        public virtual Klasa Klasa { get; set; } // FK naziv_klase
        public virtual Igrac Igrac { get; set; } // FK id_igraca


    }
}
