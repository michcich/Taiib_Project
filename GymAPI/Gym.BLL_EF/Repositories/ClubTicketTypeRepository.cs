using Gym.BLL.IRepositories;
using Gym.DAL.Context;
using Gym.Model.Models;

namespace Gym.BLL_EF.Repositories
{
    public class ClubTicketTypeRepository : Repository<ClubTicketType>, IClubTicketTypeRepository
    {
        public ClubTicketTypeRepository(GymDbContext context) : base(context)
        {
        }
    }
}
