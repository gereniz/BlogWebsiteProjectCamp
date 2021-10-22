using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Add(T t)
        {
            using var domainContext = new DomainContext();
            domainContext.Add(t);
            domainContext.SaveChanges();
        }

        public void Delete(T t)
        {
            using var domainContext = new DomainContext();
            domainContext.Remove(t);
            domainContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var domainContext = new DomainContext();
            return domainContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var domainContext = new DomainContext();
            return domainContext.Set<T>().Find(id);
        }

        public void Update(T t)
        {
            using var domainContext = new DomainContext();
            domainContext.Update(t);
            domainContext.SaveChanges();
        }
    }
}
