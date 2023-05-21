using DedaMrazovaRadionica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Mapiranja
{
    class VilenjakZaPokloneMapiranja:SubclassMap<VilenjakZaPoklone>
    {
        public VilenjakZaPokloneMapiranja()
        {
            Table("VILENJAK_ZA_POKLON");

            Abstract();

            HasMany(x => x.PakovanjePoklona).KeyColumn("ID_VILENJAKA_ZA_POKLONE").Cascade.All().Inverse();
            HasMany(x => x.VilenjakZaPokloneVestinaSpoj).KeyColumn("ID_VILENJAKA_ZA_POKLONE").Cascade.AllDeleteOrphan().Inverse();
        }
    }
}
