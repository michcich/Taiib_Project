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
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IMapper _mapper;

        public ReservationService(IReservationRepository reservationRepository, IMapper mapper)
        {
            _reservationRepository = reservationRepository;
            _mapper = mapper;
        }

        public async Task AddReservation(ReservationDto reservationDto)
        {
            var reservation = _mapper.Map<Reservation>(reservationDto);
            await _reservationRepository.CreateAsync(reservation);
        }

        public async Task<List<ReservationDto>> GetReservationsByUserId(string userId)
        {
            var reservations = await _reservationRepository.GetReservationsByUserId(userId);
            return _mapper.Map<List<ReservationDto>>(reservations);
        }

        public async Task<List<ReservationDto>> GetReservationsByClassId(int classId)
        {
            var reservations = await _reservationRepository.GetReservationsByClassId(classId);
            return _mapper.Map<List<ReservationDto>>(reservations);
        }


        public async Task DeleteReservation(int id)
        {
            var reservation = await _reservationRepository.GetByIdAsync(id);
            if (reservation != null)
            {
                _reservationRepository.Delete(reservation);
            }
        }
    }
}
