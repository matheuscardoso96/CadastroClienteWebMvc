using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientesWebMvc.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public DateTime Registro { get; set; }
        public string NomeOuRazaoSocial { get; set; }
        public string SobrenomeOUNomeFantasia { get; set; }
        public string RgOuIe { get; set; }
        public string OrGaoExpedidor { get; set; }
        public string CpfOuCpnj { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
        public ICollection<ClienteEndereco> ClienteEnderecos { get; set; } = new List<ClienteEndereco>();

        public Cliente()
        {
        }

        public Cliente(int id, DateTime registro, string nomeOuRazaoSocial, string sobrenomeOUNomeFantasia, string rgOuIe, string orGaoExpedidor, string cpfOuCpnj, TipoPessoa tipoPessoa, ICollection<ClienteEndereco> clienteEnderecos)
        {
            Id = id;
            Registro = registro;
            NomeOuRazaoSocial = nomeOuRazaoSocial;
            SobrenomeOUNomeFantasia = sobrenomeOUNomeFantasia;
            RgOuIe = rgOuIe;
            OrGaoExpedidor = orGaoExpedidor;
            CpfOuCpnj = cpfOuCpnj;
            TipoPessoa = tipoPessoa;
            ClienteEnderecos = clienteEnderecos;
        }


        public void AddClienteEnderecos(ClienteEndereco ce)
        {
            ClienteEnderecos.Add(ce);
        }

        public void RemoveClienteEnderecos(ClienteEndereco ce)
        {
            ClienteEnderecos.Remove(ce);
        }

        public double TotalDeClienteEnderecos()
        {
            return ClienteEnderecos.Count();
        }
    }
}
