using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mapiranje
{

    public class BorbaMap : ClassMap<Borba>
    {
        public BorbaMap()
        {
            Table("borba");

            Id(x => x.Id, "id").GeneratedBy.TriggerIdentity(); // Number(10, 0)

            Map(x => x.VremeBorbe, "vreme_borbe");
            Map(x => x.Pobednik, "pobednik");
            Map(x => x.BonusPoeni, "bonus_poeni");

            HasMany(x => x.Timovi)
                .KeyColumn("id_borbe")
                .Inverse()
                .Cascade.All();
        }
    }

}



