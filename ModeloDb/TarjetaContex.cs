using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;
using Microsoft.EntityFrameworkCore;
namespace ModeloDb
{
    public class TarjetaContex : DbContext
    {
       
         public TarjetaContex(DbContextOptions<TarjetaContex> options) 
         :base(options)
         { 

         }

        //Se asegura del borrado y la creacion de la base de datos
        public void PreparaDB()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //1 a muchos usuario solicitud 
            modelBuilder.Entity<Solicitud>()
              .HasOne(c => c.Usuario)
              .WithMany(m => m.Solicitudes)
              .HasForeignKey(c => c.Usuarioid);
            //tarjetas  solicitud
            modelBuilder.Entity<Solicitud>()
            .HasOne(c => c.Tarjeta)
            .WithMany(m => m.Solicitudes)
            .HasForeignKey(c => c.Tarjetaid);
            //deudas solicitud
            modelBuilder.Entity<Solicitud>()
                .HasOne(c => c.Deuda)
                .WithMany(m => m.Solicitudes)
                .HasForeignKey(c => c.DeudaSolicitudid);
            //solicitud Registro
            modelBuilder.Entity<Solicitud>()
                .HasOne(r => r.Registro)
                .WithMany(s => s.Solicituds)
                .HasForeignKey(r => r.regisId);
            // solidets solicitud
            modelBuilder.Entity<solicitudDet>()
           .HasOne(s => s.Solicitud)
           .WithMany(det => det.SolicitudDets)
           .HasForeignKey(s => s.soliId);
            // solidets usuario
            modelBuilder.Entity<solicitudDet>()
           .HasOne(u => u.usuario)
           .WithMany(det => det.SolicitudDets)
           .HasForeignKey(s => s.usuId);
            // solidets tarjeta
            modelBuilder.Entity<solicitudDet>()
           .HasOne(t => t.Tarjeta)
           .WithMany(det => det.SolicitudDets)
           .HasForeignKey(t => t.tarId);
            // solidets deudas
            modelBuilder.Entity<solicitudDet>()
           .HasOne(d => d.Deuda)
           .WithMany(det => det.SolicitudDets)
           .HasForeignKey(d => d.deuId);
            // clave primaria diferente a int
            modelBuilder.Entity<Configuracion>()
               .HasKey(configuracion => configuracion.Id);
            // 1 a 1 det porcentaje
            modelBuilder.Entity<solicitudDet>()
          .HasOne(d => d.PorcentajeEndeudamiento)
          .WithOne(po => po.solicitudDet)
          .HasForeignKey<PorcentajeEndeudamiento>(d => d.id);
            //muchos a muchos 
            modelBuilder.Entity<Prerequisito>()
                .HasKey(p => new { p.TarjetaId, p.UsuarioId });

            modelBuilder.Entity<Prerequisito>()
            .HasOne(pre => pre.Tarjeta)
            .WithMany(tarjeta => tarjeta.Prerequsitos)
            .OnDelete(DeleteBehavior.NoAction)
            .HasForeignKey(pre => pre.TarjetaId);

            modelBuilder.Entity<Prerequisito>()
          .HasOne(pre => pre.Usuario)
          .WithMany(usuario => usuario.Prerequsitos)
          .OnDelete(DeleteBehavior.NoAction)
          .HasForeignKey(pre => pre.UsuarioId);
        }
        //Declaracion de clases 
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Solicitud> Solicitudes { get; set; }
        public DbSet<solicitudDet> solicitudDets { get; set; }
        public DbSet<Tarjeta> Tarjetas { get; set; }
        public DbSet<Deuda> Deudas { get; set; }
        public DbSet<RolPago> Rol { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<RolPagoPublica> RolPublica { get; set; }
        public DbSet<Configuracion> Configuracions { get; set;}
        public DbSet<Registro > Registros { get; set; }

        public DbSet<PorcentajeEndeudamiento> porcentajeEndeudamientos { get; set; }


    }


}

