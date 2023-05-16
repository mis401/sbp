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

            Map(x => x.RedniBroj, "REDNI_BROJ");
            Map(x => x.Tip, "TIP");
            Map(x => x.Opis, "OPIS");

            References(x => x.IzradjenaUDeluRadionice).Column("ID_DELA_RADIONICE").LazyLoad();
            References(x => x.Vilenjak).Column("ID_VILENJAKA_ZA_IGRACKE").LazyLoad();
            References(x => x.PripadaListiZelja).Column("ID_LISTE_ZELJA").LazyLoad();
            References(x => x.PripadaPoklonu).Column("ID_POKLONA").LazyLoad();

        }
    }
}
