using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientesWebMvc.Models;

namespace ClientesWebMvc.Data
{
    public class SeedingService
    {
        private ClientesWebMvcContext _context;

        public SeedingService(ClientesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Cidade.Any() ||
                _context.Cliente.Any() ||
                _context.ClienteEndereco.Any() ||
                _context.Pais.Any() ||
                _context.TipoEndereco.Any() ||
                _context.TipoPessoa.Any() ||
                _context.Uf.Any()
                )
            {
                return; //Banco de dados já foi populado
            }


            //Criar Tipos de Endereços
            TipoEndereco tipoEndereco1 = new TipoEndereco(1, "Residêncial");
            TipoEndereco tipoEndereco2 = new TipoEndereco(2, "Comercial");
            TipoEndereco tipoEndereco3 = new TipoEndereco(3, "Correspondência");
            TipoEndereco tipoEndereco4 = new TipoEndereco(4, "Entrega");
            TipoEndereco tipoEndereco5 = new TipoEndereco(5, "Recado");
            TipoEndereco tipoEndereco6 = new TipoEndereco(6, "Outros");

            //Criar Tipos de Pessoa
            TipoPessoa tipoPessoa1 = new TipoPessoa(1, "Física");
            TipoPessoa tipoPessoa2 = new TipoPessoa(2, "Jurídicas");

            //Criar Paises
            Pais p1 = new Pais(1, "Estados Unidos");
            Pais p2 = new Pais(55, "Brasil");
            Pais p3 = new Pais(61, "Austrália");

            //Criar Estados
            Uf uf1 = new Uf(1, "AC", "ACRE", p2);
            Uf uf2 = new Uf(2, "AL", "ALAGOAS", p2);
            Uf uf3 = new Uf(3, "AP", "AMAPÁ", p2);
            Uf uf4 = new Uf(4, "AM", "AMAZONAS", p2);
            Uf uf5 = new Uf(5, "BA", "BAHIA", p2);
            Uf uf6 = new Uf(6, "CE", "CEARÁ", p2);
            Uf uf7 = new Uf(7, "DF", "DISTRITO FEDERAL", p2);
            Uf uf8 = new Uf(8, "ES", "ESPÍRITO SANTO", p2);
            Uf uf9 = new Uf(9, "GO", "GOIÁS", p2);
            Uf uf10 = new Uf(10, "MA", "MARANHÃO", p2);
            Uf uf11 = new Uf(11, "MT", "MATO GROSSO", p2);
            Uf uf12 = new Uf(12, "MS", "MATO GROSSO DO SUL", p2);
            Uf uf13 = new Uf(13, "MG", "MINAS GERAIS", p2);
            Uf uf14 = new Uf(14, "PA", "PARÁ", p2);
            Uf uf15 = new Uf(15, "PB", "PARAÍBA", p2);
            Uf uf16 = new Uf(16, "PR", "PARANÁ", p2);
            Uf uf17 = new Uf(17, "PE", "PERNAMBUCO", p2);
            Uf uf18 = new Uf(18, "PI", "PIAUÍ", p2);
            Uf uf19 = new Uf(19, "RJ", "RIO DE JANEIRO", p2);
            Uf uf20 = new Uf(20, "RN", "RIO GRANDE DO NORTE", p2);
            Uf uf21 = new Uf(21, "RS", "RIO GRANDE DO SUL", p2);
            Uf uf22 = new Uf(22, "RO", "RONDÔNIA", p2);
            Uf uf23 = new Uf(23, "RR", "RORAIMA", p2);
            Uf uf24 = new Uf(24, "SC", "SANTA CATARINA", p2);
            Uf uf25 = new Uf(25, "SP", "SÃO PAULO", p2);
            Uf uf26 = new Uf(26, "SE", "SERGIPE", p2);
            Uf uf27 = new Uf(27, "TO", "TOCANTINS", p2);

