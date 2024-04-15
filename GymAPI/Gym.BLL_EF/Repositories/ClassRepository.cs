using Gym.BLL.IRepositories;
using Gym.DAL.Context;
using Gym.Model.Models;
using Microsoft.EntityFrameworkCore;

namespace Gym.BLL_EF.Repositories
{
    public class ClassRepository : Repository<Class>, IClassRepository
    {
        private readonly GymDbContext _context;

        public ClassRepository(GymDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Class>> GetClassesByGymId(int GymId)
        {
            var list = await _context.Classes.Where(x => x.ClubId == GymId).ToListAsync();
            return list;
        }
    }
}
