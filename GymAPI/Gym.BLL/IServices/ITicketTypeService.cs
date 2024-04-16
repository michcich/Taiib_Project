using Gym.BLL.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.BLL.IServices
{
    public interface ITicketTypeService
    {
        Task<List<TicketTypeDto>> GetAllTicketTypes();
        Task<TicketTypeDto> GetTicketTypeById(int id);
        Task UpdateTicketType(TicketTypeDto ticketTypeDto);
        Task DeleteTicketType(int id);
    }
}