            //Criar Cidades
            Cidade cidade1 = new Cidade(1, "Rio Branco", uf1);
            Cidade cidade2 = new Cidade(2, "Maceió", uf2);
            Cidade cidade3 = new Cidade(3, "Macapá", uf3);
            Cidade cidade4 = new Cidade(4, "Manaus", uf4);
            Cidade cidade5 = new Cidade(5, "Salvador", uf5);
            Cidade cidade6 = new Cidade(6, "Fortaleza", uf6);
            Cidade cidade7 = new Cidade(7, "Brasília", uf7);
            Cidade cidade8 = new Cidade(8, "Vitória", uf8);
            Cidade cidade9 = new Cidade(9, "Goiânia", uf9);
            Cidade cidade10 = new Cidade(10, "São Luís", uf10);
            Cidade cidade11 = new Cidade(11, "Cuiabá", uf11);
            Cidade cidade12 = new Cidade(12, "Campo Grande", uf12);
            Cidade cidade13 = new Cidade(13, "Belo Horizonte", uf13);
            Cidade cidade14 = new Cidade(14, "Belém", uf14);
            Cidade cidade15 = new Cidade(15, "João Pessoa", uf15);
            Cidade cidade16 = new Cidade(16, "Curitiba", uf16);
            Cidade cidade17 = new Cidade(17, "Recife", uf17);
            Cidade cidade18 = new Cidade(18, "Teresina", uf18);
            Cidade cidade19 = new Cidade(19, "Rio de Janeiro", uf19);
            Cidade cidade20 = new Cidade(20, "Natal", uf20);
            Cidade cidade21 = new Cidade(21, "Porto Alegre", uf21);
            Cidade cidade22 = new Cidade(22, "Porto Velho", uf22);
            Cidade cidade23 = new Cidade(23, "Vista", uf23);
            Cidade cidade24 = new Cidade(24, "Florianópolis", uf24);
            Cidade cidade25 = new Cidade(25, "São Paulo", uf25);
            Cidade cidade26 = new Cidade(26, "Aracaju", uf26);
            Cidade cidade27 = new Cidade(27, "Tocantins", uf27);
            Cidade cidade28 = new Cidade(28, "Aparecida de Goiânia", uf9);


            //Criar Clientes
            Cliente cliente1 = new Cliente(1, DateTime.Now, new DateTime(1996, 10, 17), "Daniel", "Blue", "000000000", "SSPGO", "10000000000", tipoPessoa1);
            Cliente cliente2 = new Cliente(2, DateTime.Now, new DateTime(1989, 08, 06), "Vicente", "Red", "100000000", "SSPSP", "20000000000", tipoPessoa1);
            Cliente cliente3 = new Cliente(3, DateTime.Now, new DateTime(1994, 01, 30), "Faculdade São João Ribeiro", "FSJR", "1200000000", "SSPSP", "89000000000000", tipoPessoa2);


            //Criar Endereços
            ClienteEndereco endereco1 = new ClienteEndereco(1, "Rua A", "1", "Quadra 1 Lote 1", "Garavelo", "70000030", "Igreja", cidade28, tipoEndereco1, cliente1);
            ClienteEndereco endereco2 = new ClienteEndereco(2, "Rua B", "2", "Quadra 20 Lote 10", "Setor Pedro Ludovico", "70000010", "Padaria", cidade9, tipoEndereco1, cliente2);
            ClienteEndereco endereco3 = new ClienteEndereco(3, "Rua C", "3", "Quadra 15 Lote 1 ao 10", "Papillon Park", "70000033", "Supermercado", cidade28, tipoEndereco2, cliente3);

            _context.TipoEndereco.AddRange(tipoEndereco1, tipoEndereco2, tipoEndereco3, tipoEndereco4,
                                           tipoEndereco5, tipoEndereco6);

            _context.TipoPessoa.AddRange(tipoPessoa1, tipoPessoa2);

            _context.Pais.AddRange(p1, p2, p3);

            _context.Uf.AddRange(uf1, uf2, uf3, uf4, uf5, uf6, uf7, uf8, uf9, uf10, uf11, uf12, uf13, uf14,
                                uf15, uf16, uf17, uf18, uf19, uf20, uf21, uf22, uf23, uf24, uf25, uf26, uf27);

            _context.Cidade.AddRange(cidade1, cidade2, cidade3, cidade4, cidade5, cidade6, cidade7,
                                    cidade8, cidade9, cidade10, cidade11, cidade12, cidade13, cidade14,
                                    cidade15, cidade16, cidade17, cidade18, cidade19, cidade20, cidade21,
                                    cidade22, cidade23, cidade24, cidade25, cidade26, cidade27);

            _context.Cliente.AddRange(cliente1, cliente1, cliente1);

            _context.ClienteEndereco.AddRange(endereco1,endereco2,endereco3);

            _context.SaveChanges();
        }
    }
}
