using Gym.BLL.IRepositories;
using Gym.DAL.Context;
using Gym.Model.Models;

namespace Gym.BLL_EF.Repositories
{
    public class UserPaymentRepository : Repository<UserPayment>, IUserPaymentRepository
    {
        public UserPaymentRepository(GymDbContext context) : base(context)
        {
        }
    }
}
