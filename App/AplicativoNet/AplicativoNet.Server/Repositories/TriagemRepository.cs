using AplicativoNet.Server.Context;
using AplicativoNet.Server.Controllers;
using AplicativoNet.Server.Models;
using AplicativoNet.Server.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AplicativoNet.Server.Repositories
{
    public class TriagemRepository : ITriagemRepository
    {
        private readonly AppDBContext _context;

        public TriagemRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task<bool> Create(Triagem obj)
        {
            _context.Triagems.Add(obj);
            bool changes = await _context.SaveChangesAsync() > 0;

            return changes;
        }

        public async Task<IEnumerable<Triagem>> FindAll()
        {
            return await _context.Triagems.ToListAsync();
        }

        public async Task<Triagem> FindById(int id)
        {
            return await _context.Triagems.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
