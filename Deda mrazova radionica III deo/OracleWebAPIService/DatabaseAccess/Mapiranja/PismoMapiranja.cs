using DatabaseAccess.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Mapiranja
{
    class PismoMapiranja : ClassMap<Pismo>
    {
        public PismoMapiranja() 
        {
            Table("PISMO");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Tekst, "TEKST");
            Map(x => x.IndeksDobrote, "INDEKS_DOBROTE");
            Map(x => x.DatumSlanja).Column("DATUM_SLANJA").CustomType("date");
            Map(x => x.DatumPrijema).Column("DATUM_PRIJEMA").CustomType("date");

            References(x => x.PripadaDetetu).Column("ID_DETETA").LazyLoad();

            HasOne(x => x.ListaZelja).PropertyRef(x => x.PripadaPismu);

        }
    }
}
