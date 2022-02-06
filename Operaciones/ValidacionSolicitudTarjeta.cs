using ModeloDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;
using Microsoft.EntityFrameworkCore;

namespace Operaciones
{
    public class ValidacionSolicitudTarjeta
    {
        public TarjetaContex db { get; set; }

        public ValidacionSolicitudTarjeta(TarjetaContex db)
        {
            this.db = db;
        }

        public bool ApruebaSolicitud(Usuario usuario, Solicitud solicitud)
        {

            return false;
           

        }
    }
}
