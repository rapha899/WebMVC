
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ModeloDb;
using System.Configuration;

namespace Consola
{
    public class TarjetaDbBuilder
    {
        const string DBTipo = "DBTipo";
        enum DBTipoConn {SqlServer , Postgers ,Memoria }
        static TarjetaContex db;

        public static TarjetaContex Crear()
        { 
        //lee la configuracion de que base usar del archivo App.config
        string dbtipo = ConfigurationManager.AppSettings[DBTipo];
        string conn = ConfigurationManager.ConnectionStrings[dbtipo].ConnectionString;

        DbContextOptions<TarjetaContex> contextOptions;
            switch (dbtipo)
            {
                case "SqlServer":
                    contextOptions = new DbContextOptionsBuilder<TarjetaContex>()
                        .UseSqlServer(conn)
                        .Options;
                    break;
                case "Postgres":
                    contextOptions = new DbContextOptionsBuilder<TarjetaContex>()
                        .UseNpgsql(conn)
                        .Options;
                    break;
                default: // Por defecto usa la memoria como base de datos
                    contextOptions = new DbContextOptionsBuilder<TarjetaContex>()
                        .UseInMemoryDatabase(conn)
                        .Options;
                    break;
            }

            db = new TarjetaContex(contextOptions);
            return db;
        }
    }
}
