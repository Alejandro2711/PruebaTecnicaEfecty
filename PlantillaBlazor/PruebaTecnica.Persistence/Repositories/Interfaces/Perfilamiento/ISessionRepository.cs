
using PruebaTecnica.Domain.Entities.Perfilamiento;
using PruebaTecnica.Persistence.Repositories.Common;

namespace PruebaTecnica.Persistence.Repositories.Interfaces.Perfilamiento
{
    public interface ISessionRepository : IGenericRepository<Session>
    {
        public Task<bool> SaveSessionInfo(Session session);
        public Task<bool> DesactivarSessionsUsuario(long idUsuario, string motivo);
        public Task InhabilitarSesionesInactivas(int dias);
        public Task<bool> InhabilitarSessionByIdAuditoria(long idAuditoria, string motivo);
    }
}
