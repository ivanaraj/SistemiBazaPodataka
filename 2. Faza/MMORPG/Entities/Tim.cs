using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Entities
{
    public class Tim
    {
        public virtual string Naziv { get; set; }
        public virtual int MaxIgraca { get; set; }
        public virtual int MinIgraca { get; set; }
        public virtual int? BonusPoeni { get; set; }

        // Opcionalno: kolekcija igraca ako želiš bidirekcionu vezu
        public virtual IList<Igrac> Igraci { get; set; } // 1:N
        public virtual IList<Staza> Staze { get; set; } // N:M kroz igrao_tim

        public virtual IList<UcestvovaoU> Borbe { get; set; } 

        public Tim()
        {
            Igraci = new List<Igrac>();
            Staze = new List<Staza>(); 
            Borbe = new List<UcestvovaoU>();
        }
    }
}
