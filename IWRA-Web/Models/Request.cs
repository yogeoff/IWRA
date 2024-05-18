using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IWRA_Web.Models;

public class Request
{
    [Key]
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    [Required]
    public string RequestorName { get; set; } = "";

    public string RequestorEmail { get; set; } = "";

    public DateTime ExpectedCompletionDate { get; set; }

    public string WorkRequestNumber { get; set; } = "";

    public string InternalAuditNumber { get; set; } = "";

    [Required]
    public string Content { get; set; } = "";

    [ForeignKey("Assignee")]
    public int AssigneeId { get; set; } = 0;

    public Assignee Assignee { get; set; } = null!;

    [ForeignKey("Department")]
    public int DepartmentId { get; set; }

    [ForeignKey("Status")]
    public int StatusId { get; set; } = 0;

    public bool IsPriority { get; set; }
}
