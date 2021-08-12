using Domain.Entities;

namespace Application.Http.Responses
{
    public class PersonaResponse
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public PersonaResponse(Persona persona)
        {
            Id = persona.Id;
            Nombre = persona.Nombre;
            Apellidos = persona.Apellidos;
            Email = persona.Email;
            Telefono = persona.Telefono;
        }
    }
}