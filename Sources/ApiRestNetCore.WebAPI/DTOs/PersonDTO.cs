using ApiRestNetCore.Entities;

namespace ApiRestNetCore.WebAPI.DTOs
{
    public class PersonDTO : Person
    {
        public override string LastName { get => base.LastName; set => base.LastName = value; }

        public override string FirstName { get => base.FirstName; set => base.FirstName = value; }
    }
}
