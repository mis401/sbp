using DedaMrazovaRadionica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Mapiranja
{
    class DeteRoditeljMapiranja : ClassMap<DeteRoditelj>
    {
        public DeteRoditeljMapiranja() 
        {
            Table("DETE_RODITELJ");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.Dete).Column("ID_DETETA").LazyLoad();
        }

    }
}
