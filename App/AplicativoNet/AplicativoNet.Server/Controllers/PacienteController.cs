using AplicativoNet.Server.Models;
using AplicativoNet.Server.Repositories;
using AplicativoNet.Server.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AplicativoNet.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : ControllerBase
    {
        private  IPacienteRepository _pacientRepository;
        public PacienteController(IPacienteRepository repository)
        {
            _pacientRepository = repository ??
                throw new ArgumentNullException(nameof(repository));
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Paciente>>> FindAll()
        {
            var pacientes = await _pacientRepository.FindAll();
            return Ok(pacientes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Paciente>> FindById(int id)
        {
            var paciente = await _pacientRepository.FindById(id);
            if (paciente == null) return NotFound();
            return Ok(paciente);
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Create([FromBody] Paciente vo)
        {
            if (vo == null) return BadRequest();
            var pacienteCreated = await _pacientRepository.Create(vo);
            return Ok(pacienteCreated);
        }


    }
}
