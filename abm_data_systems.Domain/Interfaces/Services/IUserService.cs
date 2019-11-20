using System;
using System.Threading.Tasks;
using abm_data_systems.Domain.Entities;

namespace abm_data_systems.Domain.Interfaces.Services
{
    public interface IUserService : IServiceBase<User>
    {
        Task<User> Login(string username, string password);
    }
}
