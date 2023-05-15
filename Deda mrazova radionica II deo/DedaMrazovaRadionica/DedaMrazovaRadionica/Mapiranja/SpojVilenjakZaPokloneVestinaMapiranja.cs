using DedaMrazovaRadionica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Mapiranja
{
    class SpojVilenjakZaPokloneVestinaMapiranja: ClassMap<SpojVilenjakZaPokloneVestina>
    {
        public SpojVilenjakZaPokloneVestinaMapiranja()
        {
            Table("ZA_POKLON_POSEDUJE_VESTINU");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.VilenjakZaPoklone).Column("ID_VILENJAKA_ZA_POKLONE").LazyLoad();//
            References(x => x.MagicnaVestina).Column("ID_VESTINE").LazyLoad();//

        }
    }
}
