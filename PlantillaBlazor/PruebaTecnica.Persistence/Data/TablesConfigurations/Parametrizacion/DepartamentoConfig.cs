using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PruebaTecnica.Domain.Entities.Parametrizacion;


namespace PruebaTecnica.Persistence.Data.TablesConfigurations.Parametrizacion
{
    public class DepartamentoConfig : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            builder.HasData(
                Build()
            );
        }

        private List<Departamento> Build()
        {
            CSVService csvService = new CSVService();

            string path = Path.Combine(AppContext.BaseDirectory, "Data", "SeedData", "Departamentos.csv");

            return csvService.csvToList<Departamento>(path, ",").ToList();

        }
    }
}
