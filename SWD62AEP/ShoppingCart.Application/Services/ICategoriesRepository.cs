using System.Linq;
using ShoppingCart.Domain.Model;

namespace ShoppingCart.Application.Services
{
    public interface ICategoriesRepository
    {
        IQueryable<Category> GetCategories();
    }
}