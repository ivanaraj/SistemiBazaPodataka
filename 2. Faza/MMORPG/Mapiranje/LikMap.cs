using FluentNHibernate.Mapping;
using MMORPG.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPG.Mapiranje
{
    public class LikMap : ClassMap<Lik>
    {
        public LikMap()
        {
            Table("lik");

            Id(x => x.Id, "id").GeneratedBy.TriggerIdentity(); // number(6,0)

            Map(x => x.StepenZamora, "stepen_zamora");
            Map(x => x.Iskustvo, "iskustvo");
            Map(x => x.KolicinaZlata, "kolicina_zlata");
            Map(x => x.NivoZdravstvenogStanja, "nivo_zdravstvenog_stanja");

            // Veza ka Rasa  N:1
            References(x => x.Rasa, "naziv_rase").LazyLoad();
            // Veza ka Klasa  N:1
            References(x => x.Klasa, "naziv_klase").LazyLoad();
            // Veza ka Igrac  N:1
            References(x => x.Igrac, "id_igraca").LazyLoad();
        
        }
    }
}
