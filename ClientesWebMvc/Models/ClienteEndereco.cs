using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientesWebMvc.Models
{
    public class ClienteEndereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Referencia { get; set; }
        public Cidade Cidade { get; set; }
        public TipoEndereco TipoEndereco { get; set; }
        public Cliente Cliente { get; set; }

        public ClienteEndereco()
        {
        }

        public ClienteEndereco(int id, string logradouro, string numero, string complemento, string bairro, string cep, string referencia, Cidade cidade, TipoEndereco tipoEndereco, Cliente cliente)
        {
            Id = id;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cep = cep;
            Referencia = referencia;
            Cidade = cidade;
            TipoEndereco = tipoEndereco;
            Cliente = cliente;
        }
    }
}
