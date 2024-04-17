using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.BLL.Dto.ClubTicketType
{
    public class ClubTicketTypeResponseDto
    {
        public int Id { get; set; }
        public int ClubId { get; set; }
        public int TicketTypeId { get; set; }
    }
}
