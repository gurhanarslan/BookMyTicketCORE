using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTicket.Models
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();

            if (!context.Categories.Any())
            {
                context.AddRange(

                    new Category() { CategoryName = "Aksiyon" },
                    new Category() { CategoryName = "Macera" },
                    new Category() { CategoryName = "Animasyon" },
                    new Category() { CategoryName = "Fantastik" }

                    );
                context.SaveChanges();
            }

            if (!context.Tickets.Any())
            {
                context.AddRange(

                    new Ticket() { FullorEmpty = false },
                    new Ticket() { FullorEmpty = false },
                    new Ticket() { FullorEmpty = false },
                    new Ticket() { FullorEmpty = false },
                    new Ticket() { FullorEmpty = false },
                    new Ticket() { FullorEmpty = false },
                    new Ticket() { FullorEmpty = false },
                    new Ticket() { FullorEmpty = false },
                    new Ticket() { FullorEmpty = false },
                    new Ticket() { FullorEmpty = false },
                    new Ticket() { FullorEmpty = false },
                    new Ticket() { FullorEmpty = false },
                    new Ticket() { FullorEmpty = false },
                    new Ticket() { FullorEmpty = false },
                    new Ticket() { FullorEmpty = false },
                    new Ticket() { FullorEmpty = false },
                    new Ticket() { FullorEmpty = false },
                    new Ticket() { FullorEmpty = false },
                    new Ticket() { FullorEmpty = false },
                    new Ticket() { FullorEmpty = false },
                    new Ticket() { FullorEmpty = false },
                    new Ticket() { FullorEmpty = false },
                    new Ticket() { FullorEmpty = false },
                    new Ticket() { FullorEmpty = false },
                    new Ticket() { FullorEmpty = false },
                    new Ticket() { FullorEmpty = false }



                    );
                context.SaveChanges();
            }

            if (!context.biletHoles.Any())
            {
                context.AddRange(

                    new BiletHole() {  BiletStatus = "bos" },
                    new BiletHole() { BiletStatus = "bos" },
                    new BiletHole() { BiletStatus = "bos" },
                    new BiletHole() { BiletStatus = "bos" },
                    new BiletHole() { BiletStatus = "bos" },
                    new BiletHole() { BiletStatus = "bos" },
                    new BiletHole() { BiletStatus = "bos" },
                    new BiletHole() { BiletStatus = "bos" },
                    new BiletHole() { BiletStatus = "bos" },
                    new BiletHole() { BiletStatus = "bos" },
                    new BiletHole() { BiletStatus = "bos" },
                    new BiletHole() { BiletStatus = "bos" },
                    new BiletHole() { BiletStatus = "bos" },
                    new BiletHole() { BiletStatus = "bos" },
                    new BiletHole() { BiletStatus = "bos" },
                    new BiletHole() { BiletStatus = "bos" },
                    new BiletHole() { BiletStatus = "bos" },
                    new BiletHole() { BiletStatus = "bos" },
                    new BiletHole() { BiletStatus = "bos" },
                    new BiletHole() { BiletStatus = "bos" },
                    new BiletHole() { BiletStatus = "bos" },
                    new BiletHole() { BiletStatus = "bos" },
                    new BiletHole() { BiletStatus = "bos" },
                    new BiletHole() { BiletStatus = "bos" },
                    new BiletHole() { BiletStatus = "bos" },
                    new BiletHole() { BiletStatus = "bos" }



                    );
                context.SaveChanges();
            }


            if (!context.Movies.Any())
            {
                context.AddRange(
                    new Movies() { MoviesName = "Recep İvedik 7", CategoryId=1 },
                     new Movies() { MoviesName = "Recep İvedik 6", CategoryId = 1 },
                     new Movies() { MoviesName = "Recep İvedik 5", CategoryId = 1 }
                    );
                context.SaveChanges();
            }
        }
    }
}
