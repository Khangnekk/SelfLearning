using CodeFirst_WebAPI.DTO.PlayerInstrument;

namespace CodeFirst_WebAPI.DTO.Player
{
	public class GetPlayerDetailResponse
	{
		public string NickName { get; set; }
		public DateTime JoinedDate { get; set; }
		public List<GetPlayerInstrumentResponse> PlayerInstrumentResponses { get; set; }
	}
}
