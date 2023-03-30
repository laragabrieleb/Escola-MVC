namespace EscolaMVC.Models.Entities
{
    public class Responsável
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Contato { get; set; }

        public Responsável(string nome, string endereco, string contato)
        {
            Nome = nome;
            Endereco = endereco;
            Contato = contato;
        }
    }
}
