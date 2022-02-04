using System;
using Microsoft.EntityFrameworkCore;
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
                    ;

                Console.WriteLine("Listado de cursos");
                foreach (var solicitud in listaSolicitudes)
                {
                    Console.WriteLine(
                        solicitud.Usuario.Nombre + " "+
                        solicitud.Tarjeta.NombreTarjeta + " "+
                        solicitud.NombreEmpresa + " "+
                        solicitud.Usuario.Edad



                    );
                }
            }
        }
    }
}
