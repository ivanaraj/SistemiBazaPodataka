using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Entities
{
    public class Borba
    {
        public virtual string Id { get; set; }
        public virtual DateTime VremeBorbe { get; set; }
        public virtual string Pobednik { get; set; }
        public virtual int? BonusPoeni { get; set; }

        public virtual IList<UcestvovaoU> Timovi { get; set; } 

        public Borba() {
          Timovi = new List<UcestvovaoU>();
        }
    }
}
