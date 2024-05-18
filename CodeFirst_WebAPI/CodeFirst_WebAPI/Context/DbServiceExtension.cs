using Microsoft.EntityFrameworkCore;

namespace CodeFirst_WebAPI.Context
{
	public static class DbServiceExtension
	{
		public static void AddDatabaseService(this IServiceCollection services, string connectionString)
			=> services.AddDbContext<CodeFirstDemoContext>(option => option.UseSqlServer(connectionString));
	}
}
