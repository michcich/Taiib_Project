using Gym.BLL.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.BLL.IServices
{
    public interface IReservationService
    {
        Task AddReservation(ReservationDto reservationDto);
        Task<List<ReservationDto>> GetReservationsByUserId(string userId);
        Task<List<ReservationDto>> GetReservationsByClassId(int classId);
        Task DeleteReservation(int id);
    }
}
