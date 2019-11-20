
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTicket.Models
{
   public interface IBiletHoleRepository
    {
        IQueryable<Ticket> getAll();
        void CreateCategory(Ticket category);
        void UpdateCategory(Ticket category);
        void DeleteCategory(int categoryid);
        Ticket getById(int categoryid);
    
            }
}
