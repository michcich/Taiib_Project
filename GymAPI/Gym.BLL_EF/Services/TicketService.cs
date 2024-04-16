using AutoMapper;
using Gym.BLL.Dto;
using Gym.BLL.IRepositories;
using Gym.BLL.IServices;
using Gym.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.BLL_EF.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper _mapper;

        public TicketService(ITicketRepository ticketRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }

        public async Task AddTicket(TicketDto ticketDto)
        {
            var ticket = _mapper.Map<Ticket>(ticketDto);
            await _ticketRepository.CreateAsync(ticket);
        }

        public async Task<List<TicketDto>> GetTicketsByTicketTypeId(int ticketTypeId)
        {
            var tickets = await _ticketRepository.GetTicketsByTicketTypeId(ticketTypeId);
            return _mapper.Map<List<TicketDto>>(tickets);
        }

        public async Task UpdateTicket(TicketDto ticketDto)
        {
            var ticket = await _ticketRepository.GetByIdAsync(ticketDto.Id);
            if (ticket != null)
            {
                _mapper.Map(ticketDto, ticket);
                _ticketRepository.Update(ticket);
            }
        }
    }
}
