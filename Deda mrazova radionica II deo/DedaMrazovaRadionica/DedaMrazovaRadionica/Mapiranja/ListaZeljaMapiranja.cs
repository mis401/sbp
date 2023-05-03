using DedaMrazovaRadionica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Mapiranja
{
    class ListaZeljaMapiranja : ClassMap<ListaZelja>
    {
        public ListaZeljaMapiranja()
        {
            Table("LISTA_ZELJA");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

        }
    }
}
