using ClientesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientesWebMvc.Services
{
    public class CidadeService
    {
        private readonly ClientesWebMvcContext _context;

        public CidadeService(ClientesWebMvcContext context)
        {
            _context = context;
        }

        public List<Cidade> FindaAll()
        {
            return _context.Cidade.ToList();
        }
    }
}
