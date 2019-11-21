using System;
using System.Threading.Tasks;
using abm_data_systems.Application.Interfaces;
using abm_data_systems.Application.Validation;
using abm_data_systems.Application.ViewModels.CodeChallenge;
using abm_data_systems.Domain.Entities.CodeChallenge;
using abm_data_systems.Domain.Interfaces.Services;
using AutoMapper;
using DotNetCore.Objects;

namespace abm_data_systems.Application.Services
{
    public class CodeChallengeAppService : AppServiceBase<InputDocument, InputDocumentViewModal>, ICodeChallengeAppService
    {
        protected readonly ICodeChallengeService _service;

        public CodeChallengeAppService(IMapper iMapper, ICodeChallengeService service)
            : base(iMapper, service)
        {
            _service = service;
        }

        public async Task<IDataResult<int>> Question3(InputDocumentViewModal inputDocumentViewModal)
        {
            IResult validation = new Question3ViewModalValitor().Validate(inputDocumentViewModal);

            if (validation.IsError)
            {
                return DataResult<int>.Error(validation.Message);
            }
            //If the XML document is given here is passed then return a status of ‘0’ – which means the document was structured correctly.
            return DataResult<int>.Success("0");
            //return DataResult<int>.Success(await _service.Question3(_mapper.Map<InputDocument>(inputDocumentViewModal)));
        }
    }
}
