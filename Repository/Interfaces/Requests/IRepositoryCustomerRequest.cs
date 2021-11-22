using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DotNetCoreReposityMediatorCQRS.Repository.Interfaces.Requests
{
    public interface IRepositoryCustomerRequest<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> Obter(Expression<Func<TEntity, bool>> filter);
        Task<TEntity> ObterPorIdAsync(Guid Id);
    }
}