using System.ComponentModel.DataAnnotations;

namespace HolaMVC.Models;

public class Persona
{
    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres")]
    public string Nombre { get; set; } = string.Empty;
}