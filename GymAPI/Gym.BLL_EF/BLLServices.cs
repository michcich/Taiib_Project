using Gym.BLL.IRepositories;
using Gym.BLL_EF.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Gym.BLL_EF
{
    public static class BLLServices
    {
        public static IServiceCollection AddBLL(this IServiceCollection services)
        {
            services.AddScoped<IClassRepository, ClassRepository>();
            services.AddScoped<IClubRepository, ClubRepository>();
            services.AddScoped<IClubTicketTypeRepository, ClubTicketTypeRepository>();
            services.AddScoped<IReservationRepository, ReservationRepository>();
            services.AddScoped<ITicketRepository, TicketRepository>();
            services.AddScoped<ITicketTypeRepository, TicketTypeRepository>();
            services.AddScoped<IUserPaymentRepository, UserPaymentRepository>();

            return services;
        }
    }
}
