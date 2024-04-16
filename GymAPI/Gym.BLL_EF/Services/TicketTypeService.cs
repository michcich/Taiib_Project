using AutoMapper;
using Gym.BLL.Dto;
using Gym.BLL.IRepositories;
using Gym.BLL.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.BLL_EF.Services
{
    public class TicketTypeService : ITicketTypeService
    {
        private readonly ITicketTypeRepository _ticketTypeRepository;
        private readonly IMapper _mapper;

        public TicketTypeService(ITicketTypeRepository ticketTypeRepository, IMapper mapper)
        {
            _ticketTypeRepository = ticketTypeRepository;
            _mapper = mapper;
        }

        public async Task DeleteTicketType(int id)
        {
            var ticketType = await _ticketTypeRepository.GetByIdAsync(id);
            if (ticketType != null)
            {
                _ticketTypeRepository.Delete(ticketType);
            }
        }

        public async Task<List<TicketTypeDto>> GetAllTicketTypes()
        {
            var ticketTypes = await _ticketTypeRepository.GetAllAsync();
            return _mapper.Map<List<TicketTypeDto>>(ticketTypes);
        }

        public async Task<TicketTypeDto> GetTicketTypeById(int id)
        {
            var ticketType = await _ticketTypeRepository.GetTicketTypeByIdAsync(id);
            return _mapper.Map<TicketTypeDto>(ticketType);
        }

        public async Task UpdateTicketType(TicketTypeDto ticketTypeDto)
        {
            var ticketType = await _ticketTypeRepository.GetByIdAsync(ticketTypeDto.Id);
            if (ticketType != null)
            {
                _mapper.Map(ticketTypeDto, ticketType);
                _ticketTypeRepository.Update(ticketType);
            }
        }
    }
}
