using System;
using System.Threading.Tasks;
using abm_data_systems.Application.Interfaces;
using abm_data_systems.Application.ViewModels;
using abm_data_systems.Domain.Entities;
using abm_data_systems.Domain.Interfaces.Services;
using AutoMapper;

namespace abm_data_systems.Application.Services
{
    public class UserAppService : AppServiceBase<User, UserViewModel>, IUserAppService
    {
        protected readonly IUserService _service;

        public UserAppService(IMapper iMapper, IUserService service)
            : base(iMapper, service)
        {
            _service = service;
        }

        public async Task<UserViewModel> Login(string username, string password)
        {
            return _mapper.Map<UserViewModel>(await _service.Login(username, password));
        }
    }
}
