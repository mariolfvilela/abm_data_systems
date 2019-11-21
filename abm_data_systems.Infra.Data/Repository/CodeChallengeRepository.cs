using System;
using System.Threading.Tasks;
using abm_data_systems.Domain.Entities.CodeChallenge;
using abm_data_systems.Domain.Interfaces.Repositories;
using abm_data_systems.Infra.Data.Context;

namespace abm_data_systems.Infra.Data.Repository
{
    public class CodeChallengeRepository : RepositoryBase<InputDocument>, ICodeChallengeRepository
    {
        public CodeChallengeRepository(Context_ABM_Data_Systems contexto)
            : base(contexto)
        {
        }

        public Task<InputDocument> GetStatus()
        {
            throw new NotImplementedException();
        }

        public Task<int> Question3(InputDocument inputDocument)
        {
            throw new NotImplementedException();
        }
    }
}
