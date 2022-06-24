using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasSolidFundamentos
{
    class ClienteRico
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }

        public ClienteRico(int id, string nome, string endereco)
        {
            DomainExceptionValidation.Where(id < 1, "É necessário um identificador válido!");
            DomainExceptionValidation.Where(string.IsNullOrEmpty(nome), "É necessário informar um nome!");
            DomainExceptionValidation.Where(string.IsNullOrEmpty(endereco), "É necessário informar um endereço válido!");

            this.Id = id;
            this.Nome = nome;
            this.Endereco = endereco;
        }
    }
}
