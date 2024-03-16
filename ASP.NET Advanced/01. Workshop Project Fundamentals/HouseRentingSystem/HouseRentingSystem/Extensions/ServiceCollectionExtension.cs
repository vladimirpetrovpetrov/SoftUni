using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Services;
using HouseRentingSystem.Infrastructure.Data;
using HouseRentingSystem.Infrastructure.Data.Common;
using HouseRentingSystem.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IHouseService, HouseService>();
        services.AddScoped<IAgentService, AgentService>();
        services.AddScoped<IApplicationUserService, ApplicationUserService>();

        return services;
    }

    public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
    {
        var connectionString = config.GetConnectionString("DefaultConnection");
        services.AddDbContext<HouseRentingDbContext>(options =>
            options.UseSqlServer(connectionString));

        services.AddScoped<IRepository,Repository>();

        services.AddDatabaseDeveloperPageExceptionFilter();

        return services;
    }

    public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
    {
        services.AddDefaultIdentity<ApplicationUser>(options =>
        {
            options.SignIn.RequireConfirmedAccount = false;
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = false;
        })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<HouseRentingDbContext>();

        return services;
    }

    public static IApplicationBuilder SeedAdmin(this IApplicationBuilder app)
    {
        using var scopedServices = app.ApplicationServices.CreateScope();

        var services = scopedServices.ServiceProvider;

        var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

        Task.Run(async () =>
        {
            if(await roleManager.RoleExistsAsync("Admin"))
            {
                return;
            }

            var role = new IdentityRole { Name = "Admin" };

            await roleManager.CreateAsync(role);

            var admin = await userManager.FindByNameAsync("admin@mail.com");

            await userManager.AddToRoleAsync(admin, role.Name);
        })
            .GetAwaiter()
            .GetResult();

        return app;
    }

}
