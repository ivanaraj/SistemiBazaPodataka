using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Entities
{
    public class UcestvovaoU
    {
        public virtual int Id { get; protected set; }
        public virtual int Plasman { get; set; }

        public virtual Tim Tim { get; set; } // FK naziv_tima
        public virtual Borba Borba { get; set; } // FK id_borbe
    }
}
