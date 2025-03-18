using AplicativoNet.Server.Context;
using AplicativoNet.Server.Models;
using AplicativoNet.Server.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AplicativoNet.Server.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly AppDBContext _context;

        public PacienteRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task<bool> Create(Paciente obj)
        {
            _context.Pacientes.Add(obj);
            bool changes = await _context.SaveChangesAsync() > 0;

            return changes;
        }

        public async Task<IEnumerable<Paciente>> FindAll()
        {
            return await _context.Pacientes.ToListAsync();
        }

        public async Task<Paciente> FindById(int id)
        {
            return await _context.Pacientes.FirstOrDefaultAsync(x => x.Id == id);
        }

    }
}
