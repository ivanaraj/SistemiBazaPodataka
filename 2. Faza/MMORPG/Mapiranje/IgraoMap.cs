using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMORPG.Entities;

namespace MMORPG.Mapiranje
{
    public class IgraoMap : ClassMap<Igrao>
    {
        public IgraoMap()
        {
            Table("igrao");

            Id(x => x.Id, "id").GeneratedBy.TriggerIdentity();

            Map(x => x.BrojIgranja, "broj_igranja");
            Map(x => x.BrojSavladanihNeprijatelja, "broj_savladanih_neprijatelja");

            References(x => x.Igrac, "id_igraca").LazyLoad();
            References(x => x.Staza, "naziv_staze").LazyLoad();
        }
    }
}
