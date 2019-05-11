using ClientesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientesWebMvc.Services
{
    public class ClienteService
    {
        private readonly ClientesWebMvcContext _context;

        public ClienteService(ClientesWebMvcContext context)
        {
            _context = context;
        }

        public List<Cliente> FindAll()
        {
            return _context.Cliente.ToList();
        }
    }
}
