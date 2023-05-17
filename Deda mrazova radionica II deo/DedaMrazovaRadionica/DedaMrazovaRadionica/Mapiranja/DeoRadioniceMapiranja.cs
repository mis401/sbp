using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Entiteti
{
    class DeoRadioniceMapiranja : ClassMap<DeoRadionice>
    {
        public DeoRadioniceMapiranja()
        {
            Table("DEO_RADIONICE");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.TipIgracke, "TIP_IGRACKE");

            HasMany(x => x.IgrackeIstogTipa).KeyColumn("ID_DELA_RADIONICE").Cascade.All().Inverse();
            HasMany(x => x.ZahtevaVestinu).KeyColumn("ID_DELA_RADIONICE").Cascade.All().Inverse();
            HasMany(x => x.VilenjaciZaIzraduIgracaka).KeyColumn("ID_DELA_RADIONICE").Cascade.All().Inverse();

      

        }

    }
}
