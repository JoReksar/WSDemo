using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntiquesShop.Database.Models;

namespace AntiquesShop.Database
{
    internal class AntiquesShopDatabase : DbContext
    {
        public static AntiquesShopDatabase Instance { get; } = new();

        protected AntiquesShopDatabase() { }

        public DbSet<Antiques> Antiques { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<RegistrationData> Registrations { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
