using DatabaseAccess.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Mapiranja
{
    class DeteRoditeljMapiranja : ClassMap<DeteRoditelj>
    {
        public DeteRoditeljMapiranja() 
        {
            Table("DETE_RODITELJ");
            
            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Roditelj, "IME_RODITELJA");

            References(x => x.Dete).Column("ID_DETETA").LazyLoad();
        }

    }
}
