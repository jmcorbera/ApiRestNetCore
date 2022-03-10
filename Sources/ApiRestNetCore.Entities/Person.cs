namespace ApiRestNetCore.Entities
{
    public class Person : Entity
    {
        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }
    }
}
