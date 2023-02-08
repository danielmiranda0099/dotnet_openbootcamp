using System.ComponentModel.DataAnnotations;

namespace API.Models.DataModels;

public class Curso : BaseEntity {
    [Required]
    public string Nombre { get; set; } = string.Empty;
    [Required, StringLength(280)]
    public string DescripcionCorta { get; set; } = string.Empty;
    public string DescripcionLarga { get; set; } = string.Empty;
    public string PublicoObjetivo { get; set; }  = string.Empty;
    public string Objetivos { get; set; } = string.Empty;
    public string Requisitos { get; set; } = string.Empty;
    public Nivel Nivel { get; set; } 
}

public enum Nivel {
    Basico,
    Intermedio,
    Avanzado
}