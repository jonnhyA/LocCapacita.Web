using LocCapacita.Domain.Interfaces.Repositories;
using LocCapacita.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocCapacita.Domain.Service
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity obj)
        {
            _repository.Add(obj);
            _repository.Salvar();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
            _repository.Salvar();
        }

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
            _repository.Salvar();
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
