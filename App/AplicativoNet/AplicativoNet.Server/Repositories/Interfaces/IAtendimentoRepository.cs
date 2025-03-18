using AplicativoNet.Server.Models;

namespace AplicativoNet.Server.Repositories.Interfaces
{
    public interface IAtendimentoRepository
    {
        Task<IEnumerable<Atendimento>> FindAll();
        Task<Atendimento> FindById(int id);
        Task<bool> Create(Atendimento vo);
    }
}
