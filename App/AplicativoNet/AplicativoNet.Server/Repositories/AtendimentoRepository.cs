using AplicativoNet.Server.Context;
using AplicativoNet.Server.Models;
using AplicativoNet.Server.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AplicativoNet.Server.Repositories
{
    public class AtendimentoRepository : IAtendimentoRepository
    {
        private readonly AppDBContext _context;

        public AtendimentoRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task<bool> Create(Atendimento obj)
        {
            _context.Atendimentos.Add(obj);
            bool changes = await _context.SaveChangesAsync() > 0;

            return changes;
        }

        public async Task<IEnumerable<Atendimento>> FindAll()
        {
            return await _context.Atendimentos.ToListAsync();            
        }

        public async Task<Atendimento> FindById(int id)
        {
            return await _context.Atendimentos.FirstOrDefaultAsync(x => x.Id == id);            
        }



    }
}
