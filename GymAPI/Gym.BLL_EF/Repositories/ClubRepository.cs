using Gym.BLL.IRepositories;
using Gym.DAL.Context;
using Gym.Model.Models;

namespace Gym.BLL_EF.Repositories
{
    public class ClubRepository : Repository<Club>, IClubRepository
    {
        public ClubRepository(GymDbContext context) : base(context)
        { }
    }
}
