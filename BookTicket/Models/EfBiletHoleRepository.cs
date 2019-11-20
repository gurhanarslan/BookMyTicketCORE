using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTicket.Models
{
    public class EfBiletHoleRepository : IBiletHoleRepository
    {

        private ApplicationDbContext context;

        public EfBiletHoleRepository(ApplicationDbContext _context)
        {
            context = _context;
        }

        public void CreateCategory(Ticket category)
        {
            context.Tickets.Add(category);
            context.SaveChanges();
        }

        public void DeleteCategory(int categoryid)
        {
            var user = context.Tickets.FirstOrDefault(i => i.BiletNumberId == categoryid);
            if (context != null)
            {
                context.Tickets.Remove(user);
                context.SaveChanges();
            }
        }

        public IQueryable<Ticket> getAll()
        {
            return context.Tickets;
        }

        public Ticket getById(int categoryid)
        {
            return context.Tickets.FirstOrDefault(i => i.BiletNumberId == categoryid);
        }

        public void UpdateCategory(Ticket category)
        {
            context.Tickets.Update(category);
            context.SaveChanges();
        }
    }
}
