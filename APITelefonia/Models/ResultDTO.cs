using System;

namespace APITelefonia.Models
{
    public class ResultDTO
    {
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Nombre_fabricante { get; set; }

        public string Nombre_estado { get; set; }

        public DateTime Fecha_fabricacion { get; set; }

        public DateTime Fecha_estado { get; set; }
    }
}
