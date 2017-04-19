using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LocCapacita.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void AddRange(List<TEntity> entity);
        TEntity GetById(int id);
        IQueryable<TEntity> Get();
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
        void Salvar();
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> expression);
    }
}
