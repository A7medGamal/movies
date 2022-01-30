using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movies.Models;


namespace movies.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _Context;
        public MoviesController(ApplicationDbContext context)
        {
            _Context = context;

        }
        public async Task <IActionResult> Index()
        {
            var moveis = await _Context.Movies.ToListAsync();
            return View(moveis);
        }
    }
}
