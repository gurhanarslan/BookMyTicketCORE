using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookTicket.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace BookTicket.Controllers
{
    public class HomeController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        private IMoviesRepository moviesRepository;
        private ICategoryRepository categoryRepository;
        private IBiletHoleRepository biletHoleRepository;
        public HomeController(UserManager<ApplicationUser> _userManager, IMoviesRepository _moviesRepository, ICategoryRepository category, IBiletHoleRepository _biletHoleRepository)
        {
            userManager = _userManager;
            moviesRepository = _moviesRepository;
            categoryRepository = category;
            biletHoleRepository = _biletHoleRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MoviesDetails(string title)
        {
            return View(moviesRepository.getByTitle(title));
        }

        public IActionResult Movies()
        {
            return View(moviesRepository.getAll().Where(i => i.CategoryName == "Vizyonda"));
        }
        public IActionResult UpComing()
        {
            return View(moviesRepository.getAll().Where(i => i.CategoryName == "UpComing"));
        }
        public IActionResult UpComing2020()
        {
            return View(moviesRepository.getAll().Where(i => i.CategoryName == "UpComing2020"));
        }
        [Authorize]
        public IActionResult BiletHole()
        {
            ViewBag.BiletHole = new SelectList(biletHoleRepository.getAll(), "BiletNumberId");

            return View(biletHoleRepository.getAll());
        }
        [HttpPost]
        public IActionResult TicketStatus(int BiletNumberId, Ticket biletHole)
        {
            if (ModelState.IsValid)
            {

            var user = biletHoleRepository.getAll().Where(i => i.BiletNumberId == BiletNumberId);
            /* user=>biletnumberId = 16 */
            biletHole.FullorEmpty = true;
            biletHoleRepository.UpdateCategory(biletHole);
            return RedirectToAction("BiletHole");
            }
            return RedirectToAction("BiletHole",biletHole);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
