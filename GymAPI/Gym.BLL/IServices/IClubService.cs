using Gym.BLL.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.BLL.IServices
{
    public interface IClubService
    {
        Task AddClub(ClubDto clubDto);
        Task<List<ClubDto>> GetAllClubs();
        Task<ClubDto> GetClubById(int id);
        Task UpdateClub(ClubDto clubDto);
        Task DeleteClub(int id);
    }
}
