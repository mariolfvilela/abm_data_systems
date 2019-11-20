using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using abm_data_systems.Application.ViewModels;
using abm_data_systems.Domain.Entities.Common;
using abm_data_systems.Domain.Interfaces.Services;
using AutoMapper;
using DotNetCore.Objects;
using abm_data_systems.Application.Interfaces;

namespace abm_data_systems.Application.Services
{
    public class AppServiceBase<TEntity, TEntityViewModel> : IAppServicoBase<TEntity, TEntityViewModel>
        where TEntity : EntityBase
        where TEntityViewModel : ViewModelBase
    {
        protected readonly IServiceBase<TEntity> _service;
        protected readonly IMapper _mapper;

        public AppServiceBase(IMapper iMapper, IServiceBase<TEntity> servico)
            : base()
        {
            this._mapper = iMapper;
            this._service = servico;
        }

        public async Task<IDataResult<int>> AddAsync(TEntityViewModel entityViewModel)
        {
            //return _mapper.Map<TEntityViewModel>(await _service.AddAsync(_mapper.Map<TEntity>(entityViewModel)));
            return DataResult<int>.Success((await _service.AddAsync(_mapper.Map<TEntity>(entityViewModel))));
        }

        public async Task<TEntityViewModel> GetByIdAsync(int id)
        {
            return _mapper.Map<TEntityViewModel>(await _service.GetByIdAsync(id));
        }

        public async Task<IEnumerable<TEntityViewModel>> ListAsync()
        {
            return _mapper.Map<IEnumerable<TEntityViewModel>>(await _service.ListAsync());
        }

        public Task<PagedList<TEntityViewModel>> ListAsync(PagedListParameters parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<IResult> RemoveAsync(TEntityViewModel entityViewModel)
        {
            return await _service.RemoveAsync(_mapper.Map<TEntity>(entityViewModel)) ? Result.Success() : Result.Error();
        }

        public async Task<IResult> RemoveByIdAsync(int id)
        {
            return (await _service.RemoveByIdAsync(id)) ? Result.Success() : Result.Error();
        }

        public async Task<TEntityViewModel> UpdateAsync(TEntityViewModel entityViewModel)
        {
            return _mapper.Map<TEntityViewModel>(await _service.UpdateAsync(_mapper.Map<TEntity>(entityViewModel)));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
