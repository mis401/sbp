using DedaMrazovaRadionica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Mapiranja
{
    class SpojVilenjakZaIrvaseVestinaMapiranja:ClassMap<SpojVilenjakZaIrvaseVestina>
    {
        public SpojVilenjakZaIrvaseVestinaMapiranja()
        {
            Table("ZA_IGRACKE_POSEDUJE_VESTINU");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.VilenjakZaIrvase).Column("ID_VILENJAKA_ZA_IRVASE").LazyLoad();//
            References(x => x.MagicnaVestina).Column("ID_VESTINE").LazyLoad();//

        }
    }
}
