using Microsoft.EntityFrameworkCore;
using ModeloDb;
using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class OpCapacidadEndeudamiento
    {
        public TarjetaContex db { get; set; }

        public OpCapacidadEndeudamiento(TarjetaContex db)
        {
            this.db = db;
        }
        float deuda, ingresos, porcentajeFijo;

        public OpCapacidadEndeudamiento(Solicitud solicitud) {
           
            var tmpSolicitud = db.Solicitudes
                    .Include(soli => soli.Ingresos)
                    .Include(soli => soli.Deuda)
                    .Include(soli => soli.Tarjeta)
                    .Single(soli => soli.id == solicitud.id);
            deuda = tmpSolicitud.Deuda.CantidadDeuda;
            ingresos = tmpSolicitud.Ingresos;
            porcentajeFijo = 0.30f;
            //Calculo capacidad endeudamiento
            float suma = 0;
            suma = deuda + ingresos * porcentajeFijo;
            suma = MathF.Round(suma, 2);

        }
        //calcula capacidad endeudamiento
        public float Endeudamiento(Solicitud solicitud) {
            float suma;
            float porcentajeFijo = 0.30f;
            //Calculo capacidad endeudamiento
            suma = (solicitud.Ingresos - solicitud.Deuda.CantidadDeuda)*porcentajeFijo;
            suma = MathF.Round(suma, 2);
            return suma;
           }
        // aprueba credito segun capacidas endeudamiento
        public bool Aprobado(Solicitud solicitud)
        {
            if (Endeudamiento(solicitud) < solicitud.Tarjeta.valorAprobacion) { 
                return false;
            }
            if (Endeudamiento(solicitud) >= solicitud.Tarjeta.valorAprobacion) {
                return true;
            }
            return false;
        }

       
    }

}
