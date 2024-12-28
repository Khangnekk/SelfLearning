//All are demos, just focus on the main part, ignore design pattern
using Microsoft.EntityFrameworkCore;

namespace DemoVisitor.Models
{
	public partial class demoVisitorContext : DbContext
	{
		public demoVisitorContext()
		{
		}

		public demoVisitorContext(DbContextOptions<demoVisitorContext> options)
			: base(options)
		{
		}

		public virtual DbSet<VisitorContentEmail> VisitorContentEmails { get; set; } = null!;

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
				optionsBuilder.UseSqlServer(config.GetConnectionString("DB"));
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<VisitorContentEmail>(entity =>
			{
				entity.ToTable("VisitorContentEmail");
			});

			OnModelCreatingPartial(modelBuilder);
		}

		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}
