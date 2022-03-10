using ApiRestNetCore.Abstractions;

namespace ApiRestNetCore.Entities
{
    public abstract class Entity : IEntity
    {
        public virtual int Id { get; set; }
    }
}
