using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Operaciones;
namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carga grabar = new Carga();
            grabar.DatosIni();

            using (var db = TarjetaDbBuilder.Crear())
            {
                var listaSolicitudes = db.Solicitudes
                    .Include(solicitudes => solicitudes.Usuario)
                    .Include(solicitudes => solicitudes.Deuda)
                    .Include(solicitudes => solicitudes.Tarjeta)
                    .Include(solicitudes => solicitudes.Deuda)
                    ;

                Console.WriteLine("Listado de Solicitudes");
                foreach (var solicitud in listaSolicitudes)
                {
                    Console.WriteLine(
                        solicitud.Usuario.Nombre + " "+
                        solicitud.Tarjeta.NombreTarjeta + " "+
                        solicitud.NombreEmpresa + " "+
                        solicitud.Ingresos + " " +
                      //  solicitud.Usuario.Edad+""+
                        solicitud.Deuda.CantidadDeuda +""
                    );
                    //capacidad endeudamiento
                    OpCapacidadEndeudamiento opCapacidadEndeudamiento = new OpCapacidadEndeudamiento(db);
                    opCapacidadEndeudamiento.Endeudamiento(solicitud);
                    opCapacidadEndeudamiento.Endeudamiento(solicitud);
                    //capacidad de endeudamiento solicitante
                    Console.WriteLine(opCapacidadEndeudamiento.Endeudamiento(solicitud));
                    Console.WriteLine(opCapacidadEndeudamiento.Aprobado(solicitud));
                    //var solicitudesw = validacion.ApruebaSolicitud(solicitud ,solicitud.Usuario);
                   
                }
            }

            
         
            
                 
}
}
}


