﻿using Gym.BLL.Dto;
using Gym.BLL.IRepositories;
using Gym.DAL.Context;
using Gym.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace Gym.BLL_EF.Repositories
{
    public class ReservationRepository : Repository<Reservation>, IReservationRepository
    {
        private readonly GymDbContext _context;

        public ReservationRepository(GymDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task CreateAsync(Reservation entity)
        {
            int reserved = _context.Reservations
                .AsNoTracking()
                .Where(x => x.ClassId == entity.ClassId)
                .Count();

            int slots = await _context.Classes
                .AsNoTracking()
                .Where(x => x.Id == entity.ClassId)
                .Select(x => x.Slots)
                .FirstOrDefaultAsync();

            if (reserved < slots) 
            {
                await base.CreateAsync(entity);
            }
        }

        public async Task<List<Reservation>> GetReservationsByUserId(string userId, PageProperties pageProperties)
        {
            int offset = pageProperties.PageNumber - 1 * pageProperties.PageSize;
            return await _context.Reservations
                .Where(r => r.UserId == userId)
                .Skip(offset)
                .Take(pageProperties.PageSize)
                .ToListAsync();
        }

        public async Task<List<Reservation>> GetReservationsByClassId(int classId, PageProperties pageProperties)
        {
            int offset = pageProperties.PageNumber - 1 * pageProperties.PageSize;
            return await _context.Reservations
                .Where(r => r.ClassId == classId)
                .Skip(offset)
                .Take(pageProperties.PageSize)
                .ToListAsync();
        }
    }
}
