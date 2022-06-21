using exemploAPI.Context;
using Microsoft.AspNetCore.Mvc;
using exemploAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace exemploAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class NCMController : ControllerBase
    {
        private readonly ConexaoDBS _context;

        public NCMController(ConexaoDBS context)
        {
            _context = context;
        }

        /// <summary>
        /// Busca todos os NCM.
        /// </summary>
        /// <returns>200</returns>
        [HttpGet("todos")]
        public IActionResult Get()
        {
            var ncms = _context.NCMs;
            return Ok(ncms);
        }

        /// <summary>
        /// Adicionar.
        /// </summary>
        /// <returns>200</returns>
        [HttpPost("Adicionar")]
        public async Task<IActionResult> Post([FromBody]NCM nCM)
        {
            _context.Add(nCM);
            await _context.SaveChangesAsync();
            return Ok(nCM);
        }

        [HttpPut("Atualizar")]
        public async Task<IActionResult> Put(NCM nCM)
        {

           
          
            {
                if (!NCMExists(nCM.id))
                    return NotFound();
                else
                {
                    return NotFound();
                }

            }

        }

        private bool NCMExists(object id)
        {
            throw new NotImplementedException();
        }




        /// <summary>
        /// Busca por descrição.
        /// </summary>
        /// <returns>200</returns>
        [HttpGet("por-descricao")]
        public IActionResult GetByDescricao(string descricao)
        {
            var ncms = _context.NCMs.Where(x => x.Descricao.Contains(descricao));
            return Ok(ncms);
        }

        [HttpGet("por-codigo")]
        public IActionResult GetBycodigo(string codigo)
        {
            var ncm = _context.NCMs.FirstOrDefault(x => x.Codigo == codigo);
            return Ok(ncm);
        }
    }
}
