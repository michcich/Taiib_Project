using Gym.BLL.IRepositories;
using Gym.DAL.Context;
using Gym.Model.Models;

namespace Gym.BLL_EF.Repositories
{
    public class TicketTypeRepository : Repository<TicketType>, ITicketTypeRepository
    {
        public TicketTypeRepository(GymDbContext context) : base(context)
        {
        }
    }
}
