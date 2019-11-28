using System;
using System.Collections.Generic;
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

        public Task<IDataResult<EdifactViewModal>> Question1(EdifactViewModal edifactViewModal)
        {
            var lines = edifactViewModal.Message.Split('\'');     // splits at the apostrophe character

            foreach (string line in lines)
            {
                var pieces = line.Split('+', ':');    // splits at both of those characters
                //DoSomething(pieces);
            }
            return (Task<IDataResult<EdifactViewModal>>)DataResult<EdifactViewModal>.Success(edifactViewModal);
        }

        public Task<IDataResult<List<dynamic>>> Question2(InputDocumentViewModal inputDocument)
        {
            throw new NotImplementedException();
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
