using PruebaTecnica.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnica.Domain.DTO
{
    public class CargueEjemploDTO
    {
        public long IdUsuario { get; set; }
        public string IpAddress { get; set; } = string.Empty;
        public Archivo ArchivoCargue { get; set; }
    }
}
