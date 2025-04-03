using PruebaTecnica.Domain.Entities.Prueba;
using PruebaTecnica.Persistence.Repositories.Interfaces.Prueba;
using PruebaTecnica.Services.Interfaces.Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Services.Implementations.Prueba
{
    public class PruebaService : IPruebaService
    {
        private readonly IPruebaRepository _PruebaRepository;

        public PruebaService(IPruebaRepository pruebaRepository)
        {
            _PruebaRepository = pruebaRepository;
        }

        public async Task<IEnumerable<PruebaModel>> consulatPruebas()
        {
            return await _PruebaRepository.Get();
        }

        public async Task<bool> InsertarPrueba(PruebaModel prueba)
        {
            return await _PruebaRepository.InsertarUsuario(prueba);
        }
    }
}
