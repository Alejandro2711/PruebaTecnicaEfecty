using PruebaTecnica.Domain.Entities.Parametrizacion;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Persistence.Data.TablesConfigurations.Parametrizacion
{
    public class PGeneralConfig : IEntityTypeConfiguration<ParametroGeneral>
    {
        public void Configure(EntityTypeBuilder<ParametroGeneral> builder)
        {
            builder.HasData(Build());
        }

        private List<ParametroGeneral> Build()
        {
            return new List<ParametroGeneral>()
            {
                new ParametroGeneral()
                {
                    Id = 1,
                    Nombre = "SiNo",
                    FechaAdicion = new DateTime(2024,5,1),
                    IdUsuarioAdiciono = 1
                },
                new ParametroGeneral()
                {
                    Id = 2,
                    Nombre = "Tipo Doucmento",
                    FechaAdicion = new DateTime(2025,4,3),
                    IdUsuarioAdiciono = 1
                },
                new ParametroGeneral()
                {
                    Id = 3,
                    Nombre = "Estado Civil",
                    FechaAdicion = new DateTime(2025,4,3),
                    IdUsuarioAdiciono = 1
                }
            };
        }
    }
}
