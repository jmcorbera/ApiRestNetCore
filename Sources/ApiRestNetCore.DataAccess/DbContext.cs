using ApiRestNetCore.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace ApiRestNetCore.DataAccess
{
    public class DbContext<T> : IDbContext<T> where T : class, IEntity
    {
        DbSet<T> _items;
        EFDBContext _ctx;

        public DbContext(EFDBContext ctx)
        {
            _ctx = ctx;
            _items = _ctx.Set<T>();
        }

        public void Delete(int id)
        {
            var e = _items.Where(i => i.Id == id).FirstOrDefault();
            _items.Remove(e);
        }

        public IList<T> GetAll()
        {
            return _items.ToList();
        }

        public T GetById(int id)
        {
            return _items.Where(i => i.Id.Equals(id)).FirstOrDefault();
        }

        public T Save(T entity)
        {
            //if(_items.Contains(_items.Where(i => i.Id.Equals(entity.Id)).FirstOrDefault()))
            //{
            //    _items.Update(entity);
            //}
            //else
            //{
            //    _items.Add(entity);
            //}

            _items.Add(entity);
            _ctx.SaveChanges();

            return entity;
        }
    }
}
