using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientesWebMvc.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Uf uf { get; set; }
        public ICollection<ClienteEndereco> ClienteEnderecos { get; set; } = new List<ClienteEndereco>();

        public Cidade()
        {
        }

        public Cidade(int id, string descricao, Uf uf)
        {
            Id = id;
            Descricao = descricao;
            this.uf = uf;
        }

        public void AddClienteEnderecos(ClienteEndereco ce)
        {
            ClienteEnderecos.Add(ce);
        }

        public void RemoveClienteEnderecos(ClienteEndereco ce)
        {
            ClienteEnderecos.Remove(ce);
        }

        public double TotalDeClientesEnderecos()
        {
            return ClienteEnderecos.Count();
        }
    }
}
