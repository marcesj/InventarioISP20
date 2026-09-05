using Backend.Controllers;
using Microsoft.EntityFrameworkCore;
using Services.Models;

namespace Backend.Data
{
    public class InventarioContext : DbContext
    {
        public InventarioContext()
        {
            
        }
        public InventarioContext(DbContextOptions <InventarioContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Pais> Paises { get; set; }

        // Creamos el metodo ONConfiguring para configurar la cadena
        // de coneccion a la base de datos postgreSQL

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //Creamos el metodo OnConfigurin para configurar la cadena
                //de coneccion a la base de datos postgreSQL
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                    .AddEnvironmentVariables()
                    .Build();

                //string cadenaConexion = configuration.GetConnectionString("mysqlRemote");
                var cadenaConexion = configuration.GetConnectionString("postgresRemote");

                optionsBuilder.UseNpgsql(cadenaConexion);
            }
            /*if (!optionsBuilder.IsConfigured)
            {
                 // Configurar la cadena de conexion a la base de datos PostgreSQL
                 //optionBuilder.UseNpgsql("Host=localhost;Port=5432;Database=InventarioDB;Username=postgres;Password=1234");

                // Configurar la cadena de conexion a la base de datos PostgreSQL
                //optionBuilder.UseNpgsql("Host=up-de-fral-postgresql-3.db.run-on-seenode.com;Port=11550;Database=db_68mv3svm5lq8;Username=db_68mv3svm5lq8;Password=LchYWwoWOxBz3MxzD4NdQC8t");
             }*/
        }
        //creamos el metodo OnModelCreating para insertar datos
        //semillas en la tabla Clientes
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                 new Cliente { Id = 1, Firstname = "Juan", Lastname = "Perez",
                     Dni = "12345678", Address = "Calle Falsa 123", IsDeleted = false, LocalidadId=5 },
                 new Cliente { Id = 2, Firstname = "Maria", Lastname = "Gomez",
                     Dni = "87654321", Address = "Avenida Siempre Viva 456", IsDeleted = false, LocalidadId=5 },
                 new Cliente { Id = 3, Firstname = "Pedro", Lastname = "Lopez",
                     Dni = "11223344", Address = "Calle Real 789", IsDeleted = false, LocalidadId=5 }
             );

            //Cargamos datos semillas en la tabla Localidades
            modelBuilder.Entity<Localidad>().HasData(
                new Localidad { Id = 1, Name = "Buenos Aires", ProvinciaId = 1 },
                new Localidad { Id = 2, Name = "Córdoba", ProvinciaId = 2 },
                new Localidad { Id = 3, Name = "Santa Fe", ProvinciaId = 3 },
                new Localidad { Id = 4, Name = "Rosario", ProvinciaId = 3 },
                new Localidad { Id = 5, Name = "San Justo", ProvinciaId = 3 }
            );

            modelBuilder.Entity<Provincia>().HasData(
                new Provincia { Id = 1, Name = "Buenos Aires", PaisId = 1 },
                new Provincia { Id = 2, Name = "Córdoba", PaisId = 1 },
                new Provincia { Id = 3, Name = "Chile", PaisId = 1 }
            );

            modelBuilder.Entity<Pais>().HasData(
                new Pais { Id = 1, Name = "Argentina" },
                new Pais { Id = 2, Name = "Brasil" },
                new Pais { Id = 3, Name = "Chile" }
            );

            //desactivamos la eliminación en cascada para la relación entre
            //Localidad y Provincia usando Fluent API
            modelBuilder.Entity<Localidad>()
                .HasOne(l => l.Provincia)
                .WithMany()
                .HasForeignKey(l => l.ProvinciaId)
                .OnDelete(DeleteBehavior.Restrict);
            //desactivamos la eliminación en cascada para la relación entre
            //Provincia y Pais usando Fluent API
            modelBuilder.Entity<Provincia>()
                .HasOne(p => p.Pais)
                .WithMany()
                .HasForeignKey(p => p.PaisId)
                .OnDelete(DeleteBehavior.Restrict);


            // configuramos la propiedad Created_at para que tenga
            // un valor por defecto de la fecha y hora actual
            modelBuilder.Entity<Cliente>()
                .Property(c => c.Created_at)
                .HasDefaultValueSql("NOW()");

            // configuramos los queries filters para que no se muestren los clientes
            // eliminados
            modelBuilder.Entity<Cliente>()
                .HasQueryFilter(c => !c.IsDeleted);
            modelBuilder.Entity<Localidad>()
                .HasQueryFilter(l => !l.IsDeleted);

            //Filters for Provincia
            modelBuilder.Entity<Provincia>()
                .HasQueryFilter(p => !p.IsDeleted);

            //Filters for Pais
            modelBuilder.Entity<Pais>()
                .HasQueryFilter(p => !p.IsDeleted);

        }

        

        
        

        
    }


}
