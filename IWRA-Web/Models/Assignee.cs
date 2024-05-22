using System.ComponentModel.DataAnnotations;

namespace IWRA_Web.Models;

public class Assignee
{
    [Key]
    public int Id { get; set; }

    [Timestamp]
    public DateTime CreatedAt { get; set; }

    [Required]
    public string Name { get; set; } = "";

    [Required]
    public string Email { get; set; } = "";
}
