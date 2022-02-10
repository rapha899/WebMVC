using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Tarjeta
    {
        public int Id { get; set; }
        public string NombreTarjeta { get; set; }
        public int Edad {get ; set; }
        public int YearsTranajoPrivado { get; set; }
        public int YearsTrabajoPublica { get; set; }
        public int YearsFactura { get; set; }

        public float valorAprobacion { get; set; }
        //relacion solicitudes
        public List<Solicitud> Solicitudes { get; set; }

        public List<solicitudDet> SolicitudDets { get; set; }

        //Relacion muchos a muchos
        public ICollection<Prerequisito> Prerequsitos { get; set; }

    }
}
