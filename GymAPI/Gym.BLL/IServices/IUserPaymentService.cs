using Gym.BLL.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.BLL.IServices
{
    public interface IUserPaymentService
    {
        Task AddUserPayment(UserPaymentDto userPaymentDto);
        Task<List<UserPaymentDto>> GetUserPaymentsByUserId(string userId);
    }
}
