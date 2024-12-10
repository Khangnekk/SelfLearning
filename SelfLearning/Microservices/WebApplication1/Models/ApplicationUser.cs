using Microsoft.AspNetCore.Identity;

namespace Learn.Services.AuthAPI.Models
{
	public class ApplicationUser : IdentityUser
	{
		public string Name { get; set; }
		public byte[]? Avatar { get; set; }
	}
}
