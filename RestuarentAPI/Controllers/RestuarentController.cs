using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestuarentAPI.Application.Restuarent.Commands.CreateRestuarent;
using RestuarentAPI.Application.Restuarent.Queries.GetAllRestuarents;
using RestuarentAPI.Application.Restuarent.Queries.GetRestuarentById;
using RestuarentAPI.Domain.Entities;

namespace RestuarentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestuarentController : BaseController
    {

        [HttpGet]
        public async Task<IActionResult> GetAllRestuarent()
        {
            var restuarents= await Mediator.Send(new GetAllRestuarentsQuery());

            if(restuarents == null)
            {
                return NotFound();
            }

            return Ok(restuarents);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetRestuarentById(int id)
        {
            var restuarent =await Mediator.Send(new GetRestuarentByIdQuery() { Id = id});
            if (restuarent == null)
            {
                return NotFound();
            }

            return Ok(restuarent);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRestuarent(CreateRestuarentCommand restuarent)
        {
            try
            {
                await Mediator.Send(restuarent);
                return Ok(CreatedAtAction(nameof(GetRestuarentByIdQuery), restuarent));
        }
            catch (Exception ex)
            {
                // Log the exception if needed
                return StatusCode(500,ex.Message);
    }
}

    }
}
