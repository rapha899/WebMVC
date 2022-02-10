using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Cedula { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }
        //relacion solicitudes
        public List<Solicitud> Solicitudes { get; set; }
        //
        public List<solicitudDet> SolicitudDets { get; set; }

        //pre
        public ICollection<Prerequisito> Prerequsitos { get; set; }


    }
}
