﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ClientesWebMvc.Controllers
{
    public class ClienteEnderecosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}