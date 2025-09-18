using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mapiranje
{
    public class UcestvovaoUMap : ClassMap<UcestvovaoU>
    {
        public UcestvovaoUMap()
        {
            Table("ucestvovao_u");

            Id(x => x.Id, "id").GeneratedBy.TriggerIdentity(); // number(6,0)


            Map(x => x.Plasman, "plasman");


            References(x => x.Tim, "naziv_tima").LazyLoad(); // FK naziv_tima
            References(x => x.Borba, "id_borbe").LazyLoad(); // FK id_borbe
        }
    }
}
