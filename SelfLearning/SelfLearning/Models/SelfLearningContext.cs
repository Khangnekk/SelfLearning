using Microsoft.EntityFrameworkCore;

namespace SelfLearning.Models
{
	public partial class SelfLearningContext : DbContext
	{
		public SelfLearningContext()
		{
		}

		public SelfLearningContext(DbContextOptions<SelfLearningContext> options)
			: base(options)
		{
		}

		public virtual DbSet<User> Users { get; set; } = null!;

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
				optionsBuilder.UseSqlServer(config.GetConnectionString("MyConnectionStrings"));
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<User>(entity =>
			{
				entity.ToTable("User");

				entity.Property(e => e.Id).HasColumnName("id");

				entity.Property(e => e.Avatar).HasColumnName("avatar");

				entity.Property(e => e.Name)
					.HasMaxLength(150)
					.HasColumnName("name");
			});

			OnModelCreatingPartial(modelBuilder);
		}

		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}
