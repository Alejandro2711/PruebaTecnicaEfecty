using PruebaTecnica.Domain.Entities.Perfilamiento;
using PruebaTecnica.Persistence.Data;
using PruebaTecnica.Persistence.Repositories.Common;
using PruebaTecnica.Persistence.Repositories.Interfaces.Perfilamiento;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Persistence.Repositories.Implementations.Perfilamiento
{
    public class ModuloRepository : EFCoreRepository<Modulo>, IModuloRepository
    {
        public ModuloRepository(IDbContextFactory<AppDbContext> dbContextFactory) : base(dbContextFactory)
        {

        }

        public async Task<bool> EliminarAsignacionesRolModulo(IEnumerable<RolModulo> asignaciones)
        {
            using var context = _dbContextFactory.CreateDbContext();

            context.RolModulo.RemoveRange(asignaciones);

            var entities = await context.SaveChangesAsync();

            return entities > 0;
        }
        public async Task<bool> InsertarAsignacionesRolModulo(IEnumerable<RolModulo> asignaciones)
        {
            using var context = _dbContextFactory.CreateDbContext();

            foreach (var a in asignaciones)
            {
                a.FechaAdicion = DateTime.Now;
            }

            context.RolModulo.AddRange(asignaciones);

            var entities = await context.SaveChangesAsync();

            return entities > 0;
        }
    }
}
