using System;
using System.Text;
using Code.Infrastructure.Persistence.Interceptors;
using Domain.Entities;
using Infrastructure.Persistence;
using Infrastructure.Repositories.Implementation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace Infrastructure
{
    public static class ConfigurationServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());

            serviceCollection.AddDbContext<ApplicationDbContext>(options =>
                   options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                       builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            serviceCollection.AddScoped<ApplicationDbContextInitialiser>();
            serviceCollection.AddScoped<AuditableEntitySaveChangesInterceptor>();
            serviceCollection.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            serviceCollection.AddTransient<IDateTime, DateTimeService>();
            serviceCollection.AddTransient<ICategoryRepository, CategoryRepository>();
            serviceCollection.AddTransient<IBookRepository, BookRepository>();
            serviceCollection.AddTransient<ICartItemRepository, CartItemRepository>();
            serviceCollection.AddTransient<ICartRepository, CartRepository>();
            serviceCollection.AddTransient<ILanguageRepository, LanguageRepository>();
            serviceCollection.AddTransient<IFormatRepository, FormatRepository>();
            serviceCollection.AddTransient<IGenreRepository, GenreRepository>();

            serviceCollection.AddTransient<IApplicationDbContext, ApplicationDbContext>();

            serviceCollection.AddIdentity<AppUser, IdentityRole>(opt =>
            {
                opt.SignIn.RequireConfirmedEmail = false;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequiredLength = 8;
                opt.Password.RequireDigit = false;
                opt.Password.RequireUppercase = false;
                opt.Lockout.MaxFailedAccessAttempts = 5;
                opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);

            }).AddDefaultTokenProviders().AddEntityFrameworkStores<ApplicationDbContext>();

            serviceCollection.AddAuthentication(opt =>
            {
                opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(cfg =>
            {
                cfg.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidAudience = configuration["Jwt:Audience"],
                    ValidIssuer = configuration["Jwt:Issue"],
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"])),
                    ClockSkew = TimeSpan.Zero
                };
            });

            return serviceCollection;
        }
    }
}

