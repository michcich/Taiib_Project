using Gym.BLL.IRepositories;
using Gym.DAL.Context;
using Gym.Model.Models;

namespace Gym.BLL_EF.Repositories
{
    public class TicketRepository : Repository<Ticket>, ITicketRepository
    {
        public TicketRepository(GymDbContext context) : base(context)
        {
        }
    }
}
