using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class NewsletterEntity
{
    [Key]
    [Required]
    public string Email { get; set; } = null!;
}
