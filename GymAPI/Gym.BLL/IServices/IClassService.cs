using Gym.BLL.Dto;

namespace Gym.BLL.IServices
{
    public interface IClassService
    {
        Task AddClass(ClassDto classDto);
        void DeleteClass(int id);
        void UpdateClass(ClassDto classDto);
        Task<List<ClassDto>> GetClasses(int ClubId);
    }
}
