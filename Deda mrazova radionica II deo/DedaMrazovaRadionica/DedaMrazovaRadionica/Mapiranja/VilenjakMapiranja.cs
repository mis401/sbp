using DedaMrazovaRadionica.Entiteti;
using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Mapiranja
{
    class VilenjakMapiranja : ClassMap<Vilenjak>
    {
        public VilenjakMapiranja()
        {
            Table("VILENJAK");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime, "IME");
            Map(x => x.ZemljaPorekla, "ZEMLJA_POREKLA");
            Map(x => x.DatumZaposlenja, "DATUM_ZAPOSLJAVANJA");
            Map(x => x.VrstaVilenjaka, "VRSTA_VILENJAKA");
            Map(x => x.TipMaterijala, "TIP_MATERIJALA");
            Map(x => x.FlagKoordinator, "FLAG_KOORDINATOR");
            Map(x => x.FlagSef, "FLAG_SEF");
            Map(x => x.DatumPostavljanja, "DATUM_POSTAVLJANJA");
            Map(x => x.Ocena, "OCENA");
            Map(x => x.DuzinaObuke, "DUZINA_OBUKE");

        }
    }
}
