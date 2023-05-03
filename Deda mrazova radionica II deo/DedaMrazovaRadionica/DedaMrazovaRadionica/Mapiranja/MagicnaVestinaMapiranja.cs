using DedaMrazovaRadionica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Mapiranja
{
    class MagicnaVestinaMapiranja:ClassMap<MagicnaVestina>
    {
        public MagicnaVestinaMapiranja()
        {
            Table("MAGICNA_VESTINA");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv, "NAZIV");
        }
    }
}
