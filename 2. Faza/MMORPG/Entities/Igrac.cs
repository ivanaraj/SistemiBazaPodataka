using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Entities
{
    public class Igrac
    {
        public virtual int Id { get; protected set; }
        public virtual string Nadimak { get; set; }
        public virtual string Lozinka { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual char Pol { get; set; }
        public virtual int? Uzrast { get; set; }

        public virtual Tim Tim { get; set; }        // FK naziv_tima
        public virtual Lik Lik { get; set; }        // FK id_lika


        public virtual IList<Pomocnik> Pomocnici { get; set; } // 1:N
        public virtual IList<Sesija> Sesije { get; set; }    // 1:N
        public virtual IList<Predmet> KljučniPredmeti { get; set; }  // N:M
        public virtual IList<Oprema> Opreme { get; set; }  // N:M

        public virtual IList<Igrao> IgraoStaze { get; set; }



        public Igrac()
        {
            Pomocnici = new List<Pomocnik>();
            Sesije = new List<Sesija>();
            KljučniPredmeti = new List<Predmet>();
            Opreme = new List<Oprema>();
        }
    }
}
