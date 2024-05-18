using CodeFirst_WebAPI.DTO.PlayerInstrument;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst_WebAPI.DTO.Player
{
	public class CreatePlayerRequest
	{
		[Required]
		public string NickName { get; set; }
		[Required]
		public List<CreatePlayerInstrumentRequest> playerInstrumentRequests { get; set; }
	}
}
