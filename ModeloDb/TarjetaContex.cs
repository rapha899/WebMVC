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

       
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MSI\\SQLEXPRESS;Database=EFCore-ProyectoTrajeta;Trusted_Connection=True");
        }
        */
       

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
            modelBuilder.Entity<Deuda>()
                .HasOne(c => c.Solicitud)
                .WithMany(m => m.Deudas)
                .HasForeignKey(c => c.CurrentSolicitudid);
            //1 a 1 Factura Calculo
            modelBuilder.Entity<Calculo>()
               .HasOne(facturas => facturas.Facturas)
               .WithOne(rol => rol.Calculos)
               .HasForeignKey<Factura>(pago => pago.Calculos_Id);
            // 1 a 1 rol publico

            //muchos a muchos 
            modelBuilder.Entity<Prerequisito>()
                .HasKey(p => new { p.RolPagoId, p.FacturaId, p.RolPagoPublicaId, p.UsuarioId });

            modelBuilder.Entity<Prerequisito>()
            .HasOne(pre => pre.Factura)
            .WithMany(factura => factura.Prerequsitos)
            .OnDelete(DeleteBehavior.NoAction)
            .HasForeignKey(pre => pre.FacturaId);

            modelBuilder.Entity<Prerequisito>()
          .HasOne(pre => pre.Usuario)
          .WithMany(usuario => usuario.Prerequsitos)
          .OnDelete(DeleteBehavior.NoAction)
          .HasForeignKey(pre => pre.UsuarioId);

            modelBuilder.Entity<Prerequisito>()
            .HasOne(pre => pre.RolPagosPublica)
            .WithMany(rlp => rlp.Prerequsitos)
            .OnDelete(DeleteBehavior.NoAction)
            .HasForeignKey(pre => pre.RolPagoPublicaId);

            modelBuilder.Entity<Prerequisito>()
          .HasOne(pre => pre.RolPago)
          .WithMany(rol => rol.Prerequsitos)
          .OnDelete(DeleteBehavior.NoAction)
          .HasForeignKey(pre => pre.RolPagoId);
        }
        //Declaracion de clases 
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Solicitud> Solicitudes { get; set; }
        public DbSet<Tarjeta> Tarjetas { get; set; }
        public DbSet<Deuda> Deudas { get; set; }
        public DbSet<RolPago> Rol { get; set; }
        public DbSet<Calculo> Calculos { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<RolPagoPublica> RolPublica { get; set; }

    }


}

