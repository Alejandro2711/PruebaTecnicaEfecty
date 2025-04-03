using PruebaTecnica.Domain.Entities.Prueba;
using PruebaTecnica.Persistence.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Persistence.Repositories.Interfaces.Prueba
{
    public interface IPruebaRepository : IGenericRepository<PruebaModel>
    {
        public Task<bool> InsertarUsuario(PruebaModel prueba);
    }
}
