using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PruebaTecnica.Domain.Entities.Parametrizacion
{
    /// <summary>
    /// Modelo que representa la información de un parámetro detallado
    /// </summary>
    [Table("ParametroDetallado", Schema = "Par")]
    public class ParametroDetallado : BaseEntity
    {
        /// <summary>
        /// Nombre del parámetro detallado
        /// </summary>
        [MaxLength(300)]
        public string Nombre { get; set; } = string.Empty;
        /// <summary>
        /// Identificador del parámetro general al cual está asociado el parámetro detallado actual
        /// </summary>
        public long IdParametroGeneral { get; set; }
        /// <summary>
        /// Referencia al parámetro general al cual está asociado el parámetro detallado actual
        /// </summary>
        /// 
        [JsonIgnore]
        public virtual ParametroGeneral ParametroGeneral { get; set; }
    }
}
