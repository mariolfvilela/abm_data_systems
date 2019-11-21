using System;
using System.Threading.Tasks;
using abm_data_systems.Domain.Entities.CodeChallenge;

namespace abm_data_systems.Domain.Interfaces.Services
{
    public interface ICodeChallengeService : IServiceBase<InputDocument>
    {
        Task<int> Question3(InputDocument inputDocument);
    }
}
