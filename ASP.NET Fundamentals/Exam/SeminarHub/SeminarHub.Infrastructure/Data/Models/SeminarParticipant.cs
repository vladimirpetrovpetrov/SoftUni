using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeminarHub.Infrastructure.Data.Models;

public class SeminarParticipant
{

    [Comment("Seminar identifier")]
    public int SeminarId { get; set; }

    [ForeignKey(nameof(SeminarId))]
    [Comment("Seminar associated with the participant")]
    public Seminar Seminar { get; set; } = null!;

    [Comment("Participant identifier")]
    public string ParticipantId { get; set; } = string.Empty;

    [ForeignKey(nameof(ParticipantId))]
    [Comment("Participant of the seminar")]
    public IdentityUser Participant { get; set; } = null!;
}