using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mapiranje
{

    public class PredmetMap : ClassMap<Predmet>
    {
        public PredmetMap()
        {
            Table("predmet");

            Id(x => x.Id, "id").GeneratedBy.TriggerIdentity(); // Number(6,0)

            Map(x => x.Opis, "opis");
            Map(x => x.Naziv, "naziv");
            Map(x => x.XpBonus, "xp_bonus");

            HasManyToMany(x => x.StazeKljucniPredmet)
                .Table("kljucni_za")
                .ParentKeyColumn("id_kljucnog_predmeta")
                .ChildKeyColumn("naziv_staze")
                .Cascade.All()
                .Inverse(); //predmet nije vlasnik veze
                 
            HasManyToMany(x => x.StazePredmet)
                .Table("nalazi_se_na")
                .ParentKeyColumn("id_predmeta")
                .ChildKeyColumn("naziv_staze")
                .Cascade.All()
                .Inverse(); //predmet nije vlasnik veze

            HasManyToMany(x => x.IgraciKoriste)
                .Table("koristi")
                .ParentKeyColumn("id_kljucnog_predmeta")
                .ChildKeyColumn("id_igraca")
                .Cascade.All()
                .Inverse(); //predmet nije vlasnik veze

            HasManyToMany(x => x.RaseMoguIskoristiti)
                .Table("moze_iskoristiti")
                .ParentKeyColumn("id_predmeta")
                .ChildKeyColumn("naziv_rase")
                .Cascade.All(); // predmet je vlasnik veze


        }
    }

}