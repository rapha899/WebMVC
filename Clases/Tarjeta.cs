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

        public float valorAprobacion { get; set; }
        //relacion solicitudes
        public List<Solicitud> Solicitudes { get; set; }
    }
}
