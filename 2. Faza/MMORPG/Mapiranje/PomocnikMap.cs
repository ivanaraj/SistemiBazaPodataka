using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mapiranje
{
    public class PomocnikMap : ClassMap<Pomocnik>
    {
        public PomocnikMap()
        {
            Table("pomocnik");

            Id(x => x.Id, "id").GeneratedBy.TriggerIdentity(); // Number(6,0)

            Map(x => x.Ime, "ime");
            Map(x => x.BonusZastite, "bonus_zastite");

            // Veza ka Igrac N:1
            References(x => x.Igrac).Column("id_igraca").LazyLoad();
            // veza ka Rasa N:1
            References(x => x.NazivRase).Column("naziv_rase").LazyLoad();
            // Veza ka Klasa N:1
            References(x => x.NazivKlase).Column("naziv_klase").LazyLoad();
        }
    }


}
