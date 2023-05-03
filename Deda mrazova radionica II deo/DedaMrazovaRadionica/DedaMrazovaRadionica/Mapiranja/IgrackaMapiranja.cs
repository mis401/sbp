using DedaMrazovaRadionica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Mapiranja
{
    class IgrackaMapiranja :ClassMap<Igracka>
    {
        public IgrackaMapiranja()
        {
            Table("IGRACKA");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Redni_broj, "REDNI_BROJ");
            Map(x => x.Tip, "TIP");
            Map(x => x.Opis, "OPIS");
        }
    }
}
