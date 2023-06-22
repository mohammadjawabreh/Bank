using Bank.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;

namespace Bank.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ModelContext _context;

        public HomeController(ILogger<HomeController> logger,ModelContext context )
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {

            var Homepage = _context.Homepages.ToList(); 
            var Testimonial = _context.Testimonials.ToList();
            var Aboutu = _context.Aboutus.ToList();

            var model = Tuple.Create<IEnumerable<Homepage>,IEnumerable<Testimonial>,
            IEnumerable<Aboutu>>(Homepage,Testimonial, Aboutu);

            return View(model);








        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}