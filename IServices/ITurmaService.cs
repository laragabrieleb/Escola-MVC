using EscolaMVC.Models.Entities;

namespace EscolaMVC.IServices
{
    public interface ITurmaService
    {
        Task Create(Turma turma);
        Task<List<Turma>> List();
    }
}
