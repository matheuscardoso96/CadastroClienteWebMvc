using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientesWebMvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClientesWebMvc.Controllers
{
    public class UfsController : Controller
    {
        private readonly UfService _ufService;

        public UfsController(UfService ufService)
        {
            _ufService = ufService;
        }

        public IActionResult Index()
        {
            var list = _ufService.FindAll();
            return View(list);
        }
    }
}