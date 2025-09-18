using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mapiranje
{

    public class OpremaMap : ClassMap<Oprema>
    {
        public OpremaMap()
        {
            Table("oprema");

            Id(x => x.Id, "id").GeneratedBy.TriggerIdentity(); // Number(6,0)

            Map(x => x.Opis, "opis");
            Map(x => x.Naziv, "naziv");
            Map(x => x.TipOpreme, "tip_opreme");
            Map(x => x.Napad, "napad");
            Map(x => x.Odbrana, "odbrana");
            Map(x => x.XpBonus, "xp_bonus");

            HasManyToMany(x => x.Igraci)
                .Table("kupio")
                .ParentKeyColumn("id_opreme")
                .ChildKeyColumn("id_igraca")
                .Cascade.All()
                .Inverse(); // oprema nije vlasnik veze

            HasManyToMany(x => x.Rase)
                .Table("moze_koristiti_rase")
                .ParentKeyColumn("id_opreme")
                .ChildKeyColumn("naziv_rase")
                .Cascade.All(); // oprema je vlasnik veze

            HasManyToMany(x => x.Klase)
                .Table("moze_koristiti_klase")
                .ParentKeyColumn("id_opreme")
                .ChildKeyColumn("naziv_klase")
                .Cascade.All(); // oprema je vlasnik veze
        }
    }

}

