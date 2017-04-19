
using LocCapacita.Data.Interface;
using LocCapacita.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LocCapacita.Data.Repository
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected IUnitOfWork Uow = new UnitOfWork.UnitOfWork();

        public void Add(TEntity obj)
        {
            Uow.Context.Set<TEntity>().Add(obj);
        }

        public void AddRange(List<TEntity> entity)
        {
            Uow.Context.Set<TEntity>().AddRange(entity);
        }

        public TEntity GetById(int id)
        {
            return Uow.Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Uow.Context.Set<TEntity>().ToList();
        }

        public void Update(TEntity obj)
        {
            Uow.Context.Entry(obj).State = EntityState.Modified;
        }

        public void Remove(TEntity obj)
        {
            Uow.Context.Set<TEntity>().Attach(obj);
            Uow.Context.Set<TEntity>().Remove(obj);
        }

        public void Dispose()
        {
            Uow.Dispose();
        }

        public void Salvar()
        {
            Uow.Commit();
        }

        public IQueryable<TEntity> Get()
        {
            return Uow.Context.Set<TEntity>();
        }

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> expression)
        {
            return Get().Where(expression);
        }
    }
}
