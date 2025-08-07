using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Options;
using Resume.Domain.Entities.ContacUs;
using Resume.Domain.Entities.Education;
using Resume.Domain.Entities.Expeience;
using Resume.Domain.Entities.MySkills;
namespace Resume.Infrastructure;

public class ResumeDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Resume;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<MySkills> MySkills { get; set; }
    public DbSet<Education> Educations { get; set; }


    public DbSet<ContactUs> ContactUs { get; set; }
}

