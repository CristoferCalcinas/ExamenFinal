using System.ComponentModel.DataAnnotations;

namespace ProyectoBackendAdrian.Models
{
    public class Aviones
    {
        [Key]
        public int numero {  get; set; }
        public string? modelo { get; set; }
        public string? peso { get; set; }
        public string? capacidad {  get; set; }
    }
}
