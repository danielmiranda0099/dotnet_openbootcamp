using System.ComponentModel.DataAnnotations;

namespace API.Models.DataModels;

public class Category : BaseEntity {
    [Required]
    public string Name { get; set; } = string.Empty;

    //RELATIONING WITH MODEL COURSE
    public ICollection<Course> courses { get; set; } = new List<Course>();
}