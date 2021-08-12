namespace Application.Http.Requests
{
    public class CrearPersonaRequest
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public short Edad { get; set; }
        public string Cedula { get; set; }
    }
}