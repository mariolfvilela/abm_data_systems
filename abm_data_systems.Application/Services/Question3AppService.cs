using System;
using System.Threading.Tasks;
using abm_data_systems.Application.Interfaces;
using abm_data_systems.Application.ViewModels.Question3;
using abm_data_systems.Domain.Entities.Question3;
using abm_data_systems.Domain.Interfaces.Services;
using AutoMapper;
using DotNetCore.Objects;

namespace abm_data_systems.Application.Services
{
    public class Question3AppService : AppServiceBase<DeclarationHeader, DeclarationHeaderViewModal>, IQuestion3AppService
    {
        protected readonly IQuestion3Service _service;

        public Question3AppService(IMapper iMapper, IQuestion3Service service)
            : base(iMapper, service)
        {
            _service = service;
        }

        public async Task<IDataResult<int>> GetStatus(DeclarationHeaderViewModal declarationHeaderViewModal)
        {
            return DataResult<int>.Success(await _service.GetStatus(_mapper.Map<DeclarationHeader>(declarationHeaderViewModal)));
        }
    }
}
