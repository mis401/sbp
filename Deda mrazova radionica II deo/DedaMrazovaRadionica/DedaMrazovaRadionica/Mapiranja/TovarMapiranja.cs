﻿using DedaMrazovaRadionica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Mapiranja
{
    class TovarMapiranja : ClassMap<Tovar>
    {
        public TovarMapiranja()
        {
            Table("TOVAR");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Grad, "GRAD");

            HasMany(x => x.Pokloni).KeyColumn("ID_TOVARA").Cascade.All().Inverse();//
            HasMany(x => x.Vilenjaci).KeyColumn("ID_TOVARA").Cascade.All().Inverse();//
            HasMany(x=>x.IrvasIsporucujeTovar).KeyColumn("ID_TOVARA").Cascade.All().Inverse();//
        }
    }
}
