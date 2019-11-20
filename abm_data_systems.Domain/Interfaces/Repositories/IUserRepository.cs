using System;
using System.Threading.Tasks;
using abm_data_systems.Domain.Entities;

namespace abm_data_systems.Domain.Interfaces.Repositories
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        Task<User> Login(string username, string password);
    }
}
