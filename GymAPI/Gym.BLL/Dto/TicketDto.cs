﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.BLL.Dto
{
    public class TicketDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int TicketTypeId { get; set; }
    }
}