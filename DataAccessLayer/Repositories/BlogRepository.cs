using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    { 

        public void Add(Blog blog)
        {
            using var domainContext = new DomainContext();
            domainContext.Add(blog);
            domainContext.SaveChanges();
        }

        public void Delete(Blog blog)
        {
            using var domainContext = new DomainContext();
            domainContext.Remove(blog);
            domainContext.SaveChanges();
        }

        public List<Blog> GetAll()
        {
            using var domainContext = new DomainContext();
            return domainContext.Blogs.ToList();
        }

        public Blog GetById(int id)
        {
            using var domainContext = new DomainContext();
            return domainContext.Blogs.Find(id);
        }

        public void Update(Blog blog)
        {
            using var domainContext = new DomainContext();
            domainContext.Update(blog);
            domainContext.SaveChanges();
        }
    }
}
