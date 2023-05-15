using DedaMrazovaRadionica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Mapiranja
{
    class VilenjakZaPokloneMapiranja:SubclassMap<VilenjakZaPoklone>
    {
        public VilenjakZaPokloneMapiranja()
        {
            Table("VILENJAK_ZA_POKLON");

            Abstract();

            HasManyToMany(x => x.MagicneVestine)
               .Table("ZA_POKLON_POSEDUJE_VESTINU")
               .ParentKeyColumn("ID_VILENJAKA_ZA_POKLONE")
               .ChildKeyColumn("ID_VESTINE").Cascade.All().Inverse();

            HasManyToMany(x => x.Pokloni)
              .Table("PAKOVANJE_POKLONA")
              .ParentKeyColumn("ID_VILENJAKA_ZA_POKLONE")
              .ChildKeyColumn("ID_POKLONA").Cascade.All().Inverse();
        }
    }
}
