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
            DomainExceptionValidation.Where(id < 1, ErrorMessages.INVALID_ID);
            DomainExceptionValidation.Where(string.IsNullOrEmpty(nome), ErrorMessages.INVALID_NOME);
            DomainExceptionValidation.Where(string.IsNullOrEmpty(endereco), ErrorMessages.INVALID_ENDERECO);

            this.Id = id;
            this.Nome = nome;
            this.Endereco = endereco;
        }
    }
}
