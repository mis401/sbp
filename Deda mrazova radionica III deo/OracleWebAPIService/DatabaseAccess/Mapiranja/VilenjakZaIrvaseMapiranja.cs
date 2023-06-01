using DatabaseAccess.Entiteti;
using FluentNHibernate.Mapping;
using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Mapiranja
{
    class VilenjakZaIrvaseMapiranja : SubclassMap<VilenjakZaIrvase>
    {
        public VilenjakZaIrvaseMapiranja()
        {
            Table("VILENJAK_ZA_IRVASE");

            Abstract();

            References(x => x.Irvas).Column("ID_IRVASA").LazyLoad();

            HasMany(x=>x.VilenjakZaIrvaseVestinaSpoj).KeyColumn("ID_VILENJAKA_ZA_IRVASE").Cascade.AllDeleteOrphan().Inverse();

            HasMany(x => x.Pesme).KeyColumn("ID_VILENJAKA_ZA_IRVASE").Cascade.AllDeleteOrphan().Inverse();

        }
    }
}
