using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PublicationManager.Models;
using Jr.PublicationLibrary;

namespace PublicationManager.Controllers
{
    public class HomeController : Controller
    {
        private publicationRepo _publicationRepo = new publicationRepo();
        private object publicationRepo;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            var myMagasine = new Magasine
            {
                Year = 2015,
                Author = "Bruce Adams",
                Title = "Criket Magasine",
                EditionMonth = "January",
                SuscriptionPrice = 50
            };

            _publicationRepo.Add(myMagasine);
            return View(myMagasine);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
