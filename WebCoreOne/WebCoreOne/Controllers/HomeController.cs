using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCoreOne.Data;
using WebCoreOne.Entities;
using WebCoreOne.Services;

namespace WebCoreOne.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServicenterface _service;
        private readonly DataContext _context;

        public HomeController(IServicenterface service, DataContext context)
        {
            _service = service;
            _context = context;
        }
      /*  public  Task<ActionResult> Index()
        {
            ViewBag.myobject = _service;
            SeedData.Seed(_context);
            return View();
        }*/

       

        public IActionResult Index()
        {
            ViewBag.myobject = _service;
            SeedData.Seed(_context);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
