using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Homies.Data.DataConstants.EventConstants;
using Type = Homies.Data.Models.Type;

namespace Homies.Data.Models;

[Comment("Event")]
public class Event
{
    [Key]
    [Comment("Event identifier")]
    public int Id { get; set; }

    [Required]
    [StringLength(NameMaxLength)]
    [Comment("Event name")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [StringLength(DescMaxLength)]
    [Comment("Event description")]
    public string Description { get; set; } = string.Empty;

    [Required]
    [Comment("Event organiser identifier")]
    public string OrganiserId { get; set; } = string.Empty;

    [Required]
    [ForeignKey(nameof(OrganiserId))]
    [Comment("Event organiser")]
    public IdentityUser Organiser { get; set; } = null!;

    [Required]
    [Comment("The date and time, the event is created")]
    public DateTime CreatedOn { get; set; }

    [Required]
    [Comment("The date and time , the event starts")]
    public DateTime Start { get; set; }

    [Required]
    [Comment("The date and time , the event ends")]
    public DateTime End { get; set; }

    [Required]
    [Comment("The type identifier of the event")]
    public int TypeId { get; set; }

    [Required]
    [ForeignKey(nameof(TypeId))]
    [Comment("The type of the event")]
    public Type Type { get; set; } = null!;

    public List<EventParticipant> EventsParticipants { get; set; } = new List<EventParticipant>();
}
