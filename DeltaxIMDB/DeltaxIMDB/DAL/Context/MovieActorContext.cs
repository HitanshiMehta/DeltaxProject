using DeltaxIMDB.Models;
using System.Data.Entity;

namespace DeltaxIMDB.DAL.Context
{
    public class MovieActorContext : DbContext
    {
        public MovieActorContext()
            : base("DefaultConnection")
        {
        }
        public DbSet<MovieActorModel> MovieActor { get; set; }

        public System.Data.Entity.DbSet<DeltaxIMDB.Models.ActorModel> ActorModels { get; set; }

        public System.Data.Entity.DbSet<DeltaxIMDB.Models.MovieModel> MovieModels { get; set; }
    }
}