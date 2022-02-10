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
        // llamada al db contex
        readonly TarjetaContex db;
        //retorno del db contex
        public OpCapacidadEndeudamiento(TarjetaContex db)
        {
            this.db = db;
        }
        float deuda, ingresos, porcentajeFijo;

        // constructor calculo capacidad endeudamiento
        public void CalculoPorcentaje(Solicitud solicitud)
        {

            var tmpSolicitud = db.Solicitudes
                    //  .Include(soli => soli.Ingresos)
                    .Include(soli => soli.Deuda)
                    .Include(t => t.Tarjeta)
                    .Include(det => det.SolicitudDets)
                    .ThenInclude(p => p.PorcentajeEndeudamiento)
                    .Single(soli => soli.id == solicitud.id);
            deuda = tmpSolicitud.Deuda.CantidadDeuda;
            ingresos = tmpSolicitud.Ingresos;
            //Calculo capacidad endeudamiento
            float suma = 0;
            suma = deuda + ingresos * porcentajeFijo;
            suma = MathF.Round(suma, 2);
            
        }

        //Se encarga de comparar la capacidaded de endeudamiento con el prerequisitos de la tarjeta 
        public float Endeudamiento(Solicitud solicitud)
        {
            float suma;
            float porcentajeFijo = 0.30f;
            //Calculo capacidad endeudamiento
            suma = (solicitud.Ingresos - solicitud.Deuda.CantidadDeuda) * porcentajeFijo;
            suma = MathF.Round(suma, 2);
            return suma;
        }
        // aprueba credito segun el calculo final  entre la capacidad de endeudamiento y el prerequisitos 
        public bool Aprobado(Solicitud solicitud)
        {
            if (Endeudamiento(solicitud) < solicitud.Tarjeta.valorAprobacion)
            {
                return false;
            }
            
                if (Endeudamiento(solicitud) >= solicitud.Tarjeta.valorAprobacion)
                {
                    if (solicitud.Usuario.Edad >= solicitud.Tarjeta.Edad)
                        if (solicitud.YearsTranajoPrivado >= solicitud.Tarjeta.YearsTranajoPrivado || solicitud.YearsTrabajoPublica >= solicitud.Tarjeta.YearsTrabajoPublica || solicitud.YearsFactura >= solicitud.Tarjeta.YearsFactura)
                            return true;
                }
            
            return false;
        }


    }

}
