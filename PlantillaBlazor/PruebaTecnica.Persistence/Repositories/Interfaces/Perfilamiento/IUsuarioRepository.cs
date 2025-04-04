﻿using PruebaTecnica.Domain.Entities.Perfilamiento;
using PruebaTecnica.Persistence.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Persistence.Repositories.Interfaces.Perfilamiento
{
    public interface IUsuarioRepository : IGenericRepository<Usuario>
    {
        public Task<bool> RegistrarAuditoriaLogin(AuditoriaLoginUsuario auditoria);
        public Task<bool> RegistrarAuditoriaCierreSesion(AuditoriaLoginUsuario auditoria);
        public Task<bool> InsertarUsuario(Usuario usuario);
        public Task<long> GetCantidadIntentosFallidos(long idUsuario, int cantidadMinutos);

        /// <summary>
        /// Inactiva aquellos usuarios que no han entrado a la plataforma después de n cantidad de días
        /// </summary>
        /// <param name="diasDesdeUltimoLoggeo">Días desde los cuales no se han loggeado los usuarios</param>
        /// <returns>Booleano indicando si la operación fue exitosa</returns>
        public Task<bool> InactivarUsuariosNoActivos(int diasDesdeUltimoLoggeo);
    }
}
