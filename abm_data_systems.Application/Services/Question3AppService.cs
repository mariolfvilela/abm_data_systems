using System;
using System.Threading.Tasks;
using abm_data_systems.Application.Interfaces;
using abm_data_systems.Application.ViewModels.CodeChallenge;
using abm_data_systems.Domain.Entities.CodeChallenge;
using abm_data_systems.Domain.Interfaces.Services;
using AutoMapper;
using DotNetCore.Objects;

namespace abm_data_systems.Application.Services
{
    public class Question3AppService : AppServiceBase<InputDocument, InputDocumentViewModal>, IQuestion3AppService
    {
        protected readonly ICodeChallengeService _service;

        public Question3AppService(IMapper iMapper, ICodeChallengeService service)
            : base(iMapper, service)
        {
            _service = service;
        }

        public async Task<IDataResult<int>> Question3(InputDocumentViewModal declarationHeaderViewModal)
        {
            return DataResult<int>.Success(await _service.Question3(_mapper.Map<InputDocument>(declarationHeaderViewModal)));
        }
    }
}
