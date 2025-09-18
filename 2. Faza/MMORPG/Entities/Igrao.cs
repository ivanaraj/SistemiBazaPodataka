using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Entities
{
    public class Igrao
    {
        public virtual int Id { get; protected set; }
        public virtual int? BrojIgranja { get; set; }
        public virtual int? BrojSavladanihNeprijatelja { get; set; }


        public virtual Igrac Igrac { get; set; } // FK id_igraca
        public virtual Staza Staza { get; set; } // FK naziv_staze
    }
}
