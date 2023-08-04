using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI.Relational;
using Proyecto_majo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_majo.Proyecto_MajoDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet <Compra> Compras { get; set; }
        public DbSet<Cliente> Clientes { get; set; } // DbSet representa la tabla en la base de datos
        public DbSet<Roles> Roles { get; set; } // DbSet representa la tabla en la base de datos
        public DbSet<Productos> Productos { get; set; } // DbSet representa la tabla en la base de datos
        public DbSet<Vendedor> Vendedor { get; set; } // DbSet representa la tabla en la base de datos


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=;database=ventasbd;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vendedor>().HasData(
                new Vendedor
                {
                    IdVendedor = 1,
                    NombreVendedor = "Usuario 1",
                    UserName = "user1",
                    Password = "password1",
                    IdRoles = 1 // Aquí debes proporcionar el ID del rol correspondiente
                },
                new Vendedor
                {
                    IdVendedor = 2,
                    NombreVendedor = "Usuario 2",
                    UserName = "user2",
                    Password = "password2",
                    IdRoles = 2 // Aquí debes proporcionar el ID del rol correspondiente
                }
                // Agrega más usuarios si es necesario
            );

            modelBuilder.Entity<Roles>().HasData(
                new Roles
                {
                    IdRoles = 1,
                    RoleName = "Administrador"
                },
                new Roles
                {
                    IdRoles = 2,
                    RoleName = "Usuario Normal"
                }
            // Agrega más roles si es necesario
            );

        }






    }
}
