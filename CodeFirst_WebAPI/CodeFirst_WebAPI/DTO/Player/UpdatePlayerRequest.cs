using System.ComponentModel.DataAnnotations;

namespace CodeFirst_WebAPI.DTO.Player
{
	public class UpdatePlayerRequest
	{
		[Required]
		public string NickName { get; set; }

	}
}
