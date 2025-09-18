using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MMORPG.Entities;

namespace MMORPG.Mapiranje
{

    public class KlasaMap : ClassMap<Klasa>
    {
        public KlasaMap()
        {
            Table("klasa");

            Id(x => x.Naziv, "naziv").GeneratedBy.Assigned(); //VARCHAR2(15 char)

            Map(x => x.NivoBuke, "nivo_buke");
            Map(x => x.MaxNivoZamki, "max_nivo_zamki");
            Map(x => x.Stit, "stit");
            Map(x => x.OruzjeUObeRuke, "oruzje_u_obe_ruke");
            Map(x => x.Religija, "religija");
            Map(x => x.Lecenje, "lecenje");
            Map(x => x.MaxTezinaOklopa, "max_tezina_oklopa");
            Map(x => x.LukSamostrel, "luk_samostrel");

            HasMany(x => x.Likovi)
                .KeyColumn("naziv_klase")
                .Inverse()
                .Cascade.All();

            HasMany(x => x.Pomocnici)
                .KeyColumn("naziv_klase")
                .Inverse()
                .Cascade.All();

            HasMany(x => x.Magije)
                .Table("carobnjak_magije")
                .KeyColumn("id_carobnjaka")
                .Element("magija") 
                .Cascade.All()
                .LazyLoad(); // visevrednosni atribut

            HasMany(x => x.Blagoslovi)
                .Table("svestenik_blagoslov")
                .KeyColumn("id_svestenika")
                .Element("tip_blagoslova") 
                .Cascade.All()
                .LazyLoad(); // visevrednosni atribut

            HasManyToMany(x => x.Staze)
                .Table("zahteva_klasu")
                .ParentKeyColumn("naziv_klase")
                .ChildKeyColumn("naziv_staze")
                .Cascade.All()
                .Inverse(); //klasa nije vlasnik veze

            HasManyToMany(x => x.Opreme)
                .Table("moze_koristiti_klase")
                .ParentKeyColumn("naziv_klase")
                .ChildKeyColumn("id_opreme")
                .Cascade.All()
                .Inverse(); //klasa nije vlasnik veze
        }
    }

}
