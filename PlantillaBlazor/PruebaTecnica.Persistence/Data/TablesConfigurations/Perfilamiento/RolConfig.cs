using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PruebaTecnica.Domain.Entities.Perfilamiento;

namespace PruebaTecnica.Persistence.Data.TablesConfigurations.Perfilamiento
{
    public class RolConfig : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            //Data inicial
            builder.HasData(
                Build()
            );
        }

        private List<Rol> Build()
        {
            return new List<Rol>()
            {
                new Rol()
                {
                    Id = 1,
                    Nombre = "Administrador",
                    IsActive = true,
                    IdUsuarioAdiciono = 1,
                    FechaAdicion = new DateTime(2024,5,1)
                },
                new Rol()
                {
                    Id = 100,
                    Nombre = "Default",
                    IsActive = true,
                    IdUsuarioAdiciono = 1,
                    FechaAdicion = new DateTime(2024,9,27)
                },
            };
        }
    }
}
