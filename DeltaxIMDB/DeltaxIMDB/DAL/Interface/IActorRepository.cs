using DeltaxIMDB.Models;
using System;
using System.Collections.Generic;

namespace DeltaxIMDB.DAL.Interface
{
    public interface IActorRepository : IDisposable
    {
        IEnumerable<ActorModel> GetActor();
        ActorModel GetActorById(int? ActorId);
        void AddActor(ActorModel Actor);
        void UpdateActor(ActorModel Actor);
        void DeleteActor(int ActorId);
        void save();
    }
}