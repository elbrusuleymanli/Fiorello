using Fiorello.DAL;
using Fiorello.Models;
using Fiorello.VM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorello.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            HomeVM model = new HomeVM
            {
                Sliders = _context.Sliders.OrderBy(s => s.Order).ToList(),
                Experts = _context.Experts.Include(e=>e.Position).Take(4).ToList(),
                ExpertsOwl = _context.ExpertsOwl.Include(e => e.Position).OrderBy(e=>e.Order).ToList()
            };
            return View(model);
        }

     

  
    }
}
