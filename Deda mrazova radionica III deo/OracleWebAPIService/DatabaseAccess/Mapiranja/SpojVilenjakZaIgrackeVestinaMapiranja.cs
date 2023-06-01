using DatabaseAccess.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Mapiranja
{
    class SpojVilenjakZaIgrackeVestinaMapiranja : ClassMap<SpojVilenjakZaIgrackeVestina>
    {
        public SpojVilenjakZaIgrackeVestinaMapiranja()
        {
            Table("ZA_IGRACKE_POSEDUJE_VESTINU");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.VilenjakZaIzraduIgracaka).Column("ID_VILENJAKA_ZA_IGRACKE").LazyLoad();
            References(x => x.MagicnaVestina).Column("ID_VESTINE").LazyLoad();
        }
    }
}
