using EscolaMVC.Enums;

namespace EscolaMVC.Models.Entities
{
    public class Turma
    {
        public Guid Id { get; set; }
        public List<Aluno> Alunos { get; set; }
        public TipoTurno Turno { get; set; }

        public Turma()
        {
        }

        public Turma(Guid id, List<Aluno> alunos, TipoTurno turno)
        {
            Id = id;
            Alunos = alunos;
            Turno = turno;
        }
    }
}
