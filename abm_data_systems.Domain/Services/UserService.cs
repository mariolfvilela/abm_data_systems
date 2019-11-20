using System;
using System.Threading.Tasks;
using abm_data_systems.Domain.Entities;
using abm_data_systems.Domain.Interfaces.Repositories;
using abm_data_systems.Domain.Interfaces.Services;

namespace abm_data_systems.Domain.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        protected readonly IUserRepository _repository;

        public UserService(IUserRepository repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            _repository = repository;
        }

        public async Task<User> Login(string username, string password)
        {
            return await _repository.Login(username, password);
        }
    }
}
