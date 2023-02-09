using System.ComponentModel.DataAnnotations;

namespace API.Models.DataModels;

public class Student : BaseEntity {
    [Required]
    public string FirstName { get; set; } = string.Empty;
    [Required]
    public string LastName { get; set; } = string.Empty;
    [Required]
    public DateTime Dob { get; set; }

    //RELATIONING WITH MODEL USER
    [Required]
    public ICollection<Course> Courses { get; set; } = new List<Course>();
}