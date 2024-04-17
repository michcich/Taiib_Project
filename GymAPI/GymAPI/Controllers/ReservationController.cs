using Gym.BLL.Dto;
using Gym.BLL.Dto.Reservation;
using Gym.BLL.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GymAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpPost]
        public async Task<IActionResult> AddReservation([FromBody] ReservationRequestDto reservationDto)
        {
            if (reservationDto == null)
            {
                return BadRequest("Reservation data is null");
            }

            await _reservationService.AddReservation(reservationDto);
            return Ok();
        }

        [HttpGet("UserId/{userId}")]
        public async Task<IActionResult> GetReservationsByUserId([FromRoute]string userId, [FromQuery] PageProperties pageProperties)
        {
            var reservations = await _reservationService.GetReservationsByUserId(userId, pageProperties);
            return Ok(reservations);
        }

        [HttpGet("ClassId/{classId}")]
        public async Task<IActionResult> GetReservationsByClassId([FromRoute]int classId, [FromQuery] PageProperties pageProperties)
        {
            var reservations = await _reservationService.GetReservationsByClassId(classId, pageProperties);
            return Ok(reservations);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReservation(int id)
        {
            await _reservationService.DeleteReservation(id);
            return Ok();
        }
    }
}
