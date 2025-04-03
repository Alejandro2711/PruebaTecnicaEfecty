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
    internal class PDetalladoConfig : IEntityTypeConfiguration<ParametroDetallado>
    {
        public void Configure(EntityTypeBuilder<ParametroDetallado> builder)
        {
            builder.HasOne(p => p.ParametroGeneral)
                .WithMany(pg => pg.ListaParametrosDetallados)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(p => p.IdParametroGeneral);

            builder.HasData(Build());
        }

        private List<ParametroDetallado> Build()
        {
            return new List<ParametroDetallado>
            {
                new ParametroDetallado()
                {
                    Id = 1,
                    Nombre = "Si",
                    IdUsuarioAdiciono = 1,
                    FechaAdicion = new DateTime(2024,5,1),
                    IdParametroGeneral = 1
                },
                new ParametroDetallado()
                {
                    Id = 2,
                    Nombre = "No",
                    IdUsuarioAdiciono = 1,
                    FechaAdicion = new DateTime(2024,5,1),
                    IdParametroGeneral = 1
                },
                new ParametroDetallado()
                {
                    Id = 3,
                    Nombre = "CC",
                    IdUsuarioAdiciono = 1,
                    FechaAdicion = new DateTime(2025,4,3),
                    IdParametroGeneral = 2
                },
                new ParametroDetallado()
                {
                    Id = 4,
                    Nombre = "Nit",
                    IdUsuarioAdiciono = 1,
                    FechaAdicion = new DateTime(2025,4,3),
                    IdParametroGeneral = 2
                },
                new ParametroDetallado()
                {
                    Id = 5,
                    Nombre = "Ce",
                    IdUsuarioAdiciono = 1,
                    FechaAdicion = new DateTime(2025,4,3),
                    IdParametroGeneral = 2
                },
                new ParametroDetallado()
                {
                    Id = 6,
                    Nombre = "Soltero",
                    IdUsuarioAdiciono = 1,
                    FechaAdicion = new DateTime(2025,4,3),
                    IdParametroGeneral = 3
                },
                new ParametroDetallado()
                {
                    Id = 7,
                    Nombre = "Casado",
                    IdUsuarioAdiciono = 1,
                    FechaAdicion = new DateTime(2025,4,3),
                    IdParametroGeneral = 3
                },
                new ParametroDetallado()
                {
                    Id = 8,
                    Nombre = "Divorciado",
                    IdUsuarioAdiciono = 1,
                    FechaAdicion = new DateTime(2025,4,3),
                    IdParametroGeneral = 3
                }
            };
        }
    }
}
