using EscolaMVC.Models.Entities;

namespace EscolaMVC.IServices
{
    public interface IAlunoService
    {
        Task Create(Aluno aluno);
        Task<List<Aluno>> List();
    }
}
