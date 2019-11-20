using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTicket.Models
{
   public interface ICategoryRepository
    {
        IQueryable<Category> getAll();
        void CreateCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(int categoryid);
        Category getById(int categoryid);
    
            }
}
