using System.ComponentModel.DataAnnotations;

namespace IWRA_Web.Models;

public class Department
{
    [Key]
    public int Id { get; set; }

    [Timestamp]
    public DateTime CreatedAt { get; set; }

    [Required]
    public string Name { get; set; }
}
