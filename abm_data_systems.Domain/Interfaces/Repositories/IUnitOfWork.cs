using System;
using System.Threading.Tasks;

namespace abm_data_systems.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> CommitAsync();
    }
}
