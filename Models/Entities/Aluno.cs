namespace EscolaMVC.Models.Entities
{
    public class Aluno
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Turma Turma { get; set; }
        public Guid IdTurma { get; set; }
        public int Idade { get; set; }
        public DateTime DataDeAniversario { get; set; }
        public string TipoSanguineo { get; set; }
        public string Complemento { get; set; }
        public Responsavel Responsavel { get; set; }
        public Guid IdResponsavel { get; set; }
    }
}