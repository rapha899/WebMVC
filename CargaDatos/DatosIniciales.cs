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
           Usuario,Tarjeta,Solicitud,Deuda,RolPago,RolPagoPublica,Factura,Prerequesito,Calculo,Configuracion,Registro,Porcentaje
        }
        public Dictionary<ListaTipo, object> Carga()
        {
            //rol de pagos usuario 1
            RolPago rolPago1 = new RolPago()
            {
                nombreEmpresa = "SA",
                rolPago = 1,
                monto = 25000,

            };
            RolPago rolPago2 = new RolPago()
            {
                nombreEmpresa = "SA",
                rolPago = 2,
                monto = 3000,

            };
            RolPago rolPago3 = new RolPago()
            {
                nombreEmpresa = "SA",
                rolPago = 3,
                monto = 3000,

            };
            RolPago rolPago4 = new RolPago()
            {
                nombreEmpresa = "SA",
                rolPago = 4,
                monto = 3000,

            };
            RolPago rolPago5 = new RolPago()
            {
                nombreEmpresa = "SA",
                rolPago = 5,
                monto = 3000,

            };
            RolPago rolPago6 = new RolPago()
            {
                nombreEmpresa = "SA",
                rolPago = 6,
                monto = 3000,

            };
            RolPago rolPago7 = new RolPago()
            {
                nombreEmpresa = "SA",
                rolPago = 7,
                monto = 3000,

            };
            RolPago rolPago8 = new RolPago()
            {
                nombreEmpresa = "SA",
                rolPago = 8,
                monto = 3000,

            };
            RolPago rolPago9 = new RolPago()
            {
                nombreEmpresa = "SA",
                rolPago = 9,
                monto = 3000,

            };
            RolPago rolPago10 = new RolPago()
            {
                nombreEmpresa = "SA",
                rolPago = 10,
                monto = 3000,

            };
            RolPago rolPago11 = new RolPago()
            {
                nombreEmpresa = "SA",
                rolPago = 11,
                monto = 2090,

            };
            RolPago rolPago12 = new RolPago()
            {
                nombreEmpresa = "SA",
                rolPago = 12,
                monto = 2000,

            };
            List<RolPago> LstRol = new List<RolPago>() { rolPago1, rolPago2, rolPago3, rolPago4, rolPago5, rolPago6, rolPago7, rolPago8, rolPago9, rolPago10, rolPago11,rolPago12};
            //Facturas
            Factura factura = new Factura()
            {
                factura = 1,
                monto = 1000f
            };
            List<Factura> LstFactura = new List<Factura>() { factura };

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
                Nombre = "Juan",
                Apellido = "DelPo",
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
           

            List < Usuario> LstUsuario = new List<Usuario>() { usuario , usuario2, usuario3 , usuario4};

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
                CantidadDeuda = 300.89f,
                
                    
            };
            Deuda deudas1 = new Deuda()
            {
                TipoDeuda = "Prestamo Coperativa",
                CantidadDeuda = 2100.89f,

            };
            Deuda deudasUsuario2 = new Deuda()
            {
                TipoDeuda = "Prestamo Coperativa",
                CantidadDeuda = 700.50f,

            };
            Registro registro = new Registro()
            {
                registroUser = "Usuario1" 
            };
            Registro registro1 = new Registro()
            {
                registroUser = "Usuario2"
            };
            Registro registro2 = new Registro()
            {
                registroUser = "Usuario3"
            };
            Registro registro3 = new Registro()
            {
                registroUser = "Usuario4"
            };
            List<Registro> listaRegistros = new List<Registro>() { registro, registro1, registro2, registro3 };

            Configuracion configuracion = new Configuracion()
            {
                Ingresos = 25000.35f,
                Deudas = 300.89f,
                por30 = 0.30f,
                capa = 700.00f,
                Registro = registro1,

            };
            Configuracion config2 = new Configuracion()
            {
                Ingresos = 900f,
                por30 = 0.30f,
                Deudas = 750f,
                capa = 2500,
                Registro = registro1
            };
            Configuracion config3 = new Configuracion()
            {
                Ingresos = 2500.35f,
                por30 = 0.30f,
                Deudas = 750f,
                capa = 700,
                Registro = registro2
            };
            Configuracion config4 = new Configuracion()
            {
                Ingresos = 7899.35f,
                por30 = 0.30f,
                Deudas = 750f,
                capa = 5000,
                Registro = registro3

            };
            List<Configuracion> lstConfig = new List<Configuracion>() { configuracion  , config2 , config3 , config4};
            // dedudas lista
            List<Deuda> LstDeudas = new List<Deuda>() { deudas1, deudas , deudasUsuario2};
            Solicitud solicitud = new Solicitud()
            {
                NombreEmpresa = "SA",
                FechaSolicitud = new DateTime(2022, 1, 18),
                Ingresos = 25000.35f,
                Usuario = usuario,
                YearsFactura=3 ,
                Tarjeta = tarjeta,
                Deuda = deudas,
                Registro = registro,
                SolicitudEstado = SolicitudEstado.Aprobada,
                 SolicitudDets = new List<solicitudDet>()
                {
                   new solicitudDet()
                   {
                       Tarjeta = tarjeta,
                       Deuda = deudas,
                       usuario = usuario,
                         PorcentajeEndeudamiento = new PorcentajeEndeudamiento(){
                         por30 = 0.30f
                       }
                   }
                }
            };
            //Usuario 2
            Solicitud solicitud2 = new Solicitud()
            {
                NombreEmpresa = "Leiones de muneca",
                FechaSolicitud = new DateTime(2022, 2, 4),
                Usuario = usuario2,
                Tarjeta = tarjeta1,
                Deuda = deudasUsuario2,
                Registro = registro1,
                SolicitudEstado = SolicitudEstado.Rechazada,
                SolicitudDets = new List<solicitudDet>()
                {
                   new solicitudDet()
                   {
                       Tarjeta = tarjeta1,
                       Deuda = deudasUsuario2,
                       usuario = usuario2,
                         PorcentajeEndeudamiento = new PorcentajeEndeudamiento(){
                         Ingresos =  900f,
                         DeudaMonto = 500f,
                         por30 = 0.30f,
                       }
                   }
                }
            };
            PorcentajeEndeudamiento por = new PorcentajeEndeudamiento()
            {


            };

            Solicitud solicitud3 = new Solicitud()
            {
                NombreEmpresa = "SA",
                FechaSolicitud = new DateTime(2022, 1, 18),
                Ingresos = 2500.35f,
                Usuario = usuario3,
                YearsFactura = 3,
                Tarjeta = tarjeta,
                Deuda = deudasUsuario2,
                Registro = registro2,
                SolicitudEstado = SolicitudEstado.Aprobada,
                SolicitudDets = new List<solicitudDet>()
                {
                   new solicitudDet()
                   {
                       Tarjeta = tarjeta,
                       Deuda = deudasUsuario2,
                       usuario = usuario3,
                         PorcentajeEndeudamiento = new PorcentajeEndeudamiento(){
                         por30 = 0.30f
                       }

                   }
                }

            };

            Solicitud solicitud4 = new Solicitud()
            {
                NombreEmpresa = "Rna",
                FechaSolicitud = new DateTime(2022, 1, 18),
                Ingresos = 7899.35f,
                Usuario = usuario4,
                YearsFactura = 12,
                Tarjeta = tarjeta3,
                Deuda = deudasUsuario2,
                Registro = registro3,
                SolicitudEstado = SolicitudEstado.Aprobada,
                SolicitudDets = new List<solicitudDet>()
                {
                   new solicitudDet()
                   {
                       Tarjeta = tarjeta3,
                       Deuda = deudasUsuario2,
                       usuario = usuario4,
                       PorcentajeEndeudamiento = new PorcentajeEndeudamiento(){
                       por30 = 0.30f
                      
                       }
                   }
                   
                }

            };



            List<Solicitud> LtsSolicitudes = new List<Solicitud>() { solicitud , solicitud2 , solicitud3 ,solicitud4};
           



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
                { ListaTipo.Factura , LstFactura },
                { ListaTipo.Registro, listaRegistros },
                { ListaTipo.Configuracion, lstConfig },

            };
            return dictListasDatos;
        }
    }
}
