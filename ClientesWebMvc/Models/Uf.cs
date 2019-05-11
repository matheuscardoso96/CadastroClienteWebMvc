using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientesWebMvc.Models
{
    public class Uf
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Pais Pais { get; set; }
        public ICollection<Cidade> Cidades { get; set; } = new List<Cidade>();

        public Uf()
        {
        }

        public Uf(int id, string descricao, Pais pais)
        {
            Id = id;
            Descricao = descricao;
            Pais = pais;
        }

        public void AddCidade(Cidade cidade)
        {
            Cidades.Add(cidade);
        }

        public void RemoveCidade(Cidade cidade)
        {
            Cidades.Remove(cidade);
        }

        public double TotalDeCidades()
        {
            return Cidades.Count();
        }
    }
}
