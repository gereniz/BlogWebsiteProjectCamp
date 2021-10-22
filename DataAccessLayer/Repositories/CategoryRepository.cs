using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        DomainContext domainContext = new DomainContext();

        public void Add(Category category)
        {
            domainContext.Add(category);
            domainContext.SaveChanges();
        }

        public void Delete(Category category)
        {
            domainContext.Remove(category);
            domainContext.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return domainContext.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return domainContext.Categories.Find(id);
        }

        public void Update(Category category)
        {
            domainContext.Update(category);
            domainContext.SaveChanges();
        }
    }
}
