using Gym.BLL.Dto.ClubTicketType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.BLL.IServices
{
    public interface IClubTicketTypeService
    {
        Task AddClubTicketType(ClubTicketTypeRequestDto clubTicketTypeDto);
        Task<List<ClubTicketTypeResponseDto>> GetClubTicketTypesByClubId(int clubId);
        Task<List<ClubTicketTypeResponseDto>> GetAllClubTicketTypes();
        Task UpdateClubTicketType(int id, ClubTicketTypeRequestDto clubTicketTypeDto);
        Task DeleteClubTicketType(int id);
    }
}
