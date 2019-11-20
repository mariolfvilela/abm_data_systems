using System;
using System.Threading.Tasks;
using abm_data_systems.Domain.Entities.Question3;

namespace abm_data_systems.Domain.Interfaces.Repositories
{
    public interface IQuestion3Repository : IRepositoryBase<DeclarationHeader>
    {
        Task<int> GetStatus(DeclarationHeader declarationHeader);
    }
}
