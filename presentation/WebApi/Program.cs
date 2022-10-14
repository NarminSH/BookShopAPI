using Application;
using FluentValidation.AspNetCore;
using Infrastructure;
using Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddFluentValidationAutoValidation(configuration => configuration.DisableDataAnnotationsValidation = false)
    .AddFluentValidationClientsideAdapters();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //using (var scope = app.Services.CreateScope())
    //{
    //    var initializer = scope.ServiceProvider.GetRequiredService<ApplicationDbContextInitialiser>();
    //    await initializer.InitializeAsync();
    //    await initializer.SeedAsync();
    //}
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

