using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaTecnica.Domain.Entities.Parametrizacion
{
    [Table(name: "Ciudad", Schema = "Par")]
    public class Ciudad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public long? IdDepartamento { get; set; }

        [MaxLength(200)]
        public string? CodigoDane { get; set; }
        public virtual Departamento? Departamento { get; set; }
    }
}
