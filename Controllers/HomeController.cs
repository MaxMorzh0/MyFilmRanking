using Microsoft.AspNetCore.Mvc;
using MyFilmRanking.Models;
using MyFilmRanking.Models.ModelContext;
using Microsoft.AspNetCore.Authorization;

namespace MyFilmRanking.Controllers
{
    public class HomeController : Controller
    {
        private readonly FilmContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(FilmContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }
        public IActionResult Main()
        {
            var randomFilm = _context.Films.OrderBy(f => Guid.NewGuid()).FirstOrDefault();
            return View(randomFilm);
        }
        public IActionResult List()
        {
            var films = _context.Films.ToList();
            return View(films);
        }
        public IActionResult Film(int id)
        {
            var film = _context.Films.FirstOrDefault(f => f.Id == id);

            if (film == null)
            {
                return RedirectToAction("Main");
            }

            return View(film);
        }
        [Authorize]
        [HttpGet]
        public IActionResult AddFilm()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public IActionResult AddFilm(Film film)
        {
            film.Id = _context.Films.ToList().Last().Id + 1;
            _context.Films.Add(film);
            _context.SaveChanges();

            return RedirectToAction("List");
        }
    }
}
