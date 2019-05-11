using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientesWebMvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClientesWebMvc.Controllers
{
    public class CidadesController : Controller
    {
        private readonly CidadeService _cidadeService;

        public CidadesController(CidadeService cidadeService)
        {
            _cidadeService = cidadeService;
        }

        public IActionResult Index()
        {
            var list = _cidadeService.FindaAll();
            return View(list);
        }
    }
}