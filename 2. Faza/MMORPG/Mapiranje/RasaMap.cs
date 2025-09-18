using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mapiranje
{

    public class RasaMap : ClassMap<Rasa>
    {
        public RasaMap()
        {
            Table("rasa");

            Id(x => x.Naziv, "naziv").GeneratedBy.Assigned(); // VARCHAR2(15 char)

            Map(x => x.TipOruzja, "tip_oruzja");
            Map(x => x.UmesnostUSkrivanju, "umesnost_u_skrivanju");
            Map(x => x.NivoEnergije, "nivo_energije");

            HasMany(x => x.Likovi)
                .KeyColumn("naziv_rase")
                .Inverse()
                .Cascade.All();

            HasMany(x => x.Pomocnici)
                .KeyColumn("naziv_rase")
                .Inverse()
                .Cascade.All();

            HasManyToMany(x => x.XPPredmeti)
                .Table("moze_iskoristiti")
                .ParentKeyColumn("naziv_rase")
                .ChildKeyColumn("id_predmeta")
                .Cascade.All()
                .Inverse(); //rasa nije vlasnik veze

            HasManyToMany(x => x.Staze)
                .Table("zahteva_rasu")
                .ParentKeyColumn("naziv_rase")
                .ChildKeyColumn("naziv_staze")
                .Cascade.All()
                .Inverse(); //rasa nije vlasnik veze

            HasManyToMany(x => x.Opreme)
                .Table("moze_koristiti_rase")
                .ParentKeyColumn("naziv_rase")
                .ChildKeyColumn("id_opreme")
                .Cascade.All()
                .Inverse(); //rasa nije vlasnik veze
        }
    }

}
