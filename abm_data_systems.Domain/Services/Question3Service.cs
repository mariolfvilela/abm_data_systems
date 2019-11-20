using System;
using System.Threading.Tasks;
using abm_data_systems.Domain.Entities.Question3;
using abm_data_systems.Domain.Interfaces.Repositories;
using abm_data_systems.Domain.Interfaces.Services;

namespace abm_data_systems.Domain.Services
{
    public class Question3Service : ServiceBase<DeclarationHeader>, IQuestion3Service
    {
        protected readonly IQuestion3Repository _repository;

        public Question3Service(IQuestion3Repository repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            _repository = repository;
        }
        
        public async Task<int> GetStatus(DeclarationHeader declarationHeader)
        {
            return await _repository.GetStatus(declarationHeader);
        }
    }
}
