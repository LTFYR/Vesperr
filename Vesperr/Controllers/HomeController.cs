using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Vesperr.DAL;
using Vesperr.Models;

namespace Vesperr.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Services> list = _context.Services.ToList();
            return View(list);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Services services = _context.Services.FirstOrDefault(x => x.Id == id);
            return View(services);
        }
    }
}
