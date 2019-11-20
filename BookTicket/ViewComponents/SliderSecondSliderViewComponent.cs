using BookTicket.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTicket.ViewComponents
{
    public class SliderSecondSliderViewComponent : ViewComponent
    {
        private IMoviesRepository moviesRepository;

        public SliderSecondSliderViewComponent(IMoviesRepository _moviesRepository)
        {
            moviesRepository = _moviesRepository;
        }
        public IViewComponentResult Invoke()
        {
            return View(moviesRepository.getAll().Where(i=>i.IsSliderLogin2));
        }
    }
}
