using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreReposityMediatorCQRS.Repository.Interfaces.Requests;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreReposityMediatorCQRS.Repository
{
    public abstract class RepositoryRequestBase<TEntity> : IRepositoryRequestBase<TEntity> where TEntity : class
    {
        public readonly DbSet<TEntity> _DbSet;
        public readonly AppDbContext _AppDbContext;
        public RepositoryRequestBase(AppDbContext appDbContext)
        {
            _DbSet = appDbContext.Set<TEntity>();
            _AppDbContext = appDbContext;
        }
        public async Task AddAsync(TEntity entity)
        {
            await _DbSet.AddAsync(entity);
            await _AppDbContext.SaveChangesAsync();
        }

        public async Task DeletarAsync(TEntity entity)
        {
            _DbSet.Remove(entity);
            await _AppDbContext.SaveChangesAsync();
        }

        public async Task AtualizarAsync(TEntity entity)
        {
            _DbSet.Update(entity);
            await _AppDbContext.SaveChangesAsync();
        }       
    }
}