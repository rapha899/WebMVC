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

        public bool ApruebaSolicitud(Usuario usuario)
        {
            //   ValidacionSolicitudTarjeta usuario , solicitud
            var tmpSolicitud = db.Usuarios
                  .Include(soli => soli.Solicitudes)
                  .ThenInclude(tarjeta => tarjeta.Tarjeta)
                  .Include(soli => soli.Solicitudes)
                  .ThenInclude(deuda => deuda.Deuda)
                  .Include(soli => soli.Solicitudes)
                  .First(user => user.Id == usuario.Id);
            //Cauculo deuda
            var conSoli = db.Solicitudes.First();
            var cal = new OpCapacidadEndeudamiento(conSoli);

            //Busco solicitud
            foreach (var solicitud1 in tmpSolicitud.Solicitudes)
            {
               if (solicitud1.Usuario.Id == usuario.Id)
               if(solicitud1.Deuda == null) return false;
                if (cal.Aprobado(solicitud1)) {
                    return true;
                }

            }
           
            return false;
           

        }
    }
}
