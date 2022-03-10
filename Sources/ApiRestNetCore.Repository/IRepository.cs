using ApiRestNetCore.Abstractions;

namespace ApiRestNetCore.Repository
{
    public interface IRepository<T> : ICrud<T>
    {
    }
}
