using CodeFirst_WebAPI.DTO.Player;

namespace CodeFirst_WebAPI.Services
{
	public interface IPlayerService
	{
		Task CreatePlayerAsync(CreatePlayerRequest request);
		Task<bool> UpdatePlayerAsync(int id, UpdatePlayerRequest updatePlayerRequest);
		Task<bool> DeletePlayerAsync(int id);
		Task<GetPlayerDetailResponse> GetPlayerDetailAsync(int id);
		Task<List<GetPlayerResponse>> GetPlayerAsync();
	}
}
