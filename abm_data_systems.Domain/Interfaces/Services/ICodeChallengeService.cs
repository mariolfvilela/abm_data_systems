using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using abm_data_systems.Domain.Entities.CodeChallenge;
using DotNetCore.Objects;

namespace abm_data_systems.Domain.Interfaces.Services
{
    public interface ICodeChallengeService : IServiceBase<InputDocument>
    {
        Task<dynamic> Question1(InputDocument inputDocument);
        Task<List<dynamic>> Question2(InputDocument inputDocument);
        Task<int> Question3(InputDocument inputDocument);
    }
}
