using AplicativoNet.Server.Models;
using AplicativoNet.Server.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AplicativoNet.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtendimentoController : ControllerBase
    {
        private IAtendimentoRepository _atendimentoRepository;

        public AtendimentoController(IAtendimentoRepository atendimentoRepository)
        {
            _atendimentoRepository = atendimentoRepository 
                ?? throw new ArgumentNullException(nameof(atendimentoRepository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Atendimento>>> FindAll()
        {
            var atendimentos = await _atendimentoRepository.FindAll();
            return Ok(atendimentos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Atendimento>> FindById(int  id)
        {
            var atendimento = await _atendimentoRepository.FindById(id);
            if (atendimento == null) return NotFound();
            return Ok(atendimento);
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Create(Atendimento vo)
        {
            if (vo == null) return BadRequest();
            var atendimentoCreated = await _atendimentoRepository.Create(vo);
            return Ok(atendimentoCreated);
        }




    }
}
