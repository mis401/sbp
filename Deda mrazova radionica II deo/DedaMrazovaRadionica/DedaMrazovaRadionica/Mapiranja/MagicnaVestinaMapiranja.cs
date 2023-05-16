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

            HasMany(x => x.VilenjakZaIrvaseVestinaSpoj).KeyColumn("ID_VESTINE").Cascade.All().Inverse();
            HasMany(x => x.VilenjakZaIsporukuVestinaSpoj).KeyColumn("ID_VESTINE").Cascade.All().Inverse();
            HasMany(x => x.VilenjakZaIgrackeVestinaSpoj).KeyColumn("ID_VESTINE").Cascade.All().Inverse();
            HasMany(x => x.VilenjakZaPokloneVestinaSpoj).KeyColumn("ID_VESTINE").Cascade.All().Inverse();
        }
    }
}
