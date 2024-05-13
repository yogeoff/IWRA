using System.ComponentModel.DataAnnotations;

namespace IWRA_Web.Models;

public class Status
{
    [Key]
    public int Id { get; set; }

    [Timestamp]
    public DateTime CreatedAt { get; set; }

    [Required]
    public string Name { get; set; } = "";
}
