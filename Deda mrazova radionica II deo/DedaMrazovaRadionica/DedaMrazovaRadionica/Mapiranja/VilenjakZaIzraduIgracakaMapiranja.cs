using DedaMrazovaRadionica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Mapiranja
{
    class VilenjakZaIzraduIgracakaMapiranja : SubclassMap<VilenjakZaIzraduIgracaka>
    {
        public VilenjakZaIzraduIgracakaMapiranja()
        {
            Table("VILENJAK_ZA_IZRADU_IGRACAKA");

            Abstract();

            Map(x => x.TipMaterijala, "TIP_MATERIJALA");
            Map(x => x.FlagKoordinator, "FLAG_KOORDINATOR");
            Map(x => x.FlagSef, "FLAG_SEF");
            Map(x => x.DatumPostavljanja, "DATUM_POSTAVLJANJA");
            Map(x => x.Ocena, "OCENA");
            Map(x => x.DuzinaObuke, "DUZINA_OBUKE");

            
            HasMany(x => x.JeMentor).KeyColumn("ID_MENTORA").Cascade.All().Inverse();
            HasMany(x => x.VilenjakZaIgrackeVestinaSpoj).KeyColumn("ID_VILENJAKA_ZA_IGRACKE").Cascade.All().Inverse();

            References(x => x.DeoRadionice).Column("ID_DELA_RADIONICE").LazyLoad();
            References(x => x.ImaMentora).Column("ID_MENTORA").LazyLoad();
            References(x => x.PripadaTimu).Column("ID_TIMA").LazyLoad();// za one to many, da li treba odvojeno?

         

            



        }

    }
}
