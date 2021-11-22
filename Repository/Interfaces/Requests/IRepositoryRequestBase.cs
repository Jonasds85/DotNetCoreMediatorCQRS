using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreReposityMediatorCQRS.Repository.Interfaces.Requests
{
    public interface IRepositoryRequestBase<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> Obter(Expression<Func<TEntity, bool>> filter = null);
    }
}