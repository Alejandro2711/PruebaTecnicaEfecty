using PruebaTecnica.Domain.Entities.Parametrizacion;
using PruebaTecnica.Persistence.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Persistence.Repositories.Interfaces.Parametrizacion
{
    public interface IParametroDetalladoRepository : IGenericRepository<ParametroDetallado>
    {
        public Task<bool> EliminarParametroDetallado(long id);
    }
}
