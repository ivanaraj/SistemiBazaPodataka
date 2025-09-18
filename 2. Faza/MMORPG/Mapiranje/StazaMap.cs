using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mapiranje
{

    public class StazaMap : ClassMap<Staza>
    {
        public StazaMap()
        {
            Table("staza");

            Id(x => x.Naziv, "naziv").GeneratedBy.Assigned(); // VARCHAR2(10 char)

            Map(x => x.TipStaze, "tip_staze");
            Map(x => x.BonusPoeni, "bonus_poeni");


            HasMany(x=>x.Igraci)
                .KeyColumn("naziv_staze")
                .Inverse()
                .Cascade.All(); 

            HasManyToMany(x => x.Timovi)
                .Table("igrao_tim")
                .ParentKeyColumn("naziv_staze")
                .ChildKeyColumn("naziv_tima")
                .Cascade.All(); //staza je vlasnik veze

            HasManyToMany(x => x.KljucniPredmeti)
                .Table("kljucni_za")
                .ParentKeyColumn("naziv_staze")
                .ChildKeyColumn("id_kljucnog_predmeta")
                .Cascade.All(); //staza je vlasnik veze

            HasManyToMany(x => x.Predmeti)
                .Table("nalazi_se_na")
                .ParentKeyColumn("naziv_staze")
                .ChildKeyColumn("id_predmeta")
                .Cascade.All(); //staza je vlasnik veze

            HasManyToMany(x => x.ZahtevaneRase)
                .Table("zahteva_rasu")
                .ParentKeyColumn("naziv_staze")
                .ChildKeyColumn("naziv_rase")
                .Cascade.All(); //staza je vlasnik veze

            HasManyToMany(x => x.ZahtevaneKlase)
                .Table("zahteva_klasu")
                .ParentKeyColumn("naziv_staze")
                .ChildKeyColumn("naziv_klase")
                .Cascade.All(); //staza je vlasnik veze
        }
    }

}

