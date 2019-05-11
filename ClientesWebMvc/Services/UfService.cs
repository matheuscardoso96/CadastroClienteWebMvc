using ClientesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientesWebMvc.Services
{
    public class UfService
    {
        private readonly ClientesWebMvcContext _context;

        public UfService(ClientesWebMvcContext context)
        {
            _context = context;
        }

        public List<Uf> FindAll()
        {
            return _context.Uf.ToList();
        }
    }
}
