using DatabaseAccess.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Mapiranja
{
    class VilenjakZaIsporukuPoklonaMapiranja:SubclassMap<VilenjakZaIsporukuPoklona>
    {
        public VilenjakZaIsporukuPoklonaMapiranja()
        {
            Table("VILENJAK_ZA_ISPORUKU_POKLONA");

            Abstract();

            References(x => x.Tovar).Column("ID_TOVARA").LazyLoad();

            HasMany(x => x.VilenjakZaIsporukuVestinaSpoj).KeyColumn("ID_VILENJAKA_ZA_TOVAR").Cascade.AllDeleteOrphan();


        }
    }
}
