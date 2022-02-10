using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class solicitudDet
    {
        public int id { get; set; }

        //Relacion solicitudes 
        public int? soliId { get; set; }
        public Solicitud Solicitud { get; set; }
        //trajeta 
        public int? tarId{ get; set; }
        public Tarjeta Tarjeta { get; set; }
        //usuarios
        public int? usuId { get; set; }
        public Usuario usuario { get; set; }
        //deudas
        public int?  deuId { get; set; }
        public Deuda Deuda { get; set; }
        //1 a 1 porcentaje
        public PorcentajeEndeudamiento PorcentajeEndeudamiento { get; set; }
    }
}
