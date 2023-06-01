using DatabaseAccess.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Mapiranja
{
    class IrvasIsporucujeTovarMapiranja :ClassMap<IrvasIsporucujeTovar>
    {
        public IrvasIsporucujeTovarMapiranja() 
        {
            Table("IRVAS_ISPORUCUJE_TOVAR");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.Irvas).Column("ID_IRVASA").LazyLoad();
            References(x => x.Tovar).Column("ID_TOVARA").LazyLoad();
        }
    }
}
