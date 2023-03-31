namespace EscolaMVC.Models.Entities
{
    public class Responsavel
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Contato { get; set; }

        public Responsavel(string nome, string endereco, string contato)
        {
            Nome = nome;
            Endereco = endereco;
            Contato = contato;
        }
    }
}
