using AutoMapper;
using Gym.BLL.Dto;
using Gym.Model.Models;

namespace Gym.BLL_EF.Mapping
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<ClassDto, Class>().ReverseMap();
            CreateMap<ClubDto, Club>().ReverseMap();
            CreateMap<ClubTicketTypeDto, ClubTicketType>().ReverseMap();
            CreateMap<ReservationDto, Reservation>().ReverseMap();
            CreateMap<TicketDto, Ticket>().ReverseMap();
            CreateMap<TicketTypeDto, TicketType>().ReverseMap();
            CreateMap<UserPaymentDto, UserPayment>().ReverseMap();
        }
    }
}
