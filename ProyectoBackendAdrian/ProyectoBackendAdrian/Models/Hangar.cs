using System.ComponentModel.DataAnnotations;

namespace ProyectoBackendAdrian.Models
{
    public class Hangar
    {
        [Key]
        public int numero_hangar {  get; set; }
        public string? capacidad { get; set; }
        public string? localizacion { get; set; }
    }
}
