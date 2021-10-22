using System;
using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {

        EFCategoryRepository repository;

        public CategoryManager()
        {
            repository = new EFCategoryRepository();
        }
        public void Add(Category category)
        {
            repository.Add(category);
        }

        public void Delete(Category category)
        {
            repository.Delete(category);
        }

        public List<Category> GetAll()
        {
            return repository.GetAll();
        }

        public Category GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Update(Category category)
        {
            repository.Update(category);
        }
    }
}
