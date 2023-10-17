using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using yomikaze_dotnet.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("yomikaze_dotnetContextConnection") ?? throw new InvalidOperationException("Connection string 'yomikaze_dotnetContextConnection' not found.");

builder.Services.AddDbContext<yomikaze_dotnetContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<yomikaze_dotnetUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<yomikaze_dotnetContext>();

// Add services to the container.
builder.Services.AddRazorPages();

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
