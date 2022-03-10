using ApiRestNetCore.Entities;

namespace ApiRestNetCore.WebAPI.DTOs
{
    // ver libreria automapper
    public class PersonaDTO : Persona
    {
        public override string Apellido { get => base.Apellido; set => base.Apellido = value; }

        public override string Nombre { get => base.Nombre; set => base.Nombre = value; }
    }
}
