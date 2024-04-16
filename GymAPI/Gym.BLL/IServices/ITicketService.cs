using Gym.BLL.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.BLL.IServices
{
    public interface ITicketService
    {
        Task AddTicket(TicketDto ticketDto);
        Task<List<TicketDto>> GetTicketsByTicketTypeId(int ticketTypeId);
        Task UpdateTicket(TicketDto ticketDto);
    }
}
