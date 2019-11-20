using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using abm_data_systems.Application.ViewModels;
using abm_data_systems.Domain.Entities.Common;
using DotNetCore.Objects;

namespace abm_data_systems.Application.Interfaces
{
    public interface IAppServicoBase<TEntity, TEntityViewModel>
        where TEntity : EntityBase
        where TEntityViewModel : ViewModelBase
    {
        Task<IDataResult<int>> AddAsync(TEntityViewModel entityViewModel);
        Task<IResult> RemoveByIdAsync(int id);
        Task<IResult> RemoveAsync(TEntityViewModel entityViewModel);
        Task<TEntityViewModel> UpdateAsync(TEntityViewModel entityViewModel);
        Task<TEntityViewModel> GetByIdAsync(int id);
        Task<IEnumerable<TEntityViewModel>> ListAsync();
        Task<PagedList<TEntityViewModel>> ListAsync(PagedListParameters parameters);
    }
}
