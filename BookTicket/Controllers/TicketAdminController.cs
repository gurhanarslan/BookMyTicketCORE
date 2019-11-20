using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BookTicket.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookTicket.Controllers
{ 
    [Authorize]
    public class TicketAdminController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        private IMoviesRepository moviesRepository;
        private ICategoryRepository categoryRepository;
        public TicketAdminController(UserManager<ApplicationUser> _userManager,IMoviesRepository _moviesRepository,ICategoryRepository category)
        {
            userManager = _userManager;
            moviesRepository = _moviesRepository;
            categoryRepository = category;
        }


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllMovies()
        {
            return View(moviesRepository.getAll());
        }
        public IActionResult Movies()
        {
            return View(moviesRepository.getAll().Where(i=>i.CategoryName=="Vizyonda"));
        }
        public IActionResult UpComing()
        {
            return View(moviesRepository.getAll().Where(i=>i.CategoryName=="UpComing"));
        }
        public IActionResult UpComing2020()
        {
            return View(moviesRepository.getAll().Where(i=>i.CategoryName=="UpComing2020"));
        }
        public IActionResult Slider()
        {
            return View(moviesRepository.getAll().Where(i=>i.IsSliderLogin1 || i.IsSliderLogin2 || i.IsSliderHome));
        }
        public IActionResult UserList()
        {
            return View(userManager.Users);
        }

        [HttpGet]
        public IActionResult MoviesCreate()
        {
            ViewBag.Categories = new SelectList(categoryRepository.getAll(), "CategoryId", "CategoryName");
            return View();
        }
        [HttpPost]
        public  IActionResult MoviesCreate(Movies movies)
        {


       
            if (ModelState.IsValid)
            {
                moviesRepository.CreateMovies(movies);
                return RedirectToAction("AllMovies");
            }
            return View(movies);
        }
        [HttpPost]
        public IActionResult MoviesDelete(int id)
        {
            moviesRepository.DeleteMovies(id);
            return RedirectToAction("Index");

        }
        public IActionResult MoviesUpdate(int id)
        {
            ViewBag.Categories = new SelectList(categoryRepository.getAll(), "CategoryId", "CategoryName");
            return View(moviesRepository.getById(id));
        }
        [HttpPost]
        public async Task<IActionResult> MoviesUpdate(Movies blog, IFormFile file)
        {

            
            if (ModelState.IsValid)
            {

                if (file != null)
                {


                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", file.FileName);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    blog.Image = file.FileName;
                }
                moviesRepository.UpdateMovies(blog);
                return RedirectToAction("Index");

            }

            return RedirectToAction("Index");
        }
    }
}