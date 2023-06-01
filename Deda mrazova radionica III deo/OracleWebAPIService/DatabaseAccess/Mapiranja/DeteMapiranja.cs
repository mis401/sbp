using DatabaseAccess.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Mapiranja
{
    class DeteMapiranja : ClassMap<Dete>
    {
        public DeteMapiranja()
        {
            Table("DETE");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Drzava, "DRZAVA");
            Map(x => x.Grad, "GRAD");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.DatumRodjenja, "DATUM_RODJENJA");
            
            HasMany(x => x.Pisma).KeyColumn("ID_DETETA").Cascade.All().Inverse();
            HasMany(x=>x.Roditelji).KeyColumn("ID_DETETA").Cascade.All().Inverse();
        }
    }
}
