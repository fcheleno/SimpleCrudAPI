using SimpleCrud.Core.Interfaces.Repositories;
using SimpleCrud.Core.Interfaces.Services;

namespace SimpleCrud.Infrastructure.Services
{
    public abstract class BaseService<TEntity> : IDisposable, IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> Repository)
        {
            _repository = Repository;
        }
        
        public virtual TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }
        
        public virtual IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public virtual void Update(TEntity obj)
        {
            _repository.Update(obj);
        }
        
        public virtual void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public virtual void Dispose()
        {
            _repository.Dispose();
        }
    }
}
