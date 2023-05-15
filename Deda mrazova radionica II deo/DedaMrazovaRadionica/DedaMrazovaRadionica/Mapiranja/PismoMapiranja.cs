using DedaMrazovaRadionica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Mapiranja
{
    class PismoMapiranja : ClassMap<Pismo>
    {
        public PismoMapiranja() 
        {
            Table("PISMO");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Tekst, "TEKST");
            Map(x => x.IndeksDobrote, "INDEKS_DOBROTE");

            References(x => x.PripadaDetetu).Column("ID_DETETA").LazyLoad();

            HasOne(x => x.ListaZelja).PropertyRef(x => x.PripadaPismu);

        }
    }
}
