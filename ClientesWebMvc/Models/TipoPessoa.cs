using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientesWebMvc.Models
{
    public class TipoPessoa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

        public TipoPessoa()
        {
        }

        public TipoPessoa(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public void AddCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
        }

        public void RemoveCliente(Cliente cliente)
        {
            Clientes.Remove(cliente);
        }

        public double TotalDeTipoPessoa()
        {
            return Clientes.Count();
        }
    }




}
