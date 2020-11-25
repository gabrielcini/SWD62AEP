using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShoppingCart.Data.Context;
using ShoppingCart.Domain.Interfaces;
using ShoppingCart.Domain.Model;

namespace ShoppingCart.Data.Repositories
{
    public class CategoriesRepository: ICategoriesRespository
    {
        private ShoppingCartDbContext _context;
        public CategoriesRepository(ShoppingCartDbContext context)
        {
            _context = context;
        }

        public void AddCategory(Category c)
        {
            _context.Categories.Add(c);
            _context.SaveChanges();
        }

        public void DeleteCategory(Guid id)
        {
            var myCategory = GetCategory(id);
            _context.Categories.Remove(myCategory);
            _context.SaveChanges();
        }

        public Category GetCategory(Guid id)
        {
            return _context.Categories.SingleOrDefault(x => x.Id == id);
        }

        public IQueryable<Category> GetCategories()
        {
            return _context.Categories;
        }
    }
}
