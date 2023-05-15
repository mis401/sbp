using DedaMrazovaRadionica.Entiteti;
using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Mapiranja
{
    class VilenjakMapiranja : ClassMap<Vilenjak>
    {
        public VilenjakMapiranja()
        {

            UseUnionSubclassForInheritanceMapping();

            Id(x => x.ID).GeneratedBy.TriggerIdentity();

            Map(x => x.JedinstvenoIme, "IME");
            Map(x => x.ZemljaPorekla, "ZEMLJA_POREKLA");
            Map(x => x.DatumZaposlenja, "DATUM_ZAPOSLJAVANJA");
        }

    }
}
