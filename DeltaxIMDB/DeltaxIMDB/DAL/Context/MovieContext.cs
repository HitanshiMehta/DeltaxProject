using DeltaxIMDB.Models;
using System.Data.Entity;

namespace DeltaxIMDB.DAL.Context
{
    public class MovieContext : DbContext
    {
        public MovieContext()
            : base("DefaultConnection")
        {
        }
        public DbSet<MovieModel> Movie { get; set; }

        public System.Data.Entity.DbSet<DeltaxIMDB.Models.ProducerModel> ProducerModels { get; set; }
    }
}