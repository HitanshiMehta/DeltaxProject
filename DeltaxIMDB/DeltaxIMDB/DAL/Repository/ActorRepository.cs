using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DeltaxIMDB.DAL.Context;
using DeltaxIMDB.DAL.Interface;
using DeltaxIMDB.Models;

namespace DeltaxIMDB.DAL.Repository
{
    public class ActorRepository : IActorRepository
    {
        //********************Declaration********************
        private ActorContext _ActorContext;

        //Constructor
        public ActorRepository(ActorContext actorcontext)
        {
            _ActorContext = actorcontext;
        }

        //********************Implementation********************


        //Display
        public IEnumerable<ActorModel> GetActor()
        {
            return _ActorContext.Actor.ToList();
        }

        //Detail
        public ActorModel GetActorById(int? ActorId)
        {
            return _ActorContext.Actor.Find(ActorId);
        }

        //Insert
        public void AddActor(ActorModel Actor)
        {
            _ActorContext.Actor.Add(Actor);
        }

        //Update
        public void UpdateActor(ActorModel Actor)
        {
            _ActorContext.Entry(Actor).State = EntityState.Modified;
        }

        //Delete
        public void DeleteActor(int ActorId)
        {
            ActorModel actor = _ActorContext.Actor.Find(ActorId);
            _ActorContext.Actor.Remove(actor);
        }

        //Save
        public void save()
        {
            _ActorContext.SaveChanges();
        }


        //Dispose
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _ActorContext.Dispose();
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