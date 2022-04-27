using ISS.Controllers.Interfaces;
using ISS.Models;
using ISS.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ISS.Controllers
{

    [ApiController]
    [Route("api/v1/enterprise")]
    public class EnterpriseController : ControllerBase
    {
        private readonly EnterpriseRepository _repository;

        public EnterpriseController(EnterpriseRepository repository)
        {
            _repository = repository;
        }


        [HttpPost()]
        public async Task<ActionResult<Enterprise>> Create([FromBody] Enterprise enterprise)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var newEnterprise = await _repository.Insert(enterprise);

            return Created("Add", newEnterprise);
        }

        [HttpGet]
        public async Task<ActionResult<List<Enterprise>>> GetAll()
        {

            return Ok(await _repository.SelectAll());

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Enterprise>> GetById([FromRoute] Guid id)
        {
            Enterprise enterpriseLocalized = await _repository.SelectById(id);

            if (enterpriseLocalized == null) return NotFound();

            return Ok(enterpriseLocalized);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Enterprise>> Update([FromRoute] Guid id, [FromBody] Enterprise enterprise)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            Enterprise enterpriseLocalized = await _repository.SelectById(id);

            if (enterpriseLocalized == null) return NotFound();

            var enterpriseUpdated = await _repository.Update(enterprise);

            return Ok(enterpriseUpdated);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete([FromRoute] Guid id)
        {
            await _repository.Detele(id);

            return Ok();

        }

    }


}