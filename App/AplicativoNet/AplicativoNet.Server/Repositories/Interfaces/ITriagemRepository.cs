using AplicativoNet.Server.Models;

namespace AplicativoNet.Server.Repositories.Interfaces
{
    public interface ITriagemRepository
    {
        Task<IEnumerable<Triagem>> FindAll();
        Task<Triagem> FindById(int id);
        Task<bool> Create(Triagem vo);
    }
}
