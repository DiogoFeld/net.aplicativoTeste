using AplicativoNet.Server.Models;

namespace AplicativoNet.Server.Repositories.Interfaces
{
    public interface IPacienteRepository
    {
        Task<IEnumerable<Paciente>> FindAll();
        Task<Paciente> FindById(int id);
        Task<bool> Create(Paciente vo);
    }
}
