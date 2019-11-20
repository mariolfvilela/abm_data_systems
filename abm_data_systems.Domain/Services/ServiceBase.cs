using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using abm_data_systems.Domain.Entities.Common;
using abm_data_systems.Domain.Interfaces.Repositories;
using abm_data_systems.Domain.Interfaces.Services;
using DotNetCore.Objects;

namespace abm_data_systems.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : EntityBase
    {
        protected readonly IRepositoryBase<TEntity> _repository;
        protected readonly IUnitOfWork _unitOfWork;

        public ServiceBase(IRepositoryBase<TEntity> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<int> AddAsync(TEntity entidade)
        {
            int id = _repository.Add(entidade);

            await _unitOfWork.CommitAsync();

            return id;
        }

        public async Task<bool> RemoveAsync(TEntity entidade)
        {
            _repository.Remove(entidade);

            await _unitOfWork.CommitAsync();

            return true;
        }

        public async Task<bool> RemoveByIdAsync(int id)
        {
            _repository.RemoveById(id);

            await _unitOfWork.CommitAsync();

            return true;
        }

        public void Dispose()
        {
            _repository.Dispose();
            _unitOfWork.Dispose();
        }
        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<TEntity>> ListAsync()
        {
            return await _repository.ListAsync();
        }

        public async Task<PagedList<TEntity>> ListAsync(PagedListParameters parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity> UpdateAsync(TEntity entidade)
        {
            _repository.Update(entidade);

            await _unitOfWork.CommitAsync();

            return entidade;
        }
    }
}
