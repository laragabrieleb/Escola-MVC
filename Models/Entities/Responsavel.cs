using System;

namespace EscolaMVC.Models.Entities
{
    public class Responsavel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Contato { get; set; }

        public Responsavel(Guid id, string nome, string endereco, string contato)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Contato = contato;
        }
    }
}
