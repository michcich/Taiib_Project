using Gym.BLL.IRepositories;
using Gym.DAL.Context;
using Gym.Model.Models;

namespace Gym.BLL_EF.Repositories
{
    public class ReservationRepository : Repository<Reservation>, IReservationRepository
    {
        public ReservationRepository(GymDbContext context) : base(context)
        {
        }
    }
}
