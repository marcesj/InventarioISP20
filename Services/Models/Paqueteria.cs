using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class Paqueteria
    {
        public int id { get; set; }
        public DateTime created_at { get; set; }
        public string Emisor_Nombre_y_Apellido { get; set; }
        public long Emisor_Telefono { get; set; }
        public string Emisor_Direccion { get; set; }
        public DateTime Emisor_Fecha_y_Hora_Despacho { get; set; }
        public string Emisor_Codigo { get; set; }
        public string Destinatario_Nombre_y_Apellido { get; set; }
        public long Destinatario_Telefono { get; set; }
        public string Destinatario_Direccion { get; set; }
        public DateTime Destinatario_Fecha_y_Hora_Entrega { get; set; }
    }

}
