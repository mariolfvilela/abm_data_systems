using System;
using System.Threading.Tasks;
using abm_data_systems.Application.ViewModels;
using abm_data_systems.Domain.Entities;

namespace abm_data_systems.Application.Interfaces
{
    public interface IUserAppService : IAppServicoBase<User, UserViewModel>
    {
        Task<UserViewModel> Login(string username, string password);
    }
}
