using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargaDatos
{
    public class DatosIniciales
    {
        public enum ListaTipo
        {
           Usuario,Tarjeta,Solicitud,Deuda,RolPago,RolPagoPublica,Factura,Prerequesito,Calculo
        }
        public Dictionary<ListaTipo, object> Carga()
        {
            //rol de pagos usuario 1
            RolPago rolPago1 = new RolPago()
            {
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago2 = new RolPago()
            {
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago3 = new RolPago()
            {
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago4 = new RolPago()
            {
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago5 = new RolPago()
            {
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago6 = new RolPago()
            {
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago7 = new RolPago()
            {
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago8 = new RolPago()
            {
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago9 = new RolPago()
            {
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago10 = new RolPago()
            {
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago11 = new RolPago()
            {
                rolPago = 1,
                monto = 3000,

            };
            RolPago rolPago12 = new RolPago()
            {
                rolPago = 1,
                monto = 3000,

            };
            List<RolPago> LstRol = new List<RolPago>() { rolPago1, rolPago2, rolPago3, rolPago4, rolPago5, rolPago6, rolPago7, rolPago8, rolPago9, rolPago10, rolPago11 };
            //prerequsito 1 usuuario rol 
            

            Usuario usuario = new Usuario()
            {
                Nombre = "Raphael",
                Apellido = "Perez",
                Cedula = 1750269969,
                Email = "jr.perez@itq.edu.ec",
                Edad = 21,

            };
            Usuario usuario2 = new Usuario()
            {
                Nombre = "Jaime",
                Apellido = "Pineda",
                Cedula = 1750269967,
                Email = "jaime78@itq.edu.ec",
                Edad = 45

            };
            Usuario usuario3 = new Usuario()
            {
                Nombre = "Juan Martin",
                Apellido = "Del Potro",
                Cedula = 1750269968,
                Email = "juanmartin67@itq.edu.ec",
                Edad = 33


            };
            Usuario usuario4 = new Usuario()
            {
                Nombre = "Rafael",
                Apellido = "Nadal",
                Cedula = 1750269965,
                Email = "rafana@itq.edu.ec",
                Edad = 34


            };

            List < Usuario> LstUsuario = new List<Usuario>() { usuario , usuario2, usuario3, usuario4 };

            //Creamos una tarjeta
            Tarjeta tarjeta = new Tarjeta()
            {
                NombreTarjeta = "Visa Normal",
                valorAprobacion = 700.00f ,
                Edad = 21,
                YearsTranajoPrivado = 1,
                YearsTrabajoPublica = 2,
                YearsFactura = 3

            };
            Tarjeta tarjeta1 = new Tarjeta()
            {
                NombreTarjeta = "Visa Platinum",
                valorAprobacion = 2500.00f,
                Edad = 25,
                YearsTranajoPrivado = 1,
                YearsTrabajoPublica = 2,
                YearsFactura = 3
            };
            Tarjeta tarjeta3 = new Tarjeta()
            {
                NombreTarjeta = "Visa Signature",
                valorAprobacion = 5000.00f ,
                Edad = 30 ,
                YearsTranajoPrivado = 1 ,
                YearsTrabajoPublica = 2,
                YearsFactura = 3 


            };
            //Lista de Tarjetas
            List<Tarjeta> LstTarjetas = new List<Tarjeta>() { tarjeta, tarjeta1, tarjeta3 };
            Deuda deudas = new Deuda()
            {
                TipoDeuda = "Bancaria",
                CantidadDeuda = 300,
                
                    
            };
            Deuda deudas1 = new Deuda()
            {
                TipoDeuda = "Prestamo Coperativa",
                CantidadDeuda = 2100,

            };
            Deuda deudasUsuario2 = new Deuda()
            {
                TipoDeuda = "Prestamo Coperativa",
                CantidadDeuda = 700,

            };

            // dedudas lista
            List<Deuda> LstDeudas = new List<Deuda>() { deudas1, deudas , deudasUsuario2};
            Solicitud solicitud = new Solicitud()
            {
                NombreEmpresa = "SA",
                FechaSolicitud = new DateTime(2022, 1, 18),
                Ingresos = 12400,
                Usuario = usuario,
                Tarjeta = tarjeta,
                Deuda = deudas,
                SolicitudEstado = SolicitudEstado.Aprobada
                
            };
            //Usuario 2
            Solicitud solicitud2 = new Solicitud()
            {
                NombreEmpresa = "Leiones de muneca",
                FechaSolicitud = new DateTime(2022,2,4),
                Ingresos = 800,
                Usuario = usuario3,
                Tarjeta = tarjeta1,
                Deuda = deudasUsuario2,
                SolicitudEstado = SolicitudEstado.Rechazada

            };
            List<Solicitud> LtsSolicitudes = new List<Solicitud>() { solicitud , solicitud2};
            Prerequisito pre = new Prerequisito()
            {
               

            };

            Dictionary<ListaTipo, object> dictListasDatos = new Dictionary<ListaTipo, object>()
            {

                { ListaTipo.Usuario , LstUsuario },
                { ListaTipo.Tarjeta , LstTarjetas },
                { ListaTipo.Deuda , LstDeudas },
                { ListaTipo.RolPago , LstRol },
                { ListaTipo.Solicitud , LtsSolicitudes },
            };
            return dictListasDatos;
        }
    }
}
