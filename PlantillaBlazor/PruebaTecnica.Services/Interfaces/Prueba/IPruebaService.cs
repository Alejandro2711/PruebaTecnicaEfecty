using PruebaTecnica.Domain.Entities.Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Services.Interfaces.Prueba
{
    public interface IPruebaService
    {
        public Task<bool> InsertarPrueba(PruebaModel prueba);
        public Task<IEnumerable<PruebaModel>> consulatPruebas();
    }
}
