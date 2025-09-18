using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Entities
{
    public class Sesija
    {
        public virtual string Id { get; set; }
        public virtual int? XpPoeni { get; set; }
        public virtual int? KolicinaZlata { get; set; }
        public virtual DateTime VremePocetka { get; set; }
        public virtual double VremeTrajanja { get; set; }

        // Relacija ka Igrac
        public virtual Igrac Igrac { get; set; }    //FK
    }
}
