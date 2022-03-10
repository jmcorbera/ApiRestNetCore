using ApiRestNetCore.Abstractions;

namespace ApiRestNetCore.Business
{
    public interface IApplication<T> : ICrud<T>
    {
    }
}
