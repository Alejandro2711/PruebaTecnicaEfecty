using PruebaTecnica.Web.Entities.Authorization;

namespace PruebaTecnica.Web.Entities.Circuits
{
    /// <summary>
    /// Modelo que describe una asigación de la sesión de usuario con el identificador de la conexión/circuito actual
    /// </summary>
    public class CircuitUser
    {
        /// <summary>
        /// Sesión del usuario actual
        /// </summary>
        public UserSession Usuario { get; set; }
        /// <summary>
        /// Identificador del circuito actual
        /// </summary>
        public string CircuitId { get; set; }
    }
}
