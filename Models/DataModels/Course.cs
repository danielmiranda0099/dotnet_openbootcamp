using System.ComponentModel.DataAnnotations;

namespace API.Models.DataModels;

public class Course : BaseEntity {
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required, StringLength(280)]
    public string ShortDescription { get; set; } = string.Empty;
    [Required]
    public string Description { get; set; } = string.Empty;
    [Required]
    public string TargetPublic { get; set; }  = string.Empty;
    [Required]
    public string Targets { get; set; } = string.Empty;
    [Required]
    public string Requisitos { get; set; } = string.Empty;
    [Required]
    public Level Level { get; set; } 

    //RELATIONING WITH MODEL CATEGORY
    [Required]
    public ICollection<Category> Categories { get; set; } = new List<Category>();
    
    //RELATIONING WITH MODEL STUDENT
    [Required]
    public ICollection<Student> Students { get; set; } = new List<Student>();

    [Required]
    public Chapter Chapters { get; set; } = new Chapter();
}

public enum Level {
    Basic,
    Medium,
    Advance,
    Expert
}