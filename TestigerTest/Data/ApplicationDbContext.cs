using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestigerTest.Data.Models;

namespace TestigerTest.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Person> People{ get; set; }
        public virtual DbSet<Treatment> Treatments { get; set; }
        public virtual DbSet<TreatmentArticle> TreatmentArticles { get; set; }
    }
}