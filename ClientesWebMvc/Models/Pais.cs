using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientesWebMvc.Models
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Uf> Ufs { get; set; } = new List<Uf>();

        public Pais()
        {
        }

        public Pais(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }


        public void AddUf(Uf uf)
        {
            Ufs.Add(uf);
        }

        public void RemoveUf(Uf uf)
        {
            Ufs.Remove(uf);
        }

        public double TotalDeEstados()
        {
            return Ufs.Count();
        }
    }
}
