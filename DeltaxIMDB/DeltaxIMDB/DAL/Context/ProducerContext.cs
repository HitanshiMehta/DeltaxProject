using DeltaxIMDB.Models;
using System.Data.Entity;

namespace DeltaxIMDB.DAL.Context
{
    public class ProducerContext : DbContext
    {
        public ProducerContext()
            : base("DefaultConnection")
        {
        }
        public DbSet<ProducerModel> Producer { get; set; }
    }
}