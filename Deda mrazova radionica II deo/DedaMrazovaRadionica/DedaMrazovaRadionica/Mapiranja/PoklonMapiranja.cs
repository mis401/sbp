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
    class PoklonMapiranja: ClassMap<Poklon>
    {
        public PoklonMapiranja()
        {
            Table("POKLON");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Boja, "BOJA");
            Map(x => x.Posveta, "POSVETA");

            References(x => x.PripadaTovaru).Column("ID_TOVARA").LazyLoad();//

            HasMany(x => x.PakovanjePoklona).KeyColumn("ID_POKLONA").Cascade.All().Inverse();//
            HasMany(x => x.IgrackeZaPoklon).KeyColumn("ID_POKLONA").Cascade.All().Inverse();//

            References(x => x.ZaListuZelja, "ID_LISTE_ZELJA");//
        }
    }
}
