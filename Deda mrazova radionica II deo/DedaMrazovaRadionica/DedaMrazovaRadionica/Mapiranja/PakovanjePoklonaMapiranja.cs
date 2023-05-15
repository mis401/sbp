using DedaMrazovaRadionica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Mapiranja
{
    class PakovanjePoklonaMapiranja:ClassMap<PakovanjePoklona>
    {
        public PakovanjePoklonaMapiranja()
        {
            Table("PAKOVANJE_POKLONA");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.VilenjakZaPoklone).Column("ID_VILENJAKA_ZA_POKLONE").LazyLoad();//
            References(x => x.Poklon).Column("ID_POKLONA").LazyLoad();//
        
        }
    }
}
