using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using abm_data_systems.Domain.Entities;
using abm_data_systems.Domain.Enums;
using abm_data_systems.Domain.Interfaces.Repositories;
using abm_data_systems.Infra.Data.Context;

namespace abm_data_systems.Infra.Data.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(Context_ABM_Data_Systems contexto)
            : base(contexto)
        {
        }

        public async Task<User> Login(string username, string password)
        {
            return GetUser().Where(x => x.Username.ToLower() == username.ToLower() && x.Password == x.Password)
                .Select(x => { x.Password = ""; return x; })
                .FirstOrDefault();
        }

        private IEnumerable<User> GetUser()
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, Username = "batman", Password = "batman", Roles = Roles.Admin });
            users.Add(new User { Id = 2, Username = "robin", Password = "robin", Roles = Roles.User });
            return users;
        }
    }
}

