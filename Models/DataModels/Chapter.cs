using System.ComponentModel.DataAnnotations;

namespace API.Models.DataModels;

public class Chapter : BaseEntity {
    [Required]
    public string List { get; set; } = string.Empty;

    public int CourseId { get; set; }
    public virtual Course Course { get; set; } = new Course();
}