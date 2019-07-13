using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DeltaxIMDB.DAL.Context;
using DeltaxIMDB.DAL.Interface;
using DeltaxIMDB.Models;

namespace DeltaxIMDB.DAL.Repository
{
    public class ProducerRepository : IProducerRepository
    {
        //********************Declaration********************
        private ProducerContext _ProducerContext;

        //Constructor
        public ProducerRepository(ProducerContext Producercontext)
        {
            _ProducerContext = Producercontext;
        }

        //********************Implementation********************


        //Display
        public IEnumerable<ProducerModel> GetProducer()
        {
            return _ProducerContext.Producer.ToList();
        }

        //Detail
        public ProducerModel GetProducerById(int? ProducerId)
        {
            return _ProducerContext.Producer.Find(ProducerId);
        }

        //Insert
        public void AddProducer(ProducerModel Producer)
        {
            _ProducerContext.Producer.Add(Producer);
        }

        //Update
        public void UpdateProducer(ProducerModel Producer)
        {
            _ProducerContext.Entry(Producer).State = EntityState.Modified;
        }

        //Delete
        public void DeleteProducer(int ProducerId)
        {
            ProducerModel Producer = _ProducerContext.Producer.Find(ProducerId);
            _ProducerContext.Producer.Remove(Producer);
        }

        //Save
        public void save()
        {
            _ProducerContext.SaveChanges();
        }


        //Dispose
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _ProducerContext.Dispose();
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