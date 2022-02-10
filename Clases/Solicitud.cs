using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public enum SolicitudEstado { Pendiente, Aprobada, Rechazada, Anulada }

    public class Solicitud
    {
        public int id { get; set; }
        public float Ingresos { get; set; }
        public string NombreEmpresa { get; set; }
        public string TipoEmpresa { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public int YearsTranajoPrivado { get; set; }
        public int YearsTrabajoPublica { get; set; }
        public int YearsFactura { get; set; }

        public SolicitudEstado SolicitudEstado { get; set; }
        //usurio
        public int Usuarioid { get; set; }
        public Usuario Usuario { get; set; }
        //tarjeta
        public int Tarjetaid { get; set; }
        public Tarjeta Tarjeta { get; set; }
        //deuda
        public int DeudaSolicitudid { get; set; }
        public Deuda Deuda { get; set; }
        //aolidet
        public List<solicitudDet> SolicitudDets { get; set; }
        //Relacion registro 
        public int regisId { get; set; }    
        public Registro Registro { get; set; }

    }
}
