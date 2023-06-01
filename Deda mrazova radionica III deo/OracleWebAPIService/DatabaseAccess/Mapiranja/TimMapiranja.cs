using DatabaseAccess.Entiteti;
using FluentNHibernate.Mapping;
using NHibernate.Cfg.XmlHbmBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Mapiranja
{
    class TimMapiranja : ClassMap<Tim>
    {
        public TimMapiranja()
        {
            Table("TIM");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv, "NAZIV");

            HasMany(x => x.Vilejnaci).KeyColumn("ID_TIMA").Cascade.All().Inverse();

        
        }

    }
}