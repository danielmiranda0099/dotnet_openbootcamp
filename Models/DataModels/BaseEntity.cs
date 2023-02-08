using System.ComponentModel.DataAnnotations;

namespace API.Models.DataModels;

public class BaseEntity {
    [Key]
    [Required]
    public int Id { get; set; }

    public string CreatedBy { get; set; } = string.Empty;
    public DateTime CreateAt { get; set; } = DateTime.Now;
    public string UpdatedBy { get; set; } = string.Empty;
    public DateTime ? UpdatedAt { get; set; }
    public string DeletedBy { get; set; } = string.Empty;
    public DateTime ? DeletedAt { get; set; }
    public bool IsDeleted { get; set; } = false;
}