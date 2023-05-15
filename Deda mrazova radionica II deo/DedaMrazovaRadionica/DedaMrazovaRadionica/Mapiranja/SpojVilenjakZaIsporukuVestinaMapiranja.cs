using DedaMrazovaRadionica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Mapiranja
{
    class SpojVilenjakZaIsporukuVestinaMapiranja : ClassMap<SpojVilenjakZaIsporukuVestina>
    {
        public SpojVilenjakZaIsporukuVestinaMapiranja()
        {
            Table("ZA_ISPORUKU_POSEDUJE_VESTINU");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.VilenjakZaIsporukuPoklona).Column("ID_VILENJAKA_ZA_TOVAR").LazyLoad();//
            References(x => x.MagicnaVestina).Column("ID_VESTINE").LazyLoad();//
        }
    }
}
