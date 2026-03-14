using DBFirst_Car_Site.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DBFirst_Car_Site.Data;
using DBFirst_Car_Site.Models;

namespace DBFirst_Car_Site.Controllers
{
    public class SearchController : Controller
    {
        private readonly DbfirstCarsSiteContext _context;

        public SearchController(DbfirstCarsSiteContext context)
        {
            _context = context;
        }

        public IActionResult Index(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                return View(new List<Car>());
            }

            var results = _context.Cars
                .Where(c => c.Model.Contains(query) || c.Brand.Contains(query))
                .ToList();

            return View(results);
        }
    }
}
