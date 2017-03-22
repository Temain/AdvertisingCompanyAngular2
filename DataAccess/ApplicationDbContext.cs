using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplicationBasic.Models;

namespace WebApplicationBasic.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Person> Persons { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<CampaignMicrodistricts>()
                .HasKey(bc => new { bc.CampaignId, bc.MicrodistrictId });

            builder.Entity<CampaignMicrodistricts>()
                .HasOne(bc => bc.Campaign)
                .WithMany(b => b.CampaignMicrodistricts)
                .HasForeignKey(bc => bc.CampaignId);

            builder.Entity<CampaignMicrodistricts>()
                .HasOne(bc => bc.Microdistrict)
                .WithMany(c => c.CampaignMicrodistricts)
                .HasForeignKey(bc => bc.MicrodistrictId);
        }
    }
}