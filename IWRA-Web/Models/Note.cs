using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IWRA_Web.Models;

public class Note
{
    [Key]
    public int Id { get; set; }

    [Timestamp]
    public DateTime CreatedAt { get; set; }

    [Required]
    [ForeignKey("Request")]
    public int RequestId { get; set; }

    [Required]
    [ForeignKey("Assignee")]
    public int AssigneeId { get; set; }

    [Required]
    public string Content { get; set; }
}
