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
        // aprueba una solicitud segun el usuario 
        public bool ApruebaSolicitudUsuario(Usuario usuario)
        {

            // Validacion usuario , solicitud
            var tmpUsuario = db.Usuarios
                  .Include(soli => soli.Solicitudes)
                  .ThenInclude(det => det.SolicitudDets)
                  .ThenInclude(deuda => deuda.Deuda)
                  .Include(soli => soli.Solicitudes)
                  .ThenInclude(det => det.SolicitudDets)
                  .ThenInclude(t => t.Tarjeta)
                  .Include(solidets => solidets.SolicitudDets)
                  
                  .Single(user => user.Id == usuario.Id);
            //Si no tiene solicitudes no se puede validar
            if (tmpUsuario.Solicitudes == null) return false;
            //LLama a nuestra lista de solicitudes y muestra los datos a consultar 
            var conSoli = db.Solicitudes.First();
            var opC = new OpCapacidadEndeudamiento(db);
            opC.Endeudamiento(conSoli);
            //Busco solicitud mediante un foreach
            foreach (var solicitud1 in tmpUsuario.Solicitudes)
            {
                foreach (var det in solicitud1.SolicitudDets)
                {
                    if (opC.Aprobado(det.Solicitud))
                    {
                        return true;
                    }
                }
            }
            return false;

        }
    }
}
