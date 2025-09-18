using FluentNHibernate.Mapping;
using MMORPG.Entities;


namespace MMORPG.Mapiranje
{
    public class TimMap : ClassMap<Tim>
    {
        public TimMap()
        {
            Table("tim");

            Id(x => x.Naziv, "naziv").GeneratedBy.Assigned(); // VARCHAR2(10 char)

            Map(x => x.MaxIgraca, "max_igraca");
            Map(x => x.MinIgraca, "min_igraca");
            Map(x => x.BonusPoeni, "bonus_poeni");

            HasMany(x => x.Igraci)
                .KeyColumn("naziv_tima")
                .Inverse()
                .Cascade.All();

            HasMany(x => x.Borbe)
                .KeyColumn("naziv_tima")
                .Inverse()
                .Cascade.All();

            HasManyToMany(x => x.Staze)
                .Table("igrao_tim")
                .ParentKeyColumn("naziv_tima")
                .ChildKeyColumn("naziv_staze")
                .Cascade.All()
                .Inverse(); //staza je vlasnik veze, tim nije odgovoran za insert/update
        }
    }
}
