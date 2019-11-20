using System;
using System.Threading.Tasks;
using abm_data_systems.Domain.Entities.Question3;

namespace abm_data_systems.Domain.Interfaces.Services
{
    public interface IQuestion3Service : IServiceBase<DeclarationHeader>
    {
        Task<int> GetStatus(DeclarationHeader declarationHeader);
    }
}
