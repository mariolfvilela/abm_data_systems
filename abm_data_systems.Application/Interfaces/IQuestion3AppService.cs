using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using abm_data_systems.Application.ViewModels.CodeChallenge;
using abm_data_systems.Domain.Entities.CodeChallenge;
using DotNetCore.Objects;

namespace abm_data_systems.Application.Interfaces
{
    public interface ICodeChallengeAppService : IAppServicoBase<InputDocument, InputDocumentViewModal>
    {
        Task<IDataResult<dynamic>> Question1(InputDocumentViewModal inputDocumentViewModal);
        Task<IDataResult<List<dynamic>>> Question2(InputDocumentViewModal inputDocumentViewModal);
        Task<IDataResult<int>>Question3(InputDocumentViewModal inputDocumentViewModal);
    }
}
