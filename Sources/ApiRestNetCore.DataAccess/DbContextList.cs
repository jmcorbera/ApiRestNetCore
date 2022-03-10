using ApiRestNetCore.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace ApiRestNetCore.DataAccess
{
    public class DbContextList<T> : IDbContext<T> where T : IEntity
    {
        IList<T> _data;

        public DbContextList()
        {
            _data = new List<T>();
        }

        public void Delete(int id)
        {
            var item = _data.Where(i => i.Id == id).FirstOrDefault();
            if(item != null)
            {
                _data.Remove(item);
            }
        }

        public IList<T> GetAll()
        {
            return _data;
        }

        public T GetById(int id)
        {
            return _data.Where(i => i.Id.Equals(id)).FirstOrDefault();
        }

        public T Save(T entity)
        {
            if (entity.Id.Equals(0))
            {
                _data.Add(entity);
            }

            return entity;
        }
    }
}
