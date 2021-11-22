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
        Task AddAsync(TEntity entity);
        Task DeletarAsync(TEntity entity);
        Task AtualizarAsync(TEntity entity);
    }
}