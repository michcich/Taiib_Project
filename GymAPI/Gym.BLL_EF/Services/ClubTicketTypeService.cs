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
    public class ClubTicketTypeService : IClubTicketTypeService
    {
        private readonly IClubTicketTypeRepository _clubTicketTypeRepository;
        private readonly IMapper _mapper;

        public ClubTicketTypeService(IClubTicketTypeRepository clubTicketTypeRepository, IMapper mapper)
        {
            _clubTicketTypeRepository = clubTicketTypeRepository;
            _mapper = mapper;
        }

        public async Task AddClubTicketType(ClubTicketTypeDto clubTicketTypeDto)
        {
            var clubTicketType = _mapper.Map<ClubTicketType>(clubTicketTypeDto);
            await _clubTicketTypeRepository.CreateAsync(clubTicketType);
        }

        public async Task<List<ClubTicketTypeDto>> GetClubTicketTypesByClubId(int clubId)
        {
            var clubTicketTypes = await _clubTicketTypeRepository.GetClubTicketTypesByClubId(clubId);
            return _mapper.Map<List<ClubTicketTypeDto>>(clubTicketTypes);
        }

        public async Task<List<ClubTicketTypeDto>> GetAllClubTicketTypes()
        {
            var clubTicketTypes = await _clubTicketTypeRepository.GetAllAsync();
            return _mapper.Map<List<ClubTicketTypeDto>>(clubTicketTypes);
        }

        public async Task UpdateClubTicketType(ClubTicketTypeDto clubTicketTypeDto)
        {
            var clubTicketType = await _clubTicketTypeRepository.GetByIdAsync(clubTicketTypeDto.Id);
            if (clubTicketType != null)
            {
                _mapper.Map(clubTicketTypeDto, clubTicketType);
                _clubTicketTypeRepository.Update(clubTicketType);
            }
        }

        public async Task DeleteClubTicketType(int id)
        {
            var clubTicketType = await _clubTicketTypeRepository.GetByIdAsync(id);
            if (clubTicketType != null)
            {
                _clubTicketTypeRepository.Delete(clubTicketType);
            }
        }
    }
}
