using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Deuda
    {
        public int Id { get; set; }
        public string TipoDeuda { get; set; }
        public float CantidadDeuda { get; set; }
        //Realaciones
        public ICollection<Solicitud> Solicitudes { get; set; }

    }
}
