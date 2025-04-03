using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Domain.Entities.Parametrizacion;
using PruebaTecnica.Persistence.Data;
using PruebaTecnica.Persistence.Repositories.Common;
using PruebaTecnica.Persistence.Repositories.Interfaces.Parametrizacion;

namespace PruebaTecnica.Persistence.Repositories.Implementations.Parametrizacion
{
    public class DepartamentoRepository : EFCoreRepository<Departamento>, IDepartamentoRepository
    {
        public DepartamentoRepository(IDbContextFactory<AppDbContext> dbContextFactory) : base(dbContextFactory)
        {
        }
    }
}
