using Gym.BLL.IRepositories;
using Gym.DAL.Context;
using Gym.Model.Models;

namespace Gym.BLL_EF.Repositories
{
    public class ClassRepository : Repository<Class>, IClassRepository
    {
        public ClassRepository(GymDbContext context) : base(context)
        {
        }
    }
}
