
using System.ComponentModel.DataAnnotations;

namespace PruebaTecnica.Domain.DTO.Perfilamiento
{
    public class ReestablecerContraseñaModel
    {
        [Required(ErrorMessage = "El usuario es requerido")]
        public string NombreUsuario { get; set; } = string.Empty;
    }
}
