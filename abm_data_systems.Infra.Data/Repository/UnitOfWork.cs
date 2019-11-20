using System;
using System.Threading.Tasks;
using abm_data_systems.Domain.Interfaces.Repositories;
using abm_data_systems.Infra.Data.Context;

namespace abm_data_systems.Infra.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context_ABM_Data_Systems _context;

        private UserRepository _userRepository;

        public UnitOfWork(Context_ABM_Data_Systems context)
        {
            _context = context;
        }

        public UserRepository Artists => _userRepository = _userRepository ?? new UserRepository(_context);


        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}