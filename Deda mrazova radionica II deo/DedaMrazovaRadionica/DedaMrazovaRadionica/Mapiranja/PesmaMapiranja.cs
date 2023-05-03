using DedaMrazovaRadionica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Mapiranja
{
    class PesmaMapiranja : ClassMap<Pesma>
    {
        public PesmaMapiranja() 
        {
            Table("PESMA");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Tekst, "TEKST");
        }

    }
}
