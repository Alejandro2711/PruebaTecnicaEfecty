using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Domain.Entities.Perfilamiento;
using PruebaTecnica.Domain.Entities.Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Persistence.Data.TablesConfigurations.Prueba
{
    public class PruebaConfig : IEntityTypeConfiguration<PruebaModel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<PruebaModel> builder)
        {
            builder.HasIndex(u => u.TipoDocumento);
        }
    }
}
