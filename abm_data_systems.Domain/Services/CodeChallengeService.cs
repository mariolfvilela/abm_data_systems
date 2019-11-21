using System;
using System.Threading.Tasks;
using abm_data_systems.Domain.Entities.CodeChallenge;
using abm_data_systems.Domain.Interfaces.Repositories;
using abm_data_systems.Domain.Interfaces.Services;

namespace abm_data_systems.Domain.Services
{
    public class CodeChallengeService : ServiceBase<InputDocument>, ICodeChallengeService
    {
        protected readonly ICodeChallengeRepository _repository;

        public CodeChallengeService(ICodeChallengeRepository repository, IUnitOfWork unitOfWork)
            : base(repository, unitOfWork)
        {
            _repository = repository;
        }
        
        public async Task<int> Question3(InputDocument inputDocument)
        {
            return await _repository.Question3(inputDocument);
        }
    }
}
