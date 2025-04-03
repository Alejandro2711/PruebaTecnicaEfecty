using PruebaTecnica.Domain.Entities.Auditoria;
using PruebaTecnica.Persistence.Repositories.Common;

namespace PruebaTecnica.Persistence.Repositories.Interfaces.Registraduria
{
    public interface IRegistraduriaRepository : IGenericRepository<AuditoriaConsumoRegistraduria>
    {
        public Task<AuditoriaConsumoRegistraduria> ConsultarRegistroRegistraduria(string cedula);
    }
}
