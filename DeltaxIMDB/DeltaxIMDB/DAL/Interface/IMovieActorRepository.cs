using DeltaxIMDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DeltaxIMDB.DAL.Interface
{
    public interface IMovieActorRepository : IDisposable
    {
        IEnumerable<MovieActorModel> GetMovieActor();
        MovieActorModel GetMovieActorById(int? MovieActorId);
        void AddMovieActor(MovieActorModel MovieActor);
        void UpdateMovieActor(MovieActorModel MovieActor);
        void DeleteMovieActor(int MovieActorId);
        void save();
    }
}