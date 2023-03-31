namespace EscolaMVC.Models.Entities
{
    public class Professor
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public List<Turma> Turmas { get; set; }

        public Professor()
        {
        }

        public Professor(Guid id, string nome, List<Turma> turmas)
        {
            Id = id;
            Nome = nome;
            Turmas = turmas;
        }
    }
}
