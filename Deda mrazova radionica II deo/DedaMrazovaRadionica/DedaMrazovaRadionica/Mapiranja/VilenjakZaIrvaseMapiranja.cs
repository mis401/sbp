using DedaMrazovaRadionica.Entiteti;
using FluentNHibernate.Mapping;
using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Mapiranja
{
    class VilenjakZaIrvaseMapiranja : SubclassMap<VilenjakZaIrvase>
    {
        public VilenjakZaIrvaseMapiranja()
        {
            Table("VILENJAK_ZA_IRVASE");

            Abstract();

            References(x => x.Irvas).Column("ID_IRVASA").LazyLoad();

            HasManyToMany(x => x.MagicneVestine)
                .Table("ZA_IRVASE_POSEDUJE_VESTINU")
                .ParentKeyColumn("ID_VILENJAKA_ZA_IRVASE")
                .ChildKeyColumn("ID_VESTINE").Cascade.All().Inverse();

        }
    }
}
