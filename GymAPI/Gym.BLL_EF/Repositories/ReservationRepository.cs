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

        public async Task<List<Reservation>> GetReservationsByUserId(string userId)
        {
            return await _context.Reservations.Where(r => r.UserId == userId).ToListAsync();
        }

        public async Task<List<Reservation>> GetReservationsByClassId(int classId)
        {
            return await _context.Reservations.Where(r => r.ClassId == classId).ToListAsync();
        }
    }
}
