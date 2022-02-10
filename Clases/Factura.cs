using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Factura
    {
        public int id { get; set; }
        public int factura { get; set; }

        public float monto { get; set; }
        public DateTime FechaFactura { get; set; }
        //
        public List<Solicitud> Solicitudes { get; set; }

        //Relaciones 
        public int CurrentSolicitudid { get; set; }
        public Solicitud Solicitud { get; set; }
        //Relacion 1 a 1 
        public ICollection<Prerequisito> Prerequsitos { get; set; }
    }
}
