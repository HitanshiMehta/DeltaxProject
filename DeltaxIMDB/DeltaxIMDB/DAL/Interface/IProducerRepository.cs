using DeltaxIMDB.Models;
using System;
using System.Collections.Generic;

namespace DeltaxIMDB.DAL.Interface
{
    public interface IProducerRepository : IDisposable
    {
        IEnumerable<ProducerModel> GetProducer();
        ProducerModel GetProducerById(int? ProducerId);
        void AddProducer(ProducerModel Producer);
        void UpdateProducer(ProducerModel Producer);
        void DeleteProducer(int ProducerId);
        void save();
    }
}