using DatabaseAccess.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Mapiranja
{
    class ListaZeljaMapiranja : ClassMap<ListaZelja>
    {
        public ListaZeljaMapiranja()
        {
            Table("LISTA_ZELJA");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            HasOne(x => x.Poklon).PropertyRef(x => x.ZaListuZelja);

            References(x => x.PripadaPismu, "ID_PISMA");

            HasMany(x => x.ZeljeneIgracke).KeyColumn("ID_LISTE_ZELJA").Cascade.All().Inverse();

        }
    }
}
