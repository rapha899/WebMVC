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
                  .ThenInclude(tarjeta => tarjeta.Tarjeta)
                  .Include(soli => soli.Solicitudes)
                  .ThenInclude(deuda => deuda.Deuda)
                  .Single(user => user.Id == usuario.Id);
            //Cauculo deuda
            //LLama a nuestra lista de solicitudes y muestra los datos a consultar 
            var conSoli = db.Solicitudes.First();
            var opC = new OpCapacidadEndeudamiento(db);
            opC.CalculoPorcentaje(conSoli);
            //Busco solicitud mediante un foreach
            foreach (var solicitud1 in tmpUsuario.Solicitudes)
            {
               // si el usuario es igual al id 
                if (solicitud1.Usuario.Id == usuario.Id)
               // compara la edad del usario con los requisitos de la edad requerida para obtenr la tarjeta 
                if (solicitud1.Usuario.Edad < solicitud1.Tarjeta.Edad) return false; 
                //Comprueba que cumpla con el timpo de trabajo rquerido 
                
                //Aprueba la solicitud si su capacidad de endeudamiento el igual o superior a los ingresos del usauairo
                if (opC.Aprobado(solicitud1)) {
                    return true;
                }
                
            }
            return false;
           

        }
    }
}
