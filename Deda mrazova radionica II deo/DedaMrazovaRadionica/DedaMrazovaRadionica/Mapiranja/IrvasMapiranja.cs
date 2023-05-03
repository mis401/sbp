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
            Map(x => x.Datum_rodjenja, "DATUM_RODEJNJA");

        }   
    }
}
