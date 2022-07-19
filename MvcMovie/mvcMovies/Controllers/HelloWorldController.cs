﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace mvcMovies.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        //Get: /HelloWorld/
        
        public IActionResult Index()
        {
            return View();
        }

        //
        // Get: /HelloWorld/Welcome/

        public IActionResult Welcome(string name , int numTimes = 1)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
