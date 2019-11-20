using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTicket.Models
{
    public class EfCategoryRepository : ICategoryRepository
    {

        private ApplicationDbContext context;

        public EfCategoryRepository(ApplicationDbContext _context)
        {
            context = _context;
        }

        public void CreateCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
        }

        public void DeleteCategory(int categoryid)
        {
            var user = context.Categories.FirstOrDefault(i => i.CategoryId == categoryid);
            if (context != null)
            {
                context.Categories.Remove(user);
                context.SaveChanges();
            }
        }

        public IQueryable<Category> getAll()
        {
            return context.Categories;
        }

        public Category getById(int categoryid)
        {
            return context.Categories.FirstOrDefault(i => i.CategoryId == categoryid);
        }

        public void UpdateCategory(Category category)
        {
            context.Categories.Update(category);
            context.SaveChanges();
        }
    }
}
