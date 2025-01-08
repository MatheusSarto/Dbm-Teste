using Dbm.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Dbm.Api.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Protocolo> Protocolos { get; set; }
        public DbSet<ProtocoloFollow> ProtocolosFollow { get; set; }
        public DbSet<StatusProtocolo> StatusProtocolos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); 
        }
    }
}
