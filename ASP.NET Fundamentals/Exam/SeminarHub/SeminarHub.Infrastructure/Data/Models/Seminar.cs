using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SeminarHub.Infrastructure.Data.DataConstants.SeminarDataConstants;

namespace SeminarHub.Infrastructure.Data.Models;

public class Seminar
{
    [Key]
    [Comment("Seminar identifier")]
    public int Id { get; set; }

    [Required]
    [StringLength(MaxTopicLength)]
    [Comment("The topic of the seminar")]
    public string Topic { get; set; } = string.Empty;

    [Required]
    [StringLength(MaxLecturerFieldLength)]
    [Comment("The lecturer of the seminar")]
    public string Lecturer { get; set; } = string.Empty;

    [Required]
    [StringLength(MaxDetailsLength)]
    [Comment("Details of the seminar")]
    public string Details { get; set; } = string.Empty;

    [Required]
    [Comment("Organizer's identifier")]
    public string OrganizerId { get; set; } = string.Empty;

    [Required]
    [ForeignKey(nameof(OrganizerId))]
    [Comment("Organizer of the seminar")]
    public IdentityUser Organizer { get; set; } = null!;

    [Required]
    [Comment("Date and time of the seminar")]
    public DateTime DateAndTime { get; set; }
    [Comment("Duration of the seminar")]

    public int? Duration { get; set; }

    [Required]
    [Comment("Category identifier")]
    public int CategoryId { get; set; }

    [Required]
    [ForeignKey(nameof(CategoryId))]
    [Comment("Category of the seminar")]
    public Category Category { get; set; } = null!;
    [Comment("Participants registered for the seminar")]
    public ICollection<SeminarParticipant> SeminarsParticipants { get; set; } = new HashSet<SeminarParticipant>();
}
