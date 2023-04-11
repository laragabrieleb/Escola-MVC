using EscolaMVC.Enums;

namespace EscolaMVC.Models.Entities
{
    public class Turma
    {
        public Guid Id { get; set; }
        public int MaximoAlunos { get; set; }
        public List<Aluno> Alunos { get; set; }
        public TipoTurno Turno { get; set; }
        public Professor Professor { get; set; }
        public Guid IdProfessor { get; set; }
    }
}
