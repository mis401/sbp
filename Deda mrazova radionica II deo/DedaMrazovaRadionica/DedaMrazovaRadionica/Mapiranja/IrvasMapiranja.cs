using DedaMrazovaRadionica.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMrazovaRadionica.Mapiranja
{
    class IrvasMapiranja: ClassMap<Irvas>
    {
        public IrvasMapiranja()
        {
            Table("IRVAS");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime, "IME");
            Map(x => x.Nadimak, "NADIMAK");
            Map(x => x.Pol, "POL");
            Map(x => x.DatumRodjenja, "DATUM_RODJENJA");

            HasMany(x => x.Vilenjaci).KeyColumn("ID_IRVASA").Cascade.All().Inverse();
            HasMany(x=>x.IrvasIsporucujeTovar).KeyColumn("ID_IRVASA").Cascade.All().Inverse();


        }   
    }
}
