using ClientesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientesWebMvc.Services
{
    public class ClienteEnderecoService
    {
        public readonly ClientesWebMvcContext _context;

        public ClienteEnderecoService(ClientesWebMvcContext context)
        {
            _context = context;
        }

        public List<ClienteEndereco> FindAll()
        {
            return _context.ClienteEndereco.ToList();
        }
    }
}
