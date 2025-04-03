using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Domain.Entities.Prueba
{
    [Table("Prueba", Schema = "Ope")]
    public class PruebaModel : BaseEntity
    {
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public long? TipoDocumento { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public long? EstadoCivil { get; set; }
    }
}
