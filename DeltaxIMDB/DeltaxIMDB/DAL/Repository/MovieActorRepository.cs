using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DeltaxIMDB.DAL.Context;
using DeltaxIMDB.DAL.Interface;
using DeltaxIMDB.Models;

namespace DeltaxIMDB.DAL.Repository
{
    public class MovieActorRepository : IMovieActorRepository
    {
        //********************Declaration********************
        private MovieActorContext _MovieActorContext;


        //Constructor
        public MovieActorRepository(MovieActorContext MovieActorcontext, MovieActorModel MovieActorModel)
        {
            _MovieActorContext = MovieActorcontext;
        }

        //********************Implementation********************


        //Display
        public IEnumerable<MovieActorModel> GetMovieActor()
        {
            return _MovieActorContext.MovieActor.ToList();
        }


        //Detail
        public MovieActorModel GetMovieActorById(int? MovieActorId)
        {
            return _MovieActorContext.MovieActor.Find(MovieActorId);
        }

        //Insert
        public void AddMovieActor(MovieActorModel MovieActor)
        {
            _MovieActorContext.MovieActor.Add(MovieActor);
        }

        //Update
        public void UpdateMovieActor(MovieActorModel MovieActor)
        {
            _MovieActorContext.Entry(MovieActor).State = EntityState.Modified;
        }

        //Delete
        public void DeleteMovieActor(int MovieActorId)
        {
            MovieActorModel MovieActor = _MovieActorContext.MovieActor.Find(MovieActorId);
            _MovieActorContext.MovieActor.Remove(MovieActor);
        }

        //Save
        public void save()
        {
            _MovieActorContext.SaveChanges();
        }


        //Dispose
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _MovieActorContext.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}