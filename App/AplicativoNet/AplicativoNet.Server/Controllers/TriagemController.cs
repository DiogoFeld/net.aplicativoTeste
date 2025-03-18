using AplicativoNet.Server.Models;
using AplicativoNet.Server.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AplicativoNet.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TriagemController : ControllerBase
    {
        private ITriagemRepository _triagemRepository;

        public TriagemController(ITriagemRepository triagemRepository)
        {
            _triagemRepository = triagemRepository ??
                throw new ArgumentNullException(nameof(triagemRepository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Triagem>>> FindAll()
        {
            var triagems = await _triagemRepository.FindAll();
            return Ok(triagems);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Triagem>> FindById(int id)
        {
            var triagem = await _triagemRepository.FindById(id);
            if (triagem == null) return NotFound();
            return Ok(triagem);
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Create(Triagem vo)
        {
            if (vo == null) return BadRequest();
            var triagemCreated = await _triagemRepository.Create(vo);
            return Ok(triagemCreated);
        }


    }
}
