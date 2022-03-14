using ApiRestNetCore.Abstractions;
using System.Collections.Generic;

namespace ApiRestNetCore.Business
{
    public class Application<T> : IApplication<T> where T: IEntity
    {
        IRepository<T> _repository;

        public Application(IRepository<T> repository)
        {
            _repository = repository;
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IList<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public T Save(T entity)
        {
            return _repository.Save(entity);
        }
    }
}
