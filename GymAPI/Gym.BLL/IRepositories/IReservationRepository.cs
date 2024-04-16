using Gym.Model.Models;

namespace Gym.BLL.IRepositories
{
    public interface IReservationRepository : IRepository<Reservation>
    {
        Task<List<Reservation>> GetReservationsByUserId(string userId);
        Task<List<Reservation>> GetReservationsByClassId(int classId);
    }
}
