using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FavoriteBand.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FavoriteBand.Controllers
{
    public class BandsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var bands = DataManager.GetAllBands();
            ViewData["Bands"] = bands;

            return View();
        }

        public IActionResult Details(int id)
        {
            var band = DataManager.GetBandById(id);
            ViewData["Band"] = band;
            return View();
        }
    }
}
