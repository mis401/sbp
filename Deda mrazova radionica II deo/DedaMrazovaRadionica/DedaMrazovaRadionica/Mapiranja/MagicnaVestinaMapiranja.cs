using DedaMrazovaRadionica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Mapiranja
{
    class MagicnaVestinaMapiranja:ClassMap<MagicnaVestina>
    {
        public MagicnaVestinaMapiranja()
        {
            Table("MAGICNA_VESTINA");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv, "NAZIV");

            References(x => x.PotrebnaDeluRadionice).Column("ID_DELA_RADIONICE").LazyLoad();

            HasManyToMany(x => x.VilenjaciZaIrvase)
                .Table("ZA_IRVASE_POSEDUJE_VESTINU")
                .ParentKeyColumn("ID_VESTINE")
                .ChildKeyColumn("ID_VILENJAKA_ZA_IRVASE");

            HasManyToMany(x => x.VilenjaciZaIsporukuPoklona)
                .Table("ZA_ISPORUKU_POSEDUJE_VESTINU")
                .ParentKeyColumn("ID_VESTINE")
                .ChildKeyColumn("ID_VILENJAKA_ZA_TOVAR");

            HasManyToMany(x => x.VilenjaciZaIzraduIgracaka)
                .Table("ZA_IGRACKE_POSEDUJE_VESTINU")
                .ParentKeyColumn("ID_VESTINE")
                .ChildKeyColumn("ID_VILENJAKA_ZA_IGRACKE");

            HasManyToMany(x => x.VilenjaciZaPoklone)
                .Table("ZA_POKLON_POSEDUJE_VESTINU")
                .ParentKeyColumn("ID_VESTINE")
                .ChildKeyColumn("ID_VILENJAKA_ZA_POKLONE");
        }
    }
}
