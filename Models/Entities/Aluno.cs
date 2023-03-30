namespace EscolaMVC.Models.Entities
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DataDeAniversario { get; set; }
        public string TipoSanguineo { get; set; }
        public string Complemento { get; set; }

        public Responsável Responsável { get; set; }

        public Aluno(int id, string nome, int idade, DateTime dataDeAniversario, string tipoSanguineo)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            DataDeAniversario = dataDeAniversario;
            TipoSanguineo = tipoSanguineo;
        }


    }
}
