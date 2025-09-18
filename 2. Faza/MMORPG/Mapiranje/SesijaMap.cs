using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mapiranje
{
    internal class SesijaMap : ClassMap<Sesija>
    {
        public SesijaMap()
        {
            Table("sesija");

            Id(x => x.Id, "id").GeneratedBy.TriggerIdentity(); // number(6,0)

            Map(x => x.XpPoeni, "xp_poeni");
            Map(x => x.KolicinaZlata, "kolicina_zlata");
            Map(x => x.VremePocetka, "vreme_pocetka");
            Map(x => x.VremeTrajanja, "vreme_trajanja");

            // Veza ka Igrac  N:1
            References(x => x.Igrac, "id_igraca").LazyLoad();
        }
    }
}
