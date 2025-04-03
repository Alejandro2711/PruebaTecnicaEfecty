using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PruebaTecnica.Domain.Entities.Parametrizacion;

namespace PruebaTecnica.Persistence.Data.TablesConfigurations.Parametrizacion
{
    public class CiudadConfig : IEntityTypeConfiguration<Ciudad>
    {
        public void Configure(EntityTypeBuilder<Ciudad> builder)
        {
            builder.HasOne(c => c.Departamento)
                .WithMany(d => d.ListaCiudades)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(c => c.IdDepartamento);

            builder.HasIndex(c => c.IdDepartamento);

            var ciudades = Build();

            ciudades.ForEach(c => c.Departamento = null);

            builder.HasData(
                ciudades
            );
        }

        private List<Ciudad> Build()
        {
            CSVService csvService = new CSVService();

            string path = Path.Combine(AppContext.BaseDirectory, "Data", "SeedData", "Ciudades.csv");

            return csvService.csvToList<Ciudad>(path, ",").ToList();
        }
    }
}
