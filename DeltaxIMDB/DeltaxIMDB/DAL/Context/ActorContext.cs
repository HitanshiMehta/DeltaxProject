using DeltaxIMDB.Models;
using System.Data.Entity;

namespace DeltaxIMDB.DAL.Context
{
    public class ActorContext : DbContext
    {
        public ActorContext()
            : base("DefaultConnection")
        {
        }
        public DbSet<ActorModel> Actor { get; set; }
    }
}