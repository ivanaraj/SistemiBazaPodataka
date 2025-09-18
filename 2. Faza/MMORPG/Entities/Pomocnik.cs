using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Entities
{
    public class Pomocnik
    {
        public virtual int Id { get; protected set; }
        public virtual Igrac Igrac { get; set; } //FK id_igraca
        public virtual string Ime { get; set; }
        public virtual int BonusZastite { get; set; }
        public virtual Rasa NazivRase { get; set; } //FK naziv_rase
        public virtual Klasa NazivKlase { get; set; }   //FK naziv_klase

    }
}
