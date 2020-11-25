using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Domain.Model;
using System.Linq;

namespace ShoppingCart.Domain.Interfaces
{
    public interface ICategoriesRespository
    {
        IQueryable<Category> GetCategories();

        Category GetCategory(Guid id);
        void AddCategory(Category c);
        void DeleteCategory(Guid id);
    }
}
