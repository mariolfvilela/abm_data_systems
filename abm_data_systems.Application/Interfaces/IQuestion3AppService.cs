using System;
using System.Threading.Tasks;
using abm_data_systems.Application.ViewModels.Question3;
using abm_data_systems.Domain.Entities.Question3;
using DotNetCore.Objects;

namespace abm_data_systems.Application.Interfaces
{
    public interface IQuestion3AppService : IAppServicoBase<DeclarationHeader, DeclarationHeaderViewModal>
    {
        Task<IDataResult<int>>GetStatus(DeclarationHeaderViewModal declarationHeaderViewModal);
    }
}
