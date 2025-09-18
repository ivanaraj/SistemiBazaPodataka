using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mapiranje
{
    internal class IgracMap : ClassMap<MMORPG.Entities.Igrac>
    {
        public IgracMap() {
            Table("igrac");

            Id(x => x.Id, "id").GeneratedBy.TriggerIdentity(); // Number(6,0)

            Map(x => x.Nadimak, "nadimak");
            Map(x => x.Lozinka, "lozinka");
            Map(x => x.Ime, "ime");
            Map(x => x.Prezime, "prezime");
            Map(x => x.Pol, "pol");
            Map(x => x.Uzrast, "uzrast");

            // Veza ka Tim  N:1
            References(x => x.Tim).Column("naziv_tima").LazyLoad();
            // Veza ka Lik  N:1
            References(x => x.Lik).Column("id_lika").LazyLoad();

            HasMany(x => x.Pomocnici)
                .KeyColumn("id_igraca")
                .Inverse()
                .Cascade.All();

            HasMany(x => x.Sesije)
                .KeyColumn("id_igraca")
                .Inverse()
                .Cascade.All();

            HasMany(x => x.IgraoStaze)
                .KeyColumn("id_igraca")
                .Inverse()
                .Cascade.All();

            HasManyToMany(x => x.KljučniPredmeti)
                .Table("koristi")
                .ParentKeyColumn("id_igraca")
                .ChildKeyColumn("id_kljucnog_predmeta")
                .Cascade.All(); // igrac je vlasnik veze

            HasManyToMany(x => x.Opreme)
                .Table("kupio")
                .ParentKeyColumn("id_igraca")
                .ChildKeyColumn("id_opreme")
                .Cascade.All(); // igrac je vlasnik veze
        }
    }
}
