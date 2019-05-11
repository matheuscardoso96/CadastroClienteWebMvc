using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientesWebMvc.Models
{
    public class TipoEndereco
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public ICollection<ClienteEndereco> ClienteEnderecos { get; set; } = new List<ClienteEndereco>();

        public TipoEndereco()
        {
        }

        public TipoEndereco(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public void AddClienteEnderecos(ClienteEndereco ce)
        {
            ClienteEnderecos.Add(ce);
        }

        public void RemoveClienteEnderecos(ClienteEndereco ce)
        {
            ClienteEnderecos.Remove(ce);
        }
    }
}

