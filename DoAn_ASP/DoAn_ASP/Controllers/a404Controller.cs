﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DoAn_ASP.Controllers
{
    public class a404Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
