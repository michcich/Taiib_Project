using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.BLL.Dto
{
    public class ReservationDto
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ClassId { get; set; }
    }
}
