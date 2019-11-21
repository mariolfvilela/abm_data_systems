using System;
using System.Threading.Tasks;
using abm_data_systems.Application.ViewModels.CodeChallenge;
using abm_data_systems.Domain.Entities.CodeChallenge;
using DotNetCore.Objects;

namespace abm_data_systems.Application.Interfaces
{
    public interface ICodeChallengeAppService : IAppServicoBase<InputDocument, InputDocumentViewModal>
    {
        Task<IDataResult<int>>Question3(InputDocumentViewModal inputDocumentViewModal);
    }
}
