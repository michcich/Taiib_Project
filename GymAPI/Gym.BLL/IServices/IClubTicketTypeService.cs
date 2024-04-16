using Gym.BLL.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.BLL.IServices
{
    public interface IClubTicketTypeService
    {
        Task AddClubTicketType(ClubTicketTypeDto clubTicketTypeDto);
        Task<List<ClubTicketTypeDto>> GetClubTicketTypesByClubId(int clubId);
        Task<List<ClubTicketTypeDto>> GetAllClubTicketTypes();
        Task UpdateClubTicketType(ClubTicketTypeDto clubTicketTypeDto);
        Task DeleteClubTicketType(int id);
    }
}
