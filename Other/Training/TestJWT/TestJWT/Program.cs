using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using System.Text;
using TestJWT.Contracts;
using TestJWT.Data;
using TestJWT.Middleware;
using TestJWT.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

//Configure Serilog
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .WriteTo.Console()
    .WriteTo.File("Logs/log.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();


//Add DBContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

//AddIdentity and Identity Settings
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 5;
    options.Password.RequiredUniqueChars = 1;
})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Issuer"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("ReadZone", policy => policy.RequireClaim("Permission", "ReadZone"));
    options.AddPolicy("CreateZone", policy => policy.RequireClaim("Permission", "CreateZone"));
});


builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

//Add the Service, generating Jwt
builder.Services.AddScoped<JwtTokenGeneratorService>();
builder.Services.AddScoped<IProductService,ProductService>();
builder.Services.AddScoped<IPermissionService,PermissionService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Add the middleware for the LoggingUnauthorized attempts
app.UseUnauthorizedAccessLogging();

//Add Authentication
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

Log.CloseAndFlush();