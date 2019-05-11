using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientesWebMvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClientesWebMvc.Controllers
{
    public class ClienteEnderecosController : Controller
    {
        public readonly ClienteEnderecoService _clienteEnderecoService;

        public ClienteEnderecosController(ClienteEnderecoService clienteEnderecoService)
        {
            _clienteEnderecoService = clienteEnderecoService;
        }

        public IActionResult Index()
        {
            var list = _clienteEnderecoService.FindAll();
            return View(list);
        }
    }
}