using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaTecnica.Domain.Entities.Parametrizacion
{
    [Table(name: "Departamento", Schema = "Par")]
    public class Departamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public virtual List<Ciudad> ListaCiudades { get; set; } = new List<Ciudad>();
    }
}
