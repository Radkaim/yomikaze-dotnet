using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using yomikaze_dotnet.Areas.Identity.Data;

namespace yomikaze_dotnet.Data;

public class yomikaze_dotnetContext : IdentityDbContext<yomikaze_dotnetUser>
{
    public yomikaze_dotnetContext(DbContextOptions<yomikaze_dotnetContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
