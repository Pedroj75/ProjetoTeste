namespace ClinicaPsicologica.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }  // Nome pode ser nulo
        public int Idade { get; set; }
        public string? Sexo { get; set; }  // Sexo pode ser nulo
        public string? Email { get; set; }  // Email pode ser nulo
    }
}
