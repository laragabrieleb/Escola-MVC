using EscolaMVC.Enums;

namespace EscolaMVC.Models.Entities
{
    public class Turma
    {
        public List<Aluno> Alunos { get; set; }
        public TipoTurno Turno { get; set; }

        public Turma()
        {
        }
    }
}
