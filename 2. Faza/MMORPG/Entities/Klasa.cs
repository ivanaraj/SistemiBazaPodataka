using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Entities
{
    public class Klasa
    {
        public virtual string Naziv { get; set; }
        public virtual int? NivoBuke { get; set; }
        public virtual int? MaxNivoZamki { get; set; }
        public virtual bool? Stit { get; set; }
        public virtual bool? OruzjeUObeRuke { get; set; }
        public virtual string Religija { get; set; }
        public virtual bool? Lecenje { get; set; }
        public virtual int? MaxTezinaOklopa { get; set; }
        public virtual bool? LukSamostrel { get; set; }

        public virtual IList<Lik> Likovi { get; set; } // 1:N
        public virtual IList<Pomocnik> Pomocnici { get; set; } // 1:N
        public virtual IList<Staza> Staze { get; set; } // N:M kroz zahteva_klasu
        public virtual IList<Oprema> Opreme { get; set; } // N:M kroz moze_koristiti_klase
        public virtual IList<string> Magije { get; set; } // visevrednosni atirbut carobnjak_magije
        public virtual IList<string> Blagoslovi { get; set; } // visevrednosni atribut sveštenik_blagoslovi

        public Klasa()
        {
            Likovi = new List<Lik>(); // 1:N
            Pomocnici = new List<Pomocnik>(); // 1:N
            Staze = new List<Staza>(); // N:M
            Opreme = new List<Oprema>(); // N:M
            Magije = new List<string>(); // visevrednosni atribut
            Blagoslovi = new List<string>(); // visevrednosni atribut
        }
    }
}
