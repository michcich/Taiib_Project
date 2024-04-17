using Gym.BLL.Dto.Ticket;
using Gym.BLL.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GymAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpPost]
        public async Task<IActionResult> AddTicket([FromBody] TicketRequestDto ticketDto)
        {
            if (ticketDto == null)
            {
                return BadRequest("Ticket data is null");
            }

            await _ticketService.AddTicket(ticketDto);
            return Ok();
        }

        [HttpGet("TicketType/{ticketTypeId}")]
        public async Task<IActionResult> GetTicketsByTicketTypeId(int ticketTypeId)
        {
            var tickets = await _ticketService.GetTicketsByTicketTypeId(ticketTypeId);
            return Ok(tickets);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTicket(int id, [FromBody] TicketRequestDto ticketDto)
        {
            if (ticketDto == null)
            {
                return BadRequest("Ticket data is null");
            }

            await _ticketService.UpdateTicket(id, ticketDto);
            return Ok();
        }
    }
}
