using Domain.Base;

namespace Domain.Entities
{
    public class Persona : Entity<int>
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public short Edad { get; set; }
        public string Cedula { get; set; }
    }
}