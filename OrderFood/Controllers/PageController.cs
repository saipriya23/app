using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderFood.Models;

namespace OrderFood.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Create()
        {
            var model = new Restaurant { id = 1, name = "swagath" };
            //return new ObjectResult (model);
            return View(model);
        }
    }
}