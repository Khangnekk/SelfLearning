using CodeFirst_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst_WebAPI.Context
{
	public class CodeFirstDemoContext : DbContext
	{
		public CodeFirstDemoContext(DbContextOptions options = null) : base(options)
		{

		}
		public DbSet<Player> Players { get; set; }
		public DbSet<InstrumentType> InstrumentTypes { get; set; }
		public DbSet<PlayerInstrument> PlayerInstruments { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Player>()
				.HasMany(p => p.Instruments)
				.WithOne();
			modelBuilder.Seed();
		}
	}
}
