using Microsoft.EntityFrameworkCore;
using SeminarHub.Core.Contracts;
using SeminarHub.Core.Models;
using SeminarHub.Infrastructure;
using SeminarHub.Infrastructure.Data.Models;
using static SeminarHub.Infrastructure.Data.DataConstants.SeminarDataConstants;

namespace SeminarHub.Core.Services;

public class SeminarService : ISeminarService
{
    private readonly SeminarHubDbContext context;

    public SeminarService(SeminarHubDbContext context)
    {
        this.context = context;
    }

    public async Task<ICollection<AllSeminarViewModel>> GetSeminarsAsync()
    {
        return await context
            .Seminars
            .Select(s => new AllSeminarViewModel(
                s.Id,
                s.Topic,
                s.Lecturer,
                s.Organizer.UserName,
                s.DateAndTime,
                s.Category.Name
                ))
            .ToListAsync();
    }

    public async Task<DetailsSeminarViewModel?> GetSeminarDetailsAsync(int id)
    {
        return await context
            .Seminars
            .Where(s => s.Id == id)
            .Select(s => new DetailsSeminarViewModel(
                s.Id,
                s.Topic,
                s.Lecturer,
                s.Details,
                s.Organizer.UserName,
                s.DateAndTime,
                s.Duration,
                s.Category.Name))
            .FirstOrDefaultAsync();
    }

    public async Task<EditSeminarViewModel?> GetSeminarForEditAsync(int id)
    {
        return await context
            .Seminars
            .Where(s => s.Id == id)
            .Select(s => new EditSeminarViewModel
            {
                Id = s.Id,
                Topic = s.Topic,
                Lecturer = s.Lecturer,
                Details = s.Details,
                OrganizerId = s.OrganizerId,
                DateAndTime = s.DateAndTime.ToString(RequiredDateFormat),
                Duration = s.Duration,
                CategoryId = s.CategoryId
            })
            .FirstOrDefaultAsync();
    }

    public async Task UpdateSeminarAsync(EditSeminarViewModel model, DateTime dateTime)
    {
        var entity = await context
            .Seminars
            .Where(e => e.Id == model.Id)
            .FirstOrDefaultAsync();

        entity.Topic = model.Topic;
        entity.Lecturer = model.Lecturer;
        entity.Details = model.Details;
        entity.DateAndTime = dateTime;
        entity.Duration = model.Duration;
        entity.CategoryId = model.CategoryId;

        await context.SaveChangesAsync();
    }

    public async Task AddSeminarAsync(AddSeminarForm model, string userId, DateTime dateTime)
    {
        var seminar = new Seminar
        {
            Topic = model.Topic,
            Lecturer = model.Lecturer,
            Details = model.Details,
            DateAndTime = dateTime,
            OrganizerId = userId,
            CategoryId = model.CategoryId,
            Duration = model.Duration,
        };

        await context.Seminars.AddAsync(seminar);
        await context.SaveChangesAsync();
    }

    public Task<AllSeminarViewModel?> GetSeminarByIdAsync(int id)
    {
        return context
            .Seminars
            .Select(s => new AllSeminarViewModel(
                s.Id,
                s.Topic,
                s.Lecturer,
                s.Organizer.UserName,
                s.DateAndTime,
                s.Category.Name
                ))
            .FirstOrDefaultAsync();
    }

    public async Task<bool> IsUserSubscribedAsync(string userId, int seminarId)
    {
        return await context
            .SeminarsParticipants
            .AnyAsync(sp => sp.ParticipantId == userId && sp.SeminarId == seminarId);
    }

    public async Task SubscribeAsync(string userId, int seminarId)
    {
        var toAdd = new SeminarParticipant
        {
            SeminarId = seminarId,
            ParticipantId = userId
        };

        await context.SeminarsParticipants.AddAsync(toAdd);
        await context.SaveChangesAsync();
    }

    public async Task<ICollection<AllSeminarViewModel>> GetSubscribedAsync(string userId)
    {
        return await context
            .SeminarsParticipants
            .Where(sp => sp.ParticipantId == userId)
            .Select(sp => new AllSeminarViewModel(
                sp.Seminar.Id,
                sp.Seminar.Topic,
                sp.Seminar.Lecturer,
                sp.Seminar.Organizer.UserName,
                sp.Seminar.DateAndTime,
                sp.Seminar.Category.Name
                ))
            .ToListAsync();
    }

    public async Task UnSubscribeAsync(string userId, int seminarId)
    {
        var model = await context
            .SeminarsParticipants
            .Where(sp => sp.ParticipantId == userId && sp.SeminarId == seminarId)
            .FirstOrDefaultAsync();

        context.SeminarsParticipants.Remove(model);
        await context.SaveChangesAsync();
    }

    public async Task<bool> IsUserTheCreatorAsync(string userId, int seminarId)
    {
        var seminar = await context
            .Seminars
            .Where(s => s.Id == seminarId)
            .FirstOrDefaultAsync();

        return seminar.OrganizerId == userId;

    }

    public async Task<SeminarDeleteForm?> GetSeminarForDeleteAsync(int seminarId)
    {
        return await context
            .Seminars
            .Where(s => s.Id == seminarId)
            .Select(s => new SeminarDeleteForm
            {
                Id = s.Id,
                Topic = s.Topic,
                DateAndTime = s.DateAndTime,
            })
            .FirstOrDefaultAsync();
    }

    public async Task DeleteAsync(int seminarId)
    {
        var seminarToDelete = await context
            .Seminars.
            FindAsync(seminarId);
        if (seminarToDelete != null)
        {
            var seminarParticipantsToDelete = context.SeminarsParticipants
                .Where(sp => sp.SeminarId == seminarId);


            context.SeminarsParticipants.RemoveRange(seminarParticipantsToDelete);


            context.Seminars.Remove(seminarToDelete);


            await context.SaveChangesAsync();
        }

    }
}