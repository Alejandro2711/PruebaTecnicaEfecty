using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Domain.Entities.Perfilamiento;
using PruebaTecnica.Domain.Entities.Prueba;
using PruebaTecnica.Persistence.Data;
using PruebaTecnica.Persistence.Repositories.Common;
using PruebaTecnica.Persistence.Repositories.Interfaces.Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Persistence.Repositories.Implementations.Prueba
{
    internal class PruebaRepository : EFCoreRepository<PruebaModel>, IPruebaRepository
    {
        public PruebaRepository(IDbContextFactory<AppDbContext> dbContextFactory) : base(dbContextFactory)
        {
        }

        public async Task<bool> InsertarUsuario(PruebaModel prueba)
        {
            using var context = _dbContextFactory.CreateDbContext();

            PruebaModel temp = context.Pruebas
                .AsNoTracking()
                .FirstOrDefault(u => u.Id == prueba.Id);

            if (temp is null)
            {
                prueba.FechaAdicion = DateTime.Now;
                context.Pruebas.Add(prueba);
            }
            else
            {
                prueba.FechaUltimaActualizacion = DateTime.Now;
                context.Pruebas.Update(prueba);
            }

            int entities = await context.SaveChangesAsync();

            return entities > 0;
        }
    }
}
