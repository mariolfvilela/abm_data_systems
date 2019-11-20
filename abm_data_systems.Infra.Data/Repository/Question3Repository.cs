using System;
using System.Threading.Tasks;
using abm_data_systems.Domain.Entities.Question3;
using abm_data_systems.Domain.Interfaces.Repositories;
using abm_data_systems.Infra.Data.Context;

namespace abm_data_systems.Infra.Data.Repository
{
    public class Question3Repository : RepositoryBase<DeclarationHeader>, IQuestion3Repository
    {
        public Question3Repository(Context_ABM_Data_Systems contexto)
            : base(contexto)
        {
        }

        public Task<DeclarationHeader> GetStatus()
        {
            throw new NotImplementedException();
        }

        public Task<int> GetStatus(DeclarationHeader declarationHeader)
        {
            throw new NotImplementedException();
        }
    }
}
