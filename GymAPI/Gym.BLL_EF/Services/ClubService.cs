﻿using AutoMapper;
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
    public class ClubService : IClubService
    {
        private readonly IClubRepository _clubRepository;
        private readonly IMapper _mapper;

        public ClubService(IClubRepository clubRepository, IMapper mapper)
        {
            _clubRepository = clubRepository;
            _mapper = mapper;
        }

        public async Task AddClub(ClubDto clubDto)
        {
            var club = _mapper.Map<Club>(clubDto);
            await _clubRepository.CreateAsync(club);
        }

        public async Task DeleteClub(int id)
        {
            var club = await _clubRepository.GetByIdAsync(id);
            if (club != null)
            {
                _clubRepository.Delete(club);
            }
        }

        public async Task<List<ClubDto>> GetAllClubs()
        {
            var clubs = await _clubRepository.GetAllAsync();
            return _mapper.Map<List<ClubDto>>(clubs);
        }

        public async Task<ClubDto> GetClubById(int id)
        {
            var club = await _clubRepository.GetClubByIdAsync(id);
            return _mapper.Map<ClubDto>(club);
        }

        public async Task UpdateClub(ClubDto clubDto)
        {
            var club = await _clubRepository.GetByIdAsync(clubDto.Id);
            if (club != null)
            {
                _mapper.Map(clubDto, club);
                _clubRepository.Update(club);
            }
        }
    }
}