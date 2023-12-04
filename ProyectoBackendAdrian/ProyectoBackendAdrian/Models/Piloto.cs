using System.ComponentModel.DataAnnotations;

namespace ProyectoBackendAdrian.Models
{
    public class Piloto
    {
        [Key]
        public int numero_licencia {  get; set; }
        public string? restricciones { get; set; }
        public string? salario {  get; set; }
        public string? turno { get; set; }
    }
}
