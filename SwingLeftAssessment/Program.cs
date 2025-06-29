

using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using SwingLeftAssessment;
using SwingLeftAssessment.Models;
using SwingLeftAssessment.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
var connectionString =
    builder.Configuration.GetConnectionString("DefaultConnection")
        ?? throw new InvalidOperationException("Connection string"
        + "'DefaultConnection' not found.");

builder.Services.AddDbContext<SRDContext> (options =>
    options.UseNpgsql(connectionString));

builder.Services.AddTransient<Ivoter_registration_deadlines_service, voter_registration_deadlines_service>(); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
